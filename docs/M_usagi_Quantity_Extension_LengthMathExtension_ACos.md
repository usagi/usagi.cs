# LengthMathExtension.ACos メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

逆余弦値を cathetus / hypotenuse から計算しますよ


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity_Extension.md">usagi.Quantity.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static PlaneAngle ACos(
	this Length hypotenuse,
	Length cathetus
)
```


#### パラメーター
&nbsp;<dl><dt>hypotenuse</dt><dd>型: <a href="T_usagi_Quantity_Length.md">usagi.Quantity.Length</a><br />斜辺 ( this )</dd><dt>cathetus</dt><dd>型: <a href="T_usagi_Quantity_Length.md">usagi.Quantity.Length</a><br />隣辺 ( 相手 )</dd></dl>

#### 戻り値
型: <a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle</a><br />逆余弦による平面角

#### 使用上の注意
Visual Basic と C#では、<a href="T_usagi_Quantity_Length.md">Length</a>型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_Quantity_Extension_LengthMathExtension.md">LengthMathExtension クラス</a><br /><a href="N_usagi_Quantity_Extension.md">usagi.Quantity.Extension 名前空間</a><br />