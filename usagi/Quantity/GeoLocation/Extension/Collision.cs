using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usagi.Math
{
  static public class Calucation
  {
    static public void SolveLinearAlgebra(out double a, out double b, double x0, double y0, double x1, double y1)
    {
      var dy = y1 - y0;
      var dx = x1 - x0;
      a = dy / dx;
      b = y0 - a * x0;
    }
  }
}

namespace usagi.Quantity.GeoLocation.Extension
{
  public static class CollisionExtension
  {
    static public void SolveLinearAlgebra(out double delta, out PlaneAngle constant, LonLat p0, LonLat p1)
    {
      Math.Calucation.SolveLinearAlgebra(out delta, out var b, p0.Longitude._deg, p0.Latitude._deg, p1.Longitude._deg, p1.Latitude._deg);
      constant = PlaneAngle.FromDegrees(b);
    }

    static public bool IsInside(LonLat point, IEnumerable<LonLat> inclusive_area, PlaneAngle torelance = null)
    {
      {
        // 比較対象がない、比較対象が点、比較対象が線分の場合
        var n = inclusive_area.Count();
        if (n <= 2)
        {
          torelance = torelance ?? PlaneAngle.Second;
          if (n == 0)
            return false;
          if (n == 1)
            return point.NearlyEqualsTo(inclusive_area.First(), torelance);
          // c == 2
          SolveLinearAlgebra(out var d, out var c, inclusive_area.First(), inclusive_area.Last());
          return point.Latitude.NearlyEquals(d * point.Longitude + c, torelance);
        }
      }

      // 比較対象が3点以上で構成される Surface の場合

      var crossed = 0;

      LonLat aggregative_tester(LonLat p0, LonLat p1)
      {
        var result = 0;

        if (p0.Latitude <= point.Latitude && p1.Latitude > point.Latitude)
          result = 1;
        else if (p0.Latitude > point.Latitude && p1.Latitude <= point.Latitude)
          result = -1;
        else
          return p1;

        var d_lat_p_p0 = point.Latitude - p0.Latitude;
        var d_lat_p1_p0 = p1.Latitude - p0.Latitude;
        var r_lat = d_lat_p_p0 / d_lat_p1_p0;

        var d_lon_p1_p0 = p1.Longitude - p0.Longitude;

        var s = r_lat * d_lon_p1_p0 + p0.Longitude;

        if (point.Longitude < s)
          crossed += result;

        // Aggregate が次の p0 として今回の p1 を使う
        return p1;
      }

      // test: [ ( p[0], p[1] ), ( p[1], p[2] ), ... , ( p[last-1], p[last]) ]
      inclusive_area.Aggregate(aggregative_tester);
      // test: ( p[last], p[first] )
      aggregative_tester(inclusive_area.Last(), inclusive_area.First());

      return crossed != 0;
    }

  }
}
