# PlaneAngle.NearlyEquals メソッド (PlaneAngle, PlaneAngle)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

NearlyEquals( this, a tolerance ) への糖衣構文


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public bool NearlyEquals(
	PlaneAngle a,
	PlaneAngle tolerance = null
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />比較対象の平面角</dd><dt>tolerance (Optional)</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />許容範囲（誤差） null の場合は PlaneAngle.CentiSecond が代用される</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/a28wyd50" target="_blank">Boolean</a><br />等価と見做せる場合は ture

## 関連項目


#### 参照
<a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle クラス</a><br /><a href="Overload_usagi_Quantity_PlaneAngle_NearlyEquals.md">NearlyEquals オーバーロード</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />