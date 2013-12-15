// -----------------------------------------------------------------------
// <copyright file="Category.cs" company="">
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
  /// Finally, the Category table:
  /// </summary>
  public class Category
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
      return string.Format("Id:{0} {1}", Id, Name);
    }
  }
}
