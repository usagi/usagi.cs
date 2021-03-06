# LonLatDistanceExtension.LongitudeDistanceTo メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

経緯度の位置 a と b の中間の緯度における経度方向の距離を計算する


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_CivilEngineering_Extension.md">usagi.CivilEngineering.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static Length LongitudeDistanceTo(
	this ILonLatGettable a,
	ILonLatGettable b,
	LonLatDistanceExtension.LonLatDistanceAlgorithm llda = LonLatDistanceExtension.LonLatDistanceAlgorithm.Haversine,
	IGeometricalSpecificationGettable planet = null
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="T_usagi_Quantity_GeoLocation_ILonLatGettable.md">usagi.Quantity.GeoLocation.ILonLatGettable</a><br />経緯度の位置1つめ</dd><dt>b</dt><dd>型: <a href="T_usagi_Quantity_GeoLocation_ILonLatGettable.md">usagi.Quantity.GeoLocation.ILonLatGettable</a><br />経緯度の位置2つめ</dd><dt>llda (Optional)</dt><dd>型: <a href="T_usagi_CivilEngineering_Extension_LonLatDistanceExtension_LonLatDistanceAlgorithm.md">usagi.CivilEngineering.Extension.LonLatDistanceExtension.LonLatDistanceAlgorithm</a><br />経緯度の距離を計算するアルゴリズム</dd><dt>planet (Optional)</dt><dd>型: <a href="T_usagi_CivilEngineering_Planet_IGeometricalSpecificationGettable.md">usagi.CivilEngineering.Planet.IGeometricalSpecificationGettable</a><br />楕円体近似した惑星の形状定義; null の場合は <a href="P_usagi_CivilEngineering_Planet_GeometricalSpecification_Earth_WGS84.md">Earth_WGS84</a> が採用されます</dd></dl>

#### 戻り値
型: <a href="T_usagi_Quantity_Length.md">Length</a><br />経度方向の距離

#### 使用上の注意
Visual Basic と C#では、<a href="T_usagi_Quantity_GeoLocation_ILonLatGettable.md">ILonLatGettable</a>型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_CivilEngineering_Extension_LonLatDistanceExtension.md">LonLatDistanceExtension クラス</a><br /><a href="N_usagi_CivilEngineering_Extension.md">usagi.CivilEngineering.Extension 名前空間</a><br />