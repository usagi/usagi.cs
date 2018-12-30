# LonLat.DistanceToPlaneAngle メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

経緯度間の距離を平面角で計算 

計算はまあまあ早いが地球のような楕円体のフラッディングレートは考慮しないのでかなり大雑把。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity_GeoLocation.md">usagi.Quantity.GeoLocation</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public PlaneAngle DistanceToPlaneAngle(
	ILonLatGettable b
)
```


#### パラメーター
&nbsp;<dl><dt>b</dt><dd>型: <a href="T_usagi_Quantity_GeoLocation_ILonLatGettable.md">usagi.Quantity.GeoLocation.ILonLatGettable</a><br />比較対象</dd></dl>

#### 戻り値
型: <a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle</a><br />平面角単位での距離

## 解説
必要なら <a href="M_usagi_CivilEngineering_Extension_LonLatDistanceExtension_DistanceTo.md">DistanceTo(ILonLatGettable, ILonLatGettable, LonLatDistanceExtension.LonLatDistanceAlgorithm, IGeometricalSpecificationGettable)</a> を使うと良い

## 関連項目


#### 参照
<a href="T_usagi_Quantity_GeoLocation_LonLat.md">LonLat クラス</a><br /><a href="N_usagi_Quantity_GeoLocation.md">usagi.Quantity.GeoLocation 名前空間</a><br />