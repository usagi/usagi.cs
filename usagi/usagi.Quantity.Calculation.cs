using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usagi.Quantity
{
  /// <summary>
  /// 計算機能
  /// <para/>基本的に Generic
  /// </summary>
  public class Calculation
  {
    /// <summary>
    /// a を [ floor ... ceil ] に丸める
    /// </summary>
    /// <typeparam name="T">比較計算可能な任意の型</typeparam>
    /// <param name="a">丸め元とする値</param>
    /// <param name="floor">床値（値域の末端に含まれる）</param>
    /// <param name="ceil">天井値（値域の末端に含まれる）</param>
    /// <returns>a を [ floor ... ceil ] へで丸め込こんだ値</returns>
    static public T Clamp<T>( T a, T floor, T ceil )
      where T : IComparable<T>
    {
      if ( a.CompareTo( ceil ) >= 0 )
        return ceil;
      if ( a.CompareTo( floor ) <= 0 )
        return floor;
      return a;
    }
    /// <summary>
    /// a と b の距離（差）を計算する
    /// <para/>a と b の順序はどうでもよい
    /// </summary>
    /// <typeparam name="T">減算可能な任意の型</typeparam>
    /// <param name="a">距離を計算する1つめの値</param>
    /// <param name="b">距離を計算する2つめの値</param>
    /// <param name="OperatorSubtract">T型の減算関数</param>
    /// <returns>a と bの距離（差）</returns>
    static public T Distance<T>( T a, T b, Func<T, T, T> OperatorSubtract )
      where T : IComparable<T>
    {
      return
        a.CompareTo( b ) > 0
          ? OperatorSubtract( a, b )
          : OperatorSubtract( b, a )
        ;
    }

    /// <summary>
    /// a が [ floor ... ceil ] に含まれるか判定する
    /// </summary>
    /// <typeparam name="T">比較計算可能な任意の型</typeparam>
    /// <param name="a">判定対象の値</param>
    /// <param name="floor">床値（値域の末端に含まれる）</param>
    /// <param name="ceil">天井値（値域の末端に含まれる）</param>
    /// <returns>a が [ floor ... ceil ] に含まれる場合は true</returns>
    static public bool IsInRangeOf<T>( T a, T floor, T ceil )
      where T : IComparable<T>
    {
      return a.CompareTo( floor ) >= 0 && a.CompareTo( ceil ) <= 0;
    }

    /// <summary>
    /// 任意個の値から最小の値を1つ抽出する
    /// </summary>
    /// <typeparam name="T">比較計算可能な任意の型</typeparam>
    /// <param name="values">任意個の値群</param>
    /// <returns>抽出された最小の値</returns>
    static public T Min<T>( params T[] values ) where T : IComparable<T> { return values.Min(); }
    /// <summary>
    /// 任意個の値から最大の値を1つ抽出する
    /// </summary>
    /// <typeparam name="T">比較計算可能な任意の型</typeparam>
    /// <param name="values">任意個の値群</param>
    /// <returns>抽出された最大の値</returns>
    static public T Max<T>( params T[] values ) where T : IComparable<T> { return values.Max(); }

    /// <summary>
    /// a と b の差が tolerance 以下か判定する
    /// <para/>許容範囲（許容誤差）において近似的に等価
    /// </summary>
    /// <typeparam name="T">比較計算可能かつ減算可能かつ加算可能な任意の型</typeparam>
    /// <param name="a">差を判定したい1つめの値</param>
    /// <param name="b">差を判定したい2つめの値</param>
    /// <param name="tolerance">許容範囲（許容誤差）</param>
    /// <param name="OperatorSubtract">T型の減算関数</param>
    /// <param name="OperatorAdd">T型の加算関数</param>
    /// <returns>a と b の差が tolerance 以下なら true</returns>
    static public bool NearlyEquals<T>( T a, T b, T tolerance, Func<T, T, T> OperatorSubtract, Func<T, T, T> OperatorAdd )
      where T : IComparable<T>
    {
      var d = Distance( a, b, OperatorSubtract );
      return d.CompareTo( tolerance ) <= 0;
    }
    /// <summary>
    /// double 特殊化版
    /// <para/>double, float, decimal に対しては内部的にも同じ型のまま計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( double a, double b, double tolerance ) { return NearlyEquals<double>( a, b, tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// float 特殊化版
    /// <para/>double, float, decimal に対しては内部的にも同じ型のまま計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( float a, float b, float tolerance ) { return NearlyEquals<float>( a, b, tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// decimal 特殊化版
    /// <para/>double, float, decimal に対しては内部的にも同じ型のまま計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( decimal a, decimal b, decimal tolerance ) { return NearlyEquals<decimal>( a, b, tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// byte 特殊化版
    /// <para/>byte, UInt16, UInt32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( byte a, byte b, byte tolerance ) { return NearlyEquals( (Int16)a, (Int16)b, (Int16)tolerance, ( p, q ) => (Int16)( p - q ), ( p, q ) => (Int16)( p + q ) ); }
    /// <summary>
    /// UInt16 特殊化版
    /// <para/>byte, UInt16, UInt32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( UInt16 a, UInt16 b, UInt16 tolerance ) { return NearlyEquals( (Int32)a, (Int32)b, (Int32)tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// UInt32 特殊化版
    /// <para/>byte, UInt16, UInt32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( UInt32 a, UInt32 b, UInt32 tolerance ) { return NearlyEquals( (Int64)a, (Int64)b, (Int64)tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// UInt64 特殊化版
    /// <para/>UInt64, Int64 に対しては内部的に decimal 型で計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( UInt64 a, UInt64 b, UInt64 tolerance ) { return NearlyEquals( (decimal)a, (decimal)b, (decimal)tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// char 特殊化版
    /// <para/>char, Int16, Int32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( char a, char b, char tolerance ) { return NearlyEquals( (Int16)a, (Int16)b, (Int16)tolerance, ( p, q ) => (Int16)( p - q ), ( p, q ) => (Int16)( p + q ) ); }
    /// <summary>
    /// Int16 特殊化版
    /// <para/>char, Int16, Int32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( Int16 a, Int16 b, Int16 tolerance ) { return NearlyEquals( (Int32)a, (Int32)b, (Int32)tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// Int32 特殊化版
    /// <para/>char, Int16, Int32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( Int32 a, Int32 b, Int32 tolerance ) { return NearlyEquals( (Int64)a, (Int64)b, (Int64)tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// Int64 特殊化版
    /// <para/>UInt64, Int64 に対しては内部的に decimal 型で計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( Int64 a, Int64 b, Int64 tolerance ) { return NearlyEquals( (decimal)a, (decimal)b, (decimal)tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
  }
}
