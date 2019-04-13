# NumericExtension.ToUNorm メソッド (UInt32, Double, Double, Double)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

[ 0 ... 1 ] へ射影します。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity_Ratio_Extension.md">usagi.Quantity.Ratio.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static double ToUNorm(
	this uint a,
	double domain_logical_zero = 0,
	double domain_logical_ceil = 4294967295,
	double morphism_bias = 0
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/ctys3981" target="_blank">System.UInt32</a><br />元値</dd><dt>domain_logical_zero (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">System.Double</a><br />始域の始端</dd><dt>domain_logical_ceil (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">System.Double</a><br />終域の終端</dd><dt>morphism_bias (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">System.Double</a><br />終域</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">Double</a><br />射影された値

#### 使用上の注意
Visual Basic と C#では、<a href="http://msdn2.microsoft.com/ja-jp/library/ctys3981" target="_blank">UInt32</a>型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_Quantity_Ratio_Extension_NumericExtension.md">NumericExtension クラス</a><br /><a href="Overload_usagi_Quantity_Ratio_Extension_NumericExtension_ToUNorm.md">ToUNorm オーバーロード</a><br /><a href="N_usagi_Quantity_Ratio_Extension.md">usagi.Quantity.Ratio.Extension 名前空間</a><br />