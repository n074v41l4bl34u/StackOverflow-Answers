// -----------------------------------------------------------------------
// <copyright file="KeywordAdCategory.cs" company="">
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
  /// The Ads are related with the Keywords using the following Table:
  /// </summary>
  public class KeywordAdCategory
  {
    //[Key]
    //[Column("Keyword_Id", Order = 0)]
    public int Keyword_Id { get; set; }

    //[Key]
    //[Column("Ad_Id", Order = 1)]
    public int Ad_Id { get; set; }

    //[Key]
    //[Column("Category_Id", Order = 2)]
    public int Category_Id { get; set; }

    public override string ToString()
    {
      return string.Format("AdId:{0} CatId:{1} KeyId:{2}", Ad_Id, Category_Id, Keyword_Id);
    }
  }
}
