using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = System.Windows.Media.Color;
using usagi.Quantity;
using usagi.Quantity.Ratio.Extension;

namespace usagi.WPF.ColorSpace
{
#if false
  public static class Converter
  {
    static public
    (PlaneAngle Hue, Ratio Satulation, Ratio Luminance, Ratio Alpha)
    RGBAToHSLA( PlaneAngle Hue, Ratio Satulation, Ratio Luminance, Ratio Alpha )
    {
    }

    static public
    ( Ratio R, Ratio G, Rattio B, Ratio, A )
    HSLAToRGBA( PlaneAngle Hue, Ratio Satulation, Ratio Luminance, Ratio Alpha)
    {
      var r = a.R.ToUNormDouble();
      var g = a.G.ToUNormDouble();
      var b = a.B.ToUNormDouble();

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

#endif

  /// <summary>
  /// 色のファクトリー
  /// </summary>
  public static class Factory
  {
    /// <summary>
    /// R:8, G:8, B:8, A:8 から Color を作る
    /// </summary>
    /// <param name="r">赤っぽさ</param>
    /// <param name="g">緑っぽさ</param>
    /// <param name="b">青っぽさ</param>
    /// <param name="a">不透明度</param>
    /// <returns>色</returns>
    static public Color FromRGBA( byte r, byte g, byte b, byte a = byte.MaxValue )
    { return Color.FromArgb( a, r, g, b ); }

    /// <summary>
    /// R:F32, G:F32, B:F32, A:F32 から Color を作る
    /// </summary>
    /// <param name="r">赤っぽさ</param>
    /// <param name="g">緑っぽさ</param>
    /// <param name="b">青っぽさ</param>
    /// <param name="a">不透明度</param>
    /// <returns>色</returns>
    static public Color FromRGBA( float r, float g, float b, float a = 1.0f )
    { return Color.FromArgb( a.UNormToByte(), r.UNormToByte(), g.UNormToByte(), b.UNormToByte() ); }

    /// <summary>
    /// R:F64, G:F64, B:F64, A:F64 から Color を作る
    /// </summary>
    /// <param name="r">赤っぽさ</param>
    /// <param name="g">緑っぽさ</param>
    /// <param name="b">青っぽさ</param>
    /// <param name="a">不透明度</param>
    /// <returns>色</returns>
    static public Color FromRGBA( double r, double g, double b, double a = 1.0f )
    { return Color.FromArgb( a.UNormToByte(), r.UNormToByte(), g.UNormToByte(), b.UNormToByte() ); }

    /// <summary>
    /// HSLA から色をつくる
    /// </summary>
    /// <param name="h_in_degrees">色相 deg</param>
    /// <param name="s">飽和度</param>
    /// <param name="l">明るさ</param>
    /// <param name="a">不透明度</param>
    /// <returns>色</returns>
    static public Color FromHSLA( double h_in_degrees, double s, double l, double a = 1.0 )
    { return FromHSLA( PlaneAngle.FromDegrees( h_in_degrees ), s, l, a ); }

    /// <summary>
    /// HSLA から色をつくる
    /// </summary>
    /// <param name="h">色相</param>
    /// <param name="s">飽和度</param>
    /// <param name="l">明るさ</param>
    /// <param name="a">不透明度</param>
    /// <returns>色　</returns>
    static public Color FromHSLA( PlaneAngle h, double s, double l, double a = 1.0 )
    {
      double get_color_component( double t1, double t2, double t3 )
      {
        if ( t3 < 0.0 )
          t3 += 1.0;
        else if ( t3 > 1.0 )
          t3 -= 1.0;

        if ( t3 < 1.0 / 6.0 )
          return t1 + ( t2 - t1 ) * 6.0 * t3;
        if ( t3 < 0.5 )
          return t2;
        if ( t3 < 2.0 / 3.0 )
          return t1 + ( ( t2 - t1 ) * ( ( 2.0 / 3.0 ) - t3 ) * 6.0 );
        return t1;
      }

      var hv = h.Normalize360() / PlaneAngle.Turn;
      double r = 0, g = 0, b = 0;
      if ( l != 0 )
      {
        if ( s == 0 )
          r = g = b = l;
        else
        {
          double t2 =
            ( l < 0.5 )
              ? l * ( 1.0 + s )
              : l + s - ( l * s )
            ;
          double t1 = 2.0 * l - t2;
          r = get_color_component( t1, t2, hv + 1.0 / 3.0 );
          g = get_color_component( t1, t2, hv );
          b = get_color_component( t1, t2, hv - 1.0 / 3.0 );
        }
      }
      return FromRGBA( r, g, b, a );
    }
  }
}
