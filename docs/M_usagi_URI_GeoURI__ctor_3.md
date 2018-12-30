# GeoURI コンストラクター (LonLatAlt, String, String)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

経緯度高度を元に生成


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_URI.md">usagi.URI</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public GeoURI(
	LonLatAlt a,
	string crs = null,
	string u = null
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="T_usagi_Quantity_GeoLocation_LonLatAlt.md">usagi.Quantity.GeoLocation.LonLatAlt</a><br />経緯度高度</dd><dt>crs (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">System.String</a><br />測地系; 省略時 null</dd><dt>u (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">System.String</a><br />不確実性パラメーター値; 省略時 null</dd></dl>

## 関連項目


#### 参照
<a href="T_usagi_URI_GeoURI.md">GeoURI クラス</a><br /><a href="Overload_usagi_URI_GeoURI__ctor.md">GeoURI オーバーロード</a><br /><a href="N_usagi_URI.md">usagi.URI 名前空間</a><br />