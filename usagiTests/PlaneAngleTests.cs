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
        var b = PlaneAngle.FromDegrees( p.Item2);
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
  }
}