# Calculation.IsInRangeOf(*T*) メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

a が [ floor ... ceil ] に含まれるか判定する


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static bool IsInRangeOf<T>(
	T a,
	T floor,
	T ceil
)
where T : Object, IComparable<T>

```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: *T*<br />判定対象の値</dd><dt>floor</dt><dd>型: *T*<br />床値（値域の末端に含まれる）</dd><dt>ceil</dt><dd>型: *T*<br />天井値（値域の末端に含まれる）</dd></dl>

#### 型パラメーター
&nbsp;<dl><dt>T</dt><dd>比較計算可能な任意の型</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/a28wyd50" target="_blank">Boolean</a><br />a が [ floor ... ceil ] に含まれる場合は true

## 関連項目


#### 参照
<a href="T_usagi_Quantity_Calculation.md">Calculation クラス</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />