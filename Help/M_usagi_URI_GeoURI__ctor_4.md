# GeoURI コンストラクター (PlaneAngle, PlaneAngle, Length, String, String)<small>[<<Back to Home](https://github.com/usagi/usagi.cs/blob/master/Help/Home.md)</small> 

指定可能な全てのパラメーターを元に生成


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_URI.md">usagi.URI</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public GeoURI(
	PlaneAngle lon,
	PlaneAngle lat,
	Length alt = null,
	string crs = null,
	string u = null
)
```


#### パラメーター
&nbsp;<dl><dt>lon</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />経度</dd><dt>lat</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />緯度</dd><dt>alt (Optional)</dt><dd>型: <a href="T_usagi_Quantity_Length.md">usagi.Quantity.Length</a><br />標高（高度）; 省略時 null</dd><dt>crs (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">System.String</a><br />測地系; 省略時 null</dd><dt>u (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">System.String</a><br />不確実性パラメーター値; 省略時 null</dd></dl>

## 関連項目


#### 参照
<a href="T_usagi_URI_GeoURI.md">GeoURI クラス</a><br /><a href="Overload_usagi_URI_GeoURI__ctor.md">GeoURI オーバーロード</a><br /><a href="N_usagi_URI.md">usagi.URI 名前空間</a><br />