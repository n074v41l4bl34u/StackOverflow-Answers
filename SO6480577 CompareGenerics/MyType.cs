// -----------------------------------------------------------------------
// <copyright file="MyType.cs" author="Sergei Almazov">
// http://social.msdn.microsoft.com/Forums/en-US/6317290d-bbfb-46f6-812b-7f4252ce3f27/operator-cannot-be-applied-to-operands-of-type-t-and-t?forum=csharplanguage
// </copyright>
// -----------------------------------------------------------------------

namespace SO6480577_CompareGenerics
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  /// <summary>
  /// TODO: Update summary.
  /// </summary>
  public class MyType
  {
    //just example: result of summing MyTypes is bool.
    public static bool operator +(MyType a, MyType b)
    {
      //just a dummy return
      return false;
    }
  }

  public class cMyType : MyType { }

  class MyGeneric<T> where T : MyType
  {
    T _value;
    public T Value
    {
      get { return _value; }
    }

    //converting bool to MyGeneric
    public static explicit operator MyGeneric<T>(bool a)
    {
      //just a dummy return
      return new MyGeneric<T>();
    }

    public static MyGeneric<T> operator +(MyGeneric<T> a, MyGeneric<T> b)
    {
      //note that "+" will always call MyType.operator+
      //even if it is redeclared in T.
      return (MyGeneric<T>)(a.Value + b.Value);
    }
  }
}
