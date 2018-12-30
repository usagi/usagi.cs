# PlaneAngle.NearlyEquals メソッド (PlaneAngle, PlaneAngle, PlaneAngle)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

a と b の差が tolerance 以下か判定する


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public static bool NearlyEquals(
	PlaneAngle a,
	PlaneAngle b,
	PlaneAngle tolerance = null
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />任意の平面角1つめ</dd><dt>b</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />任意の平面角2つめ</dd><dt>tolerance (Optional)</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />許容範囲（誤差） null の場合は PlaneAngle.CentiSecond が代用される</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/a28wyd50" target="_blank">Boolean</a><br />a と b の差が tolerance 以下なら true 、そうでなければ false

## 関連項目


#### 参照
<a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle クラス</a><br /><a href="Overload_usagi_Quantity_PlaneAngle_NearlyEquals.md">NearlyEquals オーバーロード</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />