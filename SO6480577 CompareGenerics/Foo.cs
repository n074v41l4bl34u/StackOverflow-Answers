// -----------------------------------------------------------------------
// <copyright file="Class1.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace SO6480577_CompareGenerics
{
  using System;

  /// <summary>
  /// Can encapsulate any type, both class and struct but it is based on inheritance and not generics
  /// </summary>
  /// <remarks>you should also implement <typeparamref name="IEquatable<T>"/> </remarks>
  public class FooT : IComparable<FooT>
  {
    int _comparableValue = 7; //sample value

    public int CompareTo(FooT other)
    {
      // do own logic
      return _comparableValue.CompareTo(other._comparableValue);
    }

    public static bool operator <(FooT a, FooT b)
    {
      return a.CompareTo(b) < 0;
    }

    public static bool operator >(FooT a, FooT b)
    {
      return a.CompareTo(b) > 0;
    }

    public static bool operator <=(FooT a, FooT b)
    {
      return a.CompareTo(b) <= 0;
    }

    public static bool operator >=(FooT a, FooT b)
    {
      return a.CompareTo(b) >= 0;
    }
  }

  /// <summary>
  /// Solution using '>=' operator and encapsulating class
  /// </summary>
  public class Foo<T> where T : FooT, new()
  {
    private T _minimumValue = new T();

    public bool IsInRange(T value)
    {
      return value >= _minimumValue;
    }
  }

  /// <summary>
  /// Prefered solution
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class Foo2<T> where T : IComparable<T>
  {
    private T _minimumValue = default(T);

    public bool IsInRange(T value)
    {
      return value.CompareTo(_minimumValue) >= 0;
    }
  }
}