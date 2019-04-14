using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static usagi.CivilEngineering.Terrain.GSJ.datatilemap.Utility;
using System.Drawing;

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
    /// <param name="z">Z</param>
    /// <param name="x">X</param>
    /// <param name="y">Y</param>
    /// <param name="dem_type">対象とするDEM群</param>
    /// <returns>標高群</returns>
    public static double[,] LoadDEM( byte z, UInt32 x, UInt32 y, DEMType dem_type = DEMType.DEM_5A_5B_10B )
    {
      if ( z > 15 )
        return null;

      if
      ( z == 15
        && !( dem_type.HasFlag( DEMType.DEM_5A )
            || dem_type.HasFlag( DEMType.DEM_5B )
            )
      )
        return null;

      double[,] r = null;

      const string ext = ".png";
      const double f = 1.0e-2;

      if ( z == 15 )
      {
        if ( dem_type.HasFlag( DEMType.DEM_5A ) )
        {
          const string id = "dem5a_png";
          var uri = new Uri( $"{URIPatternBase}{id}/{z}/{x}/{y}{ext}" );

          r = LoadPNGNumberTileS( out var has_invalid_value, uri, f, additional_invalid_values: DEMAdditionalInvalidValue );

          if ( !has_invalid_value )
            return r;
        }

        if ( dem_type.HasFlag( DEMType.DEM_5B ) )
        {
          const string id = "dem5b_png";
          var uri = new Uri( $"{URIPatternBase}{id}/{z}/{x}/{y}{ext}" );

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
        if ( z == 15 )
        {
          var zz = 14;
          var xx = x >> 1;
          var yy = y >> 1;
          var uri = new Uri( $"{URIPatternBase}{id}/{zz}/{xx}/{yy}{ext}" );

          using ( var i = LoadPNGDataTile( uri ) )
          {
            // trimming
            const int half = ArrisLength >> 1;
            var trim_x0 = ( x & 1 ) == 1 ? half : 0;
            var trim_y0 = ( y & 1 ) == 1 ? half : 0;
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
          var uri = new Uri( $"{URIPatternBase}{id}/{z}/{x}/{y}{ext}" );

          r = LoadPNGNumberTileS( out var has_invalid_value, uri, f, additional_invalid_values: DEMAdditionalInvalidValue );

          if ( !has_invalid_value )
            return r;
        }
      }

      if ( dem_type.HasFlag( DEMType.DEM_GM ) )
      {
        const string id = "demgm_png";
        const byte critical_z = 8;

        if ( z > critical_z )
        {
          var dz = z - critical_z;

          var xx = x >> dz;
          var yy = y >> dz;
          var uri = new Uri( $"{URIPatternBase}{id}/{critical_z}/{xx}/{yy}{ext}" );

          using ( var i = LoadPNGDataTile( uri ) )
          {
            // trimming
            var scaled_length = ArrisLength >> dz;
            var dx = x - ( xx << dz );
            var dy = y - ( yy << dz );
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
          var uri = new Uri( $"{URIPatternBase}{id}/{z}/{x}/{y}{ext}" );

          if ( r == null )
            r = LoadPNGNumberTileS( out var has_invalid_value, uri, f, additional_invalid_values: DEMAdditionalInvalidValue );
          else
            LoadPNGNumberTileS( ref r, out var has_invalid_value, uri, f, additional_invalid_values: DEMAdditionalInvalidValue );
        }
      }

      return r;
    }
  }
}
