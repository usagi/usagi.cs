using System.Linq;
using System.IO;

namespace usagi.FileSystem
{
  /// <summary>
  /// ユーティリティー
  /// </summary>
  public static class Utility
  {
    /// <summary>
    /// パスに使用不能な文字があったら置き換えまたは削除する
    /// </summary>
    /// <param name="path">きたない可能性のあるパス</param>
    /// <param name="replacement">置き換え先文字。 null またはパスに使用できない文字が指定された場合は置き換えではなく削除動作。</param>
    /// <returns>きれいになった文字列</returns>
    public static string SanitizePath( string path, char? replacement = null )
    {
      var ics = Path.GetInvalidFileNameChars();

      // new string を string.Concat にしてはいけない。
      // LINQ の型名が出てくる処理系があるようだ。

      // replace
      if ( replacement.HasValue )
      {
        if ( ics.Contains( replacement.Value ) )
          goto REMOVE;

        return
          new string
          ( ( from _
              in path
              select ics.Contains( _ ) ? replacement.Value : _
            ).ToArray()
          );
      }

      REMOVE:

      // remove
      return 
        new string
        ( ( from _ 
            in path
            where !ics.Contains(_)
            select _
          ).ToArray()
        );
    }
  }
}
