using System;
using System.Collections.Generic;
using System.Linq;
using static System.Linq.Enumerable;
using SE = System.Linq.Enumerable;
using static usagi.InformationEngineering.Numeric;

namespace usagi.Collection
{
  /// <summary>
  /// <see cref="System.Linq.Enumerable"/> をより便利に
  /// した列挙機能を提供する。
  /// <para/>
  /// 大別して2系統の Range が使用可能になる。
  /// <para/>
  /// 1. <see cref="System.Linq.Enumerable"/> 互換の
  /// <code>Range( Begin, Count )</code> 系
  /// 2. 数学や工学で一般的な区間表現に互換の
  /// <code>Range( Begin, End, Termination )</code> 系
  /// <para/>
  /// 後者は必ず引数を3つ以上とり、区間の始端、終端に続けて
  /// 区間端の開閉を <see cref="RangeTermination"/> で要求する。
  /// </summary>
  public static class Enumerable
  {
    /// <summary>
    /// [ begin, ...., begin + count ) な列挙を得る。
    /// 但し、 <code>count &lt; 0</code> では空の結果を得る。
    /// <para/>
    /// <see cref="System.Linq.Enumerable.Range(int, int)"/> への糖衣構文
    /// </summary>
    /// <remarks>
    /// とかしても Enumerable.Range と EnumerableHelper.Range を
    /// 使い分けするの手間なのでこっちで .Range の面倒を全てみられるよう用意した。
    /// </remarks>
    /// <param name="begin">はじまり</param>
    /// <param name="count">いくつ欲しいのか</param>
    /// <returns>[ begin, ...., begin + count ) な列挙</returns>
    public static IEnumerable<int> Range( int begin, int count )
    { return SE.Range( begin, count ); }

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
    { return SE.Range( 0, count ); }

    /// <summary>
    /// 区間末尾の開閉を表す。
    /// </summary>
    public enum RangeTermination
    {
      /// <summary>開区間 ( ... ) </summary>
      OO
    ,
      /// <summary>半開区間 ( ... ] </summary>
      OC
    ,
      /// <summary>半開区間 [ ... ) </summary>
      CO
    ,
      /// <summary>閉区間 [ ... ] </summary>
      CC
    }

    /// <summary>
    /// 複数の区間を列挙する。
    /// 区間間（タイポではない）は、連続でも、不連続でも、重複が無くても、重複があっても構わない。
    /// </summary>
    /// <typeparam name="T">要素の型</typeparam>
    /// <param name="stepper">T型をインクリメントするファンクター</param>
    /// <param name="ranges">任意個の ( 始端要素, 終端要素, 区間端の開閉) 群</param>
    /// <returns>すべての区間の列挙</returns>
    public static
    IEnumerable<T>
    Range<T>
    ( Func<T, T> stepper
    , params (T Begin, T End, RangeTermination Termination)[] ranges
    )
      where T : IComparable<T>
      =>  ( from r
            in ranges
            select Range<T>( r.Begin, r.End, r.Termination, stepper )
          ).Aggregate( ( ca, cb ) => ca.Concat( cb ) )
          ;

    /// <summary>
    /// 始端、終端、区間端の開閉、要素のインクリメントファンクターによる
    /// ジェネリック版 Range
    /// </summary>
    /// <typeparam name="T">区間の要素の型</typeparam>
    /// <param name="begin">区間の始端</param>
    /// <param name="end">区間の終端</param>
    /// <param name="termination">区間端の開閉</param>
    /// <param name="stepper">T型をインクリメントするファンクター</param>
    /// <returns>区間の要素の列挙</returns>
    public static
    IEnumerable<T>
    Range<T>
    ( T begin
    , T end
    , RangeTermination termination
    , Func<T, T> stepper
    )
      where T : IComparable<T>
    {
      var n = begin;
      switch ( termination )
      {
        case RangeTermination.OO:
        case RangeTermination.OC:
          n = stepper( n );
          break;
      }

      for ( ; n.CompareTo( end ) < 0; n = stepper( n ) )
        yield return n;

      switch ( termination )
      {
        case RangeTermination.OC:
        case RangeTermination.CC:
          yield return n;
          break;
      }
    }

    /// <summary>
    /// 区間 { begin ... end } を列挙します。
    /// </summary>
    /// <param name="begin">区間の始端</param>
    /// <param name="end">区間の終端</param>
    /// <param name="termination">区間端の開閉</param>
    /// <returns>区間の列挙</returns>
    public static 
      IEnumerable<byte> 
      Range( byte begin, byte end, RangeTermination termination )
      => Range( begin, end, termination, v => (byte)(v + 1) );

    /// <summary>
    /// 区間 { begin ...  end } を列挙します。
    /// </summary>
    /// <param name="begin">区間の始端</param>
    /// <param name="end">区間の終端</param>
    /// <param name="termination">区間端の開閉</param>
    /// <returns>区間の列挙</returns>
    public static
      IEnumerable<sbyte>
      Range( sbyte begin, sbyte end, RangeTermination termination )
      => Range( begin, end, termination, v => (sbyte)( v + 1 ) );

    /// <summary>
    /// 区間 { begin ... end } を列挙します。
    /// </summary>
    /// <param name="begin">区間の始端</param>
    /// <param name="end">区間の終端</param>
    /// <param name="termination">区間端の開閉</param>
    /// <returns>区間の列挙</returns>
    public static
      IEnumerable<Int16>
      Range( Int16 begin, Int16 end, RangeTermination termination )
      => Range( begin, end, termination, v => (Int16)( v + 1 ) );

    /// <summary>
    /// 区間 { begin ... end } を列挙します。
    /// </summary>
    /// <param name="begin">区間の始端</param>
    /// <param name="end">区間の終端</param>
    /// <param name="termination">区間端の開閉</param>
    /// <returns>区間の列挙</returns>
    public static
      IEnumerable<UInt16>
      RangeOO( UInt16 begin, UInt16 end, RangeTermination termination )
      => Range( begin, end, termination, v => (UInt16)( v + 1 ) );

    /// <summary>
    /// 区間 { begin ... end } を列挙します。
    /// </summary>
    /// <param name="begin">区間の始端</param>
    /// <param name="end">区間の終端</param>
    /// <param name="termination">区間端の開閉</param>
    /// <returns>区間の列挙</returns>
    public static
      IEnumerable<Int32>
      Range( Int32 begin, Int32 end, RangeTermination termination )
      => Range( begin, end, termination, v => v + 1 );

    /// <summary>
    /// 区間 { begin ... end } を列挙します。
    /// </summary>
    /// <param name="begin">区間の始端</param>
    /// <param name="end">区間の終端</param>
    /// <param name="termination">区間端の開閉</param>
    /// <returns>区間の列挙</returns>
    public static
      IEnumerable<UInt32>
      Range( UInt32 begin, UInt32 end, RangeTermination termination )
      => Range( begin, end, termination, v => v + 1U );

    /// <summary>
    /// 区間 { begin ... end } を列挙します。
    /// </summary>
    /// <param name="begin">区間の始端</param>
    /// <param name="end">区間の終端</param>
    /// <param name="termination">区間端の開閉</param>
    /// <returns>区間の列挙</returns>
    public static
      IEnumerable<Int64>
      Range( Int64 begin, Int64 end, RangeTermination termination )
      => Range( begin, end, termination, v => v + 1L );

    /// <summary>
    /// 区間 { begin ... end } を列挙します。
    /// </summary>
    /// <param name="begin">区間の始端</param>
    /// <param name="end">区間の終端</param>
    /// <param name="termination">区間端の開閉</param>
    /// <returns>区間の列挙</returns>
    public static
      IEnumerable<UInt64>
      Range( UInt64 begin, UInt64 end, RangeTermination termination )
      => Range( begin, end, termination, v => v + 1UL );

    /// <summary>
    /// 区間 { begin ... end } を列挙します。
    /// </summary>
    /// <param name="begin">区間の始端</param>
    /// <param name="end">区間の終端</param>
    /// <param name="termination">区間端の開閉</param>
    /// <returns>区間の列挙</returns>
    public static
      IEnumerable<decimal>
      Range( decimal begin, decimal end, RangeTermination termination )
      => Range( begin, end, termination, SafeIncrement );

    /// <summary>
    /// 区間 { begin ... end } を列挙します。
    /// </summary>
    /// <param name="begin">区間の始端</param>
    /// <param name="end">区間の終端</param>
    /// <param name="termination">区間端の開閉</param>
    /// <returns>区間の列挙</returns>
    public static
      IEnumerable<double>
      Range( double begin, double end, RangeTermination termination )
      => Range( begin, end, termination, SafeIncrement );

    /// <summary>
    /// 区間 { begin ... end } を列挙します。
    /// </summary>
    /// <param name="begin">区間の始端</param>
    /// <param name="end">区間の終端</param>
    /// <param name="termination">区間端の開閉</param>
    /// <returns>区間の列挙</returns>
    public static
      IEnumerable<float>
      Range( float begin, float end, RangeTermination termination )
      => Range( begin, end, termination, SafeIncrement );

    // 複合 Range

    /// <summary>
    /// 複数の区間の要素をまとめて列挙する
    /// </summary>
    /// <param name="ranges">区間群</param>
    /// <returns>区間群の要素の列挙</returns>
    public static
      IEnumerable<byte>
      Range( params (byte Begin, byte End, RangeTermination Termination)[] ranges )
        => Range<byte>( ( byte a ) => (byte)( a + 1 ), ranges );

    /// <summary>
    /// 複数の区間の要素をまとめて列挙する
    /// </summary>
    /// <param name="ranges">区間群</param>
    /// <returns>区間群の要素の列挙</returns>
    public static
      IEnumerable<sbyte>
      Range( params (sbyte Begin, sbyte End, RangeTermination Termination)[] ranges )
        => Range<sbyte>( ( sbyte a ) => (sbyte)( a + 1 ), ranges );

    /// <summary>
    /// 複数の区間の要素をまとめて列挙する
    /// </summary>
    /// <param name="ranges">区間群</param>
    /// <returns>区間群の要素の列挙</returns>
    public static
      IEnumerable<UInt16>
      Range( params (UInt16 Begin, UInt16 End, RangeTermination Termination)[] ranges )
        => Range<UInt16>( ( UInt16 a ) => (UInt16)( a + 1 ), ranges );

    /// <summary>
    /// 複数の区間の要素をまとめて列挙する
    /// </summary>
    /// <param name="ranges">区間群</param>
    /// <returns>区間群の要素の列挙</returns>
    public static
      IEnumerable<Int16>
      Range( params (Int16 Begin, Int16 End, RangeTermination Termination)[] ranges )
        => Range<Int16>( ( Int16 a ) => (Int16)( a + 1 ), ranges );

    /// <summary>
    /// 複数の区間の要素をまとめて列挙する
    /// </summary>
    /// <param name="ranges">区間群</param>
    /// <returns>区間群の要素の列挙</returns>
    public static
      IEnumerable<UInt32>
      Range( params (UInt32 Begin, UInt32 End, RangeTermination Termination)[] ranges )
        => Range<UInt32>( a => a + 1U, ranges );

    /// <summary>
    /// 複数の区間の要素をまとめて列挙する
    /// </summary>
    /// <param name="ranges">区間群</param>
    /// <returns>区間群の要素の列挙</returns>
    public static
      IEnumerable<Int32>
      Range( params (Int32 Begin, Int32 End, RangeTermination Termination)[] ranges )
        => Range<Int32>( a => a + 1, ranges );

    /// <summary>
    /// 複数の区間の要素をまとめて列挙する
    /// </summary>
    /// <param name="ranges">区間群</param>
    /// <returns>区間群の要素の列挙</returns>
    public static
      IEnumerable<UInt64>
      Range( params (UInt64 Begin, UInt64 End, RangeTermination Termination)[] ranges )
        => Range<UInt64>( a => a + 1UL, ranges );

    /// <summary>
    /// 複数の区間の要素をまとめて列挙する
    /// </summary>
    /// <param name="ranges">区間群</param>
    /// <returns>区間群の要素の列挙</returns>
    public static
      IEnumerable<Int64>
      Range( params (Int64 Begin, Int64 End, RangeTermination Termination)[] ranges )
        => Range<Int64>( a => a + 1L, ranges );

    /// <summary>
    /// 複数の区間の要素をまとめて列挙する
    /// </summary>
    /// <param name="ranges">区間群</param>
    /// <returns>区間群の要素の列挙</returns>
    public static
      IEnumerable<decimal>
      Range( params (decimal Begin, decimal End, RangeTermination Termination)[] ranges )
        => Range<decimal>( SafeIncrement, ranges );

    /// <summary>
    /// 複数の区間の要素をまとめて列挙する
    /// </summary>
    /// <param name="ranges">区間群</param>
    /// <returns>区間群の要素の列挙</returns>
    public static
      IEnumerable<float>
      Range( params (float Begin, float End, RangeTermination Termination)[] ranges )
        => Range<float>( SafeIncrement, ranges );

    /// <summary>
    /// 複数の区間の要素をまとめて列挙する
    /// </summary>
    /// <param name="ranges">区間群</param>
    /// <returns>区間群の要素の列挙</returns>
    public static
      IEnumerable<double>
      Range( params (double Begin, double End, RangeTermination Termination)[] ranges )
        => Range<double>( SafeIncrement, ranges );

  }
}
