using System.Device.Location;
using usagi.URI;
using usagi.String.Extension;
using System;

namespace usagi.Quantity.GeoLocation
{
  /// <summary>
  /// 地理上の位置を扱う
  /// </summary>
  [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
  internal class NamespaceDoc { }

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
  /// PlaneAngle 型の Longitude, Latitude プロパティーを読めて
  /// <para/>Length 型の Altitude プロパティーも読める
  /// </summary>
  public interface ILonLatAltGettable
    : ILonLatGettable
    , IAltitudeGettable
  { }

  /// <summary>
  /// PlaneAngle 型の Longitude, Latitude プロパティーを書けて
  /// <para/>Length 型の Altitude プロパティーも書ける
  /// </summary>
  public interface ILonLatAltSettable
    : ILonLatSettable
    , IAltitudeSetttable
  { }

  /// <summary>
  /// PlaneAngle 型の Longitude, Latitude プロパティーを読み書きできて
  /// <para/>Length 型の Altitude プロパティーも読み書きできる
  /// </summary>
  public interface ILonLatAlt
    : ILonLatAltGettable
    , ILonLatAltSettable
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
  /// <para/>経度と緯度を平面角オブジェクトでシンプルに持つ
  /// </summary>
  public class LonLat
    : ILonLat
    , IToGeoCoordinate
    , IFromGeoCoordinate
  {
    /// <summary>
    /// 経度
    /// </summary>
    public PlaneAngle Longitude { get; set; } = PlaneAngle.Zero;
    /// <summary>
    /// 緯度
    /// </summary>
    public PlaneAngle Latitude { get; set; } = PlaneAngle.Zero;

    /// <summary>
    /// Longitude=Latitude=0 で生成
    /// </summary>
    public LonLat() { }
    /// <summary>
    /// 経緯度を指定して生成
    /// </summary>
    /// <param name="lon">経度</param>
    /// <param name="lat">緯度</param>
    public LonLat( PlaneAngle lon, PlaneAngle lat )
    {
      Longitude = lon;
      Latitude = lat;
    }
    /// <summary>
    /// 経緯度を取得可能な何かから生成
    /// </summary>
    /// <param name="lonlat">ILonLatGettable な何か</param>
    /// <see cref="ILonLatGettable"/>
    /// <seealso cref="GeoURI"/>
    /// <remarks>LonLat からのコピーコンストラクターとしても機能する</remarks>
    public LonLat( ILonLatGettable lonlat )
    {
      Longitude = lonlat.Longitude;
      Latitude = lonlat.Latitude;
    }

    /// <summary>
    /// <see cref="GeoCoordinate"/> を生成
    /// </summary>
    /// <returns>GeoCoordinate</returns>
    virtual public GeoCoordinate ToGeoCoordinate()
    { return new GeoCoordinate( Latitude.InDegrees, Longitude.InDegrees ); }

    /// <summary>
    /// <see cref="GeoCoordinate"/> から経緯度を取り込む
    /// </summary>
    /// <param name="a">取り込み元</param>
    virtual public void FromGeoCoordinate( GeoCoordinate a )
    {
      Longitude = PlaneAngle.FromDegrees( a.Longitude );
      Latitude = PlaneAngle.FromDegrees( a.Latitude );
    }

    /// <summary>
    /// 経緯度を degrees 単位の平面角から生成
    /// </summary>
    /// <param name="lon">経度 [deg]</param>
    /// <param name="lat">緯度 [deg]</param>
    /// <returns>経緯度</returns>
    public static LonLat FromDegrees( double lon, double lat )
    {
      return 
        new LonLat
        ( PlaneAngle.FromDegrees( lon )
        , PlaneAngle.FromDegrees( lat )
        );
    }

    /// <summary>
    /// 文字列化
    /// </summary>
    /// <returns>文字列化した経緯度</returns>
    public override string ToString()
    {
      return ToString( 2 );
    }

    /// <summary>
    /// 浮動小数点数の少数部の桁数指定付きの文字列化
    /// </summary>
    /// <param name="digit">小数部の桁数</param>
    /// <returns>文字列</returns>
    public virtual string ToString( int digit )
    {
      var lon_surfix = Longitude._deg >= 0 ? 'E' : 'W';
      var lat_surfix = Longitude._deg >= 0 ? 'N' : 'S';
      return $"{Latitude.ToStringInDMS( $"F{digit}" )} {lat_surfix}, {Longitude.ToStringInDMS( $"F{digit}" )} {lon_surfix}";
    }

    /// <summary>
    /// 一般的な文章に出現しがちな文字列の経緯度表記から生成を試みるファクトリー
    /// 緯度、経度の順にカンマ文字または空白文字を区切りとし、
    /// 緯度の冒頭または末尾に 北緯, 南緯, N, S の何れかがあるか省略（＝北緯）され、
    /// 経度の冒頭または末尾に 東経, 西経, E, W の何れかがあるか省略（＝東経）され、
    /// 緯度と経度の角度値が何れも平面角型でパース可能な文字列に対して期待動作する。
    /// <para/>lonlat 例1: <code>"43° 3′ 43.5″ N, 141° 21′ 15.8″ E"</code>
    /// <para/>lonlat 例2: <code>"北緯43度3分43.5秒 東経141度21分15.8秒"</code>
    /// </summary>
    /// <param name="lonlat">
    /// 緯度、経度の順にカンマ文字または空白文字を区切りとし、
    /// 緯度の冒頭または末尾に 北緯, 南緯, N, S の何れかがあるか省略（＝北緯）され、
    /// 経度の冒頭または末尾に 東経, 西経, E, W の何れかがあるか省略（＝東経）され、
    /// 緯度と経度の角度値が何れも平面角型でパース可能な文字列。
    /// </param>
    /// <returns>パースに成功した場合は LonLat インスタンス、失敗した場合は null</returns>
    /// <example>
    /// <code>
    /// // ありがちなパターン
    /// var a = LonLat.Parse( "43° 3′ 43.5″ N, 141° 21′ 15.8″ E" );
    /// var b = LonLat.Parse( "北緯43度3分43.5秒 東経141度21分15.8秒" );
    /// // 単位が不明で実数が並んでいるだけの場合は deg 単位としてパースを試みます
    /// var c = LonLat.Parse( "43.062083, 141.354389" );
    /// var d = LonLat.Parse( "43.062083 141.354389" );
    /// var e = LonLat.Parse( "N 43.062083, E 141.354389" );
    /// // GeoURI 文字列からもパース可能
    /// var f = LonLat.Parse( "geo:43.062083,141.354389" );
    /// // 使いみちはさておき実装都合 PlaneAngle がパース可能な単位はパースに成功する
    /// var g = LonLat.Parse( "0.751575131115 rad , 2.467099500189 rad" );
    /// var h = LonLat.Parse( "0.11961689722τ , 0.39265108055τ" );
    /// </code>
    /// </example>
    public static LonLat Parse( string lonlat )
    {
      if ( lonlat.StartsWith( "geo:" ) )
        try { return new LonLat( new GeoURI( lonlat ) ); }
        catch { }

      string lon_str = "";
      string lat_str = "";

      if ( lonlat.Split( ',' ) is string[] csc && csc.Length == 2 )
      {
        lon_str = csc[ 1 ].Trim( ' ', '経', '緯' );
        lat_str = csc[ 0 ].Trim( ' ', '経', '緯' );
      }
      else if ( lonlat.Split( ' ' ) is string[] css && css.Length == 2 )
      {
        lon_str = css[ 1 ].Trim( '経', '緯' );
        lat_str = css[ 0 ].Trim( '経', '緯' );
      }
      else
        return null;

      if ( lon_str.StartsOrEndsWith( "W", "西" ) )
        lon_str = $"-{lon_str.Trim( 'W', '西', '経', ' ' )}";
      else
        lon_str = lon_str.Trim( 'E', '東', '経', ' ' );

      if ( lat_str.StartsOrEndsWith( "S", "南" ) )
        lat_str = $"-{lat_str.Trim( 'S', '南', '緯', ' ' )}";
      else
        lat_str = lat_str.Trim( 'N', '北', '緯', ' ' );

      return
        ( PlaneAngle.Parse( lon_str, true ) is PlaneAngle lon 
        && PlaneAngle.Parse( lat_str, true ) is PlaneAngle lat
        ) ? new LonLat( lon, lat )
          : null
        ;
    }

    /// <summary>
    /// 経緯度の足し算
    /// </summary>
    /// <param name="a">経緯度</param>
    /// <param name="b">経緯度っぽい何か</param>
    /// <returns>足し合わせた経緯度</returns>
    static public LonLat operator +( LonLat a, ILonLatGettable b )
    {
      return new LonLat( a.Longitude + b.Longitude, a.Latitude + b.Latitude );
    }

    /// <summary>
    /// 経緯度の引き算
    /// </summary>
    /// <param name="a">元の経緯度</param>
    /// <param name="b">引く経緯度</param>
    /// <returns>引いた経緯度</returns>
    static public LonLat operator-( LonLat a, ILonLatGettable b )
    {
      return new LonLat( a.Longitude - b.Longitude, a.Latitude - b.Latitude );
    }

    /// <summary>
    /// 経緯度間の距離を平面角で計算
    /// <para/>計算はまあまあ早いが地球のような楕円体のフラッディングレートは考慮しないのでかなり大雑把。
    /// </summary>
    /// <remarks>
    /// 必要なら <see cref="usagi.CivilEngineering.Extension.LonLatDistanceExtension.DistanceTo(ILonLatGettable, ILonLatGettable, CivilEngineering.Extension.LonLatDistanceExtension.LonLatDistanceAlgorithm, CivilEngineering.Planet.IGeometricalSpecificationGettable)"/> を使うと良い
    /// </remarks>
    /// <param name="b">比較対象</param>
    /// <returns>平面角単位での距離</returns>
    public PlaneAngle DistanceToPlaneAngle( ILonLatGettable b )
    {
      var d = this - b;
      var xx = d.Longitude._deg * d.Longitude._deg;
      var yy = d.Latitude._deg * d.Latitude._deg;
      return PlaneAngle.FromDegrees( Math.Sqrt( xx + yy ) );
    }

    /// <summary>
    /// 平面角次元の距離が許容範囲以内で近似的に等価と未為せるか判定
    /// </summary>
    /// <param name="x">判定対象</param>
    /// <param name="tolerance">許容範囲</param>
    /// <returns>近似的に等価と未為せる場合は true</returns>
    /// <remarks>
    /// 必要なら <see cref="usagi.CivilEngineering.Extension.LonLatDistanceExtension.DistanceTo(ILonLatGettable, ILonLatGettable, CivilEngineering.Extension.LonLatDistanceExtension.LonLatDistanceAlgorithm, CivilEngineering.Planet.IGeometricalSpecificationGettable)"/> を使うと良い
    /// </remarks>
    public bool NearlyEqualsTo
    ( ILonLatGettable x
    , PlaneAngle tolerance = null
    )
    {
      return DistanceToPlaneAngle( x ) < PlaneAngle.Second;
    }

    /// <summary>
    /// 平面角次元の距離が経度軸、緯度軸それぞれで許容範囲以内で近似的に等価と未為せるか判定
    /// </summary>
    /// <param name="x">判定対象</param>
    /// <param name="lon_tolerance">経度軸の許容範囲; null の場合は 1″</param>
    /// <param name="lat_tolerance">緯度軸の許容範囲; null の場合は 1″</param>
    /// <returns>近似的に等価と未為せる場合は true</returns>
    /// <remarks>
    /// 必要なら <see cref="usagi.CivilEngineering.Extension.LonLatDistanceExtension.DistanceTo(ILonLatGettable, ILonLatGettable, CivilEngineering.Extension.LonLatDistanceExtension.LonLatDistanceAlgorithm, CivilEngineering.Planet.IGeometricalSpecificationGettable)"/> を使うと良い
    /// </remarks>
    public bool
    NearlyEqualsTo
    ( ILonLatGettable x
    , PlaneAngle lon_tolerance
    , PlaneAngle lat_tolerance
    )
    {
      return
        Longitude.NearlyEquals( x.Longitude, lon_tolerance ?? PlaneAngle.Second )
        && Latitude.NearlyEquals( x.Latitude, lat_tolerance ?? PlaneAngle.Second )
        ;
    }

  }

  /// <summary>
  /// 経緯度＋標高
  /// <para/>LonLat の派生で長さオブジェクトの標高を追加で持つ
  /// </summary>
  public class LonLatAlt
    : LonLat
    , ILonLatAlt
  {
    /// <summary>
    /// 標高（高度）
    /// </summary>
    public Length Altitude { get; set; } = Length.Zero;

    /// <summary>
    /// 0 値の経緯度標高を生成
    /// </summary>
    public LonLatAlt() : base() { }
    /// <summary>
    /// 経緯度を基に Altitude=0 で生成
    /// </summary>
    /// <param name="lon">経度</param>
    /// <param name="lat">緯度</param>
    public LonLatAlt( PlaneAngle lon, PlaneAngle lat ) : base( lon, lat ) { }
    /// <summary>
    /// 経緯度、標高を基に生成
    /// </summary>
    /// <param name="lon">経度</param>
    /// <param name="lat">緯度</param>
    /// <param name="alt">標高</param>
    public LonLatAlt( PlaneAngle lon, PlaneAngle lat, Length alt ) : base( lon, lat )
    { Altitude = alt; }
    /// <summary>
    /// 経緯度取得可能インターフェースを実装する何かから生成
    /// </summary>
    /// <param name="lonlat">経緯度インターフェースを実装する何か</param>
    public LonLatAlt( ILonLatGettable lonlat ) : base( lonlat ) { }
    /// <summary>
    /// 経緯度取得可能インターフェースを実装する何かと標高取得可能インターフェースを実装する何かから生成
    /// </summary>
    /// <param name="lonlat">経緯度取得可能インターフェースを実装する何か</param>
    /// <param name="a">標高取得可能インターフェースを実装する何か</param>
    public LonLatAlt( ILonLatGettable lonlat, IAltitudeGettable a )
      : base( lonlat )
    { Altitude = a.Altitude; }
    /// <summary>
    /// 経緯度標高取得可能インターフェースを実装する何かから生成
    /// </summary>
    /// <param name="lonlatalt">経緯度標高取得可能インターフェースを実装する何か</param>
    public LonLatAlt( ILonLatAltGettable lonlatalt )
      : this( lonlatalt, lonlatalt )
    { }
    /// <summary>
    /// <see cref="GeoCoordinate"/> を元に生成
    /// </summary>
    /// <param name="a">元</param>
    public LonLatAlt( GeoCoordinate a )
    { FromGeoCoordinate( a ); }

    /// <summary>
    /// <see cref="GeoCoordinate"/> を生成
    /// </summary>
    /// <returns>生成された <see cref="GeoCoordinate"/></returns>
    override public GeoCoordinate ToGeoCoordinate()
    {
      var r = base.ToGeoCoordinate();
      r.Altitude = Altitude._m;
      return r;
    }

    /// <summary>
    /// <see cref="GeoCoordinate"/> から値を取り込む
    /// </summary>
    /// <param name="a">取り込み元</param>
    override public void FromGeoCoordinate( GeoCoordinate a )
    {
      base.FromGeoCoordinate( a );
      Altitude = Length.From_m( a.Altitude );
    }

    /// <summary>
    /// 文字列化
    /// </summary>
    /// <returns>文字列化した経緯度標高</returns>
    public override string ToString()
    {
      return $"{( this as LonLat ).ToString()}, {Altitude.ToStringInMeters()}";
    }
  }
}
