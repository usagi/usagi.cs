# Length.NearlyEquals メソッド <small>[<<Back to Home](https://github.com/usagi/usagi.cs/blob/master/Help/Home.md)</small> 

a と b の差が tolerance 以下か判定する


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public static bool NearlyEquals(
	Length a,
	Length b,
	Length tolerance = null
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="T_usagi_Quantity_Length.md">usagi.Quantity.Length</a><br />任意の長さ1つめ</dd><dt>b</dt><dd>型: <a href="T_usagi_Quantity_Length.md">usagi.Quantity.Length</a><br />任意の長さ2つめ</dd><dt>tolerance (Optional)</dt><dd>型: <a href="T_usagi_Quantity_Length.md">usagi.Quantity.Length</a><br />許容範囲（誤差） null の場合は Length.From_mm(1) が代用される</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/a28wyd50" target="_blank">Boolean</a><br />a と b の差が tolerance 以下なら true 、そうでなければ false

## 関連項目


#### 参照
<a href="T_usagi_Quantity_Length.md">Length クラス</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />