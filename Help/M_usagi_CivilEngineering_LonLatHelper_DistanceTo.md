# LonLatHelper.DistanceTo メソッド <small>[<<Back to Home](https://github.com/usagi/usagi.cs/blob/master/Help/Home.md)</small> 

2つの経緯度 a, b について、 楕円体近似した惑星の形状定義 planet 上における 惑星表面上の地点間の距離を長さ次元で計算します


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_CivilEngineering.md">usagi.CivilEngineering</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public static Length DistanceTo(
	this ILonLatGettable a,
	ILonLatGettable b,
	LonLatHelper.LonLatDistanceAlgorithm llda = LonLatHelper.LonLatDistanceAlgorithm.Haversine,
	IGeometricalSpecificationGettable planet = null
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="T_usagi_Quantity_GeoLocation_ILonLatGettable.md">usagi.Quantity.GeoLocation.ILonLatGettable</a><br />経緯度の位置1つめ</dd><dt>b</dt><dd>型: <a href="T_usagi_Quantity_GeoLocation_ILonLatGettable.md">usagi.Quantity.GeoLocation.ILonLatGettable</a><br />経緯度の位置2つめ</dd><dt>llda (Optional)</dt><dd>型: <a href="T_usagi_CivilEngineering_LonLatHelper_LonLatDistanceAlgorithm.md">usagi.CivilEngineering.LonLatHelper.LonLatDistanceAlgorithm</a><br />経緯度の距離を計算するアルゴリズム</dd><dt>planet (Optional)</dt><dd>型: <a href="T_usagi_CivilEngineering_Planet_IGeometricalSpecificationGettable.md">usagi.CivilEngineering.Planet.IGeometricalSpecificationGettable</a><br />楕円体近似した惑星の形状定義; null の場合は <a href="P_usagi_CivilEngineering_Planet_GeometricalSpecification_Earth_WGS84.md">Earth_WGS84</a> が採用されます</dd></dl>

#### 戻り値
型: <a href="T_usagi_Quantity_Length.md">Length</a><br />距離

#### 使用上の注意
Visual Basic と C#では、<a href="T_usagi_Quantity_GeoLocation_ILonLatGettable.md">ILonLatGettable</a>型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_CivilEngineering_LonLatHelper.md">LonLatHelper クラス</a><br /><a href="N_usagi_CivilEngineering.md">usagi.CivilEngineering 名前空間</a><br />