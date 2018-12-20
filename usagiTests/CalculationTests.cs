using Microsoft.VisualStudio.TestTools.UnitTesting;
using usagi.Quantity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usagi.Quantity.Tests
{
  [TestClass()]
  public class CalculationTests
  {
    [TestMethod()]
    public void ClampTest()
    {
      var f = -100;
      var c = 100;
      var vs = Enumerable.Range( -200, 200 );
      foreach ( var v in vs )
        if ( v < f )
          Assert.AreEqual( f, Calculation.Clamp( v, f, c ) );
        else if ( v > c )
          Assert.AreEqual( c, Calculation.Clamp( v, f, c ) );
        else
          Assert.AreEqual( v, Calculation.Clamp( v, f, c ) );
    }

    [TestMethod()]
    public void DistanceTest()
    {
      // ( a, b, expected )
      var ps = new (int, int, int)[]
      { (   0,   0,  0 )
      , ( -10,   0, 10 )
      , (   0, -10, 10 )
      , (  10,   0, 10 )
      , (   0,  10, 10 )
      , ( -10,  10, 20 )
      , (  10, -10, 20 )
      };

      foreach ( var p in ps )
        Assert.AreEqual( p.Item3, Calculation.Distance( p.Item1, p.Item2, ( a, b ) => a - b ), p.ToString() );
    }

    [TestMethod()]
    public void IsInRangeOfTest()
    {
      // ( value, floor, ceil, expected )
      var ps = new (int, int, int, bool)[]
      { (   0,   0,  0, true )
      , (   0, -10, 10, true )
      , ( -10, -10, 10, true )
      , (  10, -10, 10, true )
      , ( -20, -10, 10, false )
      , (  20, -10, 10, false )
      };

      foreach ( var p in ps )
        Assert.AreEqual( p.Item4, Calculation.IsInRangeOf( p.Item1, p.Item2, p.Item3 ), p.ToString() );
    }

    [TestMethod()]
    public void MinTest()
    {
      Assert.AreEqual( 1, Calculation.Min( 1, 2, 3, 4, 5 ) );
      Assert.AreEqual( 1, Calculation.Min( 5, 4, 3, 2, 1 ) );
      Assert.AreEqual( -4, Calculation.Min( -2, -4, 0, 2, 4 ) );
    }

    [TestMethod()]
    public void MaxTest()
    {
      Assert.AreEqual( 5, Calculation.Max( 1, 2, 3, 4, 5 ) );
      Assert.AreEqual( 5, Calculation.Max( 5, 4, 3, 2, 1 ) );
      Assert.AreEqual( 4, Calculation.Max( -2, -4, 0, 2, 4 ) );
    }

    [TestMethod()]
    public void NearlyEqualsTest()
    {
      // ( a, b, tolerance, expected )
      var ps = new (int, int, int, bool)[]
      { (   0,   0,  0, true )
      , (   0,   5,  4, false )
      , (   0,   5,  5, true )
      , (   0,   5,  6, true )
      , (  -5,   0,  4, false )
      , (  -5,   0,  5, true )
      , (  -5,   0,  6, true )
      };

      foreach ( var p in ps )
      {
        Assert.AreEqual( p.Item4, Calculation.NearlyEquals( p.Item1, p.Item2, p.Item3 ), $"a,b of {p}" );
        Assert.AreEqual( p.Item4, Calculation.NearlyEquals( p.Item1, p.Item2, p.Item3 ), $"b,a of {p}" );
      }
    }
  }
}