# Calculation.Distance(*T*) メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

a と b の距離（差）を計算する 

a と b の順序はどうでもよい


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public static T Distance<T>(
	T a,
	T b,
	Func<T, T, T> OperatorSubtract
)
where T : Object, IComparable<T>

```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: *T*<br />距離を計算する1つめの値</dd><dt>b</dt><dd>型: *T*<br />距離を計算する2つめの値</dd><dt>OperatorSubtract</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/bb534647" target="_blank">System.Func</a>(*T*, *T*, *T*)<br />T型の減算関数</dd></dl>

#### 型パラメーター
&nbsp;<dl><dt>T</dt><dd>減算可能な任意の型</dd></dl>

#### 戻り値
型: *T*<br />a と bの距離（差）

## 関連項目


#### 参照
<a href="T_usagi_Quantity_Calculation.md">Calculation クラス</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />