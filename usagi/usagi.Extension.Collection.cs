using System.Collections.Generic;
using System.Linq;
using System;


namespace usagi.Extension.Collection
{
  /// <summary>
  /// IEnumerable, IDictionary など Collection 向けの Extension 
  /// </summary>
  [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
  internal class NamespaceDoc { }

  /// <summary>
  /// Enumerable な何かの機能拡張群
  /// </summary>
  public static class EnumerableHelper
  {
    /// <summary>
    /// IEnumerable を列挙順にインデックス付きにするやつ
    /// ref. https://ufcpp.net/blog/2016/12/tipsindexedforeach/
    /// </summary>
    /// <example>
    /// <code>
    /// // 適当な IEnumerable な何か
    /// var items = new string[]{ "aaa", "bbb", "ccc" };
    /// // タプルで取り出すぱたーん
    /// foreach ( var indexed_item in items )
    ///   Console.WriteLine( $"index={indexed_item.Index} item={indexed_item.Item}" );
    /// // タプルを構造化束縛で取り出すぱたーん
    /// foreach ( var (index,item) in items )
    ///   Console.WriteLine( $"index={index} item={item}" );
    /// </code>
    /// </example>
    /// <typeparam name="T">IEnumerable で取り出せる中身の型</typeparam>
    /// <param name="items">IEnumerable な何か</param>
    /// <returns>インデクシングされたアイテムの列挙</returns>
    public static
    IEnumerable<(int Index, T Item)>
    WithIndexing<T>
    ( this IEnumerable<T> items )
    {
      if ( items == null )
        throw new ArgumentNullException( nameof( items ) );

      IEnumerable<(int, T)> f()
      {
        var index = 0;
        foreach ( var item in items )
          yield return (index++, item);
      }

      return f();
    }

    /// <summary>
    /// IEnumerable を実装する型 a, b について等価な値を保持するか判定する。
    /// SequenceEqual と異なり列挙される順序の影響を受けない
    /// ref. https://stackoverflow.com/a/3670089/1211392
    /// </summary>
    /// <typeparam name="T">IEnumerable で取り出せる中身の型</typeparam>
    /// <param name="a">IEnumerable を実装する型 a</param>
    /// <param name="b">IEnumerable を実装する型 b</param>
    /// <returns>等価な値を保持している場合は true</returns>
    public static bool UnorderedEqual<T>
    ( this IEnumerable<T> a
    , IEnumerable<T> b
    )
    {
      if ( a.Equals( b ) )
        return true;
      if ( a.Count() != b.Count() )
        return false;

      var counter = new Dictionary<T, int>();
      // count UP by a
      foreach ( T s in a )
        if ( counter.ContainsKey( s ) )
          counter[ s ]++;
        else
          counter.Add( s, 1 );
      // cound DOWN by b
      foreach ( T s in b )
        if ( counter.ContainsKey( s ) )
          counter[ s ]--;
        else
          return false;
      return counter.Values.All( c => c == 0 );
    }

    /// <summary>
    /// [ begin, ...., begin + count ) な列挙を得る。
    /// 但し、 <code>count &lt; 0</code> では空の結果を得る。
    /// <para/>
    /// <see cref="Enumerable.Range(int, int)"/> への糖衣構文
    /// </summary>
    /// <remarks>
    /// とかしても Enumerable.Range と EnumerableHelper.Range を
    /// 使い分けするの手間なのでこっちで .Range の面倒を全てみられるよう用意した。
    /// </remarks>
    /// <param name="begin">はじまり</param>
    /// <param name="count">いくつ欲しいのか</param>
    /// <returns>[ begin, ...., begin + count ) な列挙</returns>
    public static IEnumerable<int> Range( int begin, int count )
    { return Enumerable.Range( begin, count ); }

    /// <summary>
    /// [ 0, ...., count ) な列挙を得る
    /// <para/>
    /// <see cref="Range(int, int)"/>
    /// へ <code>( 0, count )</code> を渡す糖衣構文
    /// </summary>
    /// <remarks>
    /// とかしても Enumerable.Range と EnumerableHelper.Range を
    /// 使い分けするの手間なのでこっちで .Range の面倒を全てみられるよう用意した。
    /// </remarks>
    /// <param name="count">いくつ欲しいのか</param>
    /// <returns>[ begin, ...., begin + count ) な列挙</returns>
    public static IEnumerable<int> Range( int count )
    { return Enumerable.Range( 0, count ); }

    /// <summary>
    /// generator で count 個の列挙を得る。
    /// 但し、 <code>count &lt; 0</code> では空の結果を得る。
    /// </summary>
    /// <typeparam name="T">generator 出力する型</typeparam>
    /// <param name="count">出力を得たい数量</param>
    /// <param name="generator">出力を生成可能なファンクター</param>
    /// <returns>generator により生成される count 個の列挙</returns>
    public static IEnumerable<T> Range<T>( int count, Func<T> generator )
    {
      while ( --count >= 0 )
        yield return generator();
    }

    /// <summary>
    /// [ begin, ... , count ) を始域とし、
    /// generator を写像として得られる
    /// 順序対の終域の要素の列挙を得る。
    /// 但し、 <code>count &lt; 0</code> では空の結果を得る。
    /// </summary>
    /// <typeparam name="T">generator の出力する型</typeparam>
    /// <param name="begin">始域のはじめに列挙される数</param>
    /// <param name="count">始域の要素数</param>
    /// <param name="generator">始域の要素から出力を生成可能なファンクター</param>
    /// <returns>
    /// [ begin, ... , count ) を始域とし、
    /// generator を写像として得られる
    /// 順序対の終域の要素の列挙
    /// </returns>
    public static IEnumerable<T> Range<T>( int begin, int count, Func<int, T> generator )
    { return from _ in Range( begin, count ) select generator( _ ); }

    /// <summary>
    /// [ 0, ... , count ) を始域とし、
    /// generator を写像として得られる
    /// 順序対の終域の要素の列挙を得る。
    /// 但し、 <code>count &lt; 0</code> では空の結果を得る。
    /// </summary>
    /// <typeparam name="T">generator の出力する型</typeparam>
    /// <param name="count">始域の要素数</param>
    /// <param name="generator">始域の要素から出力を生成可能なファンクター</param>
    /// <returns>
    /// [ 0, ... , count ) を始域とし、
    /// generator を写像として得られる
    /// 順序対の終域の要素の列挙を得る
    /// </returns>
    public static IEnumerable<T> Range<T>( int count, Func<int, T> generator )
    { return Range( 0, count, generator ); }

  }

  /// <summary>
  /// Dictionary な何かへの機能拡張群
  /// </summary>
  public static class DictionaryHelper
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
