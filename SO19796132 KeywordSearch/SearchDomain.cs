﻿using System.Collections.Generic;

namespace SO19796132KeywordSearch
{
  internal class SearchDomain
  {
    public List<Keyword> Keywords { get; set; }

    public List<Category> Categories { get; set; }

    public List<KeywordAdCategory> KeywordAdCategories { get; set; }
  }
}