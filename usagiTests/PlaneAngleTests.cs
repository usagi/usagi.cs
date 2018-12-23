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
  public class PlaneAngleTests
  {
    [TestMethod()]
    public void FromDegreesTest()
    {
      // ( parse, reference, tolerance )
      var ps = new (string, double, double)[]
      { ( "43° 3′ 43.5″", 43.062_083, 0.000_001 )
      , ( "141° 21′ 15.8″", 141.354_389, 0.000_001 )
      , ( "-43° 3′ 43.5″", -43.062_083, 0.000_001 )
      , ( "-141° 21′ 15.8″", -141.354_389, 0.000_001 )
      };

      foreach ( var p in ps )
      {
        var a = PlaneAngle.Parse( p.Item1 );
        var b = PlaneAngle.FromDegrees( p.Item2 );
        Assert.AreEqual( a._deg, b._deg, p.Item3 );
      }
    }

    [TestMethod()]
    public void ToStringInDMSTest()
    {
      // ( reference, source )
      var ps = new (string, double)[]
      { ( "43°3′43.5″", 43.062_083 )
      , ( "141°21′15.8″", 141.354_389 )
      , ( "-43°3′43.5″", -43.062_083 )
      , ( "-141°21′15.8″", -141.354_389 )
      };

      foreach ( var p in ps )
      {
        var a = PlaneAngle.FromDegrees( p.Item2 ).ToStringInDMS( "F1" );
        Assert.AreEqual( a, p.Item1 );
      }
    }

    [TestMethod()]
    public void NearlyEqualsTest()
    {
      var ps = from _ in Enumerable.Range( -40, 40 ) select _ * 1.0e-1;
      foreach ( var p in ps )
      {
        var a = PlaneAngle.FromTurns( p );

        Assert.IsTrue( a.NearlyEqualsTo( a ), $"p={p} a={a} case=1" );
        Assert.IsTrue( a.NearlyEqualsTo( a, PlaneAngle.Zero ), $"p={p} a={a} case=2" );
        Assert.IsFalse( a.NearlyEqualsTo( a + PlaneAngle.CentiSecond * 2 ), $"p={p} a={a} case=3" );
        Assert.IsTrue( a.NearlyEqualsTo( a + PlaneAngle.CentiSecond / 2 ), $"p={p} a={a} case=4" );
        Assert.IsFalse( a.NearlyEqualsTo( a - PlaneAngle.CentiSecond * 2 ), $"p={p} a={a} case=5" );
        Assert.IsTrue( a.NearlyEqualsTo( a - PlaneAngle.CentiSecond / 2 ), $"p={p} a={a} case=6" );
      }
    }

    [TestMethod()]
    public void CompareToTest()
    {
      var ps = from _ in Enumerable.Range( -40, 40 ) select _ * 1.0e-1;
      foreach ( var p in ps )
      {
        var a = PlaneAngle.FromTurns( p );
        Assert.AreEqual( +1, a.CompareTo( a - PlaneAngle.Degree ) );
        Assert.AreEqual( 0, a.CompareTo( a ) );
        Assert.AreEqual( -1, a.CompareTo( a + PlaneAngle.Degree ) );
      }
    }

    [TestMethod()]
    public void NormalizedNearlyEqualsToTest()
    {
      var ps = from _ in Enumerable.Range( -40, 40 ) select _ * 1.0e-1;
      foreach ( var p in ps )
      {
        var a = PlaneAngle.FromTurns( p );

        Assert.IsTrue( a.NormalizedNearlyEqualsTo( a ), $"p={p} a={a} case=1" );
        Assert.IsTrue( a.NormalizedNearlyEqualsTo( a, PlaneAngle.Zero ), $"p={p} a={a} case=2" );
        Assert.IsFalse( a.NormalizedNearlyEqualsTo( a + PlaneAngle.CentiSecond * 2 ), $"p={p} a={a} case=3" );
        Assert.IsTrue( a.NormalizedNearlyEqualsTo( a + PlaneAngle.CentiSecond / 2 ), $"p={p} a={a} case=4" );
        Assert.IsFalse( a.NormalizedNearlyEqualsTo( a - PlaneAngle.CentiSecond * 2 ), $"p={p} a={a} case=5" );
        Assert.IsTrue( a.NormalizedNearlyEqualsTo( a - PlaneAngle.CentiSecond / 2 ), $"p={p} a={a} case=6" );
      }
    }

    [TestMethod()]
    public void OperatorEq()
    {
      var a = PlaneAngle.FromDegrees( 123 );
      var b = PlaneAngle.FromDegrees( 123 );
      var c = PlaneAngle.FromDegrees( 122 );
      var d = PlaneAngle.FromDegrees( 124 );
      var e = a + PlaneAngle.Turn;
#pragma warning disable CS1718 // Comparison made to same variable
      Assert.IsTrue( a == a, "a" );
#pragma warning restore CS1718 // Comparison made to same variable
      Assert.IsTrue( a == b, "b" );
      Assert.IsFalse( a == c, "c" );
      Assert.IsFalse( a == d, "d" );
      Assert.IsFalse( a == e, "e" );
    }
  }
}