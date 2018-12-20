using Microsoft.VisualStudio.TestTools.UnitTesting;
using usagi.URI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usagi.URI.Tests
{
  [TestClass()]
  public class GeoURITests
  {
    [TestMethod()]
    public void CtorOKPatterns()
    {
      var ps = new string[]
      { "geo:43.062083,141.354389"
      , "geo:43.062083,141.354389;u=40"
      , "geo:43.062083,141.354389;crs=wgs84"
      , "geo:43.062083,141.354389;u=40;crs=wgs84"
      , "geo:43.062083,141.354389;crs=wgs84;u=40"
      , "geo:43.062083,141.354389,19.9"
      , "geo:43.062083,141.354389,19.9;u=40"
      , "geo:43.062083,141.354389,19.9;crs=wgs84"
      , "geo:43.062083,141.354389,19.9;u=40;crs=wgs84"
      , "geo:43.062083,141.354389,19.9;crs=wgs84;u=40"
      , "GEO:43.062083,141.354389,19.9;CRS=WGS84;U=XYZ"
      , "GEO:-50.0,-111.0"
      , "GEO:222,999"
      , "GEO:-222,-999"
      };

      foreach ( var p in ps )
        try
        { new GeoURI( p ); }
        catch ( Exception e )
        { Assert.Fail( $"{p} -> {e.GetType().FullName}" ); }
    }

    [TestMethod()]
    public void CtorNGPatterns()
    { 
      var ps = new string[]
      { "geo-location:1.111,2.222"
      , "geo://1,2"
      , "geo:////////1,2"
      , "https://www.example.com/"
      };

      foreach ( var p in ps )
        try
        {
          var a = new GeoURI( p );
          Assert.Fail( $"p={p} a.Scheme={a.Scheme} a.Lon={a.Longitude} a.Lat={a.Latitude}");
        }
        catch ( GeoURI.GeoURIException )
        { }
        catch ( Exception e )
        { Assert.Fail( $"p={p} e.Message={e.Message} e.GetType()={e.GetType().FullName}" ); }
    }
  }
}