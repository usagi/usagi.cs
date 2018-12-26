# usagi.cs

わたしが欲しいと思った適当な機能たち for C#

- NuGet: https://www.nuget.org/packages/usagi/
- GitHub: https://github.com/usagi/usagi.cs/
    - docs( Online Markdown ): [docs/Home.md](docs/Home.md)
    - docs( chm; for Download ): [docs/usagi.cs.docs.chm](docs/usagi.cs.docs.chm)

# Release Note 1.2.0

- `usagi.Extension.ItemsControlHelper`
    - `FindChild`, `FindChildAs`, `FindChildren`, `FindChildrenAs` を追加。
    - `FindControl`, `FindControlAs`, `FindControls`, `FindControlsAs` を Deprecated=1.2.0, Obsolete>1.2.0 予定に設定。
    - `FindChild` 系を追加し `FindControl` 系を Deprecated とした理由は [Issue #1 DataTemplate に TextBox もった ItemsControl に usagi.Extension.ItemsControlHelper.FindControls すると NullReferenceException で死ぬ](https://github.com/usagi/usagi.cs/issues/1) を参照。 
- `usagi.Extension.Collection.EnumerableHelper`
    - `Range` エクステンション追加
        - `(begin, count)` -> `[begin, ..., begin + count]` の要素を列挙。 `Enumerable.Range` への糖衣構文
        - `(count)` -> `(0, count)` への糖衣構文
        - `(count, generator())` -> count 個の generator の結果を生成
        - `(begin, count, generator(n))` -> [begin, ... , begin + count] を始域とし二項関係 generator により写像される終域の要素を列挙
        - `(count, generator(n))` -> `(0, count, generator(n))` への糖衣構文
- `usagi.Extension.string.StringHelper`
    - `ToMemoryStream` エクステンション追加
- `usagi.Extension.MemoryStream.`
    - `ToString` エクステンション追加

# License

- [MIT](LICENSE.md)

# Author

- [Usagi Ito](https://github.com/usagi/)
