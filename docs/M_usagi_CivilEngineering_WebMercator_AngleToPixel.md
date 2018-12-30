# WebMercator.AngleToPixel メソッド (LonLat, Byte)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

経緯度 -> ピクセル座標系の位置


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_CivilEngineering.md">usagi.CivilEngineering</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public static PixelLocation AngleToPixel(
	LonLat a,
	byte z
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="T_usagi_Quantity_GeoLocation_LonLat.md">usagi.Quantity.GeoLocation.LonLat</a><br />経緯度</dd><dt>z</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/yyb1w04y" target="_blank">System.Byte</a><br />Level of Detail ( LOD; or Zoom Level )</dd></dl>

#### 戻り値
型: <a href="T_usagi_CivilEngineering_PixelLocation.md">PixelLocation</a><br />ピクセル座標系の位置

## 関連項目


#### 参照
<a href="T_usagi_CivilEngineering_WebMercator.md">WebMercator クラス</a><br /><a href="Overload_usagi_CivilEngineering_WebMercator_AngleToPixel.md">AngleToPixel オーバーロード</a><br /><a href="N_usagi_CivilEngineering.md">usagi.CivilEngineering 名前空間</a><br />