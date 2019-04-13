# usagi.cs

わたしが欲しいと思った適当な機能たち for C#

- NuGet: https://www.nuget.org/packages/usagi/
- GitHub: https://github.com/usagi/usagi.cs/
    - docs( Online Markdown ): [docs/Home.md](docs/Home.md)
    - docs( chm; for Download ): [docs/usagi.cs.docs.chm](docs/usagi.cs.docs.chm)

# Release Note 3.0.0

- [Issue #9 ファイルパスのサニタイザーユーティリティーを追加する](https://github.com/usagi/usagi.cs/issues/9)
    - `usagi.FileSystem.Utility` にパスに使用不能な文字があったら置き換えまたは削除する `SanitizePath` メソッドを追加しました。
- [Issue #8 バージョン情報とか扱うのに便利な usagi.Assembly.Utility を結合](https://github.com/usagi/usagi.cs/issues/8)
    - `usagi.Assembly.Utility` に .net アッセンブリーとしてのバージョン文字列や製品名の取得を簡単にするメソッド群を追加しました。
- [Issue #6 WPF, Windows に関連する機能をライブラリーレベルで分離](https://github.com/usagi/usagi.cs/issues/6)
    - `usagi.cs` 内の `usagi` プロジェクト から WPF 用の機能を `usagi.WPF` プロジェクトへ分離しました。
        - WPF が不要なプロジェクトで `usagi` ライブラリーを使いたい場合に便利がよくなりました。
    - `usagi.WPF` の分離に伴い単体試験プロジェクトも `usagiTests` と `usagi.WPFTests` に分離しました。
- [Issue #5 `usagi.CivilEngineering.Extension.LonLatHelper` ←こいつ 2.0.0 のリネームし忘れてるよね](https://github.com/usagi/usagi.cs/issues/5)
    - ファイル名を変更しました。
        - `LonLatHelper.cs` `ILonLatGettableExtension.cs`

## Old Release Notes

過去のリリースノート群は README.md のコミット履歴からどうぞ。

- [History for usagi.cs/README.md](https://github.com/usagi/usagi.cs/commits/master/README.md)

# License

- [MIT](LICENSE.md)

# Author

- [Usagi Ito](https://github.com/usagi/)
