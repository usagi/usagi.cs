using System.IO;
using System.Text;

namespace usagi.InformationEngineering.Extension
{
  /// <summary>
  /// <see cref="MemoryStream"/> 型を機能拡張する何か
  /// </summary>
  static public class MemoryStreamStringExtension
  {
    /// <summary>
    /// string へ変換
    /// </summary>
    /// <param name="s">元ストリーム</param>
    /// <param name="e">エンコーディング; null の場合は <see cref="Encoding.UTF8"/> を使う</param>
    /// <returns>文字列</returns>
    public static string ToString( this MemoryStream s, Encoding e )
    { return ( e ?? Encoding.UTF8 ).GetString( s.ToArray() ); }

    /// <summary>
    /// MemoryStream へ変換
    /// </summary>
    /// <param name="s">元文字列</param>
    /// <param name="e">エンコーディング; null の場合は <see cref="Encoding.UTF8"/> を使う</param>
    /// <returns>s を元にしたメモリーストリーム</returns>
    public static MemoryStream ToMemoryStream( this string s, Encoding e = null )
    { return new MemoryStream( ( e ?? Encoding.UTF8 ).GetBytes( s ) ); }
  }

}
