using System.Linq;
using System;
using System.IO;
using System.Text;
using System.Windows.Media;
using usagi.ColorSpace;
using usagi.Quantity;
using usagi.Quantity.Ratio.Extension;

namespace usagi.String.Extension
{
  /// <summary>
  /// string 型を機能拡張する何か
  /// </summary>
  static public class StringExtension
  {
    /// <summary>
    /// Contains の複数パターンを OR 判定できる版
    /// </summary>
    /// <example>
    /// <code>
    /// string p1 = "This is a sushi.";
    /// string p2 = "This is an urchin.";
    /// var a1 = p1.Contains( "a ", "an " ); // true
    /// var a2 = p2.Contains( "a ", "an " ); // true
    /// </code>
    /// </example>
    /// <param name="s">元文字列</param>
    /// <param name="ss">判定したい文字列群</param>
    /// <returns>s に ss の何れかが含まれれば true</returns>
    static public bool Contains( this string s, params string[] ss )
    { return s.OrCombinator( ( a, b ) => a.Contains( b ), ss ); }

    /// <summary>
    /// StartsWith の複数パターンを OR 判定できる版
    /// </summary>
    /// <param name="s">元文字列</param>
    /// <param name="ss">判定したい文字列群</param>
    /// <returns>s が ss の何れかで始まっていれば true</returns>
    static public bool StartsWith( this string s, params string[] ss )
    { return s.OrCombinator( ( a, b ) => a.StartsWith( b ), ss ); }

    /// <summary>
    /// StartsWith の複数パターンを OR 判定できる版
    /// </summary>
    /// <param name="s">元文字列</param>
    /// <param name="ss">判定したい文字列群</param>
    /// <returns>s が ss の何れかで終わっていれば true</returns>
    static public bool EndsWith( this string s, params string[] ss )
    { return s.OrCombinator( ( a, b ) => a.EndsWith( b ), ss ); }

    /// <summary>
    /// StartsWith または EndsWith の複数パターンを OR 判定
    /// </summary>
    /// <param name="s">元文字列</param>
    /// <param name="ss">判定したい文字列群</param>
    /// <returns>s が ss の何れかで始まるか終わるかしていれば true</returns>
    static public bool StartsOrEndsWith( this string s, params string[] ss )
    { return s.OrCombinator( ( a, b ) => s.StartsWith( b ) || s.EndsWith( b ), ss ); }

    /// <summary>
    /// ss に含まれる文字列 sss について f( s, sss ) が成立するものがあるか判定する
    /// </summary>
    /// <remarks>
    /// <see cref="Contains(string, string[])"/>
    /// <see cref="StartsWith(string, string[])"/>
    /// <see cref="EndsWith(string, string[])"/>
    /// の実装詳細のために作った。
    /// </remarks>
    /// <param name="s">元文字列</param>
    /// <param name="f">ss の要素 sss ごとに f(s,sss) するファンクター</param>
    /// <param name="ss">f で s と判定させる文字列群</param>
    /// <returns>成立するものがあれば true</returns>
    internal static bool OrCombinator( this string s, Func<string, string, bool> f, params string[] ss )
    { return ( from _ in ss where f( s, _ ) select true ).Any(); }

  }
}
