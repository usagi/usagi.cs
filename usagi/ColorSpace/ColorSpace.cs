namespace usagi.ColorSpace
{
  /// <summary>
  /// 色空間、色について扱う
  /// </summary>
  [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
  internal class NamespaceDoc { }

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

}
