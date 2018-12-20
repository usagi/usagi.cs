using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usagi.Quantity.Unit.SI
{
  /// <summary>
  /// SI Metric Prefix
  /// SI接頭辞について文字列と係数の相互変換を提供します。
  /// (double) への暗黙の型変換を持ちます。
  /// μ については慣用として u が当てられる事もあるため何れでも micro として扱います。
  /// 内部表現は文字列、数値との変換は内蔵テーブルの参照を行います。
  /// この型は繰り返し頻繁に計算へそのまま用いる用途には向きませんから、そうした必要のある場合は Multiplier を取得して必要な計算を行う事をおすすめします。
  /// </summary>
  public class MetricPrefix
    : IFormattable
    , IComparable<MetricPrefix>
    , IEquatable<MetricPrefix>
  {
    /// <summary>
    /// SI接頭辞の正規表現パターン
    /// </summary>
    public const string RegexPattern = @"Y|Z|E|P|T|G|M|k|h|da|d|c|m|(?:μ|u)|n|p|a|z|y";

    /// <summary>
    /// Internal Table
    /// </summary>
    static Dictionary<string, double> Mapper { get; set; } =
      new Dictionary<string, double>()
      { { "Y", 1.0e+24 }
      , { "Z", 1.0e+21 }
      , { "E", 1.0e+18 }
      , { "P", 1.0e+15 }
      , { "T", 1.0e+12 }
      , { "G", 1.0e+9 }
      , { "M", 1.0e+6 }
      , { "k", 1.0e+3 }
      , { "h", 1.0e+2 }
      , { "da", 1.0e+1 }
      , { "", 1.0 }
      , { "d", 1.0e-1 }
      , { "c", 1.0e-2 }
      , { "m", 1.0e-3 }
      , { "μ", 1.0e-6 }
      , { "u", 1.0e-6 }
      , { "n", 1.0e-9 }
      , { "p", 1.0e-12 }
      , { "f", 1.0e-15 }
      , { "a", 1.0e-18 }
      , { "z", 1.0e-21 }
      , { "y", 1.0e-24 }
      };

    public static MetricPrefix _Y { get { return new MetricPrefix() { Prefix = "Y" }; } }
    public static MetricPrefix _Z { get { return new MetricPrefix() { Prefix = "Z" }; } }
    public static MetricPrefix _E { get { return new MetricPrefix() { Prefix = "E" }; } }
    public static MetricPrefix _P { get { return new MetricPrefix() { Prefix = "P" }; } }
    public static MetricPrefix _T { get { return new MetricPrefix() { Prefix = "T" }; } }
    public static MetricPrefix _G { get { return new MetricPrefix() { Prefix = "G" }; } }
    public static MetricPrefix _M { get { return new MetricPrefix() { Prefix = "M" }; } }
    public static MetricPrefix _k { get { return new MetricPrefix() { Prefix = "k" }; } }
    public static MetricPrefix _h { get { return new MetricPrefix() { Prefix = "h" }; } }
    public static MetricPrefix _da { get { return new MetricPrefix() { Prefix = "da" }; } }
    public static MetricPrefix _d { get { return new MetricPrefix() { Prefix = "d" }; } }
    public static MetricPrefix _c { get { return new MetricPrefix() { Prefix = "c" }; } }
    public static MetricPrefix _m { get { return new MetricPrefix() { Prefix = "m" }; } }
    public static MetricPrefix _μ { get { return new MetricPrefix() { Prefix = "μ" }; } }
    public static MetricPrefix _u { get { return new MetricPrefix() { Prefix = "μ" }; } }
    public static MetricPrefix _n { get { return new MetricPrefix() { Prefix = "n" }; } }
    public static MetricPrefix _p { get { return new MetricPrefix() { Prefix = "p" }; } }
    public static MetricPrefix _f { get { return new MetricPrefix() { Prefix = "f" }; } }
    public static MetricPrefix _a { get { return new MetricPrefix() { Prefix = "a" }; } }
    public static MetricPrefix _z { get { return new MetricPrefix() { Prefix = "z" }; } }
    public static MetricPrefix _y { get { return new MetricPrefix() { Prefix = "y" }; } }

    /// <summary>
    /// 文字列としてのSI接頭辞が得られる。
    /// 等倍の場合は空文字列が得られる。
    /// </summary>
    public string Prefix { get; private set; } = "";
    /// <summary>
    /// 数値としての倍率（係数）が得られる。
    /// </summary>
    public double Multiplier { get { return Mapper[ Prefix ]; } }
    /// <summary>
    /// 文字列からのファクトリー
    /// 与えられた文字列がSI接頭辞として有効な場合は MetricPrefix オブジェクトを返す。
    /// 与えられた文字列が空文字列の場合は等倍（1.0倍）の MetricPrefix オブジェクトを返す。
    /// 与えられた文字列がSI接頭辞として無効な場合は null を返す。
    /// </summary>
    /// <param name="str">任意の文字列</param>
    /// <returns>MetricPrefix オブジェクトまたは null</returns>
    static public MetricPrefix Parse( string str )
    {
      if ( Mapper.ContainsKey( str ) )
        return new MetricPrefix() { Prefix = str != "u" ? str : "μ" };
      return null;
    }

    /// <summary>
    /// 文字列化する
    /// </summary>
    /// <returns>SI接頭辞の文字列または等倍の場合は空文字列</returns>
    public string ToString( string format, IFormatProvider formatProvider )
    {
      return Prefix.ToString( formatProvider );
    }

    public int CompareTo( MetricPrefix other )
    {
      var d = (double)this - (double)other;
      if ( d < 0 )
        return -1;
      if ( d > 0 )
        return +1;
      return 0;
    }

    public bool Equals( MetricPrefix other ) { return CompareTo( other ) == 0; }

    public override bool Equals( object obj ) { if ( obj is MetricPrefix m ) return Equals( m ); return false; }
    public override int GetHashCode() { return Prefix.GetHashCode(); }
    public override string ToString() { return Prefix.ToString(); }

    /// <summary>
    /// MetricPrefix オブジェクトから暗黙の型変換で double の係数を得る
    /// </summary>
    /// <param name="p">有効な MetricPrefix オブジェクト</param>
    static public implicit operator double( MetricPrefix p ) { return p.Multiplier; }

    /// <summary>
    /// MetricPrefix オブジェクトから暗黙の型変換で string のSI接頭辞文字列を得る
    /// </summary>
    /// <param name="p">有効な MetricPrefix オブジェクト</param>
    static public implicit operator string( MetricPrefix p ) { return p.Prefix; }

    static public bool operator ==( MetricPrefix a, MetricPrefix b ) { return a.Prefix == b.Prefix; }
    static public bool operator !=( MetricPrefix a, MetricPrefix b ) { return !( a == b ); }
    static public bool operator <( MetricPrefix a, MetricPrefix b ) { return (double)a < (double)b; }
    static public bool operator >( MetricPrefix a, MetricPrefix b ) { return (double)a > (double)b; }
  }
}
