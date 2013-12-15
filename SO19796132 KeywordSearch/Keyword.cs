// -----------------------------------------------------------------------
// <copyright file="Keyword.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace SO19796132KeywordSearch
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  /// <summary>
  /// Where the Keyword Table is:
  /// </summary>
  public class Keyword
  {
    public int Id { get; set; }
    public string Name { get; set; }

    static char[] keywordSplitters = new char[] { '-' };
    public IEnumerable<string> GetKeywordParts()
    {
      return Name.Split(keywordSplitters);
    }

    public override string ToString()
    {
      return string.Format("Id:{0} {1}", Id, Name);
    }
  }
}
