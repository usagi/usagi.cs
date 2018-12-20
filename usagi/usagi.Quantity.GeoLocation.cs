using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

/// <summary>
/// 地理上の位置を扱う
/// </summary>
namespace usagi.Quantity.GeoLocation
{
  /// <summary>
  /// PlaneAngle 型の Longitude, Latitude プロパティーを読める
  /// </summary>
  public interface ILonLatGettable
  {
    /// <summary>
    /// 経度を取得
    /// </summary>
    PlaneAngle Longitude { get; }
    /// <summary>
    /// 緯度を取得
    /// </summary>
    PlaneAngle Latitude { get; }
  }

  /// <summary>
  /// PlaneAngle 型の Longitude, Latitude プロパティーを書ける
  /// </summary>
  public interface ILonLatSettable
  {
    /// <summary>
    /// 経度を設定
    /// </summary>
    PlaneAngle Longitude { set; }
    /// <summary>
    /// 緯度を設定
    /// </summary>
    PlaneAngle Latitude { set; }
  }

  /// <summary>
  /// PlaneAngle 型の Longitude, Latitude プロパティーを読み書きできる
  /// </summary>
  public interface ILonLat
    : ILonLatGettable
    , ILonLatSettable
  { }

  /// <summary>
  /// Length 型の標高（高度）プロパティーを取得できる
  /// </summary>
  public interface IAltitudeGettable
  {
    /// <summary>
    /// 標高（高度）を取得
    /// </summary>
    Length Altitude { get; }
  }

  /// <summary>
  /// Length 型の標高（高度）プロパティーを設定できる
  /// </summary>
  public interface IAltitudeSetttable
  {
    /// <summary>
    /// 標高（高度）を設定
    /// </summary>
    Length Altitude { set; }
  }

  /// <summary>
  /// Length 型の標高（高度）プロパティーを読み書きできる
  /// </summary>
  public interface IAltitude
    : IAltitudeGettable
    , IAltitudeSetttable
  { }

  /// <summary>
  /// System.Device.Location.GeoCoordinate 型への変換メソッドを持つ
  /// </summary>
  public interface IToGeoCoordinate
  {
    /// <summary>
    /// System.Device.Location.GeoCoordinate 型へ変換
    /// </summary>
    /// <returns>System.Device.Location.GeoCoordinate 型の位置</returns>
    GeoCoordinate ToGeoCoordinate();
  }

  /// <summary>
  /// System.Device.Location.GeoCoordinate 型からの変換メソッドを持つ
  /// </summary>
  public interface IFromGeoCoordinate
  {
    /// <summary>
    /// System.Device.Location.GeoCoordinate 型からの変換
    /// </summary>
    /// <param name="a">System.Device.Location.GeoCoordinate 型の位置</param>
    void FromGeoCoordinate( GeoCoordinate a );
  }

  /// <summary>
  /// 経緯度
  /// 経度と緯度を平面角オブジェクトでシンプルに持つ
  /// </summary>
  public class LonLat
    : ILonLat
    , IToGeoCoordinate
    , IFromGeoCoordinate
  {
    public PlaneAngle Longitude { get; set; } = PlaneAngle.Zero;
    public PlaneAngle Latitude { get; set; } = PlaneAngle.Zero;

    public LonLat() { }
    public LonLat( PlaneAngle lon, PlaneAngle lat )
    {
      Longitude = lon;
      Latitude = lat;
    }
    public LonLat( GeoCoordinate a )
    { FromGeoCoordinate( a ); }

    virtual public GeoCoordinate ToGeoCoordinate()
    { return new GeoCoordinate( Latitude.InDegrees, Longitude.InDegrees ); }

    virtual public void FromGeoCoordinate( GeoCoordinate a )
    {
      Longitude = PlaneAngle.FromDegrees( a.Longitude );
      Latitude = PlaneAngle.FromDegrees( a.Latitude );
    }
  }

  /// <summary>
  /// 経緯度＋標高
  /// LonLat の派生で長さオブジェクトの標高を追加で持つ
  /// </summary>
  public class LonLatAlt
    : LonLat
    , IAltitude
  {
    public Length Altitude { get; set; } = Length.Zero;

    public LonLatAlt() : base() { }
    public LonLatAlt( PlaneAngle lon, PlaneAngle lat ) : base( lon, lat ) { }
    public LonLatAlt( PlaneAngle lon, PlaneAngle lat, Length alt ) : base( lon, lat )
    { Altitude = alt; }
    public LonLatAlt( GeoCoordinate a )
    { FromGeoCoordinate( a ); }

    override public GeoCoordinate ToGeoCoordinate()
    {
      var r = base.ToGeoCoordinate();
      r.Altitude = Altitude._m;
      return r;
    }

    override public void FromGeoCoordinate( GeoCoordinate a )
    {
      base.FromGeoCoordinate( a );
      Altitude = Length.From_m( a.Altitude );
    }
  }
}
