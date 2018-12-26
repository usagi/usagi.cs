# GeoURI.NearlyEquals メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

経度、緯度、高度が許容範囲内で近似的に等価かつ測地系と不確実性パラメーターが完全に一致するか判定


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_URI.md">usagi.URI</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.2.0.0 (1.2.0.0)

## 構文

**C#**<br />
``` C#
public bool NearlyEquals(
	GeoURI other,
	PlaneAngle angle_tolelance = null,
	Length length_tolerance = null
)
```


#### パラメーター
&nbsp;<dl><dt>other</dt><dd>型: <a href="T_usagi_URI_GeoURI.md">usagi.URI.GeoURI</a><br />比較対象</dd><dt>angle_tolelance (Optional)</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />平面角の許容範囲</dd><dt>length_tolerance (Optional)</dt><dd>型: <a href="T_usagi_Quantity_Length.md">usagi.Quantity.Length</a><br />長さの許容範囲</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/a28wyd50" target="_blank">Boolean</a><br />一致する場合は true

## 関連項目


#### 参照
<a href="T_usagi_URI_GeoURI.md">GeoURI クラス</a><br /><a href="N_usagi_URI.md">usagi.URI 名前空間</a><br />