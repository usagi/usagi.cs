# WebMercator.NormalizeWebMercator メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

任意の経緯度を WebMercator で表現可能な適当な経緯度へ正規化する 緯度が90°を超える場合は経度は必要に応じて反転され、緯度も反転後の経度に合わせて正規化される。 正規化後の緯度は ± <a href="P_usagi_CivilEngineering_WebMercator_CriticalLatitude.md">CriticalLatitude</a> へ丸められる


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_CivilEngineering.md">usagi.CivilEngineering</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.2.0.0 (1.2.0.0)

## 構文

**C#**<br />
``` C#
public static LonLat NormalizeWebMercator(
	LonLat a
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="T_usagi_Quantity_GeoLocation_LonLat.md">usagi.Quantity.GeoLocation.LonLat</a><br />任意の経緯度</dd></dl>

#### 戻り値
型: <a href="T_usagi_Quantity_GeoLocation_LonLat.md">LonLat</a><br />正規化された経緯度

## 関連項目


#### 参照
<a href="T_usagi_CivilEngineering_WebMercator.md">WebMercator クラス</a><br /><a href="N_usagi_CivilEngineering.md">usagi.CivilEngineering 名前空間</a><br />