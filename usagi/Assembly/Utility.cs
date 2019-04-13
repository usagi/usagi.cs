using System;
using System.Reflection;
using SRA = System.Reflection.Assembly;

namespace usagi.Assembly
{
  /// <summary>
  /// .net アッセンブリーを扱う便利を良くするユーティリティー
  /// </summary>
  public class Utility
  {
    /// <summary>
    /// ビルドに応じて D, R を返す。この機能はソースから翻訳される際に結果が決定される。
    /// （ライブラリーとしてこの機能がコンパイル済みの場合、コンパイル済みのライブラリーが D, R の何れかに確定される点に注意）
    /// </summary>
    /// <returns>デバッグビルドされていれば 'D', リリースビルドされていれば 'R'</returns>
    public static char GetBuildTypeChar()
    {
      return
#if DEBUG
          'D'
#else
          'R'
#endif
          ;
    }

    /// <summary>
    /// バージョン文字列を取得
    /// </summary>
    /// <returns>バージョン文字列</returns>
    public static string GetVersionString()
    { return SRA.GetExecutingAssembly().GetName().Version.ToString(); }

    /// <summary>
    /// タイトル文字列を取得
    /// </summary>
    /// <returns>タイトル文字列</returns>
    public static string GetTitleString()
    {
      return
        ( Attribute.GetCustomAttribute
          ( SRA.GetExecutingAssembly()
          , typeof( AssemblyTitleAttribute )
          ) as AssemblyTitleAttribute
        ).Title;
    }

    /// <summary>
    /// 説明文字列を取得
    /// </summary>
    /// <returns>説明文字列</returns>
    public static string GetDescriptionString()
    {
      return
        ( Attribute.GetCustomAttribute
          ( SRA.GetExecutingAssembly()
          , typeof( AssemblyDescriptionAttribute )
          ) as AssemblyDescriptionAttribute
        ).Description;
    }

    /// <summary>
    /// 権利表示文字列を取得
    /// </summary>
    /// <returns>権利表示文字列</returns>
    public static string GetCopyrightString()
    {
      return
        ( Attribute.GetCustomAttribute
          ( SRA.GetExecutingAssembly()
          , typeof( AssemblyCopyrightAttribute )
          ) as AssemblyCopyrightAttribute
        ).Copyright;
    }

    /// <summary>
    /// 製品名文字列を取得
    /// </summary>
    /// <returns>製品名文字列</returns>
    public static string GetProductString()
    {
      return
        ( Attribute.GetCustomAttribute
          ( SRA.GetExecutingAssembly()
          , typeof( AssemblyProductAttribute )
          ) as AssemblyProductAttribute
        ).Product;
    }
  }
}
