using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using usagi.Quantity;
using usagi.Quantity.Ratio.Extension;
using usagi.String.Extension;
using static usagi.WPF.ColorSpace.Factory;

namespace usagi.WPF.ColorSpace.Extension
{
  /// <summary>
  /// <see cref="string"/> に色っぽい機能拡張を施す
  /// </summary>
  public static class StringExtetnsion
  {
    /// <summary>
    /// 色のパターンのどれを試すか表現。
    /// </summary>
    [Flags]
    public enum ColorPatternTrial
    {
      /// <summary>
      /// 色名
      /// </summary>
      Name = 0x01
    , /// <summary>
      /// #RGB, #RRGGBB, #ARGB, #AARRGGBB
      /// </summary>
      Hex = 0x02
    , /// <summary>
      /// rgba(r,g,b,a), rgb(r,g,b)
      /// </summary>
      CSS_RGBA = 0x20
    , /// <summary>
      /// hsla(h,s,l,a ), hsl(h,s,l)
      /// </summary>
      CSS_HSLA = 0x80
    , /// <summary>
      /// すべて試す
      /// </summary>
      _All = Name | Hex | CSS_RGBA | CSS_HSLA
    }

    /// <summary>
    /// Color へ変換
    /// </summary>
    /// <param name="s">色っぽい文字列</param>
    /// <param name="t">パースを試みるパターン</param>
    /// <returns>Color</returns>
    public static Color? ToColor
    ( this string s
    , ColorPatternTrial t = ColorPatternTrial._All
    )
    {
      { if ( t.HasFlag( ColorPatternTrial.Hex ) && s.ToColorFromHex() is Color c ) return c; }
      { if ( t.HasFlag( ColorPatternTrial.Name ) && s.ToColorFromName() is Color c ) return c; }

      {
        var ss = _ToColor_Preprocess( s );
        { if ( t.HasFlag( ColorPatternTrial.CSS_RGBA ) && _ToColorFromCSSRGBA( ss ) is Color c ) return c; }
        { if ( t.HasFlag( ColorPatternTrial.CSS_HSLA ) && _ToColorFromCSSHSLA( ss ) is Color c ) return c; }
      }

      return null;
    }

    /// <summary>
    /// #RGB, #RRGGBB, #ARGB, #AARRGGBB パターンをパース
    /// </summary>
    /// <param name="s">パース対象</param>
    /// <returns>色またはパース失敗時は null</returns>
    public static Color? ToColorFromHex( this string s )
    {
      var ss = s.Trim( ' ' );

      if
      ( ss.Length != "#rgb".Length
      && ss.Length != "#argb".Length
      && ss.Length != "#rrggbb".Length
      && ss.Length != "#aarrggbb".Length
      )
        return null;

      if ( ss[ 0 ] != '#' )
        return null;

      try { return (Color)ColorConverter.ConvertFromString( ss ); }
      catch ( System.FormatException ) { }

      return null;
    }

    /// <summary>
    /// 色名をパース
    /// </summary>
    /// <param name="s">パース対象</param>
    /// <returns>色または失敗時は null </returns>
    public static Color? ToColorFromName( this string s )
    {
      if ( s.Length > 0 && s[ 0 ] == '#' )
        return null;

      try { return (Color)ColorConverter.ConvertFromString( s ); }
      catch ( System.FormatException ) { }

      return null;
    }

    /// <summary>
    /// rgba(r,g,b,a), rgb(r,g,b) をパース
    /// </summary>
    /// <param name="s">パース対象</param>
    /// <returns>色または失敗時は null</returns>
    public static Color? ToColorFromCSSRGBA( this string s )
    { return _ToColorFromCSSRGBA( _ToColor_Preprocess( s ) ); }

    /// <summary>
    /// hsla(r,g,b,a), hsl(r,g,b) をパース
    /// </summary>
    /// <param name="s">パース対象</param>
    /// <returns>色または失敗時は null</returns>
    public static Color? ToColorFromCSSHSLA( this string s )
    { return _ToColorFromCSSHSLA( _ToColor_Preprocess( s ) ); }

    /// <summary>
    /// %形式などの文字列から数値をパース
    /// </summary>
    /// <param name="s">パース対象</param>
    /// <returns>数値または失敗時は null</returns>
    public static double? ToQuantity( this string s )
    {
      var ss = s.Trim( ' ' );
      var prefix = 1.0;
      switch ( ss.Last() )
      {
        case '%':
        case '٪':
        case '㌫':
        case '％':
          prefix = 1.0e-2;
          ss = ss.TrimEnd( '%', '٪', '㌫', '％' );
          break;
        case '‰':
          prefix = 1.0e-3;
          ss = ss.TrimEnd( '‰' );
          break;
        case '‱':
          prefix = 1.0e-4;
          ss = ss.TrimEnd( '‱' );
          break;
        case 'm':
          if ( !ss.EndsWith( "ppm" ) )
            break;
          goto ppm;
        case '㏙':
          ppm:
          prefix = 1.0e-6;
          ss = ss.TrimEnd( 'p', 'm', '㏙' );
          break;
        case 'l':
          if ( !ss.EndsWith( "mol" ) )
            break;
          goto mol;
        case '㏖':
          mol:
          prefix = 6.022_140_76e+23;
          ss = ss.TrimEnd( 'm', 'o', 'l', '㏖' );
          break;
        case 'n':
          if ( !ss.EndsWith( "dozen" ) )
            break;
          goto dozen;
        case '㌤':
          dozen:
          prefix = 12;
          ss = ss.TrimEnd( 'd', 'o', 'z', 'e', 'n', '㌤' );
          break;
        case 's':
          if ( ss.EndsWith( "great gross" ) )
          {
            prefix = 12 * 12 * 12;
            ss = ss.Substring( 0, ss.Length - "great gross".Length );
          }
          else if ( ss.EndsWith( "gross" ) )
          {
            prefix = 12 * 12;
            ss = ss.Substring( 0, ss.Length - "gross".Length );
          }
          break;
      }

      ss = ss.Trim( ' ' );

      if ( double.TryParse( ss, out var v ) )
        return prefix * v;

      return null;
    }

    // ここから internal 実装詳細

    internal static string[] _ToColor_Preprocess( string s )
    { return s.Trim( ' ' ).Split( ',' ); }

    internal static PlaneAngle _ToColor_PlaneAngle( string s )
    {
      if ( byte.TryParse( s, out var deg ) )
        return PlaneAngle.FromDegrees( deg );
      return null;
    }

    internal static double? _ToColor_Percent( string s )
    {
      var ss = s.Trim( ' ' );
      if ( ss.Last() == '%' )
      {
        ss = ss.TrimEnd( ' ', '%' );
        if ( double.TryParse( ss, out var v ) )
          return v / 100.0;
      }
      return null;
    }

    internal static byte? _ToColor_ValueOrPercent( string s )
    {
      if ( byte.TryParse( s, out var value ) )
        return value;

      if ( _ToColor_Percent( s ) is var percent )
        return percent?.UNormToByte();

      return null;
    }

    internal static Color? _ToColorFromCSSRGBA( string[] ss )
    {
      while
      ( ( ss.Length == 3 || ss.Length == 4 )
      && ss.First().StartsWith( "rgb(", "rgba(" )
      && ss.Last().EndsWith( ")" )
      )
      {
        var rr = ss[ 0 ].Trim( ' ', 'r', 'g', 'b', 'a', '(' );
        var gg = ss[ 1 ].Trim( ' ' );
        var bb = ss[ 2 ].Trim( ' ', ')' );
        if ( !( _ToColor_ValueOrPercent( rr ) is byte r ) )
          break;
        if ( !( _ToColor_ValueOrPercent( gg ) is byte g ) )
          break;
        if ( !( _ToColor_ValueOrPercent( bb ) is byte b ) )
          break;
        if ( ss.Length == 3 )
          return Color.FromRgb( r, g, b );
        if ( ss.Length == 4 )
        {
          var aa = ss[ 3 ].Trim( ' ', ')' );
          if ( !double.TryParse( aa, out var a ) )
            break;
          return Color.FromArgb( a.UNormToByte(), r, g, b );
        }
      }
      return null;
    }

    internal static Color? _ToColorFromCSSHSLA( string[] ss )
    {
      while
      ( ( ss.Length == 3 || ss.Length == 4 )
      && ss.First().StartsWith( "hsl(", "hsla(" )
      && ss.Last().EndsWith( ")" )
      )
      {
        var h_ = ss[ 0 ].Trim( ' ', 'h', 's', 'l', 'a', '(' );
        var s_ = ss[ 1 ].Trim( ' ' );
        var l_ = ss[ 2 ].Trim( ' ', ')' );
        if ( !( _ToColor_PlaneAngle( h_ ) is PlaneAngle h ) )
          break;
        if ( !( _ToColor_Percent( s_ ) is double s ) )
          break;
        if ( !( _ToColor_Percent( l_ ) is double l ) )
          break;
        if ( ss.Length == 3 )
          return FromHSLA( h, s, l );
        if ( ss.Length == 4 )
        {
          var aa = ss[ 3 ].Trim( ' ', ')' );
          if ( !double.TryParse( aa, out var a ) )
            break;
          return FromHSLA( h, s, l, a );
        }
      }
      return null;
    }
  }
}
