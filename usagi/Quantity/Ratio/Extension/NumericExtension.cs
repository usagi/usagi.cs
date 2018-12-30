using System;
using static System.Math;
using static usagi.Quantity.Calculation;

namespace usagi.Quantity.Ratio.Extension
{
  /// <summary>
  /// 比率、係数、無次元数、
  /// そういったようなものとして
  /// <see cref="double"/> を中心に <see cref="float"/>, <see cref="decimal"/> による
  /// 実数値としての表現形式と
  /// <see cref="sbyte"/>, <see cref="byte"/> 等の
  /// 整数型に比率としてのセマンティクスを持たせた表現形式を
  /// 便利に扱えるようにする拡張。
  /// </summary>
  /// <example>
  /// <code>
  /// // 赤の輝度を byte の値域 [ 0 ... 255 ] で表現しているよくある状況で
  /// byte u8_red = 211;
  /// // やっぱり double の値域 [ 0 ... 1 ] で計算とかしたくなったり
  /// double f64_red = u8_red.ToUNorm(); // 0.82745098039
  /// // その後 UInt16 形式で保存したくなったり
  /// byte u16_red = f64_red.UNormToUInt16(); // 54227
  /// // アスペクト比を保持していたけれど…
  /// var aspect_ratio = 16.0 / 9.0;
  /// // 分数表現に分解したくなったり
  /// var ( numerator, denominator ) = aspect_ratio.DecompositionToCommonFraction(); // ( 16, 9 )
  /// </code>
  /// </example>
  public static class NumericExtension
  {
    /// <summary>
    /// [ 0 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="domain_logical_zero">始域の始端</param>
    /// <param name="domain_logical_ceil">終域の終端</param>
    /// <param name="morphism_bias">終域</param>
    /// <returns>射影された値</returns>
    public static double ToUNorm( this byte a, double domain_logical_zero = 0, double domain_logical_ceil = byte.MaxValue, double morphism_bias = 0 ) => ( (double)a ).ToRatio( domain_logical_zero, domain_logical_ceil, morphism_bias );
    /// <summary>
    /// [ 0 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="domain_logical_zero">始域の始端</param>
    /// <param name="domain_logical_ceil">終域の終端</param>
    /// <param name="morphism_bias">終域</param>
    /// <returns>射影された値</returns>
    public static double ToUNorm( this UInt16 a, double domain_logical_zero = 0, double domain_logical_ceil = UInt16.MaxValue, double morphism_bias = 0 ) => ( (double)a ).ToRatio( domain_logical_zero, domain_logical_ceil, morphism_bias );
    /// <summary>
    /// [ 0 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="domain_logical_zero">始域の始端</param>
    /// <param name="domain_logical_ceil">終域の終端</param>
    /// <param name="morphism_bias">終域</param>
    /// <returns>射影された値</returns>
    public static double ToUNorm( this UInt32 a, double domain_logical_zero = 0, double domain_logical_ceil = UInt32.MaxValue, double morphism_bias = 0 ) => ( (double)a ).ToRatio( domain_logical_zero, domain_logical_ceil, morphism_bias );
    /// <summary>
    /// [ 0 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="domain_logical_zero">始域の始端</param>
    /// <param name="domain_logical_ceil">終域の終端</param>
    /// <param name="morphism_bias">終域</param>
    /// <returns>射影された値</returns>
    public static double ToUNorm( this UInt64 a, double domain_logical_zero = 0, double domain_logical_ceil = UInt64.MaxValue, double morphism_bias = 0 ) => ( (double)a ).ToRatio( domain_logical_zero, domain_logical_ceil, morphism_bias );

    /// <summary>
    /// [ 0 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="domain_logical_zero">始域の始端</param>
    /// <param name="domain_logical_ceil">終域の終端</param>
    /// <param name="morphism_bias">終域</param>
    /// <returns>射影された値</returns>
    public static double ToUNorm( this sbyte a, double domain_logical_zero = 0, double domain_logical_ceil = sbyte.MaxValue, double morphism_bias = 0 ) => ( (double)a ).ToRatio( domain_logical_zero, domain_logical_ceil, morphism_bias );
    /// <summary>
    /// [ 0 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="domain_logical_zero">始域の始端</param>
    /// <param name="domain_logical_ceil">終域の終端</param>
    /// <param name="morphism_bias">終域</param>
    /// <returns>射影された値</returns>
    public static double ToUNorm( this Int16 a, double domain_logical_zero = 0, double domain_logical_ceil = Int16.MaxValue, double morphism_bias = 0 ) => ( (double)a ).ToRatio( domain_logical_zero, domain_logical_ceil, morphism_bias );
    /// <summary>
    /// [ 0 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="domain_logical_zero">始域の始端</param>
    /// <param name="domain_logical_ceil">終域の終端</param>
    /// <param name="morphism_bias">終域</param>
    /// <returns>射影された値</returns>
    public static double ToUNorm( this Int32 a, double domain_logical_zero = 0, double domain_logical_ceil = Int32.MaxValue, double morphism_bias = 0 ) => ( (double)a ).ToRatio( domain_logical_zero, domain_logical_ceil, morphism_bias );
    /// <summary>
    /// [ 0 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="domain_logical_zero">始域の始端</param>
    /// <param name="domain_logical_ceil">終域の終端</param>
    /// <param name="morphism_bias">終域</param>
    /// <returns>射影された値</returns>
    public static double ToUNorm( this Int64 a, double domain_logical_zero = 0, double domain_logical_ceil = Int64.MaxValue, double morphism_bias = 0 ) => ( (double)a ).ToRatio( domain_logical_zero, domain_logical_ceil, morphism_bias );

    /// <summary>
    /// [ -1 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="domain_logical_zero">始域の始端</param>
    /// <param name="domain_logical_ceil">終域の終端</param>
    /// <param name="morphism_bias">終域</param>
    /// <returns>射影された値</returns>
    public static double ToSNorm( this byte a, double domain_logical_zero = 0, double domain_logical_ceil = byte.MaxValue, double morphism_bias = 0 ) => ( (double)a ).ToRatio( domain_logical_zero, domain_logical_ceil, morphism_bias );
    /// <summary>
    /// [ -1 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="domain_logical_zero">始域の始端</param>
    /// <param name="domain_logical_ceil">終域の終端</param>
    /// <param name="morphism_bias">終域</param>
    /// <returns>射影された値</returns>
    public static double ToSNorm( this UInt16 a, double domain_logical_zero = 0, double domain_logical_ceil = UInt16.MaxValue, double morphism_bias = 0 ) => ( (double)a ).ToRatio( domain_logical_zero, domain_logical_ceil, morphism_bias );
    /// <summary>
    /// [ -1 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="domain_logical_zero">始域の始端</param>
    /// <param name="domain_logical_ceil">終域の終端</param>
    /// <param name="morphism_bias">終域</param>
    /// <returns>射影された値</returns>
    public static double ToSNorm( this UInt32 a, double domain_logical_zero = 0, double domain_logical_ceil = UInt32.MaxValue, double morphism_bias = 0 ) => ( (double)a ).ToRatio( domain_logical_zero, domain_logical_ceil, morphism_bias );
    /// <summary>
    /// [ -1 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="domain_logical_zero">始域の始端</param>
    /// <param name="domain_logical_ceil">終域の終端</param>
    /// <param name="morphism_bias">終域</param>
    /// <returns>射影された値</returns>
    public static double ToSNorm( this UInt64 a, double domain_logical_zero = 0, double domain_logical_ceil = UInt64.MaxValue, double morphism_bias = 0 ) => ( (double)a ).ToRatio( domain_logical_zero, domain_logical_ceil, morphism_bias );

    /// <summary>
    /// [ -1 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="domain_logical_zero">始域の始端</param>
    /// <param name="domain_logical_ceil">終域の終端</param>
    /// <param name="morphism_bias">終域</param>
    /// <returns>射影された値</returns>
    public static double ToSNorm( this sbyte a, double domain_logical_zero = 0, double domain_logical_ceil = sbyte.MaxValue, double morphism_bias = 0 ) => ( (double)a ).ToRatio( domain_logical_zero, domain_logical_ceil, morphism_bias );
    /// <summary>
    /// [ -1 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="domain_logical_zero">始域の始端</param>
    /// <param name="domain_logical_ceil">終域の終端</param>
    /// <param name="morphism_bias">終域</param>
    /// <returns>射影された値</returns>
    public static double ToSNorm( this Int16 a, double domain_logical_zero = 0, double domain_logical_ceil = Int16.MaxValue, double morphism_bias = 0 ) => ( (double)a ).ToRatio( domain_logical_zero, domain_logical_ceil, morphism_bias );
    /// <summary>
    /// [ -1 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="domain_logical_zero">始域の始端</param>
    /// <param name="domain_logical_ceil">終域の終端</param>
    /// <param name="morphism_bias">終域</param>
    /// <returns>射影された値</returns>
    public static double ToSNorm( this Int32 a, double domain_logical_zero = 0, double domain_logical_ceil = Int32.MaxValue, double morphism_bias = 0 ) => ( (double)a ).ToRatio( domain_logical_zero, domain_logical_ceil, morphism_bias );
    /// <summary>
    /// [ -1 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="domain_logical_zero">始域の始端</param>
    /// <param name="domain_logical_ceil">終域の終端</param>
    /// <param name="morphism_bias">終域</param>
    /// <returns>射影された値</returns>
    public static double ToSNorm( this Int64 a, double domain_logical_zero = 0, double domain_logical_ceil = Int64.MaxValue, double morphism_bias = 0 ) => ( (double)a ).ToRatio( domain_logical_zero, domain_logical_ceil, morphism_bias );

    /// <summary>
    /// [ -1 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="all_range">始域全域を定義域とするか</param>
    /// <returns>射影された値</returns>
    public static double ToSNorm( this byte a, bool all_range )
      => all_range
        ? a.ToSNorm( Abs( (double)sbyte.MinValue ) * 0.5 + (double)sbyte.MaxValue * 0.5 )
        : a.ToSNorm()
      ;
    /// <summary>
    /// [ -1 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="all_range">始域全域を定義域とするか</param>
    /// <returns>射影された値</returns>
    public static double ToSNorm( this UInt16 a, bool all_range )
      => all_range
        ? a.ToSNorm( Abs( (double)Int16.MinValue ) * 0.5 + (double)Int16.MaxValue * 0.5 )
        : a.ToSNorm()
      ;
    /// <summary>
    /// [ -1 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="all_range">始域全域を定義域とするか</param>
    /// <returns>射影された値</returns>
    public static double ToSNorm( this UInt32 a, bool all_range )
      => all_range
        ? a.ToSNorm( Abs( (double)UInt32.MinValue ) * 0.5 + (double)UInt32.MaxValue * 0.5 )
        : a.ToSNorm()
      ;
    /// <summary>
    /// [ -1 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="all_range">始域全域を定義域とするか</param>
    /// <returns>射影された値</returns>
    public static double ToSNorm( this UInt64 a, bool all_range )
      => all_range
        ? a.ToSNorm( Abs( (double)UInt64.MinValue ) * 0.5 + (double)UInt64.MaxValue * 0.5 )
        : a.ToSNorm()
      ;

    /// <summary>
    /// [ -1 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="all_range">始域全域を定義域とするか</param>
    /// <returns>射影された値</returns>
    public static double ToSNorm( this sbyte a, bool all_range )
      => all_range
        ? a.ToSNorm( 0, Abs( (double)sbyte.MinValue ) * 0.5 + (double)sbyte.MaxValue * 0.5 )
        : a.ToSNorm()
      ;
    /// <summary>
    /// [ -1 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="all_range">始域全域を定義域とするか</param>
    /// <returns>射影された値</returns>
    public static double ToSNorm( this Int16 a, bool all_range )
      => all_range
        ? a.ToSNorm( 0, Abs( (double)Int16.MinValue ) * 0.5 + (double)Int16.MaxValue * 0.5 )
        : a.ToSNorm()
      ;
    /// <summary>
    /// [ -1 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="all_range">始域全域を定義域とするか</param>
    /// <returns>射影された値</returns>
    public static double ToSNorm( this Int32 a, bool all_range )
      => all_range
        ? a.ToSNorm( 0, Abs( (double)Int32.MinValue ) * 0.5 + (double)Int32.MaxValue * 0.5 )
        : a.ToSNorm()
      ;
    /// <summary>
    /// [ -1 ... 1 ] へ射影します。
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="all_range">始域全域を定義域とするか</param>
    /// <returns>射影された値</returns>
    public static double ToSNorm( this Int64 a, bool all_range )
      => all_range
        ? a.ToSNorm( 0, Abs( (double)Int64.MinValue ) * 0.5 + (double)Int64.MaxValue * 0.5 )
        : a.ToSNorm()
      ;

    /// <summary>
    /// 比率を生成
    /// </summary>
    /// <param name="domain_value">始域の値</param>
    /// <param name="domain_logical_zero">始域のゼロ</param>
    /// <param name="domain_logical_ceil">始域の天井</param>
    /// <param name="morphism_bias">終域でのバイアス</param>
    /// <returns>比</returns>
    public static double ToRatio
    ( this double domain_value, double domain_logical_zero = 0d, double domain_logical_ceil = 1d, double morphism_bias = 0d )
    {
      var numerator = domain_value - domain_logical_zero;
      var denominator = domain_logical_ceil - domain_logical_zero;
      return numerator / denominator + morphism_bias;
    }

    /// <summary>
    /// 比率を生成
    /// </summary>
    /// <param name="domain_value">始域の値</param>
    /// <param name="domain_logical_zero">始域のゼロ</param>
    /// <param name="domain_logical_ceil">始域の天井</param>
    /// <param name="morphism_bias">終域でのバイアス</param>
    /// <returns>比</returns>
    public static float ToRatio
    ( this float domain_value, float domain_logical_zero = 0f, float domain_logical_ceil = 1f, float morphism_bias = 0f )
    {
      var numerator = domain_value - domain_logical_zero;
      var denominator = domain_logical_ceil - domain_logical_zero;
      return numerator / denominator + morphism_bias;
    }

    /// <summary>
    /// 比率を生成
    /// </summary>
    /// <param name="domain_value">始域の値</param>
    /// <param name="domain_logical_zero">始域のゼロ</param>
    /// <param name="domain_logical_ceil">始域の天井</param>
    /// <param name="morphism_bias">終域でのバイアス</param>
    /// <returns>比</returns>
    public static decimal ToRatio
    ( this decimal domain_value, decimal domain_logical_zero = 0m, decimal domain_logical_ceil = 1m, decimal morphism_bias = 0m )
    {
      var numerator = domain_value - domain_logical_zero;
      var denominator = domain_logical_ceil - domain_logical_zero;
      return numerator / denominator + morphism_bias;
    }

    /// <summary>
    /// [ 0 ... 1 ] へクランプ
    /// </summary>
    /// <param name="a">元の値</param>
    /// <returns>クランプされた値</returns>
    public static double ClampToUNorm( this double a ) => Clamp( a, 0d, 1d );
    /// <summary>
    /// [ 0 ... 1 ] へクランプ
    /// </summary>
    /// <param name="a">元の値</param>
    /// <returns>クランプされた値</returns>
    public static float ClampToUNorm( this float a ) => Clamp( a, 0f, 1f );
    /// <summary>
    /// [ 0 ... 1 ] へクランプ
    /// </summary>
    /// <param name="a">元の値</param>
    /// <returns>クランプされた値</returns>
    public static decimal ClampToUNorm( this decimal a ) => Clamp( a, 0m, 1m );

    /// <summary>
    /// [ -1 ... 1 ] へクランプ
    /// </summary>
    /// <param name="a">元の値</param>
    /// <returns>クランプされた値</returns>
    public static double ClampToSNorm( this double a ) => Clamp( a, -1d, 1d );
    /// <summary>
    /// [ -1 ... 1 ] へクランプ
    /// </summary>
    /// <param name="a">元の値</param>
    /// <returns>クランプされた値</returns>
    public static float ClampToSNorm( this float a ) => Clamp( a, -1f, 1f );
    /// <summary>
    /// [ -1 ... 1 ] へクランプ
    /// </summary>
    /// <param name="a">元の値</param>
    /// <returns>クランプされた値</returns>
    public static decimal ClampToSNorm( this decimal a ) => Clamp( a, -1m, 1m );

    /// <summary>
    /// パーセント単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPercent( this double a, string symbol = "%", string format = "F2" ) => _append_symbol( $"{a * 1.0e+2d:format}", symbol );
    /// <summary>
    /// パーセント単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPercent( this float a, string symbol = "%", string format = "F2" ) => _append_symbol( $"{a * 1.0e+2f:format}", symbol );
    /// <summary>
    /// パーセント単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPercent( this decimal a, string symbol = "%", string format = "F2" ) => _append_symbol( $"{a * 1.0e+2m:format}", symbol );

    /// <summary>
    /// パーミル単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPermil( this double a, string symbol = "‰", string format = "F2" ) => _append_symbol( $"{a * 1.0e+3d:format}", symbol );
    /// <summary>
    /// パーミル単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPermil( this float a, string symbol = "‰", string format = "F2" ) => _append_symbol( $"{a * 1.0e+3f:format}", symbol );
    /// <summary>
    /// パーミル単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPermil( this decimal a, string symbol = "‰", string format = "F2" ) => _append_symbol( $"{a * 1.0e+3m:format}", symbol );

    /// <summary>
    /// パーミリアド単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPermyriad( this double a, string symbol = "‱", string format = "F2" ) => _append_symbol( $"{a * 1.0e+4d:format}", symbol );
    /// <summary>
    /// パーミリアド単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPermyriad( this float a, string symbol = "‱", string format = "F2" ) => _append_symbol( $"{a * 1.0e+4f:format}", symbol );
    /// <summary>
    /// パーミリアド単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPermyriad( this decimal a, string symbol = "‱", string format = "F2" ) => _append_symbol( $"{a * 1.0e+4m:format}", symbol );

    /// <summary>
    /// ppm 単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPPM( this double a, string symbol = "ppm", string format = "F2" ) => _append_symbol( $"{a * 1.0e+6d:format}", symbol );
    /// <summary>
    /// ppm 単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPPM( this float a, string symbol = "ppm", string format = "F2" ) => _append_symbol( $"{a * 1.0e+6f:format}", symbol );
    /// <summary>
    /// ppm 単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPPM( this decimal a, string symbol = "ppm", string format = "F2" ) => _append_symbol( $"{a * 1.0e+6m:format}", symbol );

    /// <summary>
    /// ppb 単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPPB( this double a, string symbol = "ppb", string format = "F2" ) => _append_symbol( $"{a * 1.0e+9d:format}", symbol );
    /// <summary>
    /// ppb 単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPPB( this float a, string symbol = "ppb", string format = "F2" ) => _append_symbol( $"{a * 1.0e+9f:format}", symbol );
    /// <summary>
    /// ppb 単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPPB( this decimal a, string symbol = "ppb", string format = "F2" ) => _append_symbol( $"{a * 1.0e+9m:format}", symbol );

    /// <summary>
    /// ppt 単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPPT( this double a, string symbol = "ppt", string format = "F2" ) => _append_symbol( $"{a * 1.0e+12d:format}", symbol );
    /// <summary>
    /// ppt 単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPPT( this float a, string symbol = "ppt", string format = "F2" ) => _append_symbol( $"{a * 1.0e+12f:format}", symbol );
    /// <summary>
    /// ppt 単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPPT( this decimal a, string symbol = "ppt", string format = "F2" ) => _append_symbol( $"{a * 1.0e+12m:format}", symbol );

    /// <summary>
    /// ppq 単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPPQ( this double a, string symbol = "ppq", string format = "F2" ) => _append_symbol( $"{a * 1.0e+15d:format}", symbol );
    /// <summary>
    /// ppq 単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPPQ( this float a, string symbol = "ppq", string format = "F2" ) => _append_symbol( $"{a * 1.0e+15f:format}", symbol );
    /// <summary>
    /// ppq 単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringPPQ( this decimal a, string symbol = "ppq", string format = "F2" ) => _append_symbol( $"{a * 1.0e+15m:format}", symbol );

    /// <summary>
    /// B 単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringBell( this float a, string symbol = "B", string format = "F2" ) => _append_symbol( $"{Log10( a ):format}", symbol );
    /// <summary>
    /// Np 単位の文字列を生成
    /// </summary>
    /// <param name="a">元値</param>
    /// <param name="symbol">記号</param>
    /// <param name="format">フォーマット</param>
    /// <returns>文字列</returns>
    public static string ToStringNeper( this double a, string symbol = "Np", string format = "F2" ) => _append_symbol( $"{ Log( a ):format}", symbol );

    internal static string _append_symbol( string a, string symbol ) => a + ( symbol != null ? $" {symbol}" : string.Empty );

    /// <summary>
    /// 始域 [ 0 ... 1 ] から終域 [ -1 ... 1 ] への射
    /// </summary>
    /// <param name="a">射を受ける始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static float UNormExpandToSNorm( this float a ) => a * 2.0f - 1.0f;
    /// <summary>
    /// 始域 [ 0 ... 1 ] から終域 [ -1 ... 1 ] への射
    /// </summary>
    /// <param name="a">射を受ける始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static double UNormExpandToSNorm( this double a ) => a * 2.0d - 1.0d;
    /// <summary>
    /// 始域 [ 0 ... 1 ] から終域 [ -1 ... 1 ] への射
    /// </summary>
    /// <param name="a">射を受ける始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static decimal UNormExpandToSNorm( this decimal a ) => a * 2.0m - 1.0m;

    /// <summary>
    /// 始域 [ -1 ... 1 ] から終域 [ 0 ... 1 ] への射
    /// </summary>
    /// <param name="a">射を受ける始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static float SNormCollapseToUNorm( this float a ) => ( a + 1.0f ) * 0.5f;
    /// <summary>
    /// 始域 [ -1 ... 1 ] から終域 [ 0 ... 1 ] への射
    /// </summary>
    /// <param name="a">射を受ける始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static double SNormCollapseToUNorm( this double a ) => ( a + 1.0d ) * 0.5d;
    /// <summary>
    /// 始域 [ -1 ... 1 ] から終域 [ 0 ... 1 ] への射
    /// </summary>
    /// <param name="a">射を受ける始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static decimal SNormCollapseToUNorm( this decimal a ) => ( a + 1.0m ) * 0.5m;

    /// <summary>
    /// 始域 [ 0 ... 1 ] から Byte 型全域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static byte UNormToByte( this double a ) => (byte)Math.Round( a.ClampToUNorm() * byte.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から UInt16 型全域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static UInt16 UNormToUInt16( this double a ) => (UInt16)Math.Round( a.ClampToUNorm() * UInt16.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から UInt32 型全域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static UInt32 UNormToUInt32( this double a ) => (UInt32)Math.Round( a.ClampToUNorm() * UInt32.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から UInt64 型全域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static UInt64 UNormToUInt64( this double a ) => (UInt64)Math.Round( a.ClampToUNorm() * UInt64.MaxValue );

    /// <summary>
    /// 始域 [ 0 ... 1 ] から SByte 型の正の値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static sbyte UNormToSByte( this double a ) => (sbyte)Math.Round( a.ClampToUNorm() * byte.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から Int16 型の正の値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int16 UNormToInt16( this double a ) => (Int16)Math.Round( a.ClampToUNorm() * UInt16.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から Int32 型の正の値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int32 UNormToInt32( this double a ) => (Int32)Math.Round( a.ClampToUNorm() * UInt32.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から Int64 型の正の値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int64 UNormToInt64( this double a ) => (Int64)Math.Round( a.ClampToUNorm() * UInt64.MaxValue );

    /// <summary>
    /// 始域 [ -1 ... 1 ] から SByte 型の最小値を除く値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static sbyte SNormToSByte( this double a ) => (sbyte)Math.Round( a.ClampToSNorm() * sbyte.MaxValue );
    /// <summary>
    /// 始域 [ -1 ... 1 ] から Int16 型の最小値を除く値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int16 SNormToInt16( this double a ) => (Int16)Math.Round( a.ClampToUNorm() * Int16.MaxValue );
    /// <summary>
    /// 始域 [ -1 ... 1 ] から Int32 型の最小値を除く値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int32 SNormToInt32( this double a ) => (Int32)Math.Round( a.ClampToUNorm() * Int32.MaxValue );
    /// <summary>
    /// 始域 [ -1 ... 1 ] から Int64 型の最小値を除く値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int64 SNormToInt64( this double a ) => (Int64)Math.Round( a.ClampToUNorm() * Int64.MaxValue );

    /// <summary>
    /// 始域 [ 0 ... 1 ] から Byte 型の全域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static byte UNormToByte( this float a ) => (byte)Math.Round( a.ClampToUNorm() * byte.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から UInt16 型の全域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static UInt16 UNormToUInt16( this float a ) => (UInt16)Math.Round( a.ClampToUNorm() * UInt16.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から UInt32 型の全域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static UInt32 UNormToUInt32( this float a ) => (UInt32)Math.Round( a.ClampToUNorm() * UInt32.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から UInt64 型の全域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static UInt64 UNormToUInt64( this float a ) => (UInt64)Math.Round( a.ClampToUNorm() * UInt64.MaxValue );

    /// <summary>
    /// 始域 [ 0 ... 1 ] から SByte 型の正の値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static sbyte UNormToSByte( this float a ) => (sbyte)Math.Round( a.ClampToUNorm() * byte.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から SByte 型の正の値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int16 UNormToInt16( this float a ) => (Int16)Math.Round( a.ClampToUNorm() * UInt16.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から SByte 型の正の値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int32 UNormToInt32( this float a ) => (Int32)Math.Round( a.ClampToUNorm() * UInt32.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から SByte 型の正の値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int64 UNormToInt64( this float a ) => (Int64)Math.Round( a.ClampToUNorm() * UInt64.MaxValue );

    /// <summary>
    /// 始域 [ -1 ... 1 ] から SByte 型の最小値を除く値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static sbyte SNormToSByte( this float a ) => (sbyte)Math.Round( a.ClampToSNorm() * sbyte.MaxValue );
    /// <summary>
    /// 始域 [ -1 ... 1 ] から Int16 型の最小値を除く値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int16 SNormToInt16( this float a ) => (Int16)Math.Round( a.ClampToUNorm() * Int16.MaxValue );
    /// <summary>
    /// 始域 [ -1 ... 1 ] から Int32 型の最小値を除く値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int32 SNormToInt32( this float a ) => (Int32)Math.Round( a.ClampToUNorm() * Int32.MaxValue );
    /// <summary>
    /// 始域 [ -1 ... 1 ] から Int64 型の最小値を除く値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int64 SNormToInt64( this float a ) => (Int64)Math.Round( a.ClampToUNorm() * Int64.MaxValue );

    /// <summary>
    /// 始域 [ 0 ... 1 ] から Byte 型の全域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static byte UNormToByte( this decimal a ) => (byte)Math.Round( a.ClampToUNorm() * byte.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から UInt16 型の全域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static UInt16 UNormToUInt16( this decimal a ) => (UInt16)Math.Round( a.ClampToUNorm() * UInt16.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から UInt32 型の全域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static UInt32 UNormToUInt32( this decimal a ) => (UInt32)Math.Round( a.ClampToUNorm() * UInt32.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から UInt64 型の全域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static UInt64 UNormToUInt64( this decimal a ) => (UInt64)Math.Round( a.ClampToUNorm() * UInt64.MaxValue );

    /// <summary>
    /// 始域 [ 0 ... 1 ] から SByte 型の正の値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static sbyte UNormToSByte( this decimal a ) => (sbyte)Math.Round( a.ClampToUNorm() * byte.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から Int16 型の正の値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int16 UNormToInt16( this decimal a ) => (Int16)Math.Round( a.ClampToUNorm() * UInt16.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から Int32 型の正の値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int32 UNormToInt32( this decimal a ) => (Int32)Math.Round( a.ClampToUNorm() * UInt32.MaxValue );
    /// <summary>
    /// 始域 [ 0 ... 1 ] から Int64 型の正の値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int64 UNormToInt64( this decimal a ) => (Int64)Math.Round( a.ClampToUNorm() * UInt64.MaxValue );

    /// <summary>
    /// 始域 [ -1 ... 1 ] から SByte 型の最小値を除く値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static sbyte SNormToSByte( this decimal a ) => (sbyte)Math.Round( a.ClampToSNorm() * sbyte.MaxValue );
    /// <summary>
    /// 始域 [ -1 ... 1 ] から Int16 型の最小値を除く値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int16 SNormToInt16( this decimal a ) => (Int16)Math.Round( a.ClampToUNorm() * Int16.MaxValue );
    /// <summary>
    /// 始域 [ -1 ... 1 ] から Int32 型の最小値を除く値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int32 SNormToInt32( this decimal a ) => (Int32)Math.Round( a.ClampToUNorm() * Int32.MaxValue );
    /// <summary>
    /// 始域 [ -1 ... 1 ] から Int64 型の最小値を除く値域を終域として射る
    /// </summary>
    /// <param name="a">始域の値</param>
    /// <returns>射られた終域の値</returns>
    public static Int64 SNormToInt64( this decimal a ) => (Int64)Math.Round( a.ClampToUNorm() * Int64.MaxValue );

    /// <summary>
    /// 分子と分母からなる分数表現へ変換する
    /// </summary>
    /// <param name="a">比</param>
    /// <param name="epsilon">
    /// 変換の粗さ; null の場合は 1.0e-6 を使う。
    /// 値が小さいほど精度が上がるが計算時間も増える。
    /// また、精度が高すぎると大雑把な分数値が欲しい場合に
    /// 分子、分母の桁が大きすぎてソレじゃないになる事もある。
    /// </param>
    /// <returns>分母と分子からなる分数表現の比</returns>
    public static
      ( int Numerator, int Denominator )
      DecompositionToCommonFraction
      ( this double a, double? epsilon = null )
    {
      epsilon = epsilon ?? 1.0e-6;
      var n = 1;
      var d = 1;
      var f = 1d;
      while ( Abs( f - a ) > epsilon )
      {
        if ( f < a )
          ++n;
        else
          n = (int)Round( a * ++d );
        f = (double)n / (double)d;
      }
      return (n, d);
    }
  }
}
