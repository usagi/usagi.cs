using System;

namespace usagi.Quantity.LengthMathExtension
{
  /// <summary>
  /// Length に System.Math 相当の機能拡張を施す
  /// </summary>
  [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
  internal class NamespaceDoc { }

  /// <summary>
  /// Length への System.Math 相当の機能拡張
  /// </summary>
  public static partial class LengthMathHelper
  {
    /// <summary>
    /// 符号を正に強制します
    /// </summary>
    /// <param name="a">長さ</param>
    /// <returns>確実に正の符号の長さ</returns>
    public static Length Abs( this Length a ) { return Length.From_m( Math.Abs( a._m ) ); }

    /// <summary>
    /// 逆正弦値を cathetus / hypotenuse から計算しますよ
    /// </summary>
    /// <param name="hypotenuse">斜辺 ( this )</param>
    /// <param name="cathetus">隣辺 ( 相手 )</param>
    /// <returns>逆正接による平面角</returns>
    public static PlaneAngle ASin( this Length hypotenuse, Length cathetus ) { return PlaneAngle.FromRadians( Math.Asin( cathetus._m / hypotenuse._m ) ); }

    /// <summary>
    /// 逆余弦値を cathetus / hypotenuse から計算しますよ
    /// </summary>
    /// <param name="hypotenuse">斜辺 ( this )</param>
    /// <param name="cathetus">隣辺 ( 相手 )</param>
    /// <returns>逆余弦による平面角</returns>
    public static PlaneAngle ACos( this Length hypotenuse, Length cathetus ) { return PlaneAngle.FromRadians( Math.Acos( cathetus._m / hypotenuse._m ) ); }

    /// <summary>
    /// 逆正接値を計算しますよ
    /// </summary>
    /// <param name="x">長さ ( this )</param>
    /// <param name="y">長さ ( 相手 )</param>
    /// <returns>逆正接値</returns>
    public static PlaneAngle ATan2( this Length x, Length y ) { return PlaneAngle.FromRadians( Math.Atan2( y._m, x._m ) ); }

    /// <summary>
    /// 符号を抽出しますよ
    /// </summary>
    /// <param name="a">長さ</param>
    /// <returns>符号; -1, 0, +1 の何れか</returns>
    public static int Sign( Length a ) { return Math.Sign( a._m ); }
  }
}