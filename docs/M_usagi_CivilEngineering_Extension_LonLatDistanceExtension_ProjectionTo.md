# LonLatDistanceExtension.ProjectionTo メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

Vincenty のアルゴリズムで経緯度 origin から距離 distance だけ角度 angle の方位へ射影した経緯度を計算するよ


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_CivilEngineering_Extension.md">usagi.CivilEngineering.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static LonLat ProjectionTo(
	this ILonLatGettable origin,
	Length distance,
	PlaneAngle angle,
	IGeometricalSpecificationGettable planet = null
)
```


#### パラメーター
&nbsp;<dl><dt>origin</dt><dd>型: <a href="T_usagi_Quantity_GeoLocation_ILonLatGettable.md">usagi.Quantity.GeoLocation.ILonLatGettable</a><br />基点とする位置</dd><dt>distance</dt><dd>型: <a href="T_usagi_Quantity_Length.md">usagi.Quantity.Length</a><br />射影先までの距離</dd><dt>angle</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />射影する方位。北=0deg, 西=+90deg, 東=-90deg, 南=180deg。 atans(y,x) 的には 北向き=+x, 西向き=+y の系</dd><dt>planet (Optional)</dt><dd>型: <a href="T_usagi_CivilEngineering_Planet_IGeometricalSpecificationGettable.md">usagi.CivilEngineering.Planet.IGeometricalSpecificationGettable</a><br />惑星。null の場合は WGS84</dd></dl>

#### 戻り値
型: <a href="T_usagi_Quantity_GeoLocation_LonLat.md">LonLat</a><br />射影先の経緯度

#### 使用上の注意
Visual Basic と C#では、<a href="T_usagi_Quantity_GeoLocation_ILonLatGettable.md">ILonLatGettable</a>型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_CivilEngineering_Extension_LonLatDistanceExtension.md">LonLatDistanceExtension クラス</a><br /><a href="N_usagi_CivilEngineering_Extension.md">usagi.CivilEngineering.Extension 名前空間</a><br />