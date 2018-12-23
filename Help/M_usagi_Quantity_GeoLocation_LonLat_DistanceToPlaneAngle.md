# LonLat.DistanceToPlaneAngle メソッド <small>[<<Back to Home](https://github.com/usagi/usagi.cs/blob/master/Help/Home.md)</small> 

経緯度間の距離を平面角で計算 

計算はまあまあ早いが地球のような楕円体のフラッディングレートは考慮しないのでかなり大雑把。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity_GeoLocation.md">usagi.Quantity.GeoLocation</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

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
必要なら <a href="M_usagi_CivilEngineering_LonLatHelper_DistanceTo.md">DistanceTo(ILonLatGettable, ILonLatGettable, LonLatHelper.LonLatDistanceAlgorithm, IGeometricalSpecificationGettable)</a> を使うと良い

## 関連項目


#### 参照
<a href="T_usagi_Quantity_GeoLocation_LonLat.md">LonLat クラス</a><br /><a href="N_usagi_Quantity_GeoLocation.md">usagi.Quantity.GeoLocation 名前空間</a><br />