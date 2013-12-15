using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SO19796132KeywordSearch
{
  class SearchDomain
  {
    public List<Keyword> Keywords { get; set; }

    public List<Category> Categories { get; set; }

    public List<KeywordAdCategory> KeywordAdCategories { get; set; }

    //public IEnumerable<KeywordSearch> KnownKeywordSearches()
    //{
    //  return Keywords.SelectMany(k=>k.Name.Split('-').)
    //}
  }
}
