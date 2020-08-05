using System;
using static usagi.CivilEngineering.Terrain.GSJ.datatilemap.Utility;
using System.Drawing;
using usagi.Quantity.GeoLocation;
using usagi.CivilEngineering.Extension;
using usagi.Quantity;
using usagi.Quantity.Extension;

namespace usagi.CivilEngineering.Terrain.GSI.maps
{
  /// <summary>
  /// DEM の選択肢
  /// </summary>
  /// <seealso href="https://maps.gsi.go.jp/development/hyokochi.html"/>
  [Flags]
  public enum DEMType
  {
    /// <summary>選択なし</summary>
    None = 0
  ,
    /// <summary>10B</summary>
    DEM_10B = 1
  ,
    /// <summary>5A</summary>
    DEM_5A = 2
  ,
    /// <summary>5B</summary>
    DEM_5B = 4
  ,
    /// <summary>5C</summary>
    DEM_5C = 8
  ,
    /// <summary>GM</summary>
    DEM_GM = 16
  ,
    /// <summary>5A+5B</summary>
    DEM_5A_5B = DEM_5A | DEM_5B
  ,
    /// <summary>5A+5B+10B</summary>
    DEM_5A_5B_10B = DEM_5A_5B | DEM_10B
  ,
    /// <summary>5A+5B+10B+GM</summary>
    DEM_5A_5B_10B_GM = DEM_5A_5B_10B | DEM_GM
  ,
    /// <summary>10B+GM</summary>
    DEM_10B_GM = DEM_10B | DEM_GM
  }

  /// <summary>
  /// 国土地理院 地理院地図 の関連機能を提供するユーティリティー
  /// </summary>
  /// <seealso href="https://maps.gsi.go.jp/help/index.html"/>
  /// <seealso href="https://maps.gsi.go.jp/"/>
  public static class Utility
  {
    const string URIPattern = "https://cyberjapandata.gsi.go.jp/xyz/{id}/{z}/{x}/{y}{ext}";
    const string URIPatternBase = "https://cyberjapandata.gsi.go.jp/xyz/";

    const int ArrisLength = 256;

    internal static Color DEMAdditionalInvalidValue = Color.FromArgb( 128, 0, 0 );

    /// <summary>
    /// 「標高タイル」をロード
    /// </summary>
    /// <param name="tile_location">タイル座標</param>
    /// <param name="dem_type">対象とするDEM群</param>
    /// <returns>標高群</returns>
    public static double[,] LoadDEM( TileLocation tile_location, DEMType dem_type = DEMType.DEM_5A_5B_10B )
    {
      if ( tile_location.Z > 15 )
        return null;

      if
      ( tile_location.Z == 15
        && !( dem_type.HasFlag( DEMType.DEM_5A )
            || dem_type.HasFlag( DEMType.DEM_5B )
            )
      )
        return null;

      double[,] r = null;

      const string ext = ".png";
      const double f = 1.0e-2;

      if ( tile_location.Z == 15 )
      {
        if ( dem_type.HasFlag( DEMType.DEM_5A ) )
        {
          const string id = "dem5a_png";
          var uri = new Uri( $"{URIPatternBase}{id}/{tile_location.Z}/{tile_location.X}/{tile_location.Y}{ext}" );

          r = LoadPNGNumberTileS( out var has_invalid_value, uri, f, additional_invalid_values: DEMAdditionalInvalidValue );

          if ( !has_invalid_value )
            return r;
        }

        if ( dem_type.HasFlag( DEMType.DEM_5B ) )
        {
          const string id = "dem5b_png";
          var uri = new Uri( $"{URIPatternBase}{id}/{tile_location.Z}/{tile_location.X}/{tile_location.Y}{ext}" );

          bool has_invalid_value;

          if ( r == null )
            r = LoadPNGNumberTileS( out has_invalid_value, uri, f, additional_invalid_values: DEMAdditionalInvalidValue );
          else
            LoadPNGNumberTileS( ref r, out has_invalid_value, uri, f, additional_invalid_values: DEMAdditionalInvalidValue );

          if ( !has_invalid_value )
            return r;
        }
      }

      if ( dem_type.HasFlag( DEMType.DEM_10B ) )
      {
        const string id = "dem_png";

        // over-z
        if ( tile_location.Z == 15 )
        {
          var zz = 14;
          var xx = tile_location.X >> 1;
          var yy = tile_location.Y >> 1;
          var uri = new Uri( $"{URIPatternBase}{id}/{zz}/{xx}/{yy}{ext}" );

          using ( var i = LoadPNGDataTile( uri ) )
          {
            // trimming
            const int half = ArrisLength >> 1;
            var trim_x0 = ( tile_location.X & 1 ) == 1 ? half : 0;
            var trim_y0 = ( tile_location.Y & 1 ) == 1 ? half : 0;
            using ( var trimmed = i.Clone( new Rectangle( trim_x0, trim_y0, half, half ), i.PixelFormat ) )
            {
              // scaling
              using ( var scaled = new Bitmap( ArrisLength, ArrisLength ) )
              {
                using ( var g = Graphics.FromImage( scaled ) )
                {
                  g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                  g.DrawImage( trimmed, 0, 0, ArrisLength, ArrisLength );
                }

                bool has_invalid_value;

                if ( r == null )
                  r = LoadPNGNumberTileS( out has_invalid_value, scaled, f, additional_invalid_values: DEMAdditionalInvalidValue );
                else
                  LoadPNGNumberTileS( ref r, out has_invalid_value, scaled, f, additional_invalid_values: DEMAdditionalInvalidValue );

                if ( !has_invalid_value )
                  return r;
              }
            }
          }
        }
        else
        {
          var uri = new Uri( $"{URIPatternBase}{id}/{tile_location.Z}/{tile_location.X}/{tile_location.Y}{ext}" );

          r = LoadPNGNumberTileS( out var has_invalid_value, uri, f, additional_invalid_values: DEMAdditionalInvalidValue );

          if ( !has_invalid_value )
            return r;
        }
      }

      if ( dem_type.HasFlag( DEMType.DEM_GM ) )
      {
        const string id = "demgm_png";
        const byte critical_z = 8;

        if ( tile_location.Z > critical_z )
        {
          var dz = tile_location.Z - critical_z;

          var xx = tile_location.X >> dz;
          var yy = tile_location.Y >> dz;
          var uri = new Uri( $"{URIPatternBase}{id}/{critical_z}/{xx}/{yy}{ext}" );

          using ( var i = LoadPNGDataTile( uri ) )
          {
            // trimming
            var scaled_length = ArrisLength >> dz;
            var dx = tile_location.X - ( xx << dz );
            var dy = tile_location.Y - ( yy << dz );
            var trim_x0 = scaled_length * dx;
            var trim_y0 = scaled_length * dy;
            using ( var trimmed = i.Clone( new Rectangle( ( int )trim_x0, ( int )trim_y0, scaled_length, scaled_length ), i.PixelFormat ) )
            {
              // scaling
              using ( var scaled = new Bitmap( ArrisLength, ArrisLength ) )
              {
                using ( var g = Graphics.FromImage( scaled ) )
                {
                  g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                  g.DrawImage( trimmed, 0, 0, ArrisLength, ArrisLength );
                }

                bool has_invalid_value;

                if ( r == null )
                  r = LoadPNGNumberTileS( out has_invalid_value, scaled, f, additional_invalid_values: DEMAdditionalInvalidValue );
                else
                  LoadPNGNumberTileS( ref r, out has_invalid_value, scaled, f, additional_invalid_values: DEMAdditionalInvalidValue );

                if ( !has_invalid_value )
                  return r;
              }
            }
          }
        }
        else
        {
          var uri = new Uri( $"{URIPatternBase}{id}/{tile_location.Z}/{tile_location.X}/{tile_location.Y}{ext}" );

          if ( r == null )
            r = LoadPNGNumberTileS( out var has_invalid_value, uri, f, additional_invalid_values: DEMAdditionalInvalidValue );
          else
            LoadPNGNumberTileS( ref r, out var has_invalid_value, uri, f, additional_invalid_values: DEMAdditionalInvalidValue );
        }
      }

      return r;
    }

    /// <summary>
    /// 中心地（経緯度）と東西軸方向・南北軸方向の距離（長さ次元）を含む矩形領域について
    /// DEMを切り出し・合成して取得する
    /// </summary>
    /// <remarks>
    /// 東西軸方向の臨界地点は赤道から遠い側（北半球なら北端における東西軸）が equatorial_delta を含む範囲で生成する。
    /// </remarks>
    /// <param name="delta">計算により採用された center からの経緯度差を out</param>
    /// <param name="z"></param>
    /// <param name="center"></param>
    /// <param name="equatorial_delta">中心地点から含めたい東西軸方向の距離</param>
    /// <param name="axial_delta">中心地点から含めたい南北軸方向の距離。 null の場合は equatorial_delta と同じ値とみなす</param>
    /// <param name="dem_type">対象とするDEM群</param>
    /// <returns>標高群</returns>
    public static double[,] LoadDEM
    ( out ILonLatSettable delta
    , byte z
    , ILonLatGettable center
    , Length equatorial_delta
    , Length axial_delta = null
    , DEMType dem_type = DEMType.DEM_5A_5B_10B
    )
    {
      axial_delta = axial_delta ?? equatorial_delta;

      // 南北方向の delta 地点へ center を射影した pa を得る
      var pa_angle = center.Latitude >= PlaneAngle.Zero ? PlaneAngle.Zero : PlaneAngle.FromTurns( 0.5 );
      var pa = center.ProjectionTo( axial_delta, pa_angle );

      // 東西方向の delta 地点へ pa を射影した pae を得る
      var pae = pa.ProjectionTo( equatorial_delta, PlaneAngle.FromTurns( 0.25 ) );

      var d = pae - center;

      // out
      delta = d;

      return LoadDEM( z, center, d, dem_type );
    }

    /// <summary>
    /// 中心地（経緯度）と中心地からの範囲（経緯度差）による矩形領域について
    /// DEM を切り出し・合成して取得する
    /// </summary>
    /// <param name="z">Z</param>
    /// <param name="center">中心地</param>
    /// <param name="delta">中心地からの範囲（経緯度差）</param>
    /// <param name="dem_type">対象とするDEM群</param>
    /// <returns>標高群</returns>
    public static double[,] LoadDEM
    ( byte z
    , ILonLatGettable center
    , ILonLatGettable delta
    , DEMType dem_type = DEMType.DEM_5A_5B_10B
    )
    {
      // 緯度軸方向の北端と南端を確定
      var dlatabs = delta.Latitude.Abs();
      var north_angle = ( center.Latitude + dlatabs ).Normalize180();
      var south_angle = ( center.Latitude - dlatabs ).Normalize180();

      // 経度軸方向の西端と東端を確定
      var dlonabs = delta.Longitude.Abs();
      var east_angle = ( center.Longitude + dlonabs ).Normalize360();
      var west_angle = ( center.Longitude - dlonabs ).Normalize360();

      //Console.WriteLine( $"e={east_angle}" );
      //Console.WriteLine( $"w={west_angle}" );
      //Console.WriteLine( $"n={north_angle}" );
      //Console.WriteLine( $"s={south_angle}" );

      // 東端・北端のピクセルを確定
      var north_east_pixel = WebMercator.AngleToPixel( new LonLat( east_angle, north_angle ), z );
      // 西端・南端のピクセルを確定
      var south_west_pixel = WebMercator.AngleToPixel( new LonLat( west_angle, south_angle ), z );

      //Console.WriteLine( $"N-E px = {north_east_pixel}" );
      //Console.WriteLine( $"S-W px = {south_west_pixel}" );

      // 東端・北端のタイルを確定
      var north_east_tile = WebMercator.PixelToTile( north_east_pixel );
      // 西端・南端のタイルを確定
      var south_west_tile = WebMercator.PixelToTile( south_west_pixel );

      //Console.WriteLine( $"N-E tile = {north_east_tile}" );
      //Console.WriteLine( $"S-W tile = {south_west_tile}" );

      // 最終的に必要なピクセル群のX軸サイズ; 区間 [ west ... east ] なのでサイズは +1 
      // west < east
      var target_pixel_size_x = ( int )( north_east_pixel.X - south_west_pixel.X + 1 );
      // 最終的に必要なピクセル群のY軸サイズ; 区間 [ north ... south ] なのでサイズは +1
      // north < south
      var target_pixel_size_y = ( int )( south_west_pixel.Y - north_east_pixel.Y + 1 );

      // 出力用のバッファー
      var r = new double[ target_pixel_size_x, target_pixel_size_y ];

      // 北西から南東へ
      {
        // r 開始地点と data 開始地点のずれを計算
        const int tile_pixel_shift = 8;
        const int data_arris_size = 1 << tile_pixel_shift;
        var dpx = (int)( south_west_tile.X << tile_pixel_shift ) - (int)south_west_pixel.X;
        var dpy = (int)( north_east_tile.Y << tile_pixel_shift ) - (int)north_east_pixel.Y;
        var t = new TileLocation( 0, 0, z );
        // data ごとの r 開始位置を dp だけずらしておく
        var rx_begin = dpx;
        var ry_begin = dpy;
        for
        ( t.Y = north_east_tile.Y
        ; t.Y <= south_west_tile.Y
        ; ++t.Y, ry_begin += data_arris_size, rx_begin = dpx
        )
          for
          ( t.X = south_west_tile.X
          ; t.X <= north_east_tile.X
          ; ++t.X, rx_begin += data_arris_size
          )
          {
            // デコードして
            var data = LoadDEM( t, dem_type );

            //using ( var i = SavePNGNumberTileS( data, 1.0e-2, 0, Color.FromArgb( 255, 128, 0, 0 ) ) )
            //  i.Save( System.IO.Path.Combine( System.Environment.GetFolderPath( System.Environment.SpecialFolder.DesktopDirectory ), $"GK/tmp/gyoe-{t.X}-{t.Y}-{t.Z}.png" ), System.Drawing.Imaging.ImageFormat.Png );

            Func<int, int, double> sampler = ( dx, dy ) => data[ dx, dy ];
            if ( data == null )
              sampler = ( dx, dy ) => double.NaN;

            // r の適切な領域へ data をコピー
            var rx = rx_begin;
            var ry = ry_begin;
            //Console.WriteLine( $"t={t} rx_begin={rx_begin} ry_begin={ry_begin}" );
            for ( var dy = 0; dy < data_arris_size; ++dy, ++ry, rx = rx_begin )
              if ( ry < 0 || ry >= r.GetLength( 1 ) )
                continue;
              else
                for ( var dx = 0; dx < data_arris_size; ++dx, ++rx )
                  if ( rx < 0 || rx >= r.GetLength( 0 ) )
                    continue;
                  else
                  //{
                    r[ rx, ry ] = sampler( dx, dy );
                    //Console.WriteLine( $"rx={rx} ry={ry} dx={dx} dy={dy} value={data[ dx, dy ]}" );
                  //}
          }
      }

      return r;
    }

  }
}
