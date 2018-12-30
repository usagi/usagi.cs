using usagi.InformationEngineering;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using static System.Threading.Tasks.Parallel;
using static usagi.Collection.Enumerable;
using usagi.InformationEngineering.Extension;

namespace usagi.InformationEngineering.Tests
{
  [TestClass()]
  public class NumericExtensionTests
  {
    [TestMethod()]
    public void I8_ClampToTest()
    {
      foreach ( var v in Range( sbyte.MinValue, sbyte.MaxValue, RangeTermination.CC ) )
        if ( v < byte.MinValue )
          AreEqual<byte>( 0, v.ClampToByte() );
        else
          AreEqual<int>( v, v.ClampToByte() );
    }

    [TestMethod()]
    public void U8_ClampToTest()
    {
      foreach ( var v in Range( byte.MinValue, byte.MaxValue, RangeTermination.CC ) )
        if ( v > sbyte.MaxValue )
          AreEqual<sbyte>( sbyte.MaxValue, v.ClampToSByte() );
        else
          AreEqual<int>( v, v.ClampToSByte() );
    }

    [TestMethod()]
    public void I16_ClampToTest()
    {
      foreach ( var v in Range( Int16.MinValue, Int16.MaxValue, RangeTermination.CC ) )
      {
        if ( v < sbyte.MinValue )
          AreEqual<sbyte>( sbyte.MinValue, v.ClampToSByte() );
        else if ( v > sbyte.MaxValue )
          AreEqual<sbyte>( sbyte.MaxValue, v.ClampToSByte() );
        else
          AreEqual<int>( v, v.ClampToSByte() );

        if ( v < byte.MinValue )
          AreEqual<byte>( byte.MinValue, v.ClampToByte() );
        else if ( v > byte.MaxValue )
          AreEqual<byte>( byte.MaxValue, v.ClampToByte() );
        else
          AreEqual<int>( v, v.ClampToByte() );

        if ( v < UInt16.MinValue )
          AreEqual<UInt16>( 0, v.ClampToUInt16() );
        else
          AreEqual<int>( v, v.ClampToUInt16() );
      }
    }

    [TestMethod()]
    public void U16_ClampToTest()
    {
      foreach ( var v in Range( UInt16.MinValue, UInt16.MaxValue, RangeTermination.CC ) )
      {
        if ( v > sbyte.MaxValue )
          AreEqual<sbyte>( sbyte.MaxValue, v.ClampToSByte() );
        else
          AreEqual<int>( v, v.ClampToSByte() );

        if ( v > byte.MaxValue )
          AreEqual<byte>( byte.MaxValue, v.ClampToByte() );
        else
          AreEqual<int>( v, v.ClampToByte() );

        if ( v > Int16.MaxValue )
          AreEqual<Int16>( Int16.MaxValue, v.ClampToInt16() );
        else
          AreEqual<int>( v, v.ClampToInt16() );
      }
    }

    [TestMethod()]
    public void I32_ClampToTest()
    {
      foreach ( var v in Range( (Int32)sbyte.MaxValue - 10, (Int32)sbyte.MaxValue + 10, RangeTermination.CC ) )
      {
        if ( v > sbyte.MaxValue )
          AreEqual<sbyte>( sbyte.MaxValue, v.ClampToSByte() );
        else
          AreEqual<sbyte>( (sbyte)v, v.ClampToSByte() );
      }

      foreach ( var v in Range( (Int32)byte.MaxValue - 10, (Int32)byte.MaxValue + 10, RangeTermination.CC ) )
      {
        if ( v > byte.MaxValue )
          AreEqual<byte>( byte.MaxValue, v.ClampToByte() );
        else
          AreEqual<byte>( (byte)v, v.ClampToByte() );
      }

      foreach ( var v in Range( (Int32)Int16.MaxValue - 10, (Int32)Int16.MaxValue + 10, RangeTermination.CC ) )
      {
        if ( v > Int16.MaxValue )
          AreEqual<Int16>( Int16.MaxValue, v.ClampToInt16() );
        else
          AreEqual<Int16>( (Int16)v, v.ClampToInt16() );
      }

      foreach ( var v in Range( (Int32)UInt16.MaxValue - 10, (Int32)UInt16.MaxValue + 10, RangeTermination.CC ) )
      {
        if ( v > UInt16.MaxValue )
          AreEqual<UInt16>( UInt16.MaxValue, v.ClampToUInt16() );
        else
          AreEqual<UInt16>( (UInt16)v, v.ClampToUInt16() );
      }

      foreach
      ( var v
        in  Range
            ( ( -10, 10, RangeTermination.CC )
            , ( Int32.MaxValue - 10, Int32.MaxValue, RangeTermination.CC )
            )
      )
      {
        if ( v < UInt32.MinValue )
          AreEqual<UInt32>( UInt32.MinValue, v.ClampToUInt32() );
        else
          AreEqual<UInt32>( (UInt32)v, v.ClampToUInt32() );
      }
    }

    [TestMethod()]
    public void U32_ClampToTest()
    {
      foreach ( var v in Range( (UInt32)(sbyte.MaxValue) - 10u, (UInt32)sbyte.MaxValue + 10u, RangeTermination.CC ) )
      {
        if ( v > sbyte.MaxValue )
          AreEqual<sbyte>( sbyte.MaxValue, v.ClampToSByte() );
        else
          AreEqual<sbyte>( (sbyte)v, v.ClampToSByte() );
      }

      foreach ( var v in Range( (UInt32)( byte.MaxValue ) - 10u, (UInt32)byte.MaxValue + 10u, RangeTermination.CC ) )
      {
        if ( v > byte.MaxValue )
          AreEqual<byte>( byte.MaxValue, v.ClampToByte() );
        else
          AreEqual<byte>( (byte)v, v.ClampToByte() );
      }

      foreach ( var v in Range( (UInt32)( Int16.MaxValue ) - 10u, (UInt32)Int16.MaxValue + 10u, RangeTermination.CC ) )
      {
        if ( v > Int16.MaxValue )
          AreEqual<Int16>( Int16.MaxValue, v.ClampToInt16() );
        else
          AreEqual<Int16>( (Int16)v, v.ClampToInt16() );
      }

      foreach ( var v in Range( (UInt32)( UInt16.MaxValue ) - 10u, (UInt32)UInt16.MaxValue + 10u, RangeTermination.CC ) )
      {
        if ( v > UInt16.MaxValue )
          AreEqual<UInt16>( UInt16.MaxValue, v.ClampToUInt16() );
        else
          AreEqual<UInt16>( (UInt16)v, v.ClampToUInt16() );
      }

      foreach ( var v in Range( (UInt32)( Int32.MaxValue ) - 10u, (UInt32)Int32.MaxValue + 10u, RangeTermination.CC ) )
      {
        if ( v > Int32.MaxValue )
          AreEqual<Int32>( Int32.MaxValue, v.ClampToInt32() );
        else
          AreEqual<Int32>( (Int32)v, v.ClampToInt32() );
      }
    }

    [TestMethod()]
    public void I64_ClampToTest()
    {
      foreach ( var v in Range( (Int64)sbyte.MaxValue - 10, (Int64)sbyte.MaxValue + 10, RangeTermination.CC ) )
      {
        if ( v > sbyte.MaxValue )
          AreEqual<sbyte>( sbyte.MaxValue, v.ClampToSByte(), "sbyte 1" );
        else
          AreEqual<sbyte>( (sbyte)v, v.ClampToSByte(), "sbyte 2" );
      }

      foreach ( var v in Range( (Int64)byte.MaxValue - 10, (Int64)byte.MaxValue + 10, RangeTermination.CC ) )
      {
        if ( v > byte.MaxValue )
          AreEqual<byte>( byte.MaxValue, v.ClampToByte(), "byte 1" );
        else
          AreEqual<byte>( (byte)v, v.ClampToByte(), "byte 2" );
      }

      foreach ( var v in Range( (Int64)Int16.MaxValue - 10, (Int64)Int16.MaxValue + 10, RangeTermination.CC ) )
      {
        if ( v > Int16.MaxValue )
          AreEqual<Int16>( Int16.MaxValue, v.ClampToInt16(), "i16 1" );
        else
          AreEqual<Int16>( (Int16)v, v.ClampToInt16(), "i16 2");
      }

      foreach ( var v in Range( (Int64)UInt16.MaxValue - 10, (Int64)UInt16.MaxValue + 10, RangeTermination.CC ) )
      {
        if ( v > UInt16.MaxValue )
          AreEqual<UInt16>( UInt16.MaxValue, v.ClampToUInt16(), "ui16 1" );
        else
          AreEqual<UInt16>( (UInt16)v, v.ClampToUInt16(), "ui16 2" );
      }

      foreach ( var v in Range( (Int64)Int32.MaxValue - 10, (Int64)Int32.MaxValue + 10, RangeTermination.CC ) )
      {
        if ( v > Int32.MaxValue )
          AreEqual<Int32>( Int32.MaxValue, v.ClampToInt32(), "i32 1" );
        else
          AreEqual<Int32>( (Int32)v, v.ClampToInt32(), "i32 2" );
      }

      foreach ( var v in Range( (Int64)UInt32.MaxValue - 10, (Int64)UInt32.MaxValue + 10, RangeTermination.CC ) )
      {
        if ( v > UInt32.MaxValue )
          AreEqual<UInt32>( UInt32.MaxValue, v.ClampToUInt32(), "ui32 1" );
        else
          AreEqual<UInt32>( (UInt32)v, v.ClampToUInt32(), "ui32 2" );
      }

      foreach
      ( var v
        in Range
            ( (-10, 10, RangeTermination.CC)
            , (Int64.MaxValue - 10, Int64.MaxValue, RangeTermination.CC)
            )
      )
      {
        if ( v < (Int64)UInt64.MinValue )
          AreEqual<UInt64>( UInt64.MinValue, v.ClampToUInt64(), "ui64 1" );
        else
          AreEqual<UInt64>( (UInt64)v, v.ClampToUInt64(), "ui64 2" );
      }
    }

    [TestMethod()]
    public void U64_ClampToTest()
    {
      foreach ( var v in Range( (UInt64)( sbyte.MaxValue ) - 10u, (UInt64)sbyte.MaxValue + 10u, RangeTermination.CC ) )
      {
        if ( v > (UInt64)sbyte.MaxValue )
          AreEqual<sbyte>( sbyte.MaxValue, v.ClampToSByte() );
        else
          AreEqual<sbyte>( (sbyte)v, v.ClampToSByte() );
      }

      foreach ( var v in Range( (UInt64)( byte.MaxValue ) - 10u, (UInt64)byte.MaxValue + 10u, RangeTermination.CC ) )
      {
        if ( v > byte.MaxValue )
          AreEqual<byte>( byte.MaxValue, v.ClampToByte() );
        else
          AreEqual<byte>( (byte)v, v.ClampToByte() );
      }

      foreach ( var v in Range( (UInt64)( Int16.MaxValue ) - 10u, (UInt64)Int16.MaxValue + 10u, RangeTermination.CC ) )
      {
        if ( v > (UInt64)Int16.MaxValue )
          AreEqual<Int16>( Int16.MaxValue, v.ClampToInt16() );
        else
          AreEqual<Int16>( (Int16)v, v.ClampToInt16() );
      }

      foreach ( var v in Range( (UInt64)( UInt16.MaxValue ) - 10u, (UInt64)UInt16.MaxValue + 10u, RangeTermination.CC ) )
      {
        if ( v > UInt16.MaxValue )
          AreEqual<UInt16>( UInt16.MaxValue, v.ClampToUInt16() );
        else
          AreEqual<UInt16>( (UInt16)v, v.ClampToUInt16() );
      }

      foreach ( var v in Range( (UInt64)( Int32.MaxValue ) - 10u, (UInt64)Int32.MaxValue + 10u, RangeTermination.CC ) )
      {
        if ( v > (UInt64)Int32.MaxValue )
          AreEqual<Int32>( Int32.MaxValue, v.ClampToInt32() );
        else
          AreEqual<Int32>( (Int32)v, v.ClampToInt32() );
      }

      foreach ( var v in Range( (UInt64)( UInt32.MaxValue ) - 10u, (UInt64)UInt32.MaxValue + 10u, RangeTermination.CC ) )
      {
        if ( v > UInt32.MaxValue )
          AreEqual<UInt32>( UInt32.MaxValue, v.ClampToUInt32() );
        else
          AreEqual<UInt32>( (UInt32)v, v.ClampToUInt32() );
      }

      foreach ( var v in Range( (UInt64)( Int64.MaxValue ) - 10u, (UInt64)Int64.MaxValue + 10u, RangeTermination.CC ) )
      {
        if ( v > Int64.MaxValue )
          AreEqual<Int64>( Int64.MaxValue, v.ClampToInt64() );
        else
          AreEqual<Int64>( (Int64)v, v.ClampToInt64() );
      }
    }
  }
}