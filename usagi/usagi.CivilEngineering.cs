using System;

namespace usagi.CivilEngineering
{
  /// <summary>
  /// 土木っぽい何か
  /// </summary>
  [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
  internal class NamespaceDoc { }

  /// <summary>
  /// ピクセル座標系の位置
  /// </summary>
  public class PixelLocation
  {
    /// <summary>
    /// ピクセル X 座標
    /// </summary>
    public UInt32 X { get; set; } = 0;
    /// <summary>
    /// ピクセル Y 座標
    /// </summary>
    public UInt32 Y { get; set; } = 0;
    /// <summary>
    /// Level of Detail ( LOD; or Zoom Level )
    /// X, Y 座標の空間の大きさを定義する Z 値（この値は厳密には座標ではない）
    /// </summary>
    public byte Z { get; set; } = 0;
    /// <summary>
    /// X = Y = Z = 0 で生成
    /// </summary>
    public PixelLocation() { }
    /// <summary>
    /// X, Y, Z 値を指定して生成
    /// </summary>
    /// <param name="x">X 座標</param>
    /// <param name="y">Y 座標</param>
    /// <param name="z">Z 値</param>
    public PixelLocation( UInt32 x, UInt32 y, byte z = 0 )
    {
      X = x;
      Y = y;
      Z = z;
    }

    /// <summary>
    /// 文字列化
    /// </summary>
    /// <returns>文字列</returns>
    public override string ToString()
    {
      return $"PixelLocation{{ X:{X}, Y:{Y}, Z:{Z} }}";
    }

    /// <summary>
    /// 等価な位置を保持するか判定
    /// </summary>
    /// <param name="obj">比較対象</param>
    /// <returns>等価な位置を保持していれば true</returns>
    public override bool Equals( object obj )
    {
      if ( obj is TileLocation t )
        return X == t.X && Y == t.Y && Z == t.Z;
      return false;
    }

    /// <summary>
    /// ハッシュ値を計算
    /// </summary>
    /// <returns>ハッシュ値</returns>
    public override int GetHashCode()
    {
      return (X, Y, Z).GetHashCode();
    }
  }

  /// <summary>
  /// タイル座標系の位置
  /// </summary>
  public class TileLocation
  {
    /// <summary>
    /// タイル X 座標
    /// </summary>
    public UInt32 X { get; set; } = 0;
    /// <summary>
    /// タイル Y 座標
    /// </summary>
    public UInt32 Y { get; set; } = 0;
    /// <summary>
    /// Level of Detail ( LOD; or Zoom Level )
    /// X, Y 座標の空間の大きさを定義する Z 値（この値は厳密には座標ではない）
    /// </summary>
    public byte Z { get; set; } = 0;
    /// <summary>
    /// X=Y=Z=0 で生成
    /// </summary>
    public TileLocation() { }
    /// <summary>
    /// X, Y, Z 値を指定して生成
    /// </summary>
    /// <param name="x">X 座標</param>
    /// <param name="y">Y 座標</param>
    /// <param name="z">Z 値</param>
    public TileLocation( UInt32 x, UInt32 y, byte z = 0 )
    {
      X = x;
      Y = y;
      Z = z;
    }

    /// <summary>
    /// 文字列化
    /// </summary>
    /// <returns>文字列</returns>
    public override string ToString()
    {
      return $"TileLocation{{ X:{X}, Y:{Y}, Z:{Z} }}";
    }

    /// <summary>
    /// 等価な位置を保持するか判定
    /// </summary>
    /// <param name="obj">比較対象</param>
    /// <returns>等価な位置を保持していれば true</returns>
    public override bool Equals( object obj )
    {
      if ( obj is TileLocation t )
        return X == t.X && Y == t.Y && Z == t.Z;
      return false;
    }

    /// <summary>
    /// ハッシュ値を計算
    /// </summary>
    /// <returns>ハッシュ値</returns>
    public override int GetHashCode()
    {
      return (X, Y, Z).GetHashCode();
    }
  }
}
