# Factory.FromHSLA メソッド (PlaneAngle, Double, Double, Double)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

HSLA から色をつくる


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_ColorSpace.md">usagi.ColorSpace</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public static Color FromHSLA(
	PlaneAngle h,
	double s,
	double l,
	double a = 1
)
```


#### パラメーター
&nbsp;<dl><dt>h</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />色相</dd><dt>s</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">System.Double</a><br />飽和度</dd><dt>l</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">System.Double</a><br />明るさ</dd><dt>a (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">System.Double</a><br />不透明度</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/ms653055" target="_blank">Color</a><br />色　

## 関連項目


#### 参照
<a href="T_usagi_ColorSpace_Factory.md">Factory クラス</a><br /><a href="Overload_usagi_ColorSpace_Factory_FromHSLA.md">FromHSLA オーバーロード</a><br /><a href="N_usagi_ColorSpace.md">usagi.ColorSpace 名前空間</a><br />