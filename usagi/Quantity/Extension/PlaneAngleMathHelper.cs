using System;

namespace usagi.Quantity.Extension
{
  /// <summary>
  /// PlaneAngle への System.Math 相当の機能拡張
  /// </summary>
  public static partial class PlaneAngleMathHelper
  {
    /// <summary>
    /// 符号を正に強制します
    /// </summary>
    /// <param name="a">平面角</param>
    /// <returns>確実に正の符号の平面角</returns>
    public static PlaneAngle Abs( this PlaneAngle a ) { return PlaneAngle.FromDegrees( Math.Abs( a._deg ) ); }
    /// <summary>
    /// 正弦値を計算しますよ
    /// </summary>
    /// <param name="a">平面角</param>
    /// <returns>正弦値</returns>
    public static double Sin( this PlaneAngle a ) { return Math.Sin( a._rad ); }
    /// <summary>
    /// 余弦値を計算しますよ
    /// </summary>
    /// <param name="a">平面角</param>
    /// <returns>余弦値</returns>
    public static double Cos( this PlaneAngle a ) { return Math.Cos( a._rad ); }
    /// <summary>
    /// 正接値を計算しますよ
    /// </summary>
    /// <param name="a">平面角</param>
    /// <returns>正接値</returns>
    public static double Tan( this PlaneAngle a ) { return Math.Tan( a._rad ); }

    /// <summary>
    /// 双曲線正弦値を計算しますよ
    /// </summary>
    /// <param name="a">平面角</param>
    /// <returns>双曲線正弦値</returns>
    public static double Sinh( this PlaneAngle a ) { return Math.Sinh( a._rad ); }
    /// <summary>
    /// 双曲線余弦値を計算しますよ
    /// </summary>
    /// <param name="a">平面角</param>
    /// <returns>双曲線余弦値</returns>
    public static double Cosh( this PlaneAngle a ) { return Math.Cosh( a._rad ); }
    /// <summary>
    /// 双曲線正接値を計算しますよ
    /// </summary>
    /// <param name="a">平面角</param>
    /// <returns>双曲線正接値</returns>
    public static double Tanh( this PlaneAngle a ) { return Math.Tanh( a._rad ); }

    /// <summary>
    /// 符号を抽出しますよ
    /// </summary>
    /// <param name="a">平面角</param>
    /// <returns>符号; -1, 0, +1 の何れか</returns>
    public static int Sign( PlaneAngle a ) { return Math.Sign( a._deg ); }
  }
}
