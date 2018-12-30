# ColorExtension.NearlyEqualsInHSLA メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

色が近似的に等価とみなせるか判定する


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_ColorSpace_Extension.md">usagi.ColorSpace.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public static bool NearlyEqualsInHSLA(
	this Color a,
	Color b,
	PlaneAngle hue_tolerance = null,
	double satulation_tolerance = 0.01,
	double luminance_tolerance = 0.01,
	double alpha_tolerance = 0.01
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/ms653055" target="_blank">System.Windows.Media.Color</a><br />色その1</dd><dt>b</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/ms653055" target="_blank">System.Windows.Media.Color</a><br />色その2</dd><dt>hue_tolerance (Optional)</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />色相の許容範囲</dd><dt>satulation_tolerance (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">System.Double</a><br />飽和度の許容範囲</dd><dt>luminance_tolerance (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">System.Double</a><br />明るさの許容範囲</dd><dt>alpha_tolerance (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">System.Double</a><br />判定結果</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/a28wyd50" target="_blank">Boolean</a><br />近似的に等価と見做せる場合は true, それ以外は false

#### 使用上の注意
Visual Basic と C#では、<a href="http://msdn2.microsoft.com/ja-jp/library/ms653055" target="_blank">Color</a>型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_ColorSpace_Extension_ColorExtension.md">ColorExtension クラス</a><br /><a href="N_usagi_ColorSpace_Extension.md">usagi.ColorSpace.Extension 名前空間</a><br />