// -----------------------------------------------------------------------
// <copyright file="Bar.cs" company="">
// TODO: Update copyright text.
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
  public class Bar<T> where T: IComparable<T>//: IComparable<Bar<T>> where T : IComparable<T>
  {
    T _comparableValue;

    //public int CompareTo(Bar<T> other)
    //{
    //  // do own logic
    //  return _comparableValue.CompareTo(other._comparableValue);
    //}

    public bool IsInRange(T value)
    {
      return value.CompareTo(_comparableValue) >= 0;
    }

    //public static bool operator <(Bar<T> a, Bar<T> b)
    //{
    //  return a.CompareTo(b) < 0;
    //}

    //public static bool operator >(Bar<T> a, Bar<T> b)
    //{
    //  return a.CompareTo(b) > 0;
    //}

    //public static bool operator <=(Bar<T> a, Bar<T> b)
    //{
    //  return a.CompareTo(b) <= 0;
    //}

    //public static bool operator >=(Bar<T> a, Bar<T> b)
    //{
    //  return a.CompareTo(b) >= 0;
    //}
  }
}
