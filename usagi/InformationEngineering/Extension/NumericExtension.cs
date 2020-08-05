using System;
using static usagi.Quantity.Calculation;

namespace usagi.InformationEngineering.Extension
{
  /// <summary>
  /// 数値型への機能拡張
  /// </summary>
  static public class NumericExtension
  {
    // ClampTo

    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public byte ClampToByte( this sbyte a ) => (byte)Max<sbyte>( a, 0 );

    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public sbyte ClampToSByte( this byte a ) => (sbyte)Min<byte>( a, (byte)sbyte.MaxValue );

    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public byte ClampToByte( this Int16 a ) => (byte)Clamp<Int16>( a, 0, byte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public sbyte ClampToSByte( this Int16 a ) => (sbyte)Clamp<Int16>( a, sbyte.MinValue, sbyte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt16 ClampToUInt16( this Int16 a ) => (UInt16)Max<Int16>( a, 0 );

    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public byte ClampToByte( this UInt16 a ) => (byte)Min<UInt16>( a, byte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public sbyte ClampToSByte( this UInt16 a ) => (sbyte)Min<UInt16>( a, (UInt16)sbyte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int16 ClampToInt16( this UInt16 a ) => (Int16)Min<UInt16>( a, (UInt16)Int16.MaxValue );

    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public byte ClampToByte( this Int32 a ) => (byte)Clamp<Int32>( a, 0, byte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public sbyte ClampToSByte( this Int32 a ) => (sbyte)Clamp<Int32>( a, sbyte.MinValue, sbyte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt16 ClampToUInt16( this Int32 a ) => (UInt16)Clamp<Int32>( a, 0, UInt16.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int16 ClampToInt16( this Int32 a ) => (Int16)Clamp<Int32>( a, Int16.MinValue, Int16.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt32 ClampToUInt32( this Int32 a ) => (UInt32)Max<Int32>( a, 0 );

    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public byte ClampToByte( this UInt32 a ) => (byte)Min<UInt32>( a, byte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public sbyte ClampToSByte( this UInt32 a ) => (sbyte)Min<UInt32>( a, (UInt32)sbyte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt16 ClampToUInt16( this UInt32 a ) => (UInt16)Min<UInt32>( a, UInt16.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int16 ClampToInt16( this UInt32 a ) => (Int16)Min<UInt32>( a, (Int32)Int16.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int32 ClampToInt32( this UInt32 a ) => (Int32)Min<UInt32>( a, (UInt32)Int32.MaxValue );

    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public byte ClampToByte( this Int64 a ) => (byte)Clamp<Int64>( a, 0, byte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public sbyte ClampToSByte( this Int64 a ) => (sbyte)Clamp<Int64>( a, sbyte.MinValue, sbyte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt16 ClampToUInt16( this Int64 a ) => (UInt16)Clamp<Int64>( a, 0, UInt16.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int16 ClampToInt16( this Int64 a ) => (Int16)Clamp<Int64>( a, Int16.MinValue, Int16.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt32 ClampToUInt32( this Int64 a ) => (UInt32)Clamp<Int64>( a, 0, UInt32.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int32 ClampToInt32( this Int64 a ) => (Int32)Clamp<Int64>( a, Int32.MinValue, Int32.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt64 ClampToUInt64( this Int64 a ) => (UInt64)Max<Int64>( a, 0 );

    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public byte ClampToByte( this UInt64 a ) => (byte)Min<UInt64>( a, byte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public sbyte ClampToSByte( this UInt64 a ) => (sbyte)Min<UInt64>( a, (UInt64)sbyte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt16 ClampToUInt16( this UInt64 a ) => (UInt16)Min<UInt64>( a, UInt16.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int16 ClampToInt16( this UInt64 a ) => (Int16)Min<UInt64>( a, (Int64)Int16.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt32 ClampToUInt32( this UInt64 a ) => (UInt32)Min<UInt64>( a, UInt32.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int32 ClampToInt32( this UInt64 a ) => (Int32)Min<UInt64>( a, (Int32)Int32.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int64 ClampToInt64( this UInt64 a ) => (Int64)Min<UInt64>( a, (UInt64)Int64.MaxValue );

    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public byte ClampToByte( this float a ) => (byte)Clamp( a, byte.MinValue, byte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public sbyte ClampToSByte( this float a ) => (sbyte)Clamp( a, sbyte.MinValue, sbyte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt16 ClampToUInt16( this float a ) => (UInt16)Clamp( a, UInt16.MinValue, UInt16.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int16 ClampToInt16( this float a ) => (Int16)Clamp( a, Int16.MinValue, Int16.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt32 ClampToUInt32( this float a ) => (UInt32)Clamp( a, UInt32.MinValue, UInt32.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int32 ClampToInt32( this float a ) => (Int32)Clamp( a, Int32.MinValue, Int32.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt64 ClampToUInt64( this float a ) => (UInt64)Clamp( a, UInt64.MinValue, UInt64.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int64 ClampToInt64( this float a ) => (Int64)Clamp( a, Int64.MinValue, Int64.MaxValue );

    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public byte ClampToByte( this double a ) => (byte)Clamp( a, byte.MinValue, byte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public sbyte ClampToSByte( this double a ) => (sbyte)Clamp( a, sbyte.MinValue, sbyte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt16 ClampToUInt16( this double a ) => (UInt16)Clamp( a, UInt16.MinValue, UInt16.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int16 ClampToInt16( this double a ) => (Int16)Clamp( a, Int16.MinValue, Int16.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt32 ClampToUInt32( this double a ) => (UInt32)Clamp( a, UInt32.MinValue, UInt32.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int32 ClampToInt32( this double a ) => (Int32)Clamp( a, Int32.MinValue, Int32.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt64 ClampToUInt64( this double a ) => (UInt64)Clamp( a, UInt64.MinValue, UInt64.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int64 ClampToInt64( this double a ) => (Int64)Clamp( a, Int64.MinValue, Int64.MaxValue );

    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public byte ClampToByte( this decimal a ) => (byte)Clamp( a, byte.MinValue, byte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public sbyte ClampToSByte( this decimal a ) => (sbyte)Clamp( a, sbyte.MinValue, sbyte.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt16 ClampToUInt16( this decimal a ) => (UInt16)Clamp( a, UInt16.MinValue, UInt16.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int16 ClampToInt16( this decimal a ) => (Int16)Clamp( a, Int16.MinValue, Int16.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt32 ClampToUInt32( this decimal a ) => (UInt32)Clamp( a, UInt32.MinValue, UInt32.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int32 ClampToInt32( this decimal a ) => (Int32)Clamp( a, Int32.MinValue, Int32.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public UInt64 ClampToUInt64( this decimal a ) => (UInt64)Clamp( a, UInt64.MinValue, UInt64.MaxValue );
    /// <summary>
    /// 値をクランプ
    /// </summary>
    /// <param name="a">対象の値t</param>
    /// <returns>定義域へクランプされた値</returns>
    static public Int64 ClampToInt64( this decimal a ) => (Int64)Clamp( a, Int64.MinValue, Int64.MaxValue );
  }
}
