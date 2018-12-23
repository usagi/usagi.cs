using Microsoft.VisualStudio.TestTools.UnitTesting;
using usagi.CivilEngineering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using usagi.Quantity.GeoLocation;
using usagi.Quantity;

namespace usagi.CivilEngineering.Tests
{
  [TestClass()]
  public class WebMercatorTests
  {
    [TestMethod()]
    public void AngleToTileTest()
    {
      var ps = new (UInt32 ExpectedX, UInt32 ExpectedY, byte ExpectedZ, LonLat ActualLocation)[]
      { ( 3, 1, 2, LonLat.FromDegrees( 140.087099, 36.104665 ) )
      , ( 7, 3, 3, LonLat.FromDegrees( 140.087099, 36.104665 ) )
      , ( 14, 6, 4, LonLat.FromDegrees( 140.087099, 36.104665 ) )
      , ( 233080, 102845, 18, LonLat.FromDegrees( 140.087099, 36.104665 ) )
      };

      foreach ( var (X, Y, Z, L) in ps )
      {
        var E = new TileLocation( X, Y, Z );
        var A = WebMercator.AngleToTile( L, Z );
        Assert.AreEqual( E, A );
      }
    }
  }
}