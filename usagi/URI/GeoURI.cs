using System;
using System.Device.Location;
using System.Text.RegularExpressions;
using usagi.Quantity;
using usagi.Quantity.GeoLocation;

namespace usagi.URI
{
  /// <summary>
  /// RFC5870 GeoURI を扱う型
  /// <para/>例: href='geo:48.198634,16.371648;crs=wgs84;u=40'
  /// </summary>
  /// <remarks>
  /// pattern 1: geo:%lat%,%lon%;u=%unc%
  /// <para/>pattern 2: geo:%lat%,%lon%,%alt%;u=%unc%
  /// <para/>pattern 3: geo:%lat%,%lon%,%alt%;crs=%crs%;u=%unc%
  /// <para/>  %lat% is a Latitude
  /// <para/>  %lon% is a Longitude
  /// <para/>  %alt% is an Altitude ( optional )
  /// <para/>  %unc% is an Uncertainty Parameter ( optional )
  /// <para/>  %crs% is a Coordinate Reference System ( optional )
  /// <para/>なお、 <see cref="Uri"/> から派生させたかったが . 文字を含まない Host の検出で例外を出すため関わらない事にした。
  /// </remarks>
  /// <seealso href="https://tools.ietf.org/rfc/rfc5870"/>
  public class GeoURI
    : ILonLatGettable
    , IAltitudeGettable
    , IToGeoCoordinate
    , IEquatable<GeoURI>
  {
    /// <summary>GeoURI固有の何らかの例外</summary>
    public abstract class GeoURIException: Exception { }
    /// <summary>Scheme が geo じゃないよ例外</summary>
    public class SchemeIsNotGeoURIException: GeoURIException { }
    /// <summary>GeoURI として認識できない場合に飛ばす例外</summary>
    public class GeoURIPatternIsNotMatchedException: GeoURIException { }
    /// <summary>経度の認識に失敗したら飛ぶ例外</summary>
    public class LongitudeParseFailedException: GeoURIException { }
    /// <summary>緯度の認識に失敗したら飛ぶ例外</summary>
    public class LatitudeParseFailedException: GeoURIException { }
    /// <summary>高度の認識に失敗したら飛ぶ例外</summary>
    public class AltitudeParseFailedException: GeoURIException { }

    /// <summary>
    /// GeoURI の Scheme
    /// </summary>
    public static readonly string UriSchemeGeo = "geo";

    /// <summary>
    /// GeoURI を解析可能な正規表現パターン
    /// </summary>
    public const string RegexPattern = @"(?<scheme>geo):(?<lat>-?[\d.]+),(?<lon>-?[\d.]+)(?:,(?<alt>-?[\d.]+))?(?:(?:;crs=(?<crs>[^;]+))|(?:;u=(?<u>[^;]+)))*";
    /// <summary>
    /// GeoURI を解析可能な正規表現
    /// </summary>
    public static readonly Regex Regex = new Regex( RegexPattern, RegexOptions.IgnoreCase );

    /// <summary>
    /// 経度
    /// </summary>
    public PlaneAngle Longitude { get; private set; }
    /// <summary>
    /// 緯度
    /// </summary>
    public PlaneAngle Latitude { get; private set; }
    /// <summary>
    /// 標高（高度）
    /// デフォルト null
    /// </summary>
    public Length Altitude { get; private set; } = null;
    /// <summary>
    /// GeoURI の u (Uncertainty; 不確実性) パラメーター
    /// <para/>デフォルト null
    /// </summary>
    /// <remarks>
    /// つまるところ何かしらシステムなどに応じてユーザー定義されたパラメーターを扱いたい場合のそれ
    /// </remarks>
    public string Uncertainty { get; private set; } = null;
    /// <summary>
    /// 測地系を表す文字列
    /// <para/>デフォルト null
    /// </summary>
    public string CoordinateReferenceSystem { get; private set; } = null;
    /// <summary>
    /// URI の Scheme
    /// </summary>
    public string Scheme { get { return UriSchemeGeo; } }
    /// <summary>
    /// 与えられた元の URI 文字列
    /// </summary>
    public string OriginalString { get; private set; }

    /// <summary>
    /// 指定可能な全てのパラメーターを元に生成
    /// </summary>
    /// <param name="lon">経度</param>
    /// <param name="lat">緯度</param>
    /// <param name="alt">標高（高度）; 省略時 null</param>
    /// <param name="crs">測地系; 省略時 null</param>
    /// <param name="u">不確実性パラメーター値; 省略時 null</param>
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
    /// <summary>
    /// 経緯度を元に生成
    /// </summary>
    /// <param name="a">経緯度</param>
    /// <param name="crs">測地系; 省略時 null</param>
    /// <param name="u">不確実性パラメーター値; 省略時 null</param>
    public GeoURI( LonLat a, string crs = null, string u = null )
      : this( a.Longitude, a.Latitude, null, crs, u )
    { }
    /// <summary>
    /// 経緯度高度を元に生成
    /// </summary>
    /// <param name="a">経緯度高度</param>
    /// <param name="crs">測地系; 省略時 null</param>
    /// <param name="u">不確実性パラメーター値; 省略時 null</param>
    public GeoURI( LonLatAlt a, string crs = null, string u = null )
      : this( a.Longitude, a.Latitude, a.Altitude, crs, u )
    { }
    /// <summary>
    /// URI を元に生成
    /// </summary>
    /// <remarks>
    /// このコンストラクターを使用する場合、 <see cref="Uri"/> は GeoURI を完全には扱えない事に留意する必要があるかもしれない
    /// </remarks>
    /// <param name="uri">URI</param>
    public GeoURI( Uri uri )
      : this( uri.OriginalString )
    { }
    /// <summary>
    /// GeoURI が期待される任意の文字列を元に生成
    /// </summary>
    /// <param name="str">任意の文字列</param>
    public GeoURI( string str )
    {
      var m = Regex.Match( str );

      if ( ! m.Groups[ "scheme" ].Success )
        throw new SchemeIsNotGeoURIException();

      if ( m is Match )
      {
        // lon
        {
          if ( !m.Groups[ "lon" ].Success || !double.TryParse( m.Groups[ "lon" ].Value, out double buffer ) )
            throw new LongitudeParseFailedException();
          Longitude = PlaneAngle.FromDegrees( buffer );
        }
        // lat
        {
          if ( !m.Groups[ "lat" ].Success || !double.TryParse( m.Groups[ "lat" ].Value, out double buffer ) )
            throw new LatitudeParseFailedException();
          Latitude = PlaneAngle.FromDegrees( buffer );
          NormalizeLonLat();
        }
        // alt
        if ( m.Groups[ "alt" ].Success )
        {
          if ( !double.TryParse( m.Groups[ "lat" ].Value, out double buffer ) )
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

    /// <summary>
    /// <see cref="GeoCoordinate"/> を生成
    /// </summary>
    /// <returns><see cref="GeoCoordinate"/> なインスタンス</returns>
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

    /// <summary>
    /// 文字列化
    /// </summary>
    /// <remarks>
    /// OriginalString に等しい結果が得られる
    /// </remarks>
    /// <returns>文字列の GeoURI </returns>
    public override string ToString()
    { return OriginalString; }

    /// <summary>
    /// 経度、緯度、標高、座標系、不確実性パラメーターが完全に一致するか比較する
    /// </summary>
    /// <param name="other">比較対象</param>
    /// <returns>一致する場合は true</returns>
    /// <remarks>
    /// 平面角の内部実装は浮動小数点数型なのでよほど意図しない限り完全一致はまずしない。
    /// <para/>必要に応じて <see cref="NearlyEquals(GeoURI, PlaneAngle, Length)"/> を使うとよい。
    /// </remarks>
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

    /// <summary>
    /// 経度、緯度、高度が許容範囲内で近似的に等価かつ測地系と不確実性パラメーターが完全に一致するか判定
    /// </summary>
    /// <param name="other">比較対象</param>
    /// <param name="angle_tolelance">平面角の許容範囲</param>
    /// <param name="length_tolerance">長さの許容範囲</param>
    /// <returns>一致する場合は true</returns>
    public bool NearlyEquals( GeoURI other, PlaneAngle angle_tolelance = null, Length length_tolerance = null )
    {
      if ( !Longitude.NormalizedNearlyEquals( other.Longitude, angle_tolelance ) )
        return false;
      if ( !Latitude.NormalizedNearlyEquals( other.Latitude, angle_tolelance ) )
        return false;
      if ( Altitude is Length && !Altitude.NearlyEquals( other.Altitude, length_tolerance ) )
        return false;
      if ( CoordinateReferenceSystem is string && !CoordinateReferenceSystem.Equals( other.CoordinateReferenceSystem ) )
        return false;
      if ( Uncertainty is string && !Uncertainty.Equals( other.Uncertainty ) )
        return false;
      return true;
    }
  }
}
