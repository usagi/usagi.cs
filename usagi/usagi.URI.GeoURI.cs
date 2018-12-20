using System;
using System.Device.Location;
using System.Text.RegularExpressions;
using usagi.Quantity;
using usagi.Quantity.GeoLocation;

namespace usagi.URI
{
  /// <summary>
  /// ref. https://tools.ietf.org/rfc/rfc5870
  /// pattern 1: geo:%lat%,%lon%;u=%unc%
  /// pattern 2: geo:%lat%,%lon%,%alt%;u=%unc%
  /// pattern 3: geo:%lat%,%lon%,%alt%;crs=%crs%;u=%unc%
  /// %lat% is a Latitude
  /// %lon% is a Longitude
  /// %alt% is an Altitude ( optional )
  /// %unc% is an Uncertainty Parameter ( optional )
  /// %crs% is a Coordinate Reference System ( optional )
  /// eg. href='geo:48.198634,16.371648;crs=wgs84;u=40'
  /// なお、 System.Uri から派生させたかったが . 文字を含まない Host の検出で例外を出すため関わらない事にした。
  /// </summary>
  public class GeoURI
    : ILonLatGettable
    , IAltitudeGettable
    , IToGeoCoordinate
    , IEquatable<GeoURI>
  {
    public class GeoURIException: Exception { }
    public class SchemeIsNotGeoURIException: GeoURIException { }
    public class GeoURIPatternIsNotMatchedException: GeoURIException { }
    public class LongitudeParseFailedException: GeoURIException { }
    public class LatitudeParseFailedException: GeoURIException { }
    public class AltitudeParseFailedException: GeoURIException { }

    public static readonly string UriSchemeGeo = "geo";

    public const string RegexPattern = @"(?<scheme>geo):(?<lat>-?[\d.]+),(?<lon>-?[\d.]+)(?:,(?<alt>-?[\d.]+))?(?:(?:;crs=(?<crs>[^;]+))|(?:;u=(?<u>[^;]+)))*";
    public static readonly Regex Regex = new Regex( RegexPattern, RegexOptions.IgnoreCase );

    public PlaneAngle Longitude { get; private set; }
    public PlaneAngle Latitude { get; private set; }
    public Length Altitude { get; private set; } = null;
    public string Uncertainty { get; private set; } = null;
    public string CoordinateReferenceSystem { get; private set; } = null;
    public string Scheme { get { return UriSchemeGeo; } }
    public string OriginalString { get; private set; }

    public GeoURI( PlaneAngle lon, PlaneAngle lat, Length alt = null, string crs = null, string u = null )
    {
      Longitude = lon;
      Latitude = lat;
      NormalizeLonLat();
      Altitude = alt;
      CoordinateReferenceSystem = crs;
      Uncertainty = u;

      OriginalString =
        $"geo:{lat._deg},{lon._deg}"
        + ( alt is Length ? $",{alt._m}" : "" )
        + ( crs is string ? $";crs={crs}" : "" )
        + ( u is string ? $";u={u}" : "" )
        ;
    }
    public GeoURI( LonLat a, string crs = null, string u = null )
      : this( a.Longitude, a.Latitude, null, crs, u )
    { }
    public GeoURI( LonLatAlt a, string crs = null, string u = null )
      : this( a.Longitude, a.Latitude, a.Altitude, crs, u )
    { }
    public GeoURI( Uri uri )
      : this( uri.OriginalString )
    { }
    public GeoURI( string str )
    {
      var m = Regex.Match( str );

      if ( ! m.Groups[ "scheme" ].Success )
        throw new SchemeIsNotGeoURIException();

      if ( m is Match )
      {
        double buffer = 0;
        // lon
        if ( !m.Groups[ "lon" ].Success || !double.TryParse( m.Groups[ "lon" ].Value, out buffer ) )
          throw new LongitudeParseFailedException();
        Longitude = PlaneAngle.FromDegrees( buffer );
        // lat
        if ( !m.Groups[ "lat" ].Success || !double.TryParse( m.Groups[ "lat" ].Value, out buffer ) )
          throw new LatitudeParseFailedException();
        Latitude = PlaneAngle.FromDegrees( buffer );
        NormalizeLonLat();
        // alt
        if ( m.Groups[ "alt" ].Success )
        {
          if ( !double.TryParse( m.Groups[ "lat" ].Value, out buffer ) )
            throw new LatitudeParseFailedException();
          Altitude = Length.From_m( buffer );
        }
        // crs
        if ( m.Groups[ "crs" ].Success )
          CoordinateReferenceSystem = m.Groups[ "crs" ].Value.ToLower();
        // u
        if ( m.Groups[ "u" ].Success )
          CoordinateReferenceSystem = m.Groups[ "u" ].Value.ToLower();
      }
      else
        throw new GeoURIPatternIsNotMatchedException();
    }

    public GeoCoordinate ToGeoCoordinate()
    {
      var r = new GeoCoordinate( Latitude._deg, Longitude._deg );
      if ( Altitude is Length )
        r.Altitude = Altitude._m;
      return r;
    }

    /// <summary>
    /// Longitude [ -180 ... +180 )
    /// Latitude [ -90 ... +90 )
    /// に正規化する。
    /// </summary>
    void NormalizeLonLat()
    {
      Latitude.Normalize180();
      if ( Math.Abs( Latitude._deg ) > 90.0 )
      {
        Longitude._turns += 0.5;
        var sign = Math.Sign( Latitude._deg );
        Latitude._deg = ( sign * 180 ) - Latitude._deg;
      }
      Longitude.Normalize180();
    }

    public override string ToString()
    { return OriginalString; }

    public bool Equals( GeoURI other )
    {
      if ( !Longitude.Equals( other.Longitude ) )
        return false;
      if ( !Latitude.Equals( other.Latitude ) )
        return false;
      if ( Altitude is Length && !Altitude.Equals( other.Altitude ) )
        return false;
      if ( CoordinateReferenceSystem is string && !CoordinateReferenceSystem.Equals( other.CoordinateReferenceSystem ) )
        return false;
      if ( Uncertainty is string && !Uncertainty.Equals( other.Uncertainty ) )
        return false;
      return true;
    }

    public bool NearlyEquals( GeoURI other, PlaneAngle angle_tolelance = null, Length length_tolerance = null )
    {
      if ( !Longitude.NormalizedNearlyEqualsTo( other.Longitude, angle_tolelance ) )
        return false;
      if ( !Latitude.NormalizedNearlyEqualsTo( other.Latitude, angle_tolelance ) )
        return false;
      if ( Altitude is Length && !Altitude.NearlyEqualsTo( other.Altitude, length_tolerance ) )
        return false;
      if ( CoordinateReferenceSystem is string && !CoordinateReferenceSystem.Equals( other.CoordinateReferenceSystem ) )
        return false;
      if ( Uncertainty is string && !Uncertainty.Equals( other.Uncertainty ) )
        return false;
      return true;
    }
  }
}
