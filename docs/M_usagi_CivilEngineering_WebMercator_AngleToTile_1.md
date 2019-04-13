# WebMercator.AngleToTile メソッド (PlaneAngle, PlaneAngle, Byte)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

経緯度 -> 所属するタイル座標系の位置


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_CivilEngineering.md">usagi.CivilEngineering</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static TileLocation AngleToTile(
	PlaneAngle lon,
	PlaneAngle lat,
	byte z
)
```


#### パラメーター
&nbsp;<dl><dt>lon</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />経度</dd><dt>lat</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />緯度</dd><dt>z</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/yyb1w04y" target="_blank">System.Byte</a><br />Level of Detail ( LOD; or Zoom Level )</dd></dl>

#### 戻り値
型: <a href="T_usagi_CivilEngineering_TileLocation.md">TileLocation</a><br />所属するタイル座標系の位置

## 関連項目


#### 参照
<a href="T_usagi_CivilEngineering_WebMercator.md">WebMercator クラス</a><br /><a href="Overload_usagi_CivilEngineering_WebMercator_AngleToTile.md">AngleToTile オーバーロード</a><br /><a href="N_usagi_CivilEngineering.md">usagi.CivilEngineering 名前空間</a><br />