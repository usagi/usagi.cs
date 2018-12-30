using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usagi.Quantity
{
  /// <summary>
  /// 平面角オブジェクト
  /// <para/>内部表現は double による meters 表現
  /// </summary>
  public class Length
    : IFormattable
    , IComparable<Length>
  {
    /// <summary>メートルに使う単位記号</summary>
    static public string SymbolOfMeters { get; set; } = "m";
    /// <summary>インチに使う単位記号</summary>
    static public string SymbolOfInches { get; set; } = "in";
    /// <summary>フィートに使う単位記号</summary>
    static public string SymbolOfFeet { get; set; } = "ft";
    /// <summary>ヤードに使う単位記号</summary>
    static public string SymbolOfYards { get; set; } = "yd";
    /// <summary>マイルに使う単位記号</summary>
    static public string SymbolOfMiles { get; set; } = "mi";
    /// <summary>ラインに使う単位記号</summary>
    static public string SymbolOfLines { get; set; } = "L";
    /// <summary>パイカに使う単位記号</summary>
    static public string SymbolOfPicas { get; set; } = "pc";
    /// <summary>ポイントに使う単位記号</summary>
    static public string SymbolOfPoints { get; set; } = "pt";
    /// <summary>尺に使う単位記号</summary>
    static public string SymbolOfShaku { get; set; } = "尺";
    /// <summary>寸に使う単位記号</summary>
    static public string SymbolOfSun { get; set; } = "寸";
    /// <summary>分に使う単位記号</summary>
    static public string SymbolOfBu { get; set; } = "分";
    /// <summary>文に使う単位記号</summary>
    static public string SymbolOfMon { get; set; } = "文";
    /// <summary>丈に使う単位記号</summary>
    static public string SymbolOfJou { get; set; } = "丈";
    /// <summary>里に使う単位記号</summary>
    static public string SymbolOfRi { get; set; } = "里";
    /// <summary>間に使う単位記号</summary>
    static public string SymbolOfKen { get; set; } = "間";
    /// <summary>町に使う単位記号</summary>
    static public string SymbolOfChou { get; set; } = "町";
    /// <summary>歯に使う単位記号</summary>
    static public string SymbolOfHa { get; set; } = "歯";
    /// <summary>級に使う単位記号</summary>
    static public string SymbolOfKyuu { get; set; } = "級";
    /// <summary>オングストロームに使う単位記号</summary>
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
    /// <summary>尺（日本）の入出力プロパティー糖衣構文</summary>
    public double _尺JP { get { return InShakuJP; } set { InShakuJP = value; } }
    /// <summary>尺（中国）の入出力プロパティー糖衣構文</summary>
    public double _ShakuCN { get { return InShakuCN; } set { InShakuCN = value; } }
    /// <summary>尺（中国）の入出力プロパティー糖衣構文</summary>
    public double _尺CN { get { return InShakuCN; } set { InShakuCN = value; } }
    /// <summary>寸の入出力プロパティー糖衣構文</summary>
    public double _Sun { get { return InSun; } set { InSun = value; } }
    /// <summary>寸の入出力プロパティー糖衣構文</summary>
    public double _寸 { get { return InSun; } set { InSun = value; } }
    /// <summary>分の入出力プロパティー糖衣構文</summary>
    public double _Bu { get { return InBu; } set { InBu = value; } }
    /// <summary>分の入出力プロパティー糖衣構文</summary>
    public double _分 { get { return InBu; } set { InBu = value; } }
    /// <summary>文の入出力プロパティー糖衣構文</summary>
    public double _Mon { get { return InMon; } set { InMon = value; } }
    /// <summary>文の入出力プロパティー糖衣構文</summary>
    public double _文 { get { return InMon; } set { InMon = value; } }
    /// <summary>丈の入出力プロパティー糖衣構文</summary>
    public double _Jou { get { return InJouJP; } set { InJouJP = value; } }
    /// <summary>丈の入出力プロパティー糖衣構文</summary>
    public double _丈 { get { return InJouJP; } set { InJouJP = value; } }
    /// <summary>間の入出力プロパティー糖衣構文</summary>
    public double _Ken { get { return InKen; } set { InKen = value; } }
    /// <summary>間の入出力プロパティー糖衣構文</summary>
    public double _間 { get { return InKen; } set { InKen = value; } }
    /// <summary>町の入出力プロパティー糖衣構文</summary>
    public double _Chou { get { return InChou; } set { InChou = value; } }
    /// <summary>町の入出力プロパティー糖衣構文</summary>
    public double _町 { get { return InChou; } set { InChou = value; } }
    /// <summary>里（日本）の入出力プロパティー糖衣構文</summary>
    public double _RiJP { get { return InRiJP; } set { InRiJP = value; } }
    /// <summary>里（日本）の入出力プロパティー糖衣構文</summary>
    public double _里JP { get { return InRiJP; } set { InRiJP = value; } }
    /// <summary>里（中国）の入出力プロパティー糖衣構文</summary>
    public double _RiCN { get { return InRiCN; } set { InRiCN = value; } }
    /// <summary>里（中国）の入出力プロパティー糖衣構文</summary>
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

    /// <summary>
    /// 0 値
    /// </summary>
    static public Length Zero { get { return new Length(); } }

    /// <summary>
    /// 1 m
    /// </summary>
    static public Length Meter { get { return From_m( 1 ); } }

    /// <summary>
    /// 1 in
    /// </summary>
    static public Length Inch { get { return From_in( 1 ); } }

    /// <summary>NaN な平面角オブジェクトを得る糖衣構文</summary>
    static public Length NaN { get { return From_m( double.NaN ); } }

    /// <summary>PositiveInfinity な平面角オブジェクトを得る糖衣構文</summary>
    static public Length PositiveInfinity { get { return From_m( double.PositiveInfinity ); } }

    /// <summary>NegativeInfinity な平面角オブジェクトを得る糖衣構文</summary>
    static public Length NegativeInfinity { get { return From_m( double.NegativeInfinity ); } }

    /// <summary>
    /// NaN 判定
    /// </summary>
    /// <returns>NaN なら true</returns>
    public bool IsNaN() { return double.IsNaN( _m ); }

    /// <summary>
    /// ∞ 判定
    /// 符号は何れであれ∞か判定する。
    /// </summary>
    /// <returns>∞ なら true</returns>
    public bool IsInfinity() { return double.IsInfinity( _m ); }
    /// <summary>
    /// +∞判定
    /// </summary>
    /// <returns>+∞ なら true</returns>
    public bool IsPositiveInfinity() { return double.IsPositiveInfinity( _m ); }
    /// <summary>
    /// -∞判定
    /// </summary>
    /// <returns>-∞ なら true</returns>
    public bool IsNegativeInfinity() { return double.IsNegativeInfinity( _m ); }

    /// <summary>
    /// メートル単位で文字列化
    /// </summary>
    /// <param name="format">フォーマット指定文字列</param>
    /// <param name="formatProvider">フォーマットプロバイダー</param>
    /// <returns>文字列化された長さ</returns>
    public string ToString( string format, IFormatProvider formatProvider ) { return ToStringInMeters( format ); }

    /// <summary>インチ単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInInches( string format ) { return $"{InInches.ToString( format )}{SymbolOfInches}"; }
    /// <summary>フィート単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInFeet( string format ) { return $"{InFeet.ToString( format )}{SymbolOfFeet}"; }
    /// <summary>ヤード単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInYards( string format ) { return $"{InYards.ToString( format )}{SymbolOfYards}"; }
    /// <summary>マイル単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInMiles( string format ) { return $"{InMiles.ToString( format )}{SymbolOfMiles}"; }
    /// <summary>ライン単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInLines( string format ) { return $"{InLines.ToString( format )}{SymbolOfPicas}"; }
    /// <summary>パイカ単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInPicas( string format ) { return $"{InPicas.ToString( format )}{SymbolOfPoints}"; }
    /// <summary>ポイント単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInPoints( string format ) { return $"{InPoints.ToString( format )}{SymbolOfShaku}"; }
    /// <summary>尺単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInShaku( string format ) { return $"{InShakuJP.ToString( format )}{SymbolOfSun}"; }
    /// <summary>寸単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInSun( string format ) { return $"{InSun.ToString( format )}{SymbolOfSun}"; }
    /// <summary>分単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInBu( string format ) { return $"{InBu.ToString( format )}{SymbolOfBu}"; }
    /// <summary>文単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInMon( string format ) { return $"{InMon.ToString( format )}{SymbolOfMon}"; }
    /// <summary>丈単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInJou( string format ) { return $"{InJouJP.ToString( format )}{SymbolOfJou}"; }
    /// <summary>里単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInRi( string format ) { return $"{InRiJP.ToString( format )}{SymbolOfRi}"; }
    /// <summary>間単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInKen( string format ) { return $"{InKen.ToString( format )}{SymbolOfKen}"; }
    /// <summary>町単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInChou( string format ) { return $"{InChou.ToString( format )}{SymbolOfChou}"; }
    /// <summary>歯単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInHa( string format ) { return $"{InHa.ToString( format )}{SymbolOfHa}"; }
    /// <summary>級単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInKyuu( string format ) { return $"{InKyuu.ToString( format )}{SymbolOfKyuu}"; }
    /// <summary>オングストローム単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInAngStrom( string format ) { return $"{InAngStrom.ToString( format )}{SymbolOfAngStrom}"; }

    /// <summary>メートル単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToStringInMeters( string format = "F2" ) { return $"{_m.ToString( format )}{SymbolOfMeters}"; }

    /// <summary>メガ・メートル単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToString_Mm( string format = "F2" ) { var p = Unit.SI.MetricPrefix._M; return $"{( _m * p ).ToString( format )}{p}{SymbolOfMeters}"; }
    /// <summary>キロ・メートル単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToString_km( string format = "F2" ) { return $"{_m.ToString( format )}{SymbolOfMeters}"; }
    /// <summary>メートル単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToString_m( string format = "F2" ) { return ToStringInMeters( format ); }
    /// <summary>センチ・メートル単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToString_cm( string format = "F2" ) { return $"{_m.ToString( format )}{SymbolOfMeters}"; }
    /// <summary>ミリ・メートル単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToString_mm( string format = "F2" ) { return $"{_m.ToString( format )}{SymbolOfMeters}"; }
    /// <summary>マイクロ・メートル単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToString_μm( string format = "F2" ) { return $"{_m.ToString( format )}{SymbolOfMeters}"; }
    /// <summary>マイクロ・メートル単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToString_um( string format = "F2" ) { return $"{_m.ToString( format )}{SymbolOfMeters}"; }
    /// <summary>ナノ・メートル単位で文字列化</summary><param name="format">フォーマット指定文字列</param><returns>文字列化された長さ</returns>
    public string ToString_nm( string format = "F2" ) { return $"{_m.ToString( format )}{SymbolOfMeters}"; }

    /// <summary>ヨッタ・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_Ym( double v ) { return new Length() { _Ym = v }; }
    /// <summary>ゼッタ・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_Zm( double v ) { return new Length() { _Zm = v }; }
    /// <summary>エクサ・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_Em( double v ) { return new Length() { _Em = v }; }
    /// <summary>ペタ・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_Pm( double v ) { return new Length() { _Pm = v }; }
    /// <summary>テラ・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_Tm( double v ) { return new Length() { _Tm = v }; }
    /// <summary>ギガ・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_Gm( double v ) { return new Length() { _Gm = v }; }
    /// <summary>メガ・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_Mm( double v ) { return new Length() { _Mm = v }; }
    /// <summary>キロ・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_km( double v ) { return new Length() { _km = v }; }
    /// <summary>ヘクト・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_hm( double v ) { return new Length() { _hm = v }; }
    /// <summary>デカ・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_dam( double v ) { return new Length() { _dam = v }; }
    /// <summary>メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_m( double v ) { return new Length() { _m = v }; }
    /// <summary>デシ・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_dm( double v ) { return new Length() { _dm = v }; }
    /// <summary>センチ・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_cm( double v ) { return new Length() { _cm = v }; }
    /// <summary>ミリ・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_mm( double v ) { return new Length() { _mm = v }; }
    /// <summary>マイクロ・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_μm( double v ) { return new Length() { _um = v }; }
    /// <summary>マイクロ・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_um( double v ) { return new Length() { _um = v }; }
    /// <summary>ナノ・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_nm( double v ) { return new Length() { _nm = v }; }
    /// <summary>ピコ・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_pm( double v ) { return new Length() { _pm = v }; }
    /// <summary>フェムト・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_fm( double v ) { return new Length() { _fm = v }; }
    /// <summary>アット・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_am( double v ) { return new Length() { _am = v }; }
    /// <summary>ゼプト・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_zm( double v ) { return new Length() { _zm = v }; }
    /// <summary>ヨクト・メートルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_ym( double v ) { return new Length() { _ym = v }; }

    /// <summary>インチの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_in( double v ) { return new Length() { _in = v }; }
    /// <summary>フィートの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_ft( double v ) { return new Length() { _ft = v }; }
    /// <summary>ヤードの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_yd( double v ) { return new Length() { _yd = v }; }
    /// <summary>マイルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_mi( double v ) { return new Length() { _mi = v }; }
    /// <summary>ミルの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_mil( double v ) { return new Length() { _mil = v }; }
    /// <summary>ラインの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_L( double v ) { return new Length() { _L = v }; }
    /// <summary>パイカの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_pica( double v ) { return new Length() { _pica = v }; }
    /// <summary>ポイントの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_pt( double v ) { return new Length() { _pt = v }; }
    /// <summary>尺（日本）の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_ShakuJP( double v ) { return new Length() { _ShakuJP = v }; }
    /// <summary>尺（日本）の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_尺JP( double v ) { return new Length() { _ShakuJP = v }; }
    /// <summary>尺（中国）の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_ShakuCN( double v ) { return new Length() { _ShakuCN = v }; }
    /// <summary>尺（中国）の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_尺CN( double v ) { return new Length() { _ShakuCN = v }; }
    /// <summary>寸の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_Sun( double v ) { return new Length() { _Sun = v }; }
    /// <summary>寸の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_寸( double v ) { return new Length() { _Sun = v }; }
    /// <summary>分の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_Bu( double v ) { return new Length() { _Bu = v }; }
    /// <summary>分の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_分( double v ) { return new Length() { _Bu = v }; }
    /// <summary>文の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_Mon( double v ) { return new Length() { _Mon = v }; }
    /// <summary>文の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_文( double v ) { return new Length() { _Mon = v }; }
    /// <summary>丈の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_Jou( double v ) { return new Length() { _Jou = v }; }
    /// <summary>丈の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_丈( double v ) { return new Length() { _Jou = v }; }
    /// <summary>間の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_Ken( double v ) { return new Length() { _Ken = v }; }
    /// <summary>間の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_間( double v ) { return new Length() { _Ken = v }; }
    /// <summary>町の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_Chou( double v ) { return new Length() { _Chou = v }; }
    /// <summary>町の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_町( double v ) { return new Length() { _Chou = v }; }
    /// <summary>里（日本）の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_RiJP( double v ) { return new Length() { _RiJP = v }; }
    /// <summary>里（日本）の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_里JP( double v ) { return new Length() { _RiJP = v }; }
    /// <summary>里（中国）の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_RiCN( double v ) { return new Length() { _RiCN = v }; }
    /// <summary>里（中国）の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_里CN( double v ) { return new Length() { _RiCN = v }; }
    /// <summary>歯の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_H( double v ) { return new Length() { _H = v }; }
    /// <summary>歯の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_歯( double v ) { return new Length() { _H = v }; }
    /// <summary>級の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_Q( double v ) { return new Length() { _Q = v }; }
    /// <summary>級の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_級( double v ) { return new Length() { _Q = v }; }
    /// <summary>オングストロームの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_AngStrom( double v ) { return new Length() { _AngStrom = v }; }
    /// <summary>オングストロームの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_Å( double v ) { return new Length() { _AngStrom = v }; }
    /// <summary>X線単位の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_xu( double v ) { return new Length() { _xu = v }; }
    /// <summary>天文単位の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_au( double v ) { return new Length() { _au = v }; }
    /// <summary>光年の値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_ly( double v ) { return new Length() { _ly = v }; }
    /// <summary>パーセクの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_pc( double v ) { return new Length() { _pc = v }; }
    /// <summary>アット・パーセクの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_apc( double v ) { return new Length() { _apc = v }; }
    /// <summary>フレンチ・カテーテル・スケールの値を元に生成</summary><param name="v">元の値</param><returns>生成された長さインスタンス</returns>
    static public Length From_Fr( double v ) { return new Length() { _Fr = v }; }

    /// <summary>
    /// 大・小・等価の比較
    /// </summary>
    /// <param name="other">比較対象</param>
    /// <returns>小=-1, 等価=0, 大=+1</returns>
    public int CompareTo( Length other ) { return _m.CompareTo( other._m ); }

    /// <summary>
    /// a が b より小さいか判定
    /// </summary>
    /// <param name="a">長さ a</param>
    /// <param name="b">長さ b</param>
    /// <returns>a が b より小さければ true</returns>
    static public bool operator <( Length a, Length b ) { return a.CompareTo( b ) < 0; }
    /// <summary>
    /// a が b より大きいか判定
    /// </summary>
    /// <param name="a">長さ a</param>
    /// <param name="b">長さ b</param>
    /// <returns>a が b より大きければ true</returns>
    static public bool operator >( Length a, Length b ) { return a.CompareTo( b ) > 0; }
    /// <summary>
    /// a が b より小さいか、または等価か判定
    /// </summary>
    /// <param name="a">長さ a</param>
    /// <param name="b">長さ b</param>
    /// <returns>a が b より小さいか等価ならば true</returns>
    static public bool operator <=( Length a, Length b ) { return a.CompareTo( b ) <= 0; }
    /// <summary>
    /// a が b より大きいか、または等価か判定
    /// </summary>
    /// <param name="a">長さ a</param>
    /// <param name="b">長さ b</param>
    /// <returns>a が b より大きいか等価ならば true</returns>
    static public bool operator >=( Length a, Length b ) { return a.CompareTo( b ) >= 0; }

    /// <summary>
    /// 単項負演算（符号反転）
    /// </summary>
    /// <param name="a">長さ</param>
    /// <returns>符号を反転した長さ</returns>
    static public Length operator -( Length a )
    { return From_m( -a._m ); }

    /// <summary>
    /// 単項正演算（複製を得るだけ）
    /// </summary>
    /// <param name="a">長さ</param>
    /// <returns>複製</returns>
    static public Length operator +( Length a )
    { return From_m( a._m ); }

    /// <summary>
    /// 二項減算演算
    /// </summary>
    /// <param name="a">元の長さ</param>
    /// <param name="b">引く長さ</param>
    /// <returns>引き算した長さ</returns>
    static public Length operator -( Length a, Length b )
    { return From_m( a._m - b._m ); }

    /// <summary>
    /// 二項加算演算
    /// </summary>
    /// <param name="a">加算する長さ1つめ</param>
    /// <param name="b">加算する長さ2つめ</param>
    /// <returns>加算した長さ</returns>
    static public Length operator +( Length a, Length b )
    { return From_m( a._m + b._m ); }

    /// <summary>
    /// 二項積算演算（長さ次元×無次元＝長さ次元）
    /// </summary>
    /// <param name="a">元の長さ</param>
    /// <param name="b">倍率</param>
    /// <returns>積算された長さ</returns>
    static public Length operator *( Length a, double b )
    { return From_m( a._m * b ); }

    /// <summary>
    /// 二項積算演算（無次元×長さ次元＝長さ次元）
    /// </summary>
    /// <param name="a">倍率</param>
    /// <param name="b">元の長さ</param>
    /// <returns>積算された長さ</returns>
    static public Length operator *( double a, Length b )
    { return b * a; }

    /// <summary>
    /// 二項除算演算（長さ次元÷無次元＝長さ次元）
    /// </summary>
    /// <param name="a">元の長さ</param>
    /// <param name="b">割る数</param>
    /// <returns>除算された長さ</returns>
    static public Length operator /( Length a, double b )
    { return From_m( a._m / b ); }

    /// <summary>
    /// 二項除算演算（長さ次元÷長さ次元＝無次元）
    /// </summary>
    /// <param name="a">元の長さ</param>
    /// <param name="b">割る数</param>
    /// <returns>除算された無次元数（比）</returns>
    static public double operator /( Length a, Length b )
    { return a._m / b._m ; }

    /// <summary>
    /// 二項剰余演算（長さ次元%長さ次元＝長さ次元）
    /// </summary>
    /// <param name="a">元の長さ</param>
    /// <param name="b">割る長さ</param>
    /// <returns>割ったら余る長さ</returns>
    static public Length operator %( Length a, Length b )
    { return From_m( a._m % b._m ); }

    /// <summary>
    /// 近似的に等価か判定
    /// </summary>
    /// <param name="a">比較対象の長さ</param>
    /// <param name="tolerance">許容範囲（許容誤差）</param>
    /// <returns>近似的に等価ならば true</returns>
    public bool NearlyEquals( Length a, Length tolerance = null )
    { return NearlyEquals( this, a, tolerance ); }

    /// <summary>
    /// a と b の差が tolerance 以下か判定する
    /// </summary>
    /// <param name="a">任意の長さ1つめ</param>
    /// <param name="b">任意の長さ2つめ</param>
    /// <param name="tolerance">許容範囲（誤差） null の場合は Length.From_mm(1) が代用される</param>
    /// <returns>a と b の差が tolerance 以下なら true 、そうでなければ false</returns>
    static public bool NearlyEquals( Length a, Length b, Length tolerance = null )
    { return Calculation.NearlyEquals( a, b, tolerance ?? Length.From_mm(1), ( p, q ) => p - q, ( p, q ) => p + q ); }
  }
}