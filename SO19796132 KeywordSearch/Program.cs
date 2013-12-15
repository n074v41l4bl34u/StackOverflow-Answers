using System;
using System.Collections.Generic;

namespace SO19796132KeywordSearch
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var keywords = new List<Keyword>()
      {
        new Keyword() { Id = 1, Name = "Mercedes-Benz" },
        new Keyword() { Id = 2, Name = "GLK" },
        new Keyword() { Id = 3, Name = "Citan" },
      };

      var categories = new List<Category>()
      {
        new Category(){Id=1, Name="Car"},
        new Category(){Id=2, Name="Truck"},
      };

      var keywordAdCategories = new List<KeywordAdCategory>()
      {
        new KeywordAdCategory(){Ad_Id=1, Keyword_Id=1, Category_Id=1},
        new KeywordAdCategory(){Ad_Id=2, Keyword_Id=1, Category_Id=2},
        new KeywordAdCategory(){Ad_Id=1, Keyword_Id=2, Category_Id=1},
        new KeywordAdCategory(){Ad_Id=2, Keyword_Id=3, Category_Id=2},
      };

      var searchDomain = new SearchDomain()
      {
        Keywords = keywords,
        Categories = categories,
        KeywordAdCategories = keywordAdCategories
      };

      var searchTerm = "Mercedes-Benz";
      var categoriesWithCounts = KeywordSearch.FromStringInput(searchTerm, searchDomain);
      DisplayFoundAdCategories(searchTerm, categoriesWithCounts);

      searchTerm = "Mercedes-Benz GLK";
      categoriesWithCounts = KeywordSearch.FromStringInput(searchTerm, searchDomain);
      DisplayFoundAdCategories(searchTerm, categoriesWithCounts);

      searchTerm = "Mercedes Citan";
      categoriesWithCounts = KeywordSearch.FromStringInput(searchTerm, searchDomain);
      DisplayFoundAdCategories(searchTerm, categoriesWithCounts);

      Console.Write("Press any key to exit.");
      Console.ReadKey();
    }

    private static void DisplayFoundAdCategories(string searchTerm, Dictionary<Category, Dictionary<int, List<KeywordAdCategory>>> categoriesWithCounts)
    {
      Console.WriteLine("Search for: \"{0}\"", searchTerm);
      foreach (var item in categoriesWithCounts)
      {
        Console.WriteLine("{0}: {1}", item.Key.Name, item.Value.Count);
      }
    }
  }
}