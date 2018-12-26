# WebMercator.PixelToTile メソッド (UInt32, UInt32, Byte, UInt32)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

ピクセル座標系の位置 -> 所属するタイル座標系の位置


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_CivilEngineering.md">usagi.CivilEngineering</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.2.0.0 (1.2.0.0)

## 構文

**C#**<br />
``` C#
public static TileLocation PixelToTile(
	uint x,
	uint y,
	byte z,
	uint tile_size = 256
)
```


#### パラメーター
&nbsp;<dl><dt>x</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/ctys3981" target="_blank">System.UInt32</a><br />ピクセル X 座標</dd><dt>y</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/ctys3981" target="_blank">System.UInt32</a><br />ピクセル Y 座標</dd><dt>z</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/yyb1w04y" target="_blank">System.Byte</a><br />Level of Detail ( LOD; or Zoom Level )</dd><dt>tile_size (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/ctys3981" target="_blank">System.UInt32</a><br />タイルの次元あたりの大きさ</dd></dl>

#### 戻り値
型: <a href="T_usagi_CivilEngineering_TileLocation.md">TileLocation</a><br />所属するタイル座標系の位置

## 関連項目


#### 参照
<a href="T_usagi_CivilEngineering_WebMercator.md">WebMercator クラス</a><br /><a href="Overload_usagi_CivilEngineering_WebMercator_PixelToTile.md">PixelToTile オーバーロード</a><br /><a href="N_usagi_CivilEngineering.md">usagi.CivilEngineering 名前空間</a><br />