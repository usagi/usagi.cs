using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using static usagi.Collection.Enumerable;

namespace usagi.Collection.Tests
{
  [TestClass()]
  public class EnumerableRangeCOTests
  {
    [TestMethod()]
    public void U8_RangeTest()
    {
      var e = Range( byte.MinValue, byte.MaxValue, RangeTermination.CO );
      Assert.AreEqual( byte.MinValue, e.First() );
      Assert.AreEqual( byte.MaxValue - 1, e.Last() );
      Assert.AreEqual( byte.MaxValue - byte.MinValue, e.Count() );
    }

    [TestMethod()]
    public void I8_RangeTest()
    {
      var e = Range( sbyte.MinValue, sbyte.MaxValue, RangeTermination.CO );
      Assert.AreEqual( sbyte.MinValue, e.First() );
      Assert.AreEqual( sbyte.MaxValue - 1, e.Last() );
      Assert.AreEqual( sbyte.MaxValue - sbyte.MinValue, e.Count() );
    }

    [TestMethod()]
    public void U16_RangeTest()
    {
      {
        var e = Range( UInt16.MinValue, UInt16.MinValue + 100u, RangeTermination.CO );
        Assert.AreEqual( UInt16.MinValue, e.First() );
        Assert.AreEqual( UInt16.MinValue + 100u - 1u, e.Last() );
        Assert.AreEqual<decimal>( UInt16.MinValue + 100u - UInt16.MinValue, e.Count() );
      }
      {
        var e = Range( UInt16.MaxValue - 100u, UInt16.MaxValue, RangeTermination.CO );
        Assert.AreEqual( UInt16.MaxValue - 100u, e.First() );
        Assert.AreEqual( UInt16.MaxValue - 1u, e.Last() );
        Assert.AreEqual<decimal>( UInt16.MaxValue - ( UInt16.MaxValue - 100u ), e.Count() );
      }
    }

    [TestMethod()]
    public void I16_RangeTest()
    {
      {
        var e = Range( Int16.MinValue, Int16.MinValue + 100u, RangeTermination.CO );
        Assert.AreEqual( Int16.MinValue, e.First() );
        Assert.AreEqual( Int16.MinValue + 100u - 1u, e.Last() );
        Assert.AreEqual<decimal>( Int16.MinValue + 100u - Int16.MinValue, e.Count() );
      }
      {
        var e = Range( Int16.MaxValue - 100u, Int16.MaxValue, RangeTermination.CO );
        Assert.AreEqual( Int16.MaxValue - 100u, e.First() );
        Assert.AreEqual( Int16.MaxValue - 1u, e.Last() );
        Assert.AreEqual<decimal>( Int16.MaxValue - ( Int16.MaxValue - 100u ), e.Count() );
      }
    }

    [TestMethod()]
    public void U32_RangeTest()
    {
      {
        var e = Range( UInt32.MinValue, UInt32.MinValue + 100, RangeTermination.CO );
        Assert.AreEqual( UInt32.MinValue, e.First() );
        Assert.AreEqual( UInt32.MinValue + 100 - 1, e.Last() );
        Assert.AreEqual<decimal>( UInt32.MinValue + 100 - UInt32.MinValue , e.Count() );
      }
      {
        var e = Range( UInt32.MaxValue - 100, UInt32.MaxValue, RangeTermination.CO );
        Assert.AreEqual( UInt32.MaxValue - 100, e.First() );
        Assert.AreEqual( UInt32.MaxValue - 1, e.Last() );
        Assert.AreEqual<decimal>( UInt32.MaxValue - ( UInt32.MaxValue - 100 ), e.Count() );
      }
    }

    [TestMethod()]
    public void I32_RangeTest()
    {
      {
        var e = Range( Int32.MinValue, Int32.MinValue + 100, RangeTermination.CO );
        Assert.AreEqual( Int32.MinValue, e.First() );
        Assert.AreEqual( Int32.MinValue + 100 - 1, e.Last() );
        Assert.AreEqual<decimal>( Int32.MinValue + 100 - Int32.MinValue, e.Count() );
      }
      {
        var e = Range( Int32.MaxValue - 100, Int32.MaxValue, RangeTermination.CO );
        Assert.AreEqual( Int32.MaxValue - 100, e.First() );
        Assert.AreEqual( Int32.MaxValue - 1, e.Last() );
        Assert.AreEqual<decimal>( Int32.MaxValue - ( Int32.MaxValue - 100 ), e.Count() );
      }
    }

    [TestMethod()]
    public void U64_RangeTest()
    {
      {
        var e = Range( UInt64.MinValue, UInt64.MinValue + 100, RangeTermination.CO );
        Assert.AreEqual( UInt64.MinValue, e.First() );
        Assert.AreEqual( UInt64.MinValue + 100 - 1, e.Last() );
        Assert.AreEqual<decimal>( UInt64.MinValue + 100 - UInt64.MinValue, e.Count() );
      }
      {
        var e = Range( UInt64.MaxValue - 100, UInt64.MaxValue, RangeTermination.CO );
        Assert.AreEqual( UInt64.MaxValue - 100, e.First() );
        Assert.AreEqual( UInt64.MaxValue - 1, e.Last() );
        Assert.AreEqual<decimal>( UInt64.MaxValue - ( UInt64.MaxValue - 100 ), e.Count() );
      }
    }

    [TestMethod()]
    public void I64_RangeTest()
    {
      {
        var e = Range( Int64.MinValue, Int64.MinValue + 100, RangeTermination.CO );
        Assert.AreEqual( Int64.MinValue, e.First() );
        Assert.AreEqual( Int64.MinValue + 100 - 1, e.Last() );
        Assert.AreEqual<decimal>( Int64.MinValue + 100 - Int64.MinValue, e.Count() );
      }
      {
        var e = Range( Int64.MaxValue - 100, Int64.MaxValue, RangeTermination.CO );
        Assert.AreEqual( Int64.MaxValue - 100, e.First() );
        Assert.AreEqual( Int64.MaxValue - 1, e.Last() );
        Assert.AreEqual<decimal>( Int64.MaxValue - ( Int64.MaxValue - 100 ), e.Count() );
      }
    }
  }
}