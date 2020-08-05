using System;
using static usagi.Quantity.Calculation;

namespace usagi.Quantity.Extension
{
  /// <summary>
  /// 数値型へ NearlyEquals メソッドを拡張する
  /// </summary>
  public static class NumericNearlyEqualsExtension
  {
    /// <summary>
    /// double 特殊化版
    /// <para/>double, float, decimal に対しては内部的にも同じ型のまま計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( this double a, double b, double tolerance ) { return NearlyEquals<double>( a, b, tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// float 特殊化版
    /// <para/>double, float, decimal に対しては内部的にも同じ型のまま計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( this float a, float b, float tolerance ) { return NearlyEquals<float>( a, b, tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// decimal 特殊化版
    /// <para/>double, float, decimal に対しては内部的にも同じ型のまま計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( this decimal a, decimal b, decimal tolerance ) { return NearlyEquals<decimal>( a, b, tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// byte 特殊化版
    /// <para/>byte, UInt16, UInt32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( this byte a, byte b, byte tolerance ) { return NearlyEquals<Int16>( (Int16)a, (Int16)b, (Int16)tolerance, ( p, q ) => (Int16)( p - q ), ( p, q ) => (Int16)( p + q ) ); }
    /// <summary>
    /// UInt16 特殊化版
    /// <para/>byte, UInt16, UInt32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( this UInt16 a, UInt16 b, UInt16 tolerance ) { return NearlyEquals<Int32>( (Int32)a, (Int32)b, (Int32)tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// UInt32 特殊化版
    /// <para/>byte, UInt16, UInt32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( this UInt32 a, UInt32 b, UInt32 tolerance ) { return NearlyEquals<Int64>( (Int64)a, (Int64)b, (Int64)tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// UInt64 特殊化版
    /// <para/>UInt64, Int64 に対しては内部的に decimal 型で計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( this UInt64 a, UInt64 b, UInt64 tolerance ) { return NearlyEquals<decimal>( (decimal)a, (decimal)b, (decimal)tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// char 特殊化版
    /// <para/>char, Int16, Int32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( this char a, char b, char tolerance ) { return NearlyEquals<Int16>( (Int16)a, (Int16)b, (Int16)tolerance, ( p, q ) => (Int16)( p - q ), ( p, q ) => (Int16)( p + q ) ); }
    /// <summary>
    /// Int16 特殊化版
    /// <para/>char, Int16, Int32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( this Int16 a, Int16 b, Int16 tolerance ) { return NearlyEquals<Int32>( (Int32)a, (Int32)b, (Int32)tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// Int32 特殊化版
    /// <para/>char, Int16, Int32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( this Int32 a, Int32 b, Int32 tolerance ) { return NearlyEquals<Int64>( (Int64)a, (Int64)b, (Int64)tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// Int64 特殊化版
    /// <para/>UInt64, Int64 に対しては内部的に decimal 型で計算を行う。
    /// </summary>
    /// <param name="a">値 a</param>
    /// <param name="b">値 b</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等しいと見做せる場合は true</returns>
    static public bool NearlyEquals( this Int64 a, Int64 b, Int64 tolerance ) { return NearlyEquals<decimal>( (decimal)a, (decimal)b, (decimal)tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
  }
}
