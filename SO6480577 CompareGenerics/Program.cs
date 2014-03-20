using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SO6480577_CompareGenerics
{
  class Program
  {
    static void Main(string[] args)
    {
      var foot = new FooT();
      var foo = new Foo<FooT>();
      var foo2 = new Foo2<int>(); // prefered solution using CompareTo method
      var bar = new Bar<string>(); // Bar<T> has implementation eqivalent to Foo2<T>
      var myGen = new MyGeneric<cMyType>();

      Console.WriteLine(foo.IsInRange(foot));
      Console.WriteLine(foo2.IsInRange(5));
      Console.WriteLine(bar.IsInRange("nine"));
      Console.WriteLine(myGen + myGen);

      Console.WriteLine("Press ANY key to exit.");
      Console.ReadKey();
    }
  }
}
