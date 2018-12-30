using Microsoft.VisualStudio.TestTools.UnitTesting;
using usagi.Quantity.Ratio.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using static System.Linq.Enumerable;
using static usagi.Quantity.Calculation;
using static System.Math;
using static usagi.Collection.Enumerable;
using usagi.InformationEngineering.Extension;

namespace usagi.Quantity.Ratio.Tests
{
  [TestClass()]
  public class NumericExtensionTests
  {
    [TestMethod()]
    public void DecompositionToCommonFractionTest()
    {
      var ts = new (int Numerator, int Denominator, double? Epsilon, bool Eq)[]
      { ( 16, 9, null, true )
      , ( 4, 3, null, true )
      , ( 3, 4, null, true )
      , ( 5, 8, null, true )
      , ( 12345, 4321, null, false )
      , ( 12345, 4321, 1.0e-100d, true )
      , ( -21, 4, null, true )
      };

      foreach ( var (n,d,e,q) in ts )
      {
        var expected = (n, d);
        var ratio = (double)n / (double)d;
        var actual = ratio.DecompositionToCommonFraction( e );
        if ( q )
          AreEqual( expected, actual );
        else
          AreNotEqual( expected, actual );
      }
    }

    [TestMethod()]
    public void UNormTest()
    {
      const decimal d = 25M;
      foreach
      ( var v
        in  Range
            ( (   -d, d, RangeTermination.CC)
            , ((decimal)sbyte.MinValue - d, (decimal)sbyte.MinValue + d, RangeTermination.CC)
            , ((Int64)sbyte.MaxValue - d, (Int64)sbyte.MaxValue + d, RangeTermination.CC)
            , ((Int64)byte.MaxValue - d, (Int64)byte.MaxValue + d, RangeTermination.CC)
            , ((Int64)Int16.MinValue - d, (Int64)Int16.MinValue + d, RangeTermination.CC)
            , ((Int64)Int16.MaxValue - d, (Int64)Int16.MaxValue + d, RangeTermination.CC)
            , ((Int64)UInt16.MaxValue - d, (Int64)UInt16.MaxValue + d, RangeTermination.CC)
            , ((Int64)Int32.MinValue - d, (Int64)Int32.MinValue + d, RangeTermination.CC)
            , ((Int64)Int32.MaxValue - d, (Int64)Int32.MaxValue + d, RangeTermination.CC)
            , ((Int64)UInt32.MaxValue - d, (Int64)UInt32.MaxValue + d, RangeTermination.CC)
            , (Int32.MaxValue - d, (Int64)Int32.MaxValue + d, RangeTermination.CC)
            , (Int32.MaxValue - d, (Int64)Int32.MaxValue + d, RangeTermination.CC)
            )
      )
      {
        var d8 = (byte)Clamp( v, byte.MinValue, byte.MaxValue );
        var d16 = (UInt16)Clamp( v, UInt16.MinValue, UInt16.MaxValue );
        var d32 = (UInt32)Clamp( v, UInt32.MinValue, UInt32.MaxValue );
        var d64 = (UInt64)Clamp( v, UInt64.MinValue, UInt64.MaxValue );
        var r8 = v.ClampToByte().ToUNorm();
        var r16 = v.ClampToUInt16().ToUNorm();
        var r32 = v.ClampToUInt32().ToUNorm();
        var r64 = v.ClampToUInt64().ToUNorm();
        IsTrue( IsInRangeOf( r8.ClampToUNorm(), 0d, 1d ), $"v={v} r8 range" );
        IsTrue( IsInRangeOf( r16.ClampToUNorm(), 0d, 1d ), $"v={v} r16 range" );
        IsTrue( IsInRangeOf( r32.ClampToUNorm(), 0d, 1d ), $"v={v} r32 range" );
        IsTrue( IsInRangeOf( r64.ClampToUNorm(), 0d, 1d ), $"v={v} r64 range" );
        var v8 = r8.UNormToByte();
        var v16 = r16.UNormToUInt16();
        var v32 = r32.UNormToUInt32();
        var v64 = r64.UNormToUInt64();
        AreEqual( d8, v8, $"v={v} d8 eq v8" );
        AreEqual( d16, v16, $"v={v} d16 eq v16" );
        AreEqual( d32, v32, $"v={v} d32 eq v32" );
        AreEqual( d64, v64, $"v={v} d64 eq v64" );
      }
    }
  }
}