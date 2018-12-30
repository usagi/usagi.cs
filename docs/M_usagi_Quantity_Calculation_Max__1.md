# Calculation.Max(*T*) メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

任意個の値から最大の値を1つ抽出する


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public static T Max<T>(
	params T[] values
)
where T : Object, IComparable<T>

```


#### パラメーター
&nbsp;<dl><dt>values</dt><dd>型: *T*[]<br />任意個の値群</dd></dl>

#### 型パラメーター
&nbsp;<dl><dt>T</dt><dd>比較計算可能な任意の型</dd></dl>

#### 戻り値
型: *T*<br />抽出された最大の値

## 関連項目


#### 参照
<a href="T_usagi_Quantity_Calculation.md">Calculation クラス</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />