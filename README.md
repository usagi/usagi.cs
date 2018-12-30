# usagi.cs

わたしが欲しいと思った適当な機能たち for C#

- NuGet: https://www.nuget.org/packages/usagi/
- GitHub: https://github.com/usagi/usagi.cs/
    - docs( Online Markdown ): [docs/Home.md](docs/Home.md)
    - docs( chm; for Download ): [docs/usagi.cs.docs.chm](docs/usagi.cs.docs.chm)

# Release Note 2.0.0

- [Issue #2 Quantity に無次元数を扱う Ratio 的なやつ欲しいよね、でも非無次元数型や double なんかの素の数値型とも面倒なく親和性いいやつが欲しいよね](https://github.com/usagi/usagi.cs/issues/2)
    - `usagi.Quantity.Ratio`, `usagi.Quantity.Ratio.Extension` 名前空間に機能が追加されました。
    - 実数値を値域 `[ 0 ... 1 ]` (UNORM), `[ -1 ... 1 ]` (SNORM) を規準とする比として扱いやすくするエクステンション群をたくさん実装しました。
    - 整数型と実数型の間で UNORM, SNORM を考慮した比に基づいた値の変換を行うエクステンション群をたくさん実装しました。
    - 実数値の比を分母と分子からなる分数表現に分解する `double.DecompositionToCommonFraction` エクステンションも追加しました。
- [Issue #3 名前空間、ソースコードディレクトリーの配置、ファイル名の見直し](https://github.com/usagi/usagi.cs/issues/3)
    - 名前空間のルールを整理し、一部の名前空間を変更しました。
        - エクステンションは機能の名前空間の下の `.Extenstion` 名前空間に入れる、とか。
        - エクステンションのクラス名のサフィックスは `Extension` に統一する、とか。
        - `usagi.Extension` に入れていたアレコレを機能ごとに名前空間を分けて再配置した、とか。
    - ディレクトリーわけを真面目にしてソースファイルの大移動（配置整理）をしました。
- [Issue #4 usagi.Quantity の Length, PlaneAngle の EqualsTo 系のメソッド名を Equals へ統一](https://github.com/usagi/usagi.cs/issues/4)
- `usagi.ColorSpace` を追加しました。
    - `System.Windows.Media.Color` を基準にあれこれと機能を書きました。
    - `Color` を数値から生成する `Factory` とか。
    - CSS形式の文字列表現の色値 `rgb(123,45,67)` とか `hsla(220,50%,50%,0.6)` とかの文字列値から `string.ToColor()` とかデキマス。
    - `Color` を HSLA 色空間のタプルと相互変換したり、 HSLA 色空間で `NearlyEquals` したりデキマス。
    - タプル形式の RGBA, HSLA を色っぽく扱うエクステ、ツイテマス。
- `usagi.Collection.Enumerable` の区間生成機能を強化しました。
    - `Range( begin, count )` 系の便利糖衣構文のほか、
    - `Range( begin, end, termination)` で開区間、半開区間、閉区間を生成したり、
    - そもそも `int` 以外の組み込み数値型 `byte` でも `decimal` でも `Range` できるようになったり
    - `Range( ( begin0, end0, termination0 ), ( begin1, end1, termination1 ), ... )` などと呪文を唱え複数のRangeを一発で生成できたりします。
- ほか、ちまちまけっこう修正とか追加とかしたし、名前空間の破壊的変更とかもしたのでメジャーバージョンを上げました。

# License

- [MIT](LICENSE.md)

# Author

- [Usagi Ito](https://github.com/usagi/)
