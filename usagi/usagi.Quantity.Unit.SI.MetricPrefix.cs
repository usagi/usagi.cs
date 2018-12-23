using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usagi.Quantity.Unit.SI
{
  /// <summary>
  /// SI Metric Prefix
  /// <list type="bullet">
  /// <item><description>SI接頭辞について文字列と係数の相互変換を提供します。</description></item>
  /// <item><description>(double) への暗黙の型変換を持ちます。</description></item>
  /// <item><description>μ については慣用として u が当てられる事もあるため何れでも micro として扱います。</description></item>
  /// </list>
  /// </summary>
  /// <remarks>
  /// 内部表現は文字列、数値との変換は内蔵テーブルの参照を行います。
  /// <para/>この型は繰り返し頻繁に計算へそのまま用いる用途には向きませんから、そうした必要のある場合は Multiplier を取得して必要な計算を行う事をおすすめします。
  /// </remarks>
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

    /// <summary>ヨッタを生成</summary>
    public static MetricPrefix _Y { get { return new MetricPrefix() { Prefix = "Y" }; } }
    /// <summary>ゼッタを生成</summary>
    public static MetricPrefix _Z { get { return new MetricPrefix() { Prefix = "Z" }; } }
    /// <summary>エクサを生成</summary>
    public static MetricPrefix _E { get { return new MetricPrefix() { Prefix = "E" }; } }
    /// <summary>ペタを生成</summary>
    public static MetricPrefix _P { get { return new MetricPrefix() { Prefix = "P" }; } }
    /// <summary>テラを生成</summary>
    public static MetricPrefix _T { get { return new MetricPrefix() { Prefix = "T" }; } }
    /// <summary>ギガを生成</summary>
    public static MetricPrefix _G { get { return new MetricPrefix() { Prefix = "G" }; } }
    /// <summary>メガを生成</summary>
    public static MetricPrefix _M { get { return new MetricPrefix() { Prefix = "M" }; } }
    /// <summary>キロを生成</summary>
    public static MetricPrefix _k { get { return new MetricPrefix() { Prefix = "k" }; } }
    /// <summary>ヘクトを生成</summary>
    public static MetricPrefix _h { get { return new MetricPrefix() { Prefix = "h" }; } }
    /// <summary>デカを生成</summary>
    public static MetricPrefix _da { get { return new MetricPrefix() { Prefix = "da" }; } }
    /// <summary>デシを生成</summary>
    public static MetricPrefix _d { get { return new MetricPrefix() { Prefix = "d" }; } }
    /// <summary>センチを生成</summary>
    public static MetricPrefix _c { get { return new MetricPrefix() { Prefix = "c" }; } }
    /// <summary>ミリを生成</summary>
    public static MetricPrefix _m { get { return new MetricPrefix() { Prefix = "m" }; } }
    /// <summary>マイクロを生成</summary>
    public static MetricPrefix _μ { get { return new MetricPrefix() { Prefix = "μ" }; } }
    /// <summary>マイクロを生成</summary>
    public static MetricPrefix _u { get { return new MetricPrefix() { Prefix = "μ" }; } }
    /// <summary>ナノを生成</summary>
    public static MetricPrefix _n { get { return new MetricPrefix() { Prefix = "n" }; } }
    /// <summary>ピコを生成</summary>
    public static MetricPrefix _p { get { return new MetricPrefix() { Prefix = "p" }; } }
    /// <summary>フェムトを生成</summary>
    public static MetricPrefix _f { get { return new MetricPrefix() { Prefix = "f" }; } }
    /// <summary>アットを生成</summary>
    public static MetricPrefix _a { get { return new MetricPrefix() { Prefix = "a" }; } }
    /// <summary>ゼプトを生成</summary>
    public static MetricPrefix _z { get { return new MetricPrefix() { Prefix = "z" }; } }
    /// <summary>ヨクトを生成</summary>
    public static MetricPrefix _y { get { return new MetricPrefix() { Prefix = "y" }; } }

    /// <summary>
    /// 文字列としてのSI接頭辞が得られる。
    /// <para/>等倍の場合は空文字列が得られる。
    /// </summary>
    public string Prefix { get; private set; } = "";
    /// <summary>
    /// 数値としての倍率（係数）が得られる。
    /// </summary>
    public double Multiplier { get { return Mapper[ Prefix ]; } }
    /// <summary>
    /// 文字列からのファクトリー
    /// <list type="bullet">
    /// <item><description>与えられた文字列がSI接頭辞として有効な場合は MetricPrefix オブジェクトを返す。</description></item>
    /// <item><description>与えられた文字列が空文字列の場合は等倍（1.0倍）の MetricPrefix オブジェクトを返す。</description></item>
    /// <item><description>与えられた文字列がSI接頭辞として無効な場合は null を返す。</description></item>
    /// </list>
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
    /// <param name="format">フォーマット</param>
    /// <param name="formatProvider">フォーマットプロバイダー</param>
    /// <returns>SI接頭辞の文字列または等倍の場合は空文字列</returns>
    public string ToString( string format, IFormatProvider formatProvider )
    {
      return Prefix.ToString( formatProvider );
    }

    /// <summary>
    /// 大・小・等価を比較
    /// </summary>
    /// <param name="other">比較対象</param>
    /// <returns>小=-1, 等価=0, 大=+1</returns>
    public int CompareTo( MetricPrefix other )
    {
      var d = (double)this - (double)other;
      if ( d < 0 )
        return -1;
      if ( d > 0 )
        return +1;
      return 0;
    }

    /// <summary>
    /// 等価な係数値か判定
    /// </summary>
    /// <param name="other">比較対象</param>
    /// <returns>等価なら true</returns>
    public bool Equals( MetricPrefix other ) { return CompareTo( other ) == 0; }

    /// <summary>
    /// SI補助単位として比較可能かつ等価か判定
    /// </summary>
    /// <param name="obj">SI補助単位として扱えるかもしれない何か</param>
    /// <returns>等価なら true</returns>
    public override bool Equals( object obj ) { if ( obj is MetricPrefix m ) return Equals( m ); return false; }
    /// <summary>
    /// ハッシュ値を取得
    /// </summary>
    /// <returns>ハッシュ値</returns>
    public override int GetHashCode() { return Prefix.GetHashCode(); }
    /// <summary>
    /// 文字列化
    /// </summary>
    /// <returns>文字列化されたプリフィックス</returns>
    public override string ToString() { return Prefix.ToString(); }

    /// <summary>
    /// MetricPrefix オブジェクトから暗黙の型変換で double の係数を得る
    /// </summary>
    /// <param name="p">有効な MetricPrefix オブジェクト</param>
    /// <returns>係数値</returns>
    static public implicit operator double( MetricPrefix p ) { return p.Multiplier; }

    /// <summary>
    /// MetricPrefix オブジェクトから暗黙の型変換で string のSI接頭辞文字列を得る
    /// </summary>
    /// <param name="p">有効な MetricPrefix オブジェクト</param>
    /// <returns>文字列</returns>
    static public implicit operator string( MetricPrefix p ) { return p.Prefix; }

    /// <summary>
    /// 等価な係数値か判定
    /// </summary>
    /// <param name="a">SI補助単位1つめ</param>
    /// <param name="b">SI補助単位2つめ</param>
    /// <returns>等価なら true</returns>
    static public bool operator ==( MetricPrefix a, MetricPrefix b ) { return a.Prefix == b.Prefix; }
    /// <summary>
    /// 不等な係数値か判定
    /// </summary>
    /// <param name="a">SI補助単位1つめ</param>
    /// <param name="b">SI補助単位2つめ</param>
    /// <returns>不等なら true</returns>
    static public bool operator !=( MetricPrefix a, MetricPrefix b ) { return !( a == b ); }
    /// <summary>
    /// a が b より小さな係数値か判定
    /// </summary>
    /// <param name="a">SI補助単位 a</param>
    /// <param name="b">SI補助単位 b</param>
    /// <returns>a が b より小さな係数値なら true</returns>
    static public bool operator <( MetricPrefix a, MetricPrefix b ) { return (double)a < (double)b; }
    /// <summary>
    /// a が b より大きな係数値か判定
    /// </summary>
    /// <param name="a">SI補助単位 a</param>
    /// <param name="b">SI補助単位 b</param>
    /// <returns>a が b より大きな係数値なら true</returns>
    static public bool operator >( MetricPrefix a, MetricPrefix b ) { return (double)a > (double)b; }
  }
}
