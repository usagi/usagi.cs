using Microsoft.VisualStudio.TestTools.UnitTesting;
using usagi.Quantity.GeoLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usagi.Quantity.GeoLocation.Tests
{
  [TestClass()]
  public class LonLatTests
  {
    [TestMethod()]
    public void ParseTest()
    {
      var patterns = new (string Pattern, LonLat Expected)[]
      { ( "43° 3′ 43.5″ N, 141° 21′ 15.8″ E", new LonLat( PlaneAngle.FromDegrees(141,21,15.8), PlaneAngle.FromDegrees( 43, 3, 43.5 ) ) )
      , ( "北緯43度3分43.5秒 東経141度21分15.8秒", new LonLat( PlaneAngle.FromDegrees(141,21,15.8), PlaneAngle.FromDegrees( 43, 3, 43.5 ) ) )
      , ( "43° 3′ 43.5″ S, 141° 21′ 15.8″ W", new LonLat( PlaneAngle.FromDegrees(-141,21,15.8), PlaneAngle.FromDegrees( -43, 3, 43.5 ) ) )
      , ( "南緯43度3分43.5秒 西経141度21分15.8秒", new LonLat( PlaneAngle.FromDegrees(-141,21,15.8), PlaneAngle.FromDegrees( -43, 3, 43.5 ) ) )
      , ( "43.062083,141.354389", new LonLat( PlaneAngle.FromDegrees(141.354389), PlaneAngle.FromDegrees(43.062083) ) )
      , ( "43.062083 deg,141.354389 deg", new LonLat( PlaneAngle.FromDegrees(141.354389), PlaneAngle.FromDegrees(43.062083) ) )
      , ( "0.2τ,0.3τ", new LonLat( PlaneAngle.FromTurns(0.3), PlaneAngle.FromTurns(0.2) ) )
      };

      foreach ( var ( P, E ) in patterns )
      {
        var A = LonLat.Parse( P );
        Assert.IsTrue
          ( E.NearlyEqualsTo( A )
          , $"pattern={P} \nexpected={E.ToString( 15 )} \nactual={A.ToString( 15 )}"
          );
      }
    }
  }
}