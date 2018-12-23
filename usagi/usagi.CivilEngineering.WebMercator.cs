using usagi.Quantity;
using usagi.Quantity.GeoLocation;
using System;

namespace usagi.CivilEngineering
{
  /// <summary>
  /// WebMercator な機能群
  /// </summary>
  /// <seealso href="https://en.wikipedia.org/wiki/Web_Mercator_projection"/>
  static public class WebMercator
  {
    /// <summary>
    /// WebMercator における臨界緯度（限界緯度）
    /// </summary>
    static public PlaneAngle CriticalLatitude
    { get; private set; } = PlaneAngle.FromDegrees( 85.051_128_78 );

    /// <summary>
    /// 任意の経緯度を WebMercator で表現可能な適当な経緯度へ正規化する
    /// 緯度が90°を超える場合は経度は必要に応じて反転され、緯度も反転後の経度に合わせて正規化される。
    /// 正規化後の緯度は ± <see cref="CriticalLatitude"/> へ丸められる
    /// </summary>
    /// <param name="a">任意の経緯度</param>
    /// <returns>正規化された経緯度</returns>
    static public LonLat NormalizeWebMercator( LonLat a )
    {
      PlaneAngle lon;
      var lat = a.Latitude.Normalize180();
      if ( Math.Abs( lat._deg ) < 90.0 )
      {
        lon = a.Longitude.Normalize180();
        lat = Calculation.Clamp( lat, -CriticalLatitude, +CriticalLatitude );
      }
      else
      {
        lon = ( a.Longitude + PlaneAngle.FromDegrees( 180.0 ) ).Normalize180();
        lat = ( PlaneAngle.FromDegrees( Math.Sign( lat._deg ) * 180.0 ) ) - lat;
      }
      return new LonLat( lon, lat );
    }

    /// <summary>
    /// LOD=z におけるピクセル空間の次元の広さを計算
    /// </summary>
    /// <param name="z">Level of Detail ( LOD; or Zoom Level )</param>
    /// <param name="tile_size">タイル1枚あたりの次元の広さ</param>
    /// <returns>LOD=z におけるピクセル空間の広さ</returns>
    static public UInt32 MapSize( byte z, UInt32 tile_size = 256 )
    {
      return tile_size << z;
    }

    /// <summary>
    /// 経緯度 -> ピクセル座標系の位置
    /// </summary>
    /// <param name="lon">経度</param>
    /// <param name="lat">緯度</param>
    /// <param name="z">Level of Detail ( LOD; or Zoom Level )</param>
    /// <returns>ピクセル座標系の位置</returns>
    static public PixelLocation AngleToPixel( PlaneAngle lon, PlaneAngle lat, byte z )
    {
      return AngleToPixel( new LonLat( lon, lat ), z );
    }

    /// <summary>
    /// 経緯度 -> ピクセル座標系の位置
    /// </summary>
    /// <param name="a">経緯度</param>
    /// <param name="z">Level of Detail ( LOD; or Zoom Level )</param>
    /// <returns>ピクセル座標系の位置</returns>
    static public PixelLocation AngleToPixel( LonLat a, byte z )
    {
      var aa = NormalizeWebMercator( a );

      var x = ( aa.Longitude._deg + 180 ) / 360;
      var sin_lat = Math.Sin( aa.Latitude._rad );
      var y = 0.5 - Math.Log( ( 1 + sin_lat ) / ( 1 - sin_lat ) ) / ( 4 * Math.PI );

      var s = MapSize( z );

      var rx = Calculation.Clamp<UInt32>( (UInt32)( x * s + 0.5 ), 0, s - 1 );
      var ry = Calculation.Clamp<UInt32>( (UInt32)( y * s + 0.5 ), 0, s - 1 );

      return new PixelLocation( rx, ry, z );
    }

    /// <summary>
    /// ピクセル座標系の位置 -> 所属するタイル座標系の位置
    /// </summary>
    /// <param name="x">ピクセル X 座標</param>
    /// <param name="y">ピクセル Y 座標</param>
    /// <param name="z">Level of Detail ( LOD; or Zoom Level )</param>
    /// <param name="tile_size">タイルの次元あたりの大きさ</param>
    /// <returns>所属するタイル座標系の位置</returns>
    static public TileLocation PixelToTile( UInt32 x, UInt32 y, byte z, UInt32 tile_size = 256 )
    {
      return PixelToTile( new PixelLocation( x, y, z ), tile_size );
    }

    /// <summary>
    /// ピクセル座標系の位置 -> 所属するタイル座標系の位置
    /// </summary>
    /// <param name="p">ピクセル座標系の位置</param>
    /// <param name="tile_size">タイルの次元あたりの大きさ</param>
    /// <returns>所属するタイル座標系の位置</returns>
    static public TileLocation PixelToTile( PixelLocation p, UInt32 tile_size = 256 )
    {
      return new TileLocation( p.X / tile_size, p.Y / tile_size, p.Z );
    }

    /// <summary>
    /// 経緯度 -> 所属するタイル座標系の位置
    /// </summary>
    /// <param name="lon">経度</param>
    /// <param name="lat">緯度</param>
    /// <param name="z">Level of Detail ( LOD; or Zoom Level )</param>
    /// <returns>所属するタイル座標系の位置</returns>
    static public TileLocation AngleToTile( PlaneAngle lon, PlaneAngle lat, byte z )
    {
      return AngleToTile( new LonLat( lon, lat ), z );
    }

    /// <summary>
    /// 経緯度 -> 所属するタイル座標系の位置
    /// </summary>
    /// <param name="a">経緯度</param>
    /// <param name="z">Level of Detail ( LOD; or Zoom Level )</param>
    /// <returns>所属するタイル座標系の位置</returns>
    static public TileLocation AngleToTile( LonLat a, byte z )
    {
      return PixelToTile( AngleToPixel( a, z ) );
    }
  }
}