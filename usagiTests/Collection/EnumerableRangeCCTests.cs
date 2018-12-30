using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using static usagi.Collection.Enumerable;

namespace usagi.Collection.Tests
{
  [TestClass()]
  public class EnumerableRangeCCTests
  {
    [TestMethod()]
    public void U8_RangeCCTest()
    {
      var e = Range( byte.MinValue, byte.MaxValue, RangeTermination.CC );
      Assert.AreEqual( byte.MinValue, e.First() );
      Assert.AreEqual( byte.MaxValue, e.Last() );
      Assert.AreEqual( byte.MaxValue - byte.MinValue + 1, e.Count() );
    }

    [TestMethod()]
    public void I8_RangeCCTest()
    {
      var e = Range( sbyte.MinValue, sbyte.MaxValue, RangeTermination.CC );
      Assert.AreEqual( sbyte.MinValue, e.First() );
      Assert.AreEqual( sbyte.MaxValue, e.Last() );
      Assert.AreEqual( sbyte.MaxValue - sbyte.MinValue + 1, e.Count() );
    }

    [TestMethod()]
    public void U16_RangeCCTest()
    {
      {
        var e = Range( UInt16.MinValue, UInt16.MinValue + 100u, RangeTermination.CC );
        Assert.AreEqual( UInt16.MinValue, e.First() );
        Assert.AreEqual( UInt16.MinValue + 100u, e.Last() );
        Assert.AreEqual<decimal>( UInt16.MinValue + 100u - UInt16.MinValue + 1U, e.Count() );
      }
      {
        var e = Range( UInt16.MaxValue - 100u, UInt16.MaxValue, RangeTermination.CC );
        Assert.AreEqual( UInt16.MaxValue - 100u, e.First() );
        Assert.AreEqual( UInt16.MaxValue, e.Last() );
        Assert.AreEqual<decimal>( UInt16.MaxValue - ( UInt16.MaxValue - 100 ) + 1U, e.Count() );
      }
    }

    [TestMethod()]
    public void I16_RangeCCTest()
    {
      {
        var e = Range( Int16.MinValue, Int16.MinValue + 100u, RangeTermination.CC );
        Assert.AreEqual( Int16.MinValue, e.First() );
        Assert.AreEqual( Int16.MinValue + 100u, e.Last() );
        Assert.AreEqual<decimal>( Int16.MinValue + 100u - Int16.MinValue + 1, e.Count() );
      }
      {
        var e = Range( Int16.MaxValue - 100u, Int16.MaxValue, RangeTermination.CC );
        Assert.AreEqual( Int16.MaxValue - 100u, e.First() );
        Assert.AreEqual( Int16.MaxValue, e.Last() );
        Assert.AreEqual<decimal>( Int16.MaxValue - ( Int16.MaxValue - 100 ) + 1, e.Count() );
      }
    }

    [TestMethod()]
    public void U32_RangeCCTest()
    {
      {
        var e = Range( UInt32.MinValue, UInt32.MinValue + 100, RangeTermination.CC );
        Assert.AreEqual( UInt32.MinValue, e.First() );
        Assert.AreEqual( UInt32.MinValue + 100, e.Last() );
        Assert.AreEqual<decimal>( UInt32.MinValue + 100 - UInt32.MinValue + 1U, e.Count() );
      }
      {
        var e = Range( UInt32.MaxValue - 100, UInt32.MaxValue, RangeTermination.CC );
        Assert.AreEqual( UInt32.MaxValue - 100, e.First() );
        Assert.AreEqual( UInt32.MaxValue, e.Last() );
        Assert.AreEqual<decimal>( UInt32.MaxValue - ( UInt32.MaxValue - 100 ) + 1U, e.Count() );
      }
    }

    [TestMethod()]
    public void I32_RangeCCTest()
    {
      {
        var e = Range( Int32.MinValue, Int32.MinValue + 100, RangeTermination.CC );
        Assert.AreEqual( Int32.MinValue, e.First() );
        Assert.AreEqual( Int32.MinValue + 100, e.Last() );
        Assert.AreEqual<decimal>( Int32.MinValue + 100 - Int32.MinValue + 1, e.Count() );
      }
      {
        var e = Range( Int32.MaxValue - 100, Int32.MaxValue, RangeTermination.CC );
        Assert.AreEqual( Int32.MaxValue - 100, e.First() );
        Assert.AreEqual( Int32.MaxValue, e.Last() );
        Assert.AreEqual<decimal>( Int32.MaxValue - ( Int32.MaxValue - 100 ) + 1, e.Count() );
      }
    }

    [TestMethod()]
    public void U64_RangeCCTest()
    {
      {
        var e = Range( UInt64.MinValue, UInt64.MinValue + 100UL, RangeTermination.CC );
        Assert.AreEqual( UInt64.MinValue, e.First() );
        Assert.AreEqual( UInt64.MinValue + 100UL, e.Last() );
        Assert.AreEqual<decimal>( UInt64.MinValue + 100UL - UInt64.MinValue + 1U, e.Count() );
      }
      {
        var e = Range( UInt64.MaxValue - 100UL, UInt64.MaxValue, RangeTermination.CC );
        Assert.AreEqual( UInt64.MaxValue - 100UL, e.First() );
        Assert.AreEqual( UInt64.MaxValue, e.Last() );
        Assert.AreEqual<decimal>( UInt64.MaxValue - ( UInt64.MaxValue - 100 ) + 1U, e.Count() );
      }
    }

    [TestMethod()]
    public void I64_RangeCCTest()
    {
      {
        var e = Range( Int64.MinValue, Int64.MinValue + 100L, RangeTermination.CC );
        Assert.AreEqual( Int64.MinValue, e.First() );
        Assert.AreEqual( Int64.MinValue + 100L, e.Last() );
        Assert.AreEqual<decimal>( Int64.MinValue + 100L - Int64.MinValue + 1L, e.Count() );
      }
      {
        var e = Range( Int64.MaxValue - 100L, Int64.MaxValue, RangeTermination.CC );
        Assert.AreEqual( Int64.MaxValue - 100L, e.First() );
        Assert.AreEqual( Int64.MaxValue, e.Last() );
        Assert.AreEqual<decimal>( Int64.MaxValue - ( Int64.MaxValue - 100 ) + 1L, e.Count() );
      }
    }
  }
}