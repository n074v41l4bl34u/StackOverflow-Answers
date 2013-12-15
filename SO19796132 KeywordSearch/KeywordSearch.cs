// -----------------------------------------------------------------------
// <copyright file="KeywordSearch.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace SO19796132KeywordSearch
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  /// <summary>
  /// TODO: Update summary.
  /// </summary>
  public class KeywordSearch
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public Keyword Keyword { get; set; }

    public override string ToString()
    {
      return string.Format("Id:{0} {1} Key:{2}", Id, Name, Keyword);
    }

    private static char[] keywordPartsSplitter = new char[] { ' ', '-' };

    internal static Dictionary<Category, Dictionary<int, List<KeywordAdCategory>>> FromStringInput(string searchPhrase, SearchDomain searchDomain)
    {
      var identifiedKeywords = searchPhrase
        .Split(keywordPartsSplitter);

      var knownKeywordParts = identifiedKeywords
        .Where
        (ik =>
          searchDomain
          .Keywords
          .SelectMany(x => x.GetKeywordParts())
          .Any(kp => kp.Equals(ik, StringComparison.InvariantCultureIgnoreCase))
        );

      var keywordkSearches = knownKeywordParts
        .Select((kkp, n) => new KeywordSearch()
        {
          Id = n,
          Name = kkp,
          Keyword = searchDomain
            .Keywords
            .Single
            (k =>
              k.GetKeywordParts()
                .Any(kp => kp.Equals(kkp, StringComparison.InvariantCultureIgnoreCase))
            )
        });

      var relevantKeywords = keywordkSearches
        .Select(ks => ks.Keyword)
        .Distinct();

      var keywordAdCategoriesByCategory = searchDomain.Categories
        .GroupJoin
        (
          searchDomain.KeywordAdCategories,
          c => c.Id,
          kac => kac.Category_Id,
          (c, kac) => new { Category = c, AdKeywordsForCategory = kac }
        );

      var relevantKeywordAdCategories = keywordAdCategoriesByCategory
        .Where
        (kacbk =>
          relevantKeywords
            .All
            (rk =>
              kacbk
                .AdKeywordsForCategory
                .Any(kac => kac.Keyword_Id == rk.Id)
            )
        );

      var foundAdsInCategories = relevantKeywordAdCategories
        .ToDictionary
        (rkac =>
          rkac.Category,
          rkac => rkac.AdKeywordsForCategory
            .GroupBy(g => g.Ad_Id)
            .ToDictionary(x => x.Key, x => x.ToList())
        );

      return foundAdsInCategories;
    }
  }
}