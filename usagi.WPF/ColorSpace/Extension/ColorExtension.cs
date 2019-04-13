using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = System.Windows.Media.Color;
using usagi.Quantity;
using usagi.Quantity.Ratio.Extension;
using usagi.Quantity.Extension;

namespace usagi.WPF.ColorSpace.Extension
{
  /// <summary>
  /// <see cref="Color"/> を機能拡張する。
  /// </summary>
  public static class ColorExtension
  {
    /// <summary>
    /// 色が近似的に等価とみなせるか判定する
    /// </summary>
    /// <param name="a">色その1</param>
    /// <param name="b">色その2</param>
    /// <param name="hue_tolerance">色相の許容範囲</param>
    /// <param name="satulation_tolerance">飽和度の許容範囲</param>
    /// <param name="luminance_tolerance">明るさの許容範囲</param>
    /// <param name="alpha_tolerance">判定結果</param>
    /// <returns>近似的に等価と見做せる場合は true, それ以外は false</returns>
    static public bool NearlyEqualsInHSLA
    ( this Color a, Color b
    , PlaneAngle hue_tolerance = null
    , double satulation_tolerance = 1.0e-2
    , double luminance_tolerance = 1.0e-2
    , double alpha_tolerance = 1.0e-2
    )
    {
      var ( ha, sa, la, aa ) = a.ToHSLA();
      var ( hb, sb, lb, ab ) = b.ToHSLA();
      return
        ha.NormalizedNearlyEquals( hb, hue_tolerance ?? PlaneAngle.Degree )
        && sa.NearlyEquals( sb, satulation_tolerance )
        && la.NearlyEquals( lb, luminance_tolerance )
        && aa.NearlyEquals( aa, alpha_tolerance )
        ;
    }

    /// <summary>
    /// RGBA から HSLA を生成
    /// </summary>
    /// <param name="rgba">RGBA</param>
    /// <returns>HSLA</returns>
    static public
    (PlaneAngle Hue, double Satulation, double Luminance, double Alpha)
      ToHSLA( this ( byte R, byte G, byte B, byte A ) rgba )
    {
      return Color.FromArgb( rgba.A, rgba.R, rgba.G, rgba.B ).ToHSLA();
    }

    /// <summary>
    /// <see cref="Color"/> から HSLA を生成
    /// </summary>
    /// <param name="a">色</param>
    /// <returns>HSLA</returns>
    static public
    ( PlaneAngle Hue, double Satulation, double Luminance, double Alpha )
    ToHSLA( this Color a )
    {
      var r = a.R.ToUNorm();
      var g = a.G.ToUNorm();
      var b = a.B.ToUNorm();

      var min = Calculation.Min( r, g, b );
      var max = Calculation.Max( r, g, b );
      var d = max - min;
      var q = max + min;

      var h = 0.0;
      var s = 0.0;
      var l = ( max + min ) / 2.0f;

      if ( d != 0 )
      {
        s =
          ( l < 0.5 )
            ? d / q
            : d / ( 2.0 - q )
          ;
      }

      if ( r == max )
        h = ( g - b ) / d;
      else if ( g == max )
        h = 2 + ( b - r ) / d;
      else
        h = 4 + ( r - g ) / d;

      return (PlaneAngle.FromTurns( h ), s, l, a.A);
    }
    
  }
}
