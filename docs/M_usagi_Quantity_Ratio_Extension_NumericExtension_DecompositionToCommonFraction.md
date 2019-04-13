# NumericExtension.DecompositionToCommonFraction メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

分子と分母からなる分数表現へ変換する


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity_Ratio_Extension.md">usagi.Quantity.Ratio.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static (int Numerator, int Denominator) DecompositionToCommonFraction(
	this double a,
	Nullable<double> epsilon = null
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">System.Double</a><br />比</dd><dt>epsilon (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/b3h38hb0" target="_blank">System.Nullable</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">Double</a>)<br />変換の粗さ; null の場合は 1.0e-6 を使う。 値が小さいほど精度が上がるが計算時間も増える。 また、精度が高すぎると大雑把な分数値が欲しい場合に 分子、分母の桁が大きすぎてソレじゃないになる事もある。</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/mt744804" target="_blank">ValueTuple</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/td2s409d" target="_blank">Int32</a>, <a href="http://msdn2.microsoft.com/ja-jp/library/td2s409d" target="_blank">Int32</a>)<br />分母と分子からなる分数表現の比

#### 使用上の注意
Visual Basic と C#では、<a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">Double</a>型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_Quantity_Ratio_Extension_NumericExtension.md">NumericExtension クラス</a><br /><a href="N_usagi_Quantity_Ratio_Extension.md">usagi.Quantity.Ratio.Extension 名前空間</a><br />