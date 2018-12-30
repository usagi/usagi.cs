# NumericNearlyEqualsExtension.NearlyEquals メソッド (Decimal, Decimal, Decimal)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

decimal 特殊化版 

double, float, decimal に対しては内部的にも同じ型のまま計算を行う。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity_Extension.md">usagi.Quantity.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public static bool NearlyEquals(
	this decimal a,
	decimal b,
	decimal tolerance
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/1k2e8atx" target="_blank">System.Decimal</a><br />値 a</dd><dt>b</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/1k2e8atx" target="_blank">System.Decimal</a><br />値 b</dd><dt>tolerance</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/1k2e8atx" target="_blank">System.Decimal</a><br />許容範囲</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/a28wyd50" target="_blank">Boolean</a><br />近似的に等しいと見做せる場合は true

#### 使用上の注意
Visual Basic と C#では、<a href="http://msdn2.microsoft.com/ja-jp/library/1k2e8atx" target="_blank">Decimal</a>型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_Quantity_Extension_NumericNearlyEqualsExtension.md">NumericNearlyEqualsExtension クラス</a><br /><a href="Overload_usagi_Quantity_Extension_NumericNearlyEqualsExtension_NearlyEquals.md">NearlyEquals オーバーロード</a><br /><a href="N_usagi_Quantity_Extension.md">usagi.Quantity.Extension 名前空間</a><br />