/// Note: このファイルに書いてあるということは未整理のα版的な実装です。
/// 整理されると適当な名前空間やクラスごとに綺麗にディレクトリーとファイルを分離して放り込まれるでしょう。たぶん。
/// Caution: このライブラリーは作者の酔狂により非ASCIIな文字がソースコードに含まれます。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using System.Text.RegularExpressions;

/// <summary>
/// Library Name: usagi.cs
/// Description: わたしが欲しいと思った適当な機能たち for C#
/// Repos.: https://github.com/usagi/usagi.cs/
/// License: [MIT](https://opensource.org/licenses/MIT)
/// Author: [Usagi Ito](https://github.com/usagi/)
/// </summary>
namespace usagi { }


/// <summary>
/// オブジェクトの Boxing に関する便利かもしれないおまけ機能を提供する
/// </summary>
namespace usagi.Boxing
{
  public class Utility
  {
    /// <summary>
    /// Optional&lt;T&gt; への糖衣構文
    /// </summary>
    abstract class Optional
    {
      /// <summary>
      /// Optional&lt;T&gt;.FromValu&lt;T&gt; への糖衣構文
      /// </summary>
      /// <typeparam name="T">ボクシングしたい任意のオブジェクトの型</typeparam>
      /// <param name="value">ボクシングしたい任意のオブジェクト</param>
      /// <returns>ボクシングされた任意のオブジェクト</returns>
      public static Optional<T> FromValue<T>( T value ) { return Optional<T>.FromValue( value ); }
    }

    /// <summary>
    /// 任意の型&lt;T&gt; についてオブジェクトの有無のチェック機構を設けたボクシングされた型を提供する
    /// オブジェクトを放り込むと暗黙的に T 型のオブジェクトとしても振る舞う
    /// null を放り込むと T 型の空のオブジェクトとして振る舞う
    /// IDisposable なオブジェクトに対してはボクシングしたまま IDisposable できる
    /// 内部表現は object による
    /// </summary>
    /// <typeparam name="T">ボクシングしたい任意の型</typeparam>
    public class Optional<T>
      : IDisposable
    {
      /// <summary>
      /// オブジェクトを内包していない状態でオブジェクトを要求するメソッドを呼んだりすると飛ばします。
      /// </summary>
      public class InvalidValueException: InvalidOperationException { public InvalidValueException( string m = "" ) : base( m ) { } }

      /// <summary>
      /// 内部表現
      /// </summary>
      object o = null;

      /// <summary>
      /// 空のボクシングオブジェクトを生成します。
      /// それはおおよそソフトな null っぽいものです。
      /// </summary>
      public Optional() { }
      /// <summary>
      /// オブジェクトを内包したボクシングオブジェクトを生成します。
      /// 生成されたボクシングオブジェクトはおおよそ暗黙の型変換によりT型のオブジェクトっぽく振る舞います。
      /// </summary>
      /// <param name="value">内包させるオブジェクト</param>
      public Optional( T value ) { Reset( value ); }

      /// <summary>
      /// ボクシングオブジェクトにオブジェクトを新たに内包させます。
      /// 既に内包しているオブジェクトがあった場合その運命はガベージコレクターに委ねられます。たぶん。
      /// </summary>
      /// <param name="value">新たに内包させるオブジェクト</param>
      /// <param name="dispose">既に内包しているオブジェクトがあり、かつ IDisposable を実装している場合に Dispose する場合は true 、しなくていい場合は false</param>
      /// <returns>新たなオブジェクトを内包した this</returns>
      public Optional<T> Reset( T value, bool dispose = true )
      {
        if ( dispose )
          Dispose();
        o = value;
        return this;
      }

      /// <summary>
      /// 新たなオブジェクトを内包させると同時に既に内包しているオブジェクトがあった場合には取り出せる版の Reset　です。
      /// </summary>
      /// <param name="value">新たに内包させるオブジェクト</param>
      /// <param name="previously">既に内包しているオブジェクトがあった場合に取り出す先</param>
      /// <returns>新たなオブジェクトを内包した this</returns>
      public Optional<T> Reset( T value, ref T previously )
      {
        TryGet( ref previously );
        return Reset( value );
      }

      /// <summary>
      /// 内包するオブジェクトがあれば取り出します。
      /// この機能は T 型への暗黙の型変換と等価です。
      /// </summary>
      /// <exception cref="InvalidValueException">内包するオブジェクトが無い場合に飛びます。</exception>
      /// <returns>内包するオブジェクト</returns>
      public T Get()
      {
        if ( o is T v )
          return v;
        throw new InvalidValueException( $"Optional<T>(T={ o.GetType().FullName.ToString()}) has not a valid value." );
      }

      /// <summary>
      /// 内包するオブジェクトがあれば value へ取り出し true を返します。
      /// 内包するオブジェクトが無ければ value には何もせず false を返します。
      /// Get や暗黙の型変換で例外が飛ぶ可能性を嫌う場合にどうぞ。
      /// </summary>
      /// <param name="value">内包するオブジェクトがあれば代入されます。無ければ何もされません。</param>
      /// <returns>内包するオブジェクトを value へ取り出せた場合は true 、そうでない場合には false が帰ります。</returns>
      public bool TryGet( ref T value )
      {
        if ( o is T v )
        {
          value = v;
          return true;
        }
        return false;
      }

      /// <summary>
      /// 内包するオブジェクトの有無を返します。
      /// </summary>
      /// <returns>内包するオブジェクトがあれば true 、無ければ false が返ります。</returns>
      public bool IsValid() { return o != null; }
      /// <summary>
      /// 内包するオブジェクトが有効な場合に operator true として true を返します。
      /// </summary>
      /// <param name="optional">ボクシングオブジェクト</param>
      /// <returns>内包するオブジェクトが有効な場合は true 、そうでなければ false</returns>
      static public bool operator true( Optional<T> optional ) { return optional.IsValid(); }
      /// <summary>
      /// 内包するオブジェクトが無効な場合に operator false として true を返します。
      /// </summary>
      /// <param name="optional">ボクシングオブジェクト</param>
      /// <returns>内包するオブジェクトが無効な場合は true 、そうでなければ false</returns>
      static public bool operator false( Optional<T> optional ) { return !optional.IsValid(); }
      /// <summary>
      /// 暗黙の型変換により T 型へ変換します。
      /// Get と等価に機能します。
      /// </summary>
      /// <param name="optional">ボクシングオブジェクト</param>
      static public implicit operator T( Optional<T> optional ) { return optional.Get(); }

      /// <summary>
      /// 内包させたいオブジェクトからボクシングオブジェクトを生成するファクトリー
      /// </summary>
      /// <param name="value">内包させたいオブジェクト</param>
      /// <returns>value を内包したボクシングオブジェクト</returns>
      static public Optional<T> FromValue( T value ) { return new Optional<T>( value ); }
      /// <summary>
      /// 空のボクシングオブジェクトを生成するファクトリーとして機能するプロパティー
      /// new Optional&ltT&gt;() の糖衣構文です。 new と ctor の ( ) をタイプしたくないあなたに。
      /// </summary>
      static public Optional<T> Null { get { return new Optional<T>(); } }

      /// <summary>
      /// 内包するオブジェクトが IDisposable を実装する場合には Dispose します。
      /// ボクシングオブジェクトとしても内包するオブジェクトの運命をガベージコレクターへ任せ、自身は何も内包しない状態へ変化します。
      /// </summary>
      public void Dispose()
      {
        if ( o is IDisposable v )
          v.Dispose();
        o = null;
      }
    }

    /// <summary>
    /// 列挙の先頭要素をボクシングオブジェクトで取り出します。
    /// </summary>
    /// <typeparam name="T">列挙された任意の型</typeparam>
    /// <param name="values">列挙された任意の型のオブジェクト群</param>
    /// <returns>列挙の先頭要素または空のボクシングオブジェクト</returns>
    static public Optional<T> FirstOf<T>( IEnumerable<T> values )
    {
      if ( values.Count() > 0 )
        return Optional.FromValue( values.First() );
      return Optional<T>.Null;
    }

    /// <summary>
    /// 列挙の末尾要素をボクシングオブジェクトで取り出します。
    /// </summary>
    /// <typeparam name="T">列挙された任意の型</typeparam>
    /// <param name="values">列挙された任意の型のオブジェクト群</param>
    /// <returns>列挙の末尾要素または空のボクシングオブジェクト</returns>
    static public Optional<T> LastOf<T>( IEnumerable<T> values )
    {
      if ( values.Count() > 0 )
        return Optional.FromValue( values.Last() );
      return Optional<T>.Null;
    }
  }
}

/// <summary>
/// 物理量またはそれっぽい何かを扱う
/// </summary>
namespace usagi.Quantity
{
  /// <summary>
  /// 計算機能
  /// 基本的に Generic
  /// </summary>
  public class Calculation
  {
    /// <summary>
    /// a を [ floor ... ceil ] に丸める
    /// </summary>
    /// <typeparam name="T">比較計算可能な任意の型</typeparam>
    /// <param name="a">丸め元とする値</param>
    /// <param name="floor">床値（値域の末端に含まれる）</param>
    /// <param name="ceil">天井値（値域の末端に含まれる）</param>
    /// <returns></returns>
    static public T Clamp<T>( T a, T floor, T ceil )
      where T : IComparable<T>
    {
      if ( a.CompareTo( ceil ) >= 0 )
        return ceil;
      if ( a.CompareTo( floor ) <= 0 )
        return floor;
      return a;
    }
    /// <summary>
    /// a と b の距離（差）を計算する
    /// a と b の順序はどうでもよい
    /// </summary>
    /// <typeparam name="T">減算可能な任意の型</typeparam>
    /// <param name="a">距離を計算する1つめの値</param>
    /// <param name="b">距離を計算する2つめの値</param>
    /// <param name="OperatorSubtract">T型の減算関数</param>
    /// <returns>a と bの距離（差）</returns>
    static public T Distance<T>( T a, T b, Func<T, T, T> OperatorSubtract )
      where T : IComparable<T>
    {
      return
        a.CompareTo( b ) > 0
          ? OperatorSubtract( a, b )
          : OperatorSubtract( b, a )
        ;
    }

    /// <summary>
    /// a が [ floor ... ceil ] に含まれるか判定する
    /// </summary>
    /// <typeparam name="T">比較計算可能な任意の型</typeparam>
    /// <param name="a">判定対象の値</param>
    /// <param name="floor">床値（値域の末端に含まれる）</param>
    /// <param name="ceil">天井値（値域の末端に含まれる）</param>
    /// <returns></returns>
    static public bool IsInRangeOf<T>( T a, T floor, T ceil )
      where T : IComparable<T>
    {
      return a.CompareTo( floor ) >= 0 && a.CompareTo( ceil ) <= 0;
    }

    /// <summary>
    /// 任意個の値から最小の値を1つ抽出する
    /// </summary>
    /// <typeparam name="T">比較計算可能な任意の型</typeparam>
    /// <param name="values">任意個の値群</param>
    /// <returns>抽出された最小の値</returns>
    static public T Min<T>( params T[] values ) where T : IComparable<T> { return values.Min(); }
    /// <summary>
    /// 任意個の値から最大の値を1つ抽出する
    /// </summary>
    /// <typeparam name="T">比較計算可能な任意の型</typeparam>
    /// <param name="values">任意個の値群</param>
    /// <returns>抽出された最大の値</returns>
    static public T Max<T>( params T[] values ) where T : IComparable<T> { return values.Max(); }

    /// <summary>
    /// a と b の差が tolerance 以下か判定する
    /// 許容範囲（許容誤差）において近似的に等価
    /// </summary>
    /// <typeparam name="T">比較計算可能かつ減算可能かつ加算可能な任意の型</typeparam>
    /// <param name="a">差を判定したい1つめの値</param>
    /// <param name="b">差を判定したい2つめの値</param>
    /// <param name="tolerance">許容範囲（許容誤差）</param>
    /// <param name="OperatorSubtract">T型の減算関数</param>
    /// <param name="OperatorAdd">T型の加算関数</param>
    /// <returns></returns>
    static public bool NearlyEquals<T>( T a, T b, T tolerance, Func<T, T, T> OperatorSubtract, Func<T, T, T> OperatorAdd )
      where T : IComparable<T>
    {
      var d = Distance( a, b, OperatorSubtract );
      return IsInRangeOf( d, Min( a, b ), Max( a, b ) );
    }
    /// <summary>
    /// double 特殊化版
    /// double, float, decimal に対しては内部的にも同じ型のまま計算を行う。
    /// </summary>
    static public bool NearlyEquals( double a, double b, double tolerance ) { return NearlyEquals<double>( a, b, tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// float 特殊化版
    /// double, float, decimal に対しては内部的にも同じ型のまま計算を行う。
    /// </summary>
    static public bool NearlyEquals( float a, float b, float tolerance ) { return NearlyEquals<float>( a, b, tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// decimal 特殊化版
    /// double, float, decimal に対しては内部的にも同じ型のまま計算を行う。
    /// </summary>
    static public bool NearlyEquals( decimal a, decimal b, decimal tolerance ) { return NearlyEquals<decimal>( a, b, tolerance, ( p, q ) => p - q, ( p, q ) => p + q ); }
    /// <summary>
    /// byte 特殊化版
    /// byte, UInt16, UInt32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    static public bool NearlyEquals( byte a, byte b, byte tolerance ) { return NearlyEquals( (Int16)a, (Int16)b, (Int16)tolerance ); }
    /// <summary>
    /// UInt16 特殊化版
    /// byte, UInt16, UInt32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    static public bool NearlyEquals( UInt16 a, UInt16 b, UInt16 tolerance ) { return NearlyEquals( (Int32)a, (Int32)b, (Int32)tolerance ); }
    /// <summary>
    /// UInt32 特殊化版
    /// byte, UInt16, UInt32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    static public bool NearlyEquals( UInt32 a, UInt32 b, UInt32 tolerance ) { return NearlyEquals( (Int64)a, (Int64)b, (Int64)tolerance ); }
    /// <summary>
    /// UInt64 特殊化版
    /// UInt64, Int64 に対しては内部的に decimal 型で計算を行う。
    /// </summary>
    static public bool NearlyEquals( UInt64 a, UInt64 b, UInt64 tolerance ) { return NearlyEquals( (decimal)a, (decimal)b, (decimal)tolerance ); }
    /// <summary>
    /// char 特殊化版
    /// char, Int16, Int32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    static public bool NearlyEquals( char a, char b, char tolerance ) { return NearlyEquals( (Int16)a, (Int16)b, (Int16)tolerance ); }
    /// <summary>
    /// Int16 特殊化版
    /// char, Int16, Int32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    static public bool NearlyEquals( Int16 a, Int16 b, Int16 tolerance ) { return NearlyEquals( (Int32)a, (Int32)b, (Int32)tolerance ); }
    /// <summary>
    /// Int32 特殊化版
    /// char, Int16, Int32 に対しては内部的に1単位大きな符号付きの型で計算を行う。
    /// </summary>
    static public bool NearlyEquals( Int32 a, Int32 b, Int32 tolerance ) { return NearlyEquals( (Int64)a, (Int64)b, (Int64)tolerance ); }
    /// <summary>
    /// Int64 特殊化版
    /// UInt64, Int64 に対しては内部的に decimal 型で計算を行う。
    /// </summary>
    static public bool NearlyEquals( Int64 a, Int64 b, Int64 tolerance ) { return NearlyEquals( (decimal)a, (decimal)b, (decimal)tolerance ); }
  }
}

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
namespace usagi.Quantity
{
  /// <summary>
  /// 平面角オブジェクト
  /// 内部表現は double による度数法表現
  /// </summary>
  public class PlaneAngle
    : IComparable<PlaneAngle>
    , IEquatable<PlaneAngle>
    , IFormattable
  {
    /// <summary>
    /// ToString 系で使用する Degrees の単位記号
    /// </summary>
    static public string SymbolOfDegrees = "°";
    /// <summary>
    /// ToString 系で使用する Minutes の単位記号
    /// </summary>
    static public string SymbolOfMinutes = "′";
    /// <summary>
    /// ToString 系で使用する Seconds の単位記号
    /// </summary>
    static public string SymbolOfSeconds = "″";
    /// <summary>
    /// ToString 系で使用する Radians の単位記号
    /// </summary>
    static public string SymbolOfRadians = "rad";
    /// <summary>
    /// ToString 系で使用する Points の単位記号
    /// </summary>
    static public string SymbolOfPoints = "pt";
    /// <summary>
    /// ToString 系で使用する Mils の単位記号
    /// </summary>
    static public string SymbolOfMils = "mils";
    /// <summary>
    /// ToString 系で使用する Gradians の単位記号
    /// </summary>
    static public string SymbolOfGradians = "ᵍ";
    /// <summary>
    /// ToString 系で使用する Turns の単位記号
    /// </summary>
    static public string SymbolOfTurns = "τ";

    /// <summary>
    /// 度分秒系の文字列をパースする正規表現パターン
    /// </summary>
    public const string RegexPatternOfDegrees = @"(?<negative>-)?(?:\s*)(?:(?<degrees>[\d.]+)(?:\s*)(?:°|度|deg))?(?:\s*)(?:(?<minutes>[\d.]+)(?:\s*)(?:′|分))?(?:\s*)(?:(?<seconds>[\d.]+)(?:\s*)(?:′′|″|秒))?";
    /// <summary>
    /// 平面角系の単位の付いた数値文字列をパースする正規表現パターン
    /// </summary>
    public const string RegexPatternOfCommons = @"(?<negative>-)?(?:\s*)(?<value>[\d.]+)(?:\s*)(?<unit>(?<prefix>Y|Z|E|P|T|G|M|k|h|da|d|c|m|(?:μ|u)|n|p|a|z|y)?(?:(?<rad>rad)|(?<pts>pts?)|(?<mils>mils?)|(?<gradians>ᵍ|gon)|(?<turns>τ|turns?)))";
    /// <summary>
    /// 度分秒系の文字列をパースする正規表現
    /// </summary>
    static public Regex RegexOfDegrees { get; } = new Regex( RegexPatternOfDegrees );
    /// <summary>
    /// 平面角系の単位の付いた数値文字列をパースする正規表現
    /// </summary>
    static public Regex RegexOfCommons { get; } = new Regex( RegexPatternOfCommons );
    /// <summary>
    /// デフォルトコンストラクター
    /// 0 値の角度を生成する
    /// </summary>
    PlaneAngle() { }
    /// <summary>
    /// コピーコンストラクター
    /// 複製元は変更せずに同じ値を持つ新たな平面角オブジェクトを生成する
    /// </summary>
    /// <param name="a">複製元</param>
    PlaneAngle( PlaneAngle a ) { InDegrees = a.InDegrees; }

    /// <summary>
    /// 度数法からのファクトリー
    /// 度, 分, 秒, °, ′, ′′, deg
    /// 主に一般生活中の平面角、測地学でよく使われる。
    /// </summary>
    /// <param name="degrees">度</param>
    /// <param name="minutes">分</param>
    /// <param name="seconds">秒</param>
    static public PlaneAngle FromDegrees( double degrees, double minutes = 0, double seconds = 0 ) { return new PlaneAngle() { InDegrees = degrees + ( minutes / 60.0 ) + ( seconds / 60.0 / 60.0 ) }; }
    /// <summary>
    /// ラジアンからのファクトリー
    /// rad
    /// 主に数学系、電気工学系でよく使われる。
    /// </summary>
    /// <param name="radians">ラジアン</param>
    /// <returns>生成された平面角オブジェクト</returns>
    static public PlaneAngle FromRadians( double radians ) { return FromDegrees( ToDegrees( radians ) ); }
    /// <summary>
    /// ポイントからのファクトリー
    /// ポイント, 点, pt
    /// 主に航海系、航空系で用いられる。
    /// </summary>
    /// <param name="points">ポイント</param>
    /// <returns>生成された平面角オブジェクト</returns>
    static public PlaneAngle FromPoints( double points ) { return FromDegrees( points * ( 1.0 / 32.0 ) ); }
    /// <summary>
    /// ミルからのファクトリー
    /// ミル, 密位, シュトリヒ, strich, mils
    /// 主に軍事系で用いられる。
    /// </summary>
    /// <param name="mils">ミル</param>
    /// <returns>生成された平面角オブジェクト</returns>
    static public PlaneAngle FromMils( double mils ) { return FromRadians( mils * 1.0e-3 ); }
    /// <summary>
    /// グラヂアンからのファクトリー
    /// グラヂアン, グラード, グレイド, ゴン, gradian, graded, gon
    /// 主にフランス及びその周辺国の一部の測量系に用いられる。
    /// </summary>
    /// <param name="gradians">グラヂアン</param>
    /// <returns>生成された平面角オブジェクト</returns>
    static public PlaneAngle FromGradians( double gradians ) { return FromDegrees( gradians * ( 9.0 / 10.0 ) ); }
    /// <summary>
    /// ターンからのファクトリー
    /// ターン, turns, 回転
    /// 主に円周全体の回転を視覚的にわかりやすく表現したい目的で用いられる。
    /// </summary>
    /// <param name="turns">ターン</param>
    /// <returns>生成された平面角オブジェクト</returns>
    static public PlaneAngle FromTurns( double turns ) { return FromDegrees( turns * 360.0 ); }

    /// <summary>
    /// 度数法の Degrees 単位での入出力用のプロパティー
    /// 他の全ての単位表現プロパティーの中で唯一直接的に内部に値を持つプロパティー。
    /// 他のすべての単位の扱いは内部的にはこの値との変換により実装される
    /// </summary>
    public double InDegrees { get; set; } = 0;
    /// <summary>
    /// 度数法の Minutes 単位での入出力用のプロパティー
    /// </summary>
    public double InMinutes { get { return InDegrees * 60.0; } set { InDegrees = value / 60.0; } }
    /// <summary>
    /// 度数法の Seconds 単位での入出力用のプロパティー
    /// </summary>
    public double InSeconds { get { return InMinutes * 60.0; } set { InDegrees = value / 60.0 / 60.0; } }

    /// <summary>
    /// 度数法の整数 Degrees 成分の値の入出力用のプロパティー
    /// </summary>
    public int PartOfDegrees { get { return Math.Sign( InDegrees ) * (int)Math.Floor( Math.Abs( InDegrees ) ); } set { InDegrees = PartOfSeconds / 60.0 / 60.0 + PartOfMinutes / 60.0 + value; } }
    /// <summary>
    /// 度数法の整数 Minutes 成分の値の入出力用のプロパティー
    /// </summary>
    public int PartOfMinutes { get { return Math.Sign( InDegrees ) * (int)Math.Floor( Math.Abs( InMinutes ) ); } set { InDegrees = PartOfSeconds / 60.0 / 60.0 + value / 60.0 + PartOfDegrees; } }
    /// <summary>
    /// 度数法の実数 Seconds 成分の値の入出力用のプロパティー
    /// </summary>
    public double PartOfSeconds { get { return InSeconds % 60.0; } set { InDegrees = value / 60.0 / 60.0 + PartOfMinutes + PartOfDegrees; } }

    /// <summary>
    /// ラジアン単位での入出力用プロパティー
    /// </summary>
    public double InRadians { get { return ToRadians( InDegrees ); } set { InDegrees = ToDegrees( value ); } }
    /// <summary>
    /// ポイント単位での入出力用プロパティー
    /// </summary>
    public double InPoints { get { return InDegrees / ( 1.0 / 32.0 ); } set { InDegrees = value * ( 1.0 / 32.0 ); } }
    /// <summary>
    /// ミル単位での入出力用プロパティー
    /// </summary>
    public double InMils { get { return InRadians / 1.0e-3; } set { InRadians = value * 1.0e-3; } }
    /// <summary>
    /// グラヂアン単位での入出力用プロパティー
    /// </summary>
    public double InGradians { get { return InDegrees / ( 9.0 / 10.0 ); } set { InDegrees = value * ( 9.0 / 10.0 ); } }
    /// <summary>
    /// ターン単位での入出力用プロパティー
    /// </summary>
    public double InTurns { get { return InDegrees / 360.0; } set { InDegrees = value * 360.0; } }

    public override string ToString() { return ToStringInDegrees(); }

    /// <summary>
    /// 度数法の Degrees 単位で文字列化する。数値に加え、単位として SymbolOfDegrees が付く。
    /// </summary>
    public string ToStringInDegrees( string format = "F2" ) { return $"{InDegrees.ToString( format )}{SymbolOfDegrees}"; }
    /// <summary>
    /// 度数法の Minutes 単位で文字列化する。数値に加え、単位として SymbolOfMinutes が付く。
    /// </summary>
    public string ToStringInMinutes( string format = "F2" ) { return $"{InMinutes.ToString( format )}{SymbolOfMinutes}"; }
    /// <summary>
    /// 度数法の Seconds 単位で文字列化する。数値に加え、単位として SymbolOfSeconds が付く。
    /// </summary>
    public string ToStringInSeconds( string format = "F2" ) { return $"{InSeconds.ToString( format )}{SymbolOfSeconds}"; }
    /// <summary>
    /// 度数法の整数 Degrees 成分、整数 Minutes 成分、実数 Seconds 成分により文字列化する。数値に加え、単位として SymbolOfDegrees, SymbolOfMinutes, SymbolOfDegrees が付く。
    /// </summary>
    public string ToStringInDMS( string seconds_format = "F2" ) { return $"{PartOfDegrees}{SymbolOfDegrees}{PartOfMinutes}{SymbolOfMinutes}{PartOfSeconds.ToString( seconds_format )}{SymbolOfSeconds}"; }
    /// <summary>
    /// Radians 単位で文字列化する。数値に加え、単位として SymbolOfRadians が付く。
    /// </summary>
    public string ToStringInRadians( string format = "F2" ) { return $"{InRadians}{SymbolOfRadians}"; }
    /// <summary>
    /// Points 単位で文字列化する。数値に加え、単位として SymbolOfPoints が付く。
    /// </summary>
    public string ToStringInPoints( string format = "F2" ) { return $"{InPoints}{SymbolOfPoints}"; }
    /// <summary>
    /// Mils 単位で文字列化する。数値に加え、単位として SymbolOfMils が付く。
    /// </summary>
    public string ToStringInMils( string format = "F2" ) { return $"{InMils}{SymbolOfMils}"; }
    /// <summary>
    /// Gradian 単位で文字列化する。数値に加え、単位として SymbolOfGradians が付く。
    /// </summary>
    public string ToStringInGradians( string format = "F2" ) { return $"{InGradians}{SymbolOfGradians}"; }
    /// <summary>
    /// Turns 単位で文字列化する。数値に加え、単位として SymbolOfTurns が付く。
    /// </summary>
    public string ToStringInTurns( string format = "F2" ) { return $"{InTurns}{SymbolOfTurns}"; }

    /// <summary>InDegrees への糖衣構文</summary>
    public double _deg { get { return InDegrees; } set { InDegrees = value; } }
    /// <summary>InMinutes への糖衣構文</summary>
    public double _min { get { return InMinutes; } set { InMinutes = value; } }
    /// <summary>InSeconds への糖衣構文</summary>
    public double _sec { get { return InSeconds; } set { InSeconds = value; } }
    /// <summary>PartOfDegrees への糖衣構文</summary>
    public int _deg_p { get { return PartOfDegrees; } set { PartOfDegrees = value; } }
    /// <summary>PartOfMinutes への糖衣構文</summary>
    public int _min_p { get { return PartOfMinutes; } set { PartOfMinutes = value; } }
    /// <summary>PartOfSeconds への糖衣構文</summary>
    public double _sec_p { get { return PartOfSeconds; } set { PartOfSeconds = value; } }
    /// <summary>InRadians への糖衣構文</summary>
    public double _rad { get { return InRadians; } set { InRadians = value; } }
    /// <summary>InPts への糖衣構文</summary>
    public double _pts { get { return InPoints; } set { InPoints = value; } }
    /// <summary>InMils への糖衣構文</summary>
    public double _mils { get { return InMils; } set { InMils = value; } }
    /// <summary>InGradians への糖衣構文</summary>
    public double _ᵍ { get { return InGradians; } set { InGradians = value; } }
    /// <summary>InGradians への糖衣構文</summary>
    public double _g { get { return InGradians; } set { InGradians = value; } }
    /// <summary>InTurns への糖衣構文</summary>
    public double _τ { get { return InTurns; } set { InTurns = value; } }
    /// <summary>InTurns への糖衣構文</summary>
    public double _turns { get { return InTurns; } set { InTurns = value; } }

    /// <summary>
    /// 度数法による Degrees または Minutes または Seconds の組み合わせ
    /// または Radians, Points, Mils, Gradians, Turns で読み取り可能な文字列
    /// から PlaneAngle オブジェクトを生成する。
    /// 読み取り不能な場合は null を返す。
    /// </summary>
    /// <param name="str">任意の文字列</param>
    /// <returns>読み取りに成功した場合は PlaneAngle オブジェクト、読み取れなかった場合は null</returns>
    static public PlaneAngle Parse( string str )
    {
      return ParseDegrees( str ) ?? ParseCommons( str );
    }
    /// <summary>
    /// 度数法による Degrees または Minutes または Seconds の組み合わせ
    /// から PlaneAngle オブジェクトを生成する。
    /// 読み取り不能な場合は null を返す。
    /// </summary>
    /// <param name="str">任意の文字列</param>
    /// <returns>読み取りに成功した場合は PlaneAngle オブジェクト、読み取れなかった場合は null</returns>
    static public PlaneAngle ParseDegrees( string str )
    {
      var m = RegexOfDegrees.Match( str );
      if ( m == null )
        return null;

      double degrees = 0;
      {
        double buffer = 0;
        if ( double.TryParse( m.Groups[ "degrees" ].Value, out buffer ) )
          degrees = buffer;
        if ( double.TryParse( m.Groups[ "minutes" ].Value, out buffer ) )
          degrees += buffer / 60.0;
        if ( double.TryParse( m.Groups[ "seconds" ].Value, out buffer ) )
          degrees += buffer / 60.0 / 60.0;
      }
      return FromDegrees( m.Groups[ "negative" ].Value == "-" ? -degrees : degrees );
    }
    /// <summary>
    /// Radians, Points, Mils, Gradians, Turns で読み取り可能な文字列
    /// から PlaneAngle オブジェクトを生成する。
    /// 読み取り不能な場合は null を返す。
    /// </summary>
    /// <param name="str">任意の文字列</param>
    /// <returns>読み取りに成功した場合は PlaneAngle オブジェクト、読み取れなかった場合は null</returns>
    static public PlaneAngle ParseCommons( string str )
    {
      var m = RegexOfCommons.Match( str );
      if ( m == null )
        return null;
      // 値を処理
      var value = double.Parse( m.Groups[ "prefix" ].Value );
      // SI接頭辞があれば値へ適用
      if ( Unit.SI.MetricPrefix.Parse( m.Groups[ "prefix" ].Value ) is Unit.SI.MetricPrefix unit_prefix )
        value *= unit_prefix;
      // 負なら値へ適用
      if ( m.Groups[ "negative" ] != null )
        value *= -1;
      // 単位系から適切なファクトリーで生成
      if ( m.Groups[ "rad" ] != null )
        return FromRadians( value );
      if ( m.Groups[ "pts" ] != null )
        return FromRadians( value );
      if ( m.Groups[ "mils" ] != null )
        return FromRadians( value );
      if ( m.Groups[ "gradians" ] != null )
        return FromRadians( value );
      if ( m.Groups[ "turns" ] != null )
        return FromRadians( value );
      return null;
    }

    /// <summary>
    /// 度数法の整数 Degrees 成分、整数 Minutes 成分、実数 Seconds 成分により文字列化する。数値に加え、単位として SymbolOfDegrees, SymbolOfMinutes, SymbolOfDegrees が付く。
    /// ToStringDMS のプロクシー
    /// </summary>
    public string ToString( string format, IFormatProvider formatProvider ) { return ToStringInDMS( format ); }

    /// <summary>
    /// 平面角オブジェクトを比較
    /// 正規化せずに比較する。正規化が必要な場合は NormalizedCompareTo を使うとよい
    /// </summary>
    /// <param name="other">比較対象の平面角オブジェクト</param>
    /// <returns>this が小さければ -1, this==other なら 0, this が大きければ +1</returns>
    public int CompareTo( PlaneAngle other )
    {
      return
        ( other.InDegrees < InDegrees )
          ? -1
          : ( ( other.InDegrees > InDegrees )
              ? +1
              : 0
            )
        ;
    }

    /// <summary>
    /// this 自身を [ 0 ... 360 ) へ正規化する。正規化前の情報は失われる。
    /// </summary>
    /// <returns>this</returns>
    public PlaneAngle Normalize360()
    {
      if ( InDegrees < 0 )
        InDegrees = 360.0 - ( -InDegrees % 360.0 );
      else
        InDegrees %= 360.0;
      return this;
    }

    /// <summary>
    /// this 自身を [ -180 ... 180 ) へ正規化する。正規化前の情報は失われる。
    /// </summary>
    /// <returns>this</returns>
    public PlaneAngle Normalize180()
    {
      Normalize360();
      if ( InDegrees >= 180.0 )
        InDegrees -= 360.0;
      return this;
    }

    /// <summary>
    /// a を元に新たに [ 0 ... 360 ) へ正規化した平面角オブジェクトを生成するファクトリー
    /// </summary>
    /// <param name="a">元とする平面角オブジェクト。変更される事はない</param>
    /// <returns>新たに生成され正規化された平面角オブジェクト</returns>
    public static PlaneAngle Normalize360( PlaneAngle a ) { return new PlaneAngle( a ).Normalize360(); }
    /// <summary>
    /// a を元に新たに [ -180 ... 180 ) へ正規化した平面角オブジェクトを生成するファクトリー
    /// </summary>
    /// <param name="a">元とする平面角オブジェクト。変更される事はない</param>
    /// <returns>新たに生成され正規化された平面角オブジェクト</returns>
    public static PlaneAngle Normalize180( PlaneAngle a ) { return new PlaneAngle( a ).Normalize180(); }

    /// <summary>
    /// [0...360) deg へ正規化した場合の角度の比較を行います。
    /// 例: a=-30, b=60 が与えられた場合、 330 vs. 60 となり結果は false となります。
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int NormalizedCompareTo( PlaneAngle a ) { return Normalize360( this ).CompareTo( Normalize360( a ) ); }

    /// <summary>
    /// 正規化した場合の this &lt; a の判定
    /// </summary>
    public bool NormalizedLessThan( PlaneAngle a ) { return NormalizedCompareTo( a ) < 0; }
    /// <summary>
    /// 正規化した場合の this &gt; a の判定
    /// </summary>
    public bool NormalizedGreaterThan( PlaneAngle a ) { return NormalizedCompareTo( a ) > 0; }
    /// <summary>
    /// 正規化した場合の this == a の判定
    /// </summary>
    public bool NormalizedEqualsTo( PlaneAngle a ) { return NormalizedCompareTo( a ) == 0; }
    /// <summary>
    /// 正規化した場合の this ≃ a の判定
    /// </summary>
    public bool NormalizedNearlyEqualsTo( PlaneAngle a, PlaneAngle tolerance = null )
    { return NearlyEquals( Normalize360( this ), Normalize360( a ), tolerance != null ? Normalize360( tolerance ) : null ); }

    /// <summary>
    /// NearlyEquals( this, a tolerance ) への糖衣構文
    /// </summary>
    /// <param name="tolerance">許容範囲（誤差） null の場合は PlaneAngle.CentiSecond が代用される</param>
    public bool NearlyEqualsTo( PlaneAngle a, PlaneAngle tolerance = null )
    { return NearlyEquals( this, a, tolerance ); }

    /// <summary>
    /// a と b の差が tolerance 以下か判定する
    /// </summary>
    /// <param name="a">任意の平面角1つめ</param>
    /// <param name="b">任意の平面角2つめ</param>
    /// <param name="tolerance">許容範囲（誤差） null の場合は PlaneAngle.CentiSecond が代用される</param>
    /// <returns>a と b の差が tolerance 以下なら true 、そうでなければ false</returns>
    static public bool NearlyEquals( PlaneAngle a, PlaneAngle b, PlaneAngle tolerance = null )
    { return Calculation.NearlyEquals( a, b, tolerance ?? PlaneAngle.CentiSecond, ( p, q ) => p - q, ( p, q ) => p + q ); }

    /// <summary>
    /// 正規化せずに角度が等しいか判定する
    /// 正規化が必要な場合は NormalizedEquals を使うとよい
    /// </summary>
    public bool Equals( PlaneAngle other ) { return CompareTo( other ) == 0; }

    /// <summary>
    /// 正規化せずに角度が等しいか判定する
    /// 正規化が必要な場合は NormalizedEquals を使うとよい
    /// </summary>
    public override bool Equals( object obj ) { if ( obj is PlaneAngle a ) return Equals( a ); return false; }

    /// <summary>
    /// 正規化せずに角度が等しいか判定する
    /// 正規化が必要な場合は NormalizedEquals を使うとよい
    /// </summary>
    static public bool operator ==( PlaneAngle a, PlaneAngle b ) { return a.Equals( b ); }
    /// <summary>
    /// 正規化せずに角度が等しいか判定する
    /// 正規化が必要な場合は NormalizedNotEquals を使うとよい
    /// </summary>
    static public bool operator !=( PlaneAngle a, PlaneAngle b ) { return !( a == b ); }
    /// <summary>
    /// 正規化せずに角度が a &lt; b か判定する
    /// 正規化が必要な場合は NormalizedLessThan を使うとよい
    /// </summary>
    static public bool operator <( PlaneAngle a, PlaneAngle b ) { return a.CompareTo( b ) < 0; }
    /// <summary>
    /// 正規化せずに角度が a &gt; b か判定する
    /// 正規化が必要な場合は NormalizedGreaterThan を使うとよい
    /// </summary>
    static public bool operator >( PlaneAngle a, PlaneAngle b ) { return a.CompareTo( b ) > 0; }
    /// <summary>
    /// 正規化した場合に角度が a &lt; b か判定する
    /// </summary>
    static public bool NormalizedLessThan( PlaneAngle a, PlaneAngle b ) { return a.NormalizedLessThan( b ); }
    /// <summary>
    /// 正規化した場合に角度が a &gt; b か判定する
    /// </summary>
    static public bool NormalizedGreaterThan( PlaneAngle a, PlaneAngle b ) { return a.NormalizedGreaterThan( b ); }

    /// <summary>
    /// 符号を反転する単項演算子
    /// </summary>
    static public PlaneAngle operator -( PlaneAngle a ) { return FromDegrees( -a.InDegrees ); }
    /// <summary>
    /// 符号をどうもしない単項演算子
    /// </summary>
    static public PlaneAngle operator +( PlaneAngle a ) { return FromDegrees( a.InDegrees ); }
    /// <summary>
    /// 減算する2項演算子
    /// </summary>
    static public PlaneAngle operator -( PlaneAngle a, PlaneAngle b ) { return FromDegrees( a.InDegrees - b.InDegrees ); }
    /// <summary>
    /// 加算する2項演算子
    /// </summary>
    static public PlaneAngle operator +( PlaneAngle a, PlaneAngle b ) { return FromDegrees( a.InDegrees + b.InDegrees ); }
    /// <summary>
    /// 角度を無次元数により掛け算する2項演算子
    /// Note: 角度次元同士の掛け算は角度2乗次元の結果を生じるが PlaneAngle 型では取り扱いの範疇を超えるため実装していない。
    /// </summary>
    static public PlaneAngle operator *( PlaneAngle a, double b ) { return FromDegrees( a.InDegrees * b ); }
    /// <summary>
    /// 角度を無次元数により割り算する2項演算子
    /// Note: 角度次元同士の割り算は無次元の結果を生じるが PlaneAngle 型では取り扱いの範疇を超えるため実装していない。
    /// </summary>
    static public PlaneAngle operator /( PlaneAngle a, double b ) { return FromDegrees( a.InDegrees / b ); }
    /// <summary>
    /// 角度の剰余を計算する2項演算子
    /// Note: 実用上の有意性を考慮し、剰余については正規化した場合の結果を計算する
    /// </summary>
    static public PlaneAngle operator %( PlaneAngle a, PlaneAngle b )
    { return FromDegrees( Normalize360( a ).InDegrees % Normalize360( b ).InDegrees ); }

#if false // users will confusion in degrees and radians
    static public implicit operator double( Angle a ) { return a.InDegrees; }
#endif

    /// <summary>度数法の1度の平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle Degree { get { return FromDegrees( 1 ); } }
    /// <summary>度数法の1/10度の平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle DeciDegree { get { return FromDegrees( 1.0e-1 ); } }
    /// <summary>度数法の1/100度の平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle CentiDegree { get { return FromDegrees( 1.0e-2 ); } }
    /// <summary>度数法の1/1000度の平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle MilliDegree { get { return FromDegrees( 1.0e-3 ); } }

    /// <summary>度数法の1分の平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle Minute { get { return FromDegrees( 0, 1 ); } }
    /// <summary>度数法の1/10分の平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle DeciMinute { get { return FromDegrees( 0, 1.0e-1 ); } }
    /// <summary>度数法の1/100分の平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle CentiMinute { get { return FromDegrees( 0, 1.0e-2 ); } }
    /// <summary>度数法の1/1000分の平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle MilliMinute { get { return FromDegrees( 0, 1.0e-3 ); } }

    /// <summary>度数法の1秒の平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle Second { get { return FromDegrees( 0, 0, 1 ); } }
    /// <summary>度数法の1/10秒の平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle DeciSecond { get { return FromDegrees( 0, 0, 1.0e-1 ); } }
    /// <summary>度数法の1/100秒の平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle CentiSecond { get { return FromDegrees( 0, 0, 1.0e-2 ); } }
    /// <summary>度数法の1/1000秒の平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle MilliSecond { get { return FromDegrees( 0, 0, 1.0e-3 ); } }

    /// <summary>1ラジアンの平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle Radian { get { return FromRadians( 1 ); } }
    /// <summary>1ポイントの平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle Point { get { return FromPoints( 1 ); } }
    /// <summary>1ミルの平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle Mil { get { return FromMils( 1 ); } }
    /// <summary>1グラヂアンの平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle Gradian { get { return FromGradians( 1 ); } }
    /// <summary>1ターンの平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle Turn { get { return FromTurns( 1 ); } }

    /// <summary>角度0の平面角オブジェクトを得る糖衣構文</summary>
    static public PlaneAngle Zero { get { return new PlaneAngle(); } }

    /// <summary>
    /// 弧度法の Radians 量を度数法の Degrees 量へ変換
    /// </summary>
    /// <param name="radians">弧度法の Radians 量</param>
    /// <returns>度数法の Degrees 量</returns>
    static public double ToDegrees( double radians ) { return 180.0 * radians / Math.PI; }
    /// <summary>
    /// 度数法の Degrees 量を弧度法の Radians 量へ変換
    /// </summary>
    /// <param name="degrees">度数法の Degrees 量</param>
    /// <returns>弧度法の Radians 量</returns>
    static public double ToRadians( double degrees ) { return Math.PI * degrees / 180.0; }

    public override int GetHashCode() { return InDegrees.GetHashCode(); }
  }

  public class Length
    : IFormattable
    , IComparable<Length>
  {
    static public string SymbolOfMeters { get; set; } = "m";
    static public string SymbolOfInches { get; set; } = "in";
    static public string SymbolOfFeet { get; set; } = "ft";
    static public string SymbolOfYards { get; set; } = "yd";
    static public string SymbolOfMiles { get; set; } = "mi";
    static public string SymbolOfLines { get; set; } = "L";
    static public string SymbolOfPicas { get; set; } = "pc";
    static public string SymbolOfPoints { get; set; } = "pt";
    static public string SymbolOfShaku { get; set; } = "尺";
    static public string SymbolOfSun { get; set; } = "寸";
    static public string SymbolOfBu { get; set; } = "分";
    static public string SymbolOfMon { get; set; } = "文";
    static public string SymbolOfJou { get; set; } = "丈";
    static public string SymbolOfRi { get; set; } = "里";
    static public string SymbolOfKen { get; set; } = "間";
    static public string SymbolOfChou { get; set; } = "町";
    static public string SymbolOfHa { get; set; } = "歯";
    static public string SymbolOfKyuu { get; set; } = "級";
    static public string SymbolOfAngStrom { get; set; } = "Å";

    /// <summary>
    /// メートル単位の値の入出力プロパティー
    /// 唯一の値の実体を持ち、他の単位の扱いはすべてこのプロパティーの実体との変換により扱われる
    /// </summary>
    public double InMeters { get; set; }

    /// <summary>インチ</summary>
    public double InInches { get { return InMeters / ( 25.4 * Unit.SI.MetricPrefix._m ); } set { InMeters = value * ( 25.4 * Unit.SI.MetricPrefix._m ); } }

    /// <summary>サウ, サウザン</summary>
    public double InThou { get { return InMils; } set { InMils = value; } }
    /// <summary>ミル</summary>
    public double InMils { get { return InInches / 1_000; } set { InInches = value * 1_000; } }
    /// <summary>イングリッシュ・ライン, U.K. Lines, French Lines (ligne; L)</summary>
    public double InLines { get { return InInches / ( 1.0 / 12.0 ); } set { InInches = value * ( 1.0 / 12.0 ); } }
    /// <summary>パイカ, Pica(P, P/)</summary>
    public double InPicas { get { return InInches / ( 1.0 / 6.0 ); } set { InInches = value * ( 1.0 / 6.0 ); } }
    /// <summary>フレンチ・パイカ, French Pica</summary>
    public double InPicasFR { get { return InInches / 0.177; } set { InInches = value * 0.177; } }
    /// <summary>アメリカン・パイカ, ジョンソン・パイカ, U.S. Pica</summary>
    public double InPicasUS { get { return InMeters / ( 4.217_5 * Unit.SI.MetricPrefix._m ); } set { InMeters = value * ( 4.217_5 * Unit.SI.MetricPrefix._m ); } }
    /// <summary>ポイント, Points</summary>
    public double InPoints { get { return InInches / ( 1.0 / 72.0 ); } set { InInches = value * ( 1.0 / 72.0 ); } }
    /// <summary>アメリカン・ポイント, U.S. Points</summary>
    public double InPointsUS { get { return InPicasUS / ( 1.0 / 12.0 ); } set { InPicasUS = value * ( 1.0 / 12.0 ); } }
    /// <summary>フレンチ・ポイント, ディド・ポイント, Points</summary>
    public double InPointsFR { get { return InMeters / ( 0.375_9 * Unit.SI.MetricPrefix._m ); } set { InMeters = value * ( 0.375_9 * Unit.SI.MetricPrefix._m ); } }
    /// <summary>シセロ, cicero, cicéro</summary>
    public double InCiceros { get { return InPointsFR / 12; } set { InPointsFR = value * 12; } }

    /// <summary>国際フート, International foot</summary>
    public double InFeet { get { return InInches / 12; } set { InInches = value * 12; } }
    /// <summary>アメリカ・測量フート, U.S. survey foot</summary>
    public double InFeetUS { get { return InMeters / ( 1200.0 / 3937.0 ); } set { InMeters = value * ( 1200.0 / 3937.0 ); } }
    /// <summary>インド・測量フート, Indian survery foot</summary>
    public double InFeetIN { get { return InMeters / 0.304_799_514; } set { InMeters = value * 0.304_799_514; } }
    /// <summary>チェイン</summary>
    public double InChains { get { return InFeet / 66; } set { InFeet = value * 66; } }
    /// <summary>アメリカ・チェイン</summary>
    public double InChainsUS { get { return InFeetUS / 66; } set { InFeetUS = value * 66; } }
    /// <summary>ロッド</summary>
    public double InRods { get { return InChains / 4; } set { InChains = value * 4; } }
    /// <summary>アメリカ・ロッド</summary>
    public double InRodsUS { get { return InChainsUS / 4; } set { InChainsUS = value * 4; } }
    /// <summary>リンク</summary>
    public double InLinks { get { return InChains / 100; } set { InChains = value * 100; } }
    /// <summary>アメリカ・リンク</summary>
    public double InLinksUS { get { return InChainsUS / 100; } set { InChainsUS = value * 100; } }
    /// <summary>ハロン</summary>
    public double InFurlongs { get { return InChains / 0.1; } set { InChains = value * 0.1; } }
    /// <summary>アメリカ・ハロン</summary>
    public double InFurlongUS { get { return InChainsUS / 0.1; } set { InChainsUS = value * 0.1; } }
    /// <summary>ヤード</summary>
    public double InYards { get { return InFeet / 3; } set { InFeet = value * 3; } }
    /// <summary>マイル, International mile</summary>
    public double InMiles { get { return InYards / 1760; } set { InYards = value * 1760; } }
    /// <summary>アメリカ測量マイル, US survey mile</summary>
    public double InMilesUS { get { return InFeetUS / 5280; } set { InFeetUS = value * 5280; } }
    /// <summary>International nautical mile, 国際海里</summary>
    public double InMilesNautical { get { return InMeters / 1_852; } set { InMeters = value * 1_852; } }
    /// <summary>Geographical mile</summary>
    public double InMilesGeographical { get { return InMeters / 1_853; } set { InMeters = value * 1_853; } }
    /// <summary>イタリア・マイル, miglio</summary>
    public double InMilesIT { get { return InMeters / 1_000; } set { InMeters = value * 1_000; } }
    /// <summary>伝統イタリア・マイル, miglio</summary>
    public double InMilesITOld { get { return InMeters / 1_489; } set { InMeters = value * 1_489; } }
    /// <summary>古代イタリア・マイル, miglio</summary>
    public double InMilesITAncient { get { return InMeters / 2_226; } set { InMeters = value * 2_226; } }
    /// <summary>古代ローマ, milliarium</summary>
    public double InMilesRomanAncient { get { return InMeters / 1_480; } set { InMeters = value * 1_480; } }
    /// <summary>新制スペイン・マイル, milla</summary>
    public double InMilesES { get { return InMilesNautical; } set { InMilesNautical = value; } }
    /// <summary>旧制スペイン・マイル, milla</summary>
    public double InMilesESOld { get { return InMeters / 1_394; } set { InMeters = value * 1_394; } }
    /// <summary>アラビア・マイル, mille</summary>
    public double InMilesArabic { get { return InMeters / 1950; } set { InMeters = value * 1950; } }
    /// <summary>ドイツ・マイル, Meile</summary>
    public double InMilesDE { get { return InMeters / 7_532.5; } set { InMeters = value * 7_532.5; } }
    /// <summary>オーストリア・マイル</summary>
    public double InMilesAT { get { return InMeters / 7_585.935_360; } set { InMeters = value * 7_585.935_360; } }
    /// <summary>ノルウェー・マイル, スウェーデン・マイル, mil</summary>
    public double InMilesNOSE { get { return InMeters / 10_000; } set { InMeters = value * 10_000; } }
    /// <summary>伝統ノルウェー・マイル, 伝統スウェーデン・マイル, mil</summary>
    public double InMilesNOSEOld { get { return InMeters / 11_000; } set { InMeters = value * 11_000; } }
    /// <summary>メートルマイル, metric mile</summary>
    public double InMilesMetric { get { return InMeters / 1500; } set { InMeters = value * 1500; } }
    /// <summary>アイルランド・マイル</summary>
    public double InMilesIE { get { return InYards / 2240; } set { InYards = value * 2240; } }
    /// <summary>Fathom 海の深さに使われる</summary>
    public double InFathom { get { return InFeet / 6; } set { InFeet = value * 6; } }

    /// <summary>日本の曲尺（かねじゃく）, Shaku</summary>
    public double InShakuJP { get { return InMeters / ( 1.0 / 33.0 ); } set { InMeters = value * ( 1.0 / 33.0 ); } }
    /// <summary>日本の鯨尺（くじらじゃく）</summary>
    public double InShakuJPKujira { get { return InShakuJP / 1.25; } set { InShakuJP = value * 1.25; } }
    /// <summary>日本の呉服尺、鯨尺の亜種</summary>
    public double InShakuJPGofuku { get { return _cm / 36.4; } set { _cm = value * 36.4; } }
    /// <summary>日本の折衷尺、伊能忠敬の又四郎と享保尺の平均尺、明示度量衡取締法における曲尺</summary>
    public double InShakuJPSecchu { get { return _cm / 30.304; } set { _cm = value * 30.304; } }
    /// <summary>日本の享保尺、竹尺、徳川吉宗が紀州熊野神社の古尺を写して天体観測に用いたらしい</summary>
    public double InShakuJPKyouhou { get { return _cm / 30.363; } set { _cm = value * 30.363; } }
    /// <summary>日本の又四郎尺、永正の京都の指物師の又四郎さんが作って大工に使われたらしい</summary>
    public double InShakuJPMatashirou { get { return _cm / 30.258; } set { _cm = value * 30.258; } }
    /// <summary>日本の大宝律令の小尺、唐尺に由来し、平安時代のスタンダードらしい</summary>
    public double InShakuJPTaihouGreater { get { return _cm / 29.6; } set { _cm = value * 29.6; } }
    /// <summary>日本の大宝律令の大尺、高麗尺に由来し、土地の測量に使われたらしい</summary>
    public double InShakuJPTaihouLesser { get { return _cm / 35.6; } set { _cm = value * 35.6; } }

    /// <summary>中国の市制（伝統単位の国際単位系による再定義系）の尺</summary>
    public double InShakuCN { get { return InMeters / ( 1.0 / 3.0 ); } set { InMeters = value * ( 1.0 / 3.0 ); } }
    /// <summary>中国の古代の唐(Táng; 西暦[618...907)年)王朝で使われていた小尺</summary>
    public double InShakuCNTangLesser { get { return _cm / 23.09; } set { _cm = value * 23.09; } }
    /// <summary>中国の古代の唐(Táng; 西暦[618...907)年)王朝で使われていた大尺</summary>
    public double InShakuCNTangGreater { get { return _cm / 29.4; } set { _cm = value * 29.4; } }
    /// <summary>中国の古代の隋(Suí; 西暦[581...618)年)王朝で使われていた小尺</summary>
    public double InShakuCNSuiLesser { get { return _cm / 24.6; } set { _cm = value * 24.6; } }
    /// <summary>中国の古代の隋(Suí; 西暦[581...618)年)王朝で使われていた大尺</summary>
    public double InShakuCNSuiGreater { get { return _cm / 29.4; } set { _cm = value * 29.4; } }
    /// <summary>中国の古代の唐(Hàn; 西暦[-206...8, 25...220)年)王朝で使われていた尺</summary>
    public double InShakuCNHan { get { return _cm / 23.09; } set { _cm = value * 23.09; } }

    /// <summary>寸（すん）、平安の「す」、古代の「き」、日本の尺の1/10</summary>
    public double InSun { get { return InShakuJP / 0.1; } set { InShakuJP = value * 0.1; } }
    /// <summary>分（ぶ）、日本の寸の1/10</summary>
    public double InBu { get { return InSun / 0.1; } set { InSun = value * 0.1; } }
    /// <summary>文（もん）、日本の古代の貨幣の直径が転じて長さの単位となった</summary>
    public double InMon { get { return _cm / 2.4; } set { _cm = value * 2.4; } }
    /// <summary>丈</summary>
    public double InJouJP { get { return InShakuJP / 10; } set { InShakuJP = value * 10; } }
    /// <summary>間</summary>
    public double InKen { get { return InShakuJP / 6; } set { InShakuJP = value * 6; } }
    /// <summary>町</summary>
    public double InChou { get { return InKen / 60; } set { InKen = value * 60; } }
    /// <summary>里（日本）</summary>
    public double InRiJP { get { return InChou / 36; } set { InChou = value * 36; } }
    /// <summary>里（中国、市制）</summary>
    public double InRiCN { get { return InMeters / 500; } set { InMeters = value * 500; } }

    /// <summary>歯、H、日本の印刷業界単位</summary>
    public double InHa { get { return _mm / 0.25; } set { _mm = value * 0.25; } }
    /// <summary>級、Q、日本の印刷業界単位</summary>
    public double InKyuu { get { return _mm / 0.25; } set { _mm = value * 0.25; } }

    /// <summary>フレンチカテーテルスケール、シャリエルスケール、フランスゲージ 主に医療現場で使われる</summary>
    public double InFrenchCatheterScale { get { return _mm / ( 1.0 / 3.0 ); } set { _mm = value * ( 1.0 / 3.0 ); } }

    /// <summary>フェルミ</summary>
    public double InFermi { get { return InMeters / Unit.SI.MetricPrefix._f; } set { InMeters = value * Unit.SI.MetricPrefix._f; } }
    /// <summary>オングストローム</summary>
    public double InAngStrom { get { return InMeters / ( 100 * Unit.SI.MetricPrefix._p ); } set { InMeters = value * ( 100 * Unit.SI.MetricPrefix._p ); } }
    /// <summary>ミクロン</summary>
    public double InMicron { get { return InMeters / Unit.SI.MetricPrefix._u; } set { InMeters = value * Unit.SI.MetricPrefix._u; } }
    /// <summary>X線単位, xu</summary>
    public double InXUnit { get { return InMeters / ( 100.21 * Unit.SI.MetricPrefix._f ); } set { InMeters = value * ( 100.21 * Unit.SI.MetricPrefix._f ); } }
    /// <summary>天文単位, au</summary>
    public double InAstronomicalUnit { get { return InMeters / 149_597_870_700; } set { InMeters = value * 149_597_870_700; } }
    /// <summary>光年, ly, light year</summary>
    public double InLightYear { get { return InMeters / 9_460_730_472_580_800; } set { InMeters = value * 9_460_730_472_580_800; } }
    /// <summary>パーセク, pc, parallax second</summary>
    public double InParsec { get { return InMeters / ( 648_000 / Math.PI ); } set { InAstronomicalUnit = value * ( 648_000 / Math.PI ); } }
    /// <summary>アット・パーセク, apc</summary>
    public double InAttoParsec { get { return InParsec / Unit.SI.MetricPrefix._a; } set { InAstronomicalUnit = value * Unit.SI.MetricPrefix._a; } }

    /// <summary>インチの入出力プロパティー糖衣構文</summary>
    public double _in { get { return InInches; } set { InInches = value; } }
    /// <summary>ヤードの入出力プロパティー糖衣構文</summary>
    public double _yd { get { return InYards; } set { InYards = value; } }
    /// <summary>フートの入出力プロパティー糖衣構文</summary>
    public double _ft { get { return InFeet; } set { InFeet = value; } }
    /// <summary>マイルの入出力プロパティー糖衣構文</summary>
    public double _mi { get { return InMiles; } set { InMiles = value; } }
    /// <summary>ミルの入出力プロパティー糖衣構文</summary>
    public double _mil { get { return InMils; } set { InMils = value; } }

    /// <summary>ラインの入出力プロパティー糖衣構文</summary>
    public double _L { get { return InLines; } set { InLines = value; } }
    /// <summary>パイカの入出力プロパティー糖衣構文</summary>
    public double _pica { get { return InPicas; } set { InPicas = value; } }
    /// <summary>ポイントの入出力プロパティー糖衣構文</summary>
    public double _pt { get { return InPoints; } set { InPoints = value; } }

    /// <summary>尺（日本）の入出力プロパティー糖衣構文</summary>
    public double _ShakuJP { get { return InShakuJP; } set { InShakuJP = value; } }
    public double _尺JP { get { return InShakuJP; } set { InShakuJP = value; } }
    /// <summary>尺（中国）の入出力プロパティー糖衣構文</summary>
    public double _ShakuCN { get { return InShakuCN; } set { InShakuCN = value; } }
    public double _尺CN { get { return InShakuCN; } set { InShakuCN = value; } }
    /// <summary>寸の入出力プロパティー糖衣構文</summary>
    public double _Sun { get { return InSun; } set { InSun = value; } }
    public double _寸 { get { return InSun; } set { InSun = value; } }
    /// <summary>分の入出力プロパティー糖衣構文</summary>
    public double _Bu { get { return InBu; } set { InBu = value; } }
    public double _分 { get { return InBu; } set { InBu = value; } }
    /// <summary>文の入出力プロパティー糖衣構文</summary>
    public double _Mon { get { return InMon; } set { InMon = value; } }
    public double _文 { get { return InMon; } set { InMon = value; } }
    /// <summary>丈の入出力プロパティー糖衣構文</summary>
    public double _Jou { get { return InJouJP; } set { InJouJP = value; } }
    public double _丈 { get { return InJouJP; } set { InJouJP = value; } }
    /// <summary>間の入出力プロパティー糖衣構文</summary>
    public double _Ken { get { return InKen; } set { InKen = value; } }
    public double _間 { get { return InKen; } set { InKen = value; } }
    /// <summary>町の入出力プロパティー糖衣構文</summary>
    public double _Chou { get { return InChou; } set { InChou = value; } }
    public double _町 { get { return InChou; } set { InChou = value; } }
    /// <summary>里（日本）の入出力プロパティー糖衣構文</summary>
    public double _RiJP { get { return InRiJP; } set { InRiJP = value; } }
    public double _里JP { get { return InRiJP; } set { InRiJP = value; } }
    /// <summary>里（中国）の入出力プロパティー糖衣構文</summary>
    public double _RiCN { get { return InRiCN; } set { InRiCN = value; } }
    public double _里CN { get { return InRiCN; } set { InRiCN = value; } }

    /// <summary>歯の入出力プロパティー糖衣構文</summary>
    public double _歯 { get { return _H; } set { _H = value; } }
    /// <summary>歯の入出力プロパティー糖衣構文</summary>
    public double _H { get { return InHa; } set { InHa = value; } }
    /// <summary>級の入出力プロパティー糖衣構文</summary>
    public double _級 { get { return _Q; } set { _Q = value; } }
    /// <summary>級の入出力プロパティー糖衣構文</summary>
    public double _Q { get { return InKyuu; } set { InKyuu = value; } }

    /// <summary>オングストロームの入出力プロパティー糖衣構文</summary>
    public double _Å { get { return InAngStrom; } set { InAngStrom = value; } }
    /// <summary>オングストロームの入出力プロパティー糖衣構文</summary>
    public double _AngStrom { get { return InAngStrom; } set { InAngStrom = value; } }
    /// <summary>ミクロンの入出力プロパティー糖衣構文</summary>
    public double _micron { get { return InMicron; } set { InMicron = value; } }
    /// <summary>X線単位の入出力プロパティー糖衣構文</summary>
    public double _xu { get { return InXUnit; } set { InXUnit = value; } }
    /// <summary>天文単位の入出力プロパティー糖衣構文</summary>
    public double _au { get { return InAstronomicalUnit; } set { InAstronomicalUnit = value; } }
    /// <summary>光年の入出力プロパティー糖衣構文</summary>
    public double _ly { get { return InLightYear; } set { InLightYear = value; } }
    /// <summary>パーセクの入出力プロパティー糖衣構文</summary>
    public double _pc { get { return InParsec; } set { InParsec = value; } }
    /// <summary>アット・パーセクの入出力プロパティー糖衣構文</summary>
    public double _apc { get { return InAttoParsec; } set { InAttoParsec = value; } }

    /// <summary>フレンチ・カテーテル・スケール</summary>
    public double _Fr { get { return InFrenchCatheterScale; } set { InFrenchCatheterScale = value; } }

    /// <summary>ヨッタ・メートル入出力プロパティー</summary>
    public double _Ym { get { return InMeters / Unit.SI.MetricPrefix._Y; } set { InMeters = value * Unit.SI.MetricPrefix._Y; } }
    /// <summary>ゼッタ・メートル入出力プロパティー</summary>
    public double _Zm { get { return InMeters / Unit.SI.MetricPrefix._Z; } set { InMeters = value * Unit.SI.MetricPrefix._Z; } }
    /// <summary>エクサ・メートル入出力プロパティー</summary>
    public double _Em { get { return InMeters / Unit.SI.MetricPrefix._E; } set { InMeters = value * Unit.SI.MetricPrefix._E; } }
    /// <summary>ペタ・メートル入出力プロパティー</summary>
    public double _Pm { get { return InMeters / Unit.SI.MetricPrefix._P; } set { InMeters = value * Unit.SI.MetricPrefix._P; } }
    /// <summary>テラ・メートル入出力プロパティー</summary>
    public double _Tm { get { return InMeters / Unit.SI.MetricPrefix._T; } set { InMeters = value * Unit.SI.MetricPrefix._T; } }
    /// <summary>ギガ・メートル入出力プロパティー</summary>
    public double _Gm { get { return InMeters / Unit.SI.MetricPrefix._G; } set { InMeters = value * Unit.SI.MetricPrefix._G; } }
    /// <summary>メガ・メートル入出力プロパティー</summary>
    public double _Mm { get { return InMeters / Unit.SI.MetricPrefix._M; } set { InMeters = value * Unit.SI.MetricPrefix._M; } }
    /// <summary>キロ・メートル入出力プロパティー</summary>
    public double _km { get { return InMeters / Unit.SI.MetricPrefix._k; } set { InMeters = value * Unit.SI.MetricPrefix._k; } }
    /// <summary>ヘクト・メートル入出力プロパティー</summary>
    public double _hm { get { return InMeters / Unit.SI.MetricPrefix._h; } set { InMeters = value * Unit.SI.MetricPrefix._h; } }
    /// <summary>デカ・・メートル入出力プロパティー</summary>
    public double _dam { get { return InMeters / Unit.SI.MetricPrefix._da; } set { InMeters = value * Unit.SI.MetricPrefix._da; } }
    /// <summary>メートル入出力プロパティー糖衣構文</summary>
    public double _m { get { return InMeters; } set { InMeters = value; } }
    /// <summary>デシ・メートル入出力プロパティー</summary>
    public double _dm { get { return InMeters / Unit.SI.MetricPrefix._d; } set { InMeters = value * Unit.SI.MetricPrefix._d; } }
    /// <summary>センチ・メートル入出力プロパティー</summary>
    public double _cm { get { return InMeters / Unit.SI.MetricPrefix._c; } set { InMeters = value * Unit.SI.MetricPrefix._c; } }
    /// <summary>ミリ・メートル入出力プロパティー</summary>
    public double _mm { get { return InMeters / Unit.SI.MetricPrefix._m; } set { InMeters = value * Unit.SI.MetricPrefix._m; } }
    /// <summary>マイクロ・メートル入出力プロパティー</summary>
    public double _μm { get { return InMeters / Unit.SI.MetricPrefix._u; } set { InMeters = value * Unit.SI.MetricPrefix._u; } }
    /// <summary>マイクロ・メートル入出力プロパティー</summary>
    public double _um { get { return InMeters / Unit.SI.MetricPrefix._u; } set { InMeters = value * Unit.SI.MetricPrefix._u; } }
    /// <summary>ナノ・メートル入出力プロパティー</summary>
    public double _nm { get { return InMeters / Unit.SI.MetricPrefix._n; } set { InMeters = value * Unit.SI.MetricPrefix._n; } }
    /// <summary>ピコ・メートル入出力プロパティー</summary>
    public double _pm { get { return InMeters / Unit.SI.MetricPrefix._p; } set { InMeters = value * Unit.SI.MetricPrefix._p; } }
    /// <summary>フェムト・メートル入出力プロパティー</summary>
    public double _fm { get { return InMeters / Unit.SI.MetricPrefix._f; } set { InMeters = value * Unit.SI.MetricPrefix._f; } }
    /// <summary>アット・メートル入出力プロパティー</summary>
    public double _am { get { return InMeters / Unit.SI.MetricPrefix._a; } set { InMeters = value * Unit.SI.MetricPrefix._a; } }
    /// <summary>ゼプト・メートル入出力プロパティー</summary>
    public double _zm { get { return InMeters / Unit.SI.MetricPrefix._z; } set { InMeters = value * Unit.SI.MetricPrefix._z; } }
    /// <summary>ヨクト・メートル入出力プロパティー</summary>
    public double _ym { get { return InMeters / Unit.SI.MetricPrefix._y; } set { InMeters = value * Unit.SI.MetricPrefix._y; } }

    static public Length Zero { get { return new Length(); } }

    public string ToString( string format, IFormatProvider formatProvider ) { return ToStringInMeters( format ); }

    public string ToStringInInches( string format ) { return $"{InInches.ToString( format )}{SymbolOfInches}"; }
    public string ToStringInFeet( string format ) { return $"{InFeet.ToString( format )}{SymbolOfFeet}"; }
    public string ToStringInYards( string format ) { return $"{InYards.ToString( format )}{SymbolOfYards}"; }
    public string ToStringInMiles( string format ) { return $"{InMiles.ToString( format )}{SymbolOfMiles}"; }
    public string ToStringInLines( string format ) { return $"{InLines.ToString( format )}{SymbolOfPicas}"; }
    public string ToStringInPicas( string format ) { return $"{InPicas.ToString( format )}{SymbolOfPoints}"; }
    public string ToStringInPoints( string format ) { return $"{InPoints.ToString( format )}{SymbolOfShaku}"; }
    public string ToStringInShaku( string format ) { return $"{InShakuJP.ToString( format )}{SymbolOfSun}"; }
    public string ToStringInSun( string format ) { return $"{InSun.ToString( format )}{SymbolOfSun}"; }
    public string ToStringInBu( string format ) { return $"{InBu.ToString( format )}{SymbolOfBu}"; }
    public string ToStringInMon( string format ) { return $"{InMon.ToString( format )}{SymbolOfMon}"; }
    public string ToStringInJou( string format ) { return $"{InJouJP.ToString( format )}{SymbolOfJou}"; }
    public string ToStringInRi( string format ) { return $"{InRiJP.ToString( format )}{SymbolOfRi}"; }
    public string ToStringInKen( string format ) { return $"{InKen.ToString( format )}{SymbolOfKen}"; }
    public string ToStringInChou( string format ) { return $"{InChou.ToString( format )}{SymbolOfChou}"; }
    public string ToStringInHa( string format ) { return $"{InHa.ToString( format )}{SymbolOfHa}"; }
    public string ToStringInKyuu( string format ) { return $"{InKyuu.ToString( format )}{SymbolOfKyuu}"; }
    public string ToStringInAngStrom( string format ) { return $"{InAngStrom.ToString( format )}{SymbolOfAngStrom}"; }

    public string ToStringInMeters( string format = "F2" ) { return $"{_m.ToString( format )}{SymbolOfMeters}"; }

    public string ToString_Mm( string format = "F2" ) { var p = Unit.SI.MetricPrefix._M; return $"{( _m * p ).ToString( format )}{p}{SymbolOfMeters}"; }
    public string ToString_km( string format = "F2" ) { return $"{_m.ToString( format )}{SymbolOfMeters}"; }
    public string ToString_m( string format = "F2" ) { return ToStringInMeters( format ); }
    public string ToString_cm( string format = "F2" ) { return $"{_m.ToString( format )}{SymbolOfMeters}"; }
    public string ToString_mm( string format = "F2" ) { return $"{_m.ToString( format )}{SymbolOfMeters}"; }
    public string ToString_μm( string format = "F2" ) { return $"{_m.ToString( format )}{SymbolOfMeters}"; }
    public string ToString_um( string format = "F2" ) { return $"{_m.ToString( format )}{SymbolOfMeters}"; }
    public string ToString_nm( string format = "F2" ) { return $"{_m.ToString( format )}{SymbolOfMeters}"; }

    static public Length From_Ym( double v ) { return new Length() { _Ym = v }; }
    static public Length From_Zm( double v ) { return new Length() { _Zm = v }; }
    static public Length From_Em( double v ) { return new Length() { _Em = v }; }
    static public Length From_Pm( double v ) { return new Length() { _Pm = v }; }
    static public Length From_Tm( double v ) { return new Length() { _Tm = v }; }
    static public Length From_Gm( double v ) { return new Length() { _Gm = v }; }
    static public Length From_Mm( double v ) { return new Length() { _Mm = v }; }
    static public Length From_km( double v ) { return new Length() { _km = v }; }
    static public Length From_hm( double v ) { return new Length() { _hm = v }; }
    static public Length From_dam( double v ) { return new Length() { _dam = v }; }
    static public Length From_m( double v ) { return new Length() { _m = v }; }
    static public Length From_dm( double v ) { return new Length() { _dm = v }; }
    static public Length From_cm( double v ) { return new Length() { _cm = v }; }
    static public Length From_mm( double v ) { return new Length() { _mm = v }; }
    static public Length From_μm( double v ) { return new Length() { _um = v }; }
    static public Length From_um( double v ) { return new Length() { _um = v }; }
    static public Length From_nm( double v ) { return new Length() { _nm = v }; }
    static public Length From_pm( double v ) { return new Length() { _pm = v }; }
    static public Length From_fm( double v ) { return new Length() { _fm = v }; }
    static public Length From_am( double v ) { return new Length() { _am = v }; }
    static public Length From_zm( double v ) { return new Length() { _zm = v }; }
    static public Length From_ym( double v ) { return new Length() { _ym = v }; }

    static public Length From_in( double v ) { return new Length() { _in = v }; }
    static public Length From_ft( double v ) { return new Length() { _ft = v }; }
    static public Length From_yd( double v ) { return new Length() { _yd = v }; }
    static public Length From_mi( double v ) { return new Length() { _mi = v }; }
    static public Length From_mil( double v ) { return new Length() { _mil = v }; }
    static public Length From_L( double v ) { return new Length() { _L = v }; }
    static public Length From_pica( double v ) { return new Length() { _pica = v }; }
    static public Length From_pt( double v ) { return new Length() { _pt = v }; }
    static public Length From_ShakuJP( double v ) { return new Length() { _ShakuJP = v }; }
    static public Length From_尺JP( double v ) { return new Length() { _ShakuJP = v }; }
    static public Length From_ShakuCN( double v ) { return new Length() { _ShakuCN = v }; }
    static public Length From_尺CN( double v ) { return new Length() { _ShakuCN = v }; }
    static public Length From_Sun( double v ) { return new Length() { _Sun = v }; }
    static public Length From_寸( double v ) { return new Length() { _Sun = v }; }
    static public Length From_Bu( double v ) { return new Length() { _Bu = v }; }
    static public Length From_分( double v ) { return new Length() { _Bu = v }; }
    static public Length From_Mon( double v ) { return new Length() { _Mon = v }; }
    static public Length From_文( double v ) { return new Length() { _Mon = v }; }
    static public Length From_Jou( double v ) { return new Length() { _Jou = v }; }
    static public Length From_丈( double v ) { return new Length() { _Jou = v }; }
    static public Length From_Ken( double v ) { return new Length() { _Ken = v }; }
    static public Length From_間( double v ) { return new Length() { _Ken = v }; }
    static public Length From_Chou( double v ) { return new Length() { _Chou = v }; }
    static public Length From_町( double v ) { return new Length() { _Chou = v }; }
    static public Length From_RiJP( double v ) { return new Length() { _RiJP = v }; }
    static public Length From_里JP( double v ) { return new Length() { _RiJP = v }; }
    static public Length From_RiCN( double v ) { return new Length() { _RiCN = v }; }
    static public Length From_里CN( double v ) { return new Length() { _RiCN = v }; }
    static public Length From_H( double v ) { return new Length() { _H = v }; }
    static public Length From_歯( double v ) { return new Length() { _H = v }; }
    static public Length From_Q( double v ) { return new Length() { _Q = v }; }
    static public Length From_級( double v ) { return new Length() { _Q = v }; }
    static public Length From_AngStrom( double v ) { return new Length() { _AngStrom = v }; }
    static public Length From_Å( double v ) { return new Length() { _AngStrom = v }; }
    static public Length From_xu( double v ) { return new Length() { _xu = v }; }
    static public Length From_au( double v ) { return new Length() { _au = v }; }
    static public Length From_ly( double v ) { return new Length() { _ly = v }; }
    static public Length From_pc( double v ) { return new Length() { _pc = v }; }
    static public Length From_apc( double v ) { return new Length() { _apc = v }; }
    static public Length From_Fr( double v ) { return new Length() { _Fr = v }; }

    public int CompareTo( Length other ) { return _m.CompareTo( other._m ); }
  }
  
  /// <summary>
  /// 経緯度
  /// 経度と緯度を平面角オブジェクトでシンプルに持つ
  /// </summary>
  public class LonLat
  {
    public PlaneAngle Longitude { get; set; } = PlaneAngle.Zero;
    public PlaneAngle Latitude { get; set; } = PlaneAngle.Zero;

    virtual public GeoCoordinate ToGeoCoordinate()
    { return new GeoCoordinate( Latitude.InDegrees, Longitude.InDegrees ); }

    static public LonLat FromGeoCoordinate( GeoCoordinate a )
    { return new LonLat() { Longitude = PlaneAngle.FromDegrees( a.Longitude ), Latitude = PlaneAngle.FromDegrees( a.Latitude ) }; }
  }

  /// <summary>
  /// 経緯度＋標高
  /// LonLat の派生で長さオブジェクトの標高を追加で持つ
  /// </summary>
  public class LonLatAlt
    : LonLat
  {
    public Length Altitude { get; set; } = Length.Zero;

    override public GeoCoordinate ToGeoCoordinate()
    { return new GeoCoordinate( Latitude.InDegrees, Longitude.InDegrees, Altitude.InMeters ); }

    new static public LonLat FromGeoCoordinate( GeoCoordinate a )
    { return new LonLatAlt() { Longitude = PlaneAngle.FromDegrees( a.Longitude ), Latitude = PlaneAngle.FromDegrees( a.Latitude ), Altitude = Length.From_m( a.Altitude ) }; }
  }
}
