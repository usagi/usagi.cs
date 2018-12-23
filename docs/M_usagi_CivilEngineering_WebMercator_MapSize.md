# WebMercator.MapSize メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

LOD=z におけるピクセル空間の次元の広さを計算


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_CivilEngineering.md">usagi.CivilEngineering</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public static uint MapSize(
	byte z,
	uint tile_size = 256
)
```


#### パラメーター
&nbsp;<dl><dt>z</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/yyb1w04y" target="_blank">System.Byte</a><br />Level of Detail ( LOD; or Zoom Level )</dd><dt>tile_size (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/ctys3981" target="_blank">System.UInt32</a><br />タイル1枚あたりの次元の広さ</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/ctys3981" target="_blank">UInt32</a><br />LOD=z におけるピクセル空間の広さ

## 関連項目


#### 参照
<a href="T_usagi_CivilEngineering_WebMercator.md">WebMercator クラス</a><br /><a href="N_usagi_CivilEngineering.md">usagi.CivilEngineering 名前空間</a><br />