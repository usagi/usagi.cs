# usagi.cs

わたしが欲しいと思った適当な機能たち for C#

- NuGet: https://www.nuget.org/packages/usagi/
- GitHub: https://github.com/usagi/usagi.cs/
    - docs( Online Markdown ): [docs/Home.md](docs/Home.md)
    - docs( chm; for Download ): [docs/usagi.cs.docs.chm](docs/usagi.cs.docs.chm)

# Release Note 1.1.0

- `usagi.Quantity.PlaneAngle`
    - 数値の度分秒単位から生成する場合に分と秒の符号を自動的に度と統一するよう実装を変更しました。
    - `Parse` により文字列から生成する場合に意図せずパースに失敗する符号や単位があったバグを修正しました。
    - 非数と∞の生成用 `NaN`, `PositiveInfinity`, `NegativeInfinity` 静的読み出し用プロパティーを追加しました。
    - 非数と∞の判定用に `IsNaN`, `IsInfinity`, `IsPositiveInfinity`, `IsNegativeInfinity` メソッドを追加しました。
    - 三角関数比から平面角を生成する `From_asin`, `From_acos`, `From_atan` ファクトリーを追加しました。
    - XML ドキュメントをたくさん追加
- `usagi.Quantity.PlaneAngle.MathExtension`
    - `PlaneAngle` へ `System.Math` の一部機能を拡張対応させるエクステンションを追加しました。
    - `Abs`, `Sin`, `Cos`, `Tan`, `Sinh`, `Cosh`, `Tanh`, `Sign` を使用可能です。エクステンションの名前空間を `using` すると `FromDegrees( 60 ).Sin()` のように使用可能になります。
- `usagi.Quantity.Length`
    - 二項比較演算子群 `operator &lt;`, `&lt;=`, `&gt;`, `&gt;=` を追加しました。
    - 二項積算演算子 `operator *` に従来の `( PlaneAngle, double )` とオペランドを交換した `( double, PlaneAngle )` を追加しました。
    - 二項除算演算子 `operator /　( PlaneAngle, PlaneAngle )` を追加しました。使用時は計算結果が無次元数となる点に留意して下さい。
    - 二項剰余演算子 `operator %　( PlaneAngle, PlaneAngle )` を追加しました。計算結果の剰余値は割られる数と同じ次元の値のため結果は `PlaneAngle` 型となる点に留意して下さい。
    - XML ドキュメントをたくさん追加
- `usagi.Quantity.LengthMathExtension`
    - `Length` へ `System.Math` の一部機能を拡張対応させるエクステンションを追加しました。
    - `Abs`, `ASin`, `ACos`, `ATan2`, `Sign` を使用可能です。 `var angle = Length.From_m(3).ASin(　cathetus: Length.From_m(4) )` の様に使います。
    - 例えば `ASin( this Length hypotenuse, Length cathetus )` の場合はエクステンション呼び出し元が斜辺( `hypotenuse` )、実引数で渡す側が隣辺( `cathetus` ) となります。
- `usagi.Quantity.GeoLocation`
    - `ILonLatAltGettable`, `ILonLatAltSettable`, `ILonLatAlt` インターフェースを追加しました。
    - `LonLat` のコピーコンストラクターが LonLat に換えて `ILonLatGettable` を引数としてとるよう変更しました。
    - `FromDegrees( double, double )` ファクトリーを追加しました。
    - `ToString` を追加しました。 overload により小数部の桁数を指定できます。
    - `Parse` を追加しました。 `"43° 3′ 43.5″ N, 141° 21′ 15.8″ E"`, `"北緯43度3分43.5秒 東経141度21分15.8秒"` などの文字列から経緯度型を生成するファクトリーです。
    - `operator +`, `-` を追加し経緯度型同士の加算と減算を可能にしました。
    - `DistanceToPlaneAngle` メソッドを追加しました。大雑把に角度単位での2点間の距離を計算したい場合にそこそこの負荷でまあまあ役に立ってくれる事もあります。より厳密性の高い、あるいは長さ単位での距離が必要な場合は `usagi.CivilEngineering.LonLatHelper.LongitudeDistanceTo` メソッドを使用して下さい。
    - `NearlyEqualsTo` を追加し、 overload により角度単位の距離、経度と緯度それぞれ軸方向ごとの角度単位の距離で近似的な等価判定を可能としました。大雑把な用途にはまあまあ役に立ってくれる事もあります。より厳密性の高い、あるいは長さ単位での距離による比較が必要な場合は `usagi.CivilEngineering.LonLatHelper.NearlyEqualsTo` メソッドを使用して下さい。
    - XML ドキュメントをたくさん追加
- `usagi.Extension.string`
    - 新たに `string` 型へのエクステンション群を追加しました。
    - `Contains( this string s, params string[] ss )` の様に、元々の `string` では1つのパラメーターしか取らないメソッドへ `params string[]` を与えて一度に複数の選択肢からの `Contains` の `||` を取得できるとかそういう拡張が主です。
    - 複数 OR 版の `Contains`, `StartsWith`, `EndsWith`　と `StartsWith` || `EndsWith`　による `StartsOrEndsWith` を使用可能です。
- `usagi.Extension.ItemsControlHelper`
    - `System.Windows.Control.ItemsControl` を C# コード実装から便利に使うためのエクステンションを追加しました。
    - `GetContentPresenter`, `FindControlAs<T>`, `FindControls` などのエクステンションにより `ItemsControl` から簡単にテンプレート要素を引っ張り出したりできるようになります。
- `usagi.Extension.Collection.EnumerableHelper`
    - `WithIndexing` を追加しました。 `IEnumerable` の列挙時にインデクシング付きで列挙したい用途に便利です。 
- `usagi.CivilEngineering`
    - `PixelLocation`, `TileLocation` など計算器での地図の扱いに使用されるピクセルやタイル単位の位置型を追加しました。
    - `WebMercator` 静的クラスを追加し、 `AngleToTile` など WebMercator 系の処理に便利なメソッドを追加しました。そのうちもっと増えます。たぶん。
- `usagi.CivilEngineering.Planet`
    - 惑星の諸元を扱うための名前空間、クラスを追加しました。
    - `IGeometricalSpecificationGettable` により惑星の形状定義情報を扱えます。
    - 地球の楕円体近似の WGS84 測地系の形状定義を `GeometricalSpecification.Earth_WGS84` 静的プロパティーで取得し扁平率や赤道長などの値を使用可能です。
- `usagi.CivilEngineering.LonLatHelper`
    - `LonLat` への専門性の高い土木工学機能のエクステンションを `usagi.Quantity.GeoLocation.LonLat` へ追加しました。
    - `Harversine`, `Vincenty` を用いた `ILonLatAltGettable` の2点間の `Length` 距離の計算などが使用可能です。
- `usagi.Quantity.Unit.SI.MetricPrefix`
    - XML ドキュメントをたくさん追加
- `usagi.URI.GeoURI`
    - XML ドキュメントをたくさん追加
- `usagi.LibraryInformation`
    - Sandcastle のドキュメント生成都合名前空間に何か入れておくと便利が良いのでライブラリーの諸元を取得できるクラスを追加しました。
- 全ての名前空間
    - Sandcastle 形式の XML ドキュメントへ変更
- ソースリポジトリーの docs ディレクトリーへ Markdown および chm 形式のドキュメントを追加しました。
    - Markdown -> [https://github.com/usagi/usagi.cs/blob/master/docs/Home.md]
    - chm -> [https://github.com/usagi/usagi.cs/blob/master/docs/usagi.cs.docs.chm]

# License

- [MIT](LICENSE.md)

# Author

- [Usagi Ito](https://github.com/usagi/)
