using System.IO;
using System.Text;

namespace usagi.Extension
{
  /// <summary>
  /// <see cref="MemoryStream"/> 型を機能拡張する何か
  /// </summary>
  static public class MemoryStreamHelper
  {
    /// <summary>
    /// string へ変換
    /// </summary>
    /// <param name="s">元ストリーム</param>
    /// <param name="e">エンコーディング; null の場合は <see cref="Encoding.UTF8"/> を使う</param>
    /// <returns>文字列</returns>
    public static string ToString( this MemoryStream s, Encoding e )
    { return ( e ?? Encoding.UTF8 ).GetString( s.ToArray() ); }
  }
}
