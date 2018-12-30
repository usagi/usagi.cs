using System.Collections.Generic;
using System.Linq;
using System;
using static usagi.Collection.Enumerable;
using UE = usagi.Collection.Enumerable;
using SE = System.Linq.Enumerable;

namespace usagi.Collection.Extension
{
  /// <summary>
  /// Dictionary な何かへの機能拡張群
  /// </summary>
  public static class IDictionaryExtension
  {
    /// <summary>
    /// IDictionary を実装する型 a, b について等価な Key と Value の組み合わせ群を保持するか判定する。
    /// SequenceEqual と異なり列挙される順序の影響を受けない
    /// ref. https://stackoverflow.com/a/3928856/1211392
    /// </summary>
    /// <typeparam name="TK">Key の型</typeparam>
    /// <typeparam name="TV">Value の型</typeparam>
    /// <param name="a">比較において this となる IDictionary を実装する型のインスタンス</param>
    /// <param name="b">比較において this と比較される IDictionary を実装する型のインスタンス</param>
    /// <param name="c">TV型の等価判定関数。 null を与えた場合は EqualityComparer&lt;TV&gt;.Default を採用する</param>
    /// <returns>a, b が等価な Key と Value の組み合わせ群を保持する場合は true 、そうでなければ false</returns>
    public static bool UnorderedEqual<TK, TV>
    ( this IDictionary<TK, TV> a
    , IDictionary<TK, TV> b
    , IEqualityComparer<TV> c = null
    )
    {
      if ( a.Equals( b ) )
        return true;
      if ( a.Count() != b.Count() )
        return false;
      c = c ?? EqualityComparer<TV>.Default;
      foreach ( var akv in a )
      {
        if ( !b.TryGetValue( akv.Key, out TV bv ) )
          return false;
        if ( !c.Equals( akv.Value, bv ) )
          return false;
      }
      return true;
    }
  }
}
