# NumericExtension.ToRatio メソッド (Single, Single, Single, Single)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

比率を生成


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity_Ratio_Extension.md">usagi.Quantity.Ratio.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static float ToRatio(
	this float domain_value,
	float domain_logical_zero = 0f,
	float domain_logical_ceil = 1f,
	float morphism_bias = 0f
)
```


#### パラメーター
&nbsp;<dl><dt>domain_value</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/3www918f" target="_blank">System.Single</a><br />始域の値</dd><dt>domain_logical_zero (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/3www918f" target="_blank">System.Single</a><br />始域のゼロ</dd><dt>domain_logical_ceil (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/3www918f" target="_blank">System.Single</a><br />始域の天井</dd><dt>morphism_bias (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/3www918f" target="_blank">System.Single</a><br />終域でのバイアス</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/3www918f" target="_blank">Single</a><br />比

#### 使用上の注意
Visual Basic と C#では、<a href="http://msdn2.microsoft.com/ja-jp/library/3www918f" target="_blank">Single</a>型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_Quantity_Ratio_Extension_NumericExtension.md">NumericExtension クラス</a><br /><a href="Overload_usagi_Quantity_Ratio_Extension_NumericExtension_ToRatio.md">ToRatio オーバーロード</a><br /><a href="N_usagi_Quantity_Ratio_Extension.md">usagi.Quantity.Ratio.Extension 名前空間</a><br />