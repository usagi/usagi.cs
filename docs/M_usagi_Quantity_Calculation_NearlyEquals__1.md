# Calculation.NearlyEquals(*T*) メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

a と b の差が tolerance 以下か判定する 

許容範囲（許容誤差）において近似的に等価


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static bool NearlyEquals<T>(
	T a,
	T b,
	T tolerance,
	Func<T, T, T> OperatorSubtract,
	Func<T, T, T> OperatorAdd
)
where T : Object, IComparable<T>

```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: *T*<br />差を判定したい1つめの値</dd><dt>b</dt><dd>型: *T*<br />差を判定したい2つめの値</dd><dt>tolerance</dt><dd>型: *T*<br />許容範囲（許容誤差）</dd><dt>OperatorSubtract</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/bb534647" target="_blank">System.Func</a>(*T*, *T*, *T*)<br />T型の減算関数</dd><dt>OperatorAdd</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/bb534647" target="_blank">System.Func</a>(*T*, *T*, *T*)<br />T型の加算関数</dd></dl>

#### 型パラメーター
&nbsp;<dl><dt>T</dt><dd>比較計算可能かつ減算可能かつ加算可能な任意の型</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/a28wyd50" target="_blank">Boolean</a><br />a と b の差が tolerance 以下なら true

## 関連項目


#### 参照
<a href="T_usagi_Quantity_Calculation.md">Calculation クラス</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />