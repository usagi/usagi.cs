# LonLat.NearlyEqualsTo メソッド (ILonLatGettable, PlaneAngle)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

平面角次元の距離が許容範囲以内で近似的に等価と未為せるか判定


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity_GeoLocation.md">usagi.Quantity.GeoLocation</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.2.0.0 (1.2.0.0)

## 構文

**C#**<br />
``` C#
public bool NearlyEqualsTo(
	ILonLatGettable x,
	PlaneAngle tolerance = null
)
```


#### パラメーター
&nbsp;<dl><dt>x</dt><dd>型: <a href="T_usagi_Quantity_GeoLocation_ILonLatGettable.md">usagi.Quantity.GeoLocation.ILonLatGettable</a><br />判定対象</dd><dt>tolerance (Optional)</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />許容範囲</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/a28wyd50" target="_blank">Boolean</a><br />近似的に等価と未為せる場合は true

## 関連項目


#### 参照
<a href="T_usagi_Quantity_GeoLocation_LonLat.md">LonLat クラス</a><br /><a href="Overload_usagi_Quantity_GeoLocation_LonLat_NearlyEqualsTo.md">NearlyEqualsTo オーバーロード</a><br /><a href="N_usagi_Quantity_GeoLocation.md">usagi.Quantity.GeoLocation 名前空間</a><br />