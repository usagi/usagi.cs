# usagi.cs

わたしが欲しいと思った適当な機能たち for C#

- NuGet: https://www.nuget.org/packages/usagi/
- GitHub: https://github.com/usagi/usagi.cs/
    - docs( Online Markdown ): [docs/Home.md](docs/Home.md)
    - docs( chm; for Download ): [docs/usagi.cs.docs.chm](docs/usagi.cs.docs.chm)

# Release Note 3.1.0

- [Issue #10 CivilEngineering に GSJ/datatilemap の入出力と変換、それを応用した GSI/dem のラッパーとかほしい](https://github.com/usagi/usagi.cs/issues/10)
    - `usagi.CivilEngineering.Terrain.GSJ.datatilemap.Utility` を追加しました。
        - GSJ/datatilemap 2.1 仕様のデータを読み込んだり変換したりできるようになりました。
        - `LoadPNGDataTile`;  PNG Data Tile の読み込み
        - `SavePNGNumberTileU`; PNG Number Tile （符号なし）のタイル単位の書き出し
        - `SavePNGNumberTileS`; PNG Number Tile （符号付き）のタイル単位の書き出し
        - `LoadPNGNumberTileU`; PNG Number Tile （符号なし）のタイル単位の読み出し
        - `LoadPNGNumberTileS`; PNG Number Tile （符号付き）のタイル単位の読み出し
        - `LoadPNGPaletteTile`; PNG Palette Tile のタイル単位の読み出し
        - `DecodeNumberPixelU`; PNG Number Tile （符号なし）のピクセル単位のデコード
        - `DecodeNumberPixelS`; PNG Number Tile （符号付き）のピクセル単位のデコード
        - `EncodeNumberPixelU`; PNG Number Tile （符号なし）のピクセル単位のエンコード
        - `EncodeNumberPixelS`; PNG Number Tile （符号付き）のピクセル単位のエンコード
        - `DecodePalettePixel`; PNG Palette Tile のピクセル単位のデコード
        - `EncodePalattePixel`; PNG Palette Tile のピクセル単位のエンコード
    - `usagi.CivilEngineering.Terrain.GSI.maps.Utility` を追加しました。
        - `LoadDEM`; DEM5A, DEM5B, DEM10B, DEMGM を組み合わせて必要に応じて補完した地形の数値標高群をタイル座標から取得

## Old Release Notes

過去のリリースノート群は README.md のコミット履歴からどうぞ。

- [History for usagi.cs/README.md](https://github.com/usagi/usagi.cs/commits/master/README.md)

# License

- [MIT](LICENSE.md)

# Author

- [Usagi Ito](https://github.com/usagi/)
