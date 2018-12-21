using System;
using System.Text.RegularExpressions;

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
    public int PartOfMinutes { get { return Math.Sign( InDegrees ) * ( (int)Math.Floor( Math.Abs( InMinutes ) ) % 60 ); } set { InDegrees = PartOfSeconds / 60.0 / 60.0 + value / 60.0 + PartOfDegrees; } }
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
    public string ToStringInDMS( string seconds_format = "F2" ) { return $"{PartOfDegrees}{SymbolOfDegrees}{Math.Abs( PartOfMinutes )}{SymbolOfMinutes}{Math.Abs( PartOfSeconds ).ToString( seconds_format )}{SymbolOfSeconds}"; }
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
    /// ToStringInDMS のプロクシー
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
        ( InDegrees < other.InDegrees )
          ? -1
          : ( ( InDegrees > other.InDegrees )
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
    {
      PlaneAngle aa, bb;
      aa = Normalize180( this );
      if ( Math.Abs( aa._deg ) < 90 )
        bb = Normalize180( a );
      else
      {
        aa = Normalize360( this );
        bb = Normalize360( a );
      }

      return 
        NearlyEquals
        ( aa
        , bb
        , tolerance != null ? Normalize360( tolerance ) : null
        );
    }

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
    public bool Equals( PlaneAngle other )
    {
      return CompareTo( other ) == 0;
    }

    /// <summary>
    /// 正規化せずに角度が等しいか判定する
    /// 正規化が必要な場合は NormalizedEquals を使うとよい
    /// </summary>
    public override bool Equals( object obj )
    {
      if ( obj is PlaneAngle a )
        return Equals( a );
      return false;
    }

    /// <summary>
    /// 正規化せずに角度が等しいか判定する
    /// 正規化が必要な場合は NormalizedEquals を使うとよい
    /// </summary>
    static public bool operator ==( PlaneAngle a, PlaneAngle b )
    {
      // a, b は共に null ではない -> a.Equals(b) -> a.CompareTo(b)==0
      if ( a is PlaneAngle && b is PlaneAngle )
        return a.Equals( b );
      // a, b の何れか一方だけが null
      if ( a is PlaneAngle || b is PlaneAngle )
        return false;
      // a, b は共に null
      return true;
    }
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
}
