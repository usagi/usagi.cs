# Numeric.ClampAdd メソッド (UInt64, UInt64)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

元の型の定義域内に必ず収まるクランプ付きの加算


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_InformationEngineering.md">usagi.InformationEngineering</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static ulong ClampAdd(
	this ulong a,
	ulong b
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/06cf7918" target="_blank">System.UInt64</a><br />元の値</dd><dt>b</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/06cf7918" target="_blank">System.UInt64</a><br />足す値</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/06cf7918" target="_blank">UInt64</a><br />加算結果

#### 使用上の注意
Visual Basic と C#では、<a href="http://msdn2.microsoft.com/ja-jp/library/06cf7918" target="_blank">UInt64</a>型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_InformationEngineering_Numeric.md">Numeric クラス</a><br /><a href="Overload_usagi_InformationEngineering_Numeric_ClampAdd.md">ClampAdd オーバーロード</a><br /><a href="N_usagi_InformationEngineering.md">usagi.InformationEngineering 名前空間</a><br />