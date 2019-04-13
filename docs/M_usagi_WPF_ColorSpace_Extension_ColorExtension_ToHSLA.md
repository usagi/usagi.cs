# ColorExtension.ToHSLA メソッド (ValueTuple(Byte, Byte, Byte, Byte))<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div><p style="color: #dc143c; font-size: 8.5pt; font-weight: bold;">["M:usagi.WPF.ColorSpace.Extension.ColorExtension.ToHSLA(System.ValueTuple{System.Byte,System.Byte,System.Byte,System.Byte})"に対する<summary>がありません]</p><strong>名前空間:</strong>
&nbsp;<a href="N_usagi_WPF_ColorSpace_Extension.md">usagi.WPF.ColorSpace.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi.WPF (in usagi.WPF.dll) バージョン: 0.0.0.0

## 構文

**C#**<br />
``` C#
public static (PlaneAngle Hue, double Satulation, double Luminance, double Alpha) ToHSLA(
	this (byte R, byte G, byte B, byte A) rgba
)
```


#### パラメーター
&nbsp;<dl><dt>rgba</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/mt744803" target="_blank">System.ValueTuple</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/yyb1w04y" target="_blank">Byte</a>, <a href="http://msdn2.microsoft.com/ja-jp/library/yyb1w04y" target="_blank">Byte</a>, <a href="http://msdn2.microsoft.com/ja-jp/library/yyb1w04y" target="_blank">Byte</a>, <a href="http://msdn2.microsoft.com/ja-jp/library/yyb1w04y" target="_blank">Byte</a>)<br /><p style="color: #dc143c; font-size: 8.5pt; font-weight: bold;">["M:usagi.WPF.ColorSpace.Extension.ColorExtension.ToHSLA(System.ValueTuple{System.Byte,System.Byte,System.Byte,System.Byte})"に対する<param name="rgba"/>がありません</p></dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/mt744803" target="_blank">ValueTuple</a>(<a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle</a>, <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">Double</a>, <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">Double</a>, <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">Double</a>)<br /><p style="color: #dc143c; font-size: 8.5pt; font-weight: bold;">["M:usagi.WPF.ColorSpace.Extension.ColorExtension.ToHSLA(System.ValueTuple{System.Byte,System.Byte,System.Byte,System.Byte})"に対する<returns>がありません]</p>

#### 使用上の注意
Visual Basic と C#では、<a href="http://msdn2.microsoft.com/ja-jp/library/mt744803" target="_blank">ValueTuple</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/yyb1w04y" target="_blank">Byte</a>, <a href="http://msdn2.microsoft.com/ja-jp/library/yyb1w04y" target="_blank">Byte</a>, <a href="http://msdn2.microsoft.com/ja-jp/library/yyb1w04y" target="_blank">Byte</a>, <a href="http://msdn2.microsoft.com/ja-jp/library/yyb1w04y" target="_blank">Byte</a>)型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_WPF_ColorSpace_Extension_ColorExtension.md">ColorExtension クラス</a><br /><a href="Overload_usagi_WPF_ColorSpace_Extension_ColorExtension_ToHSLA.md">ToHSLA オーバーロード</a><br /><a href="N_usagi_WPF_ColorSpace_Extension.md">usagi.WPF.ColorSpace.Extension 名前空間</a><br />