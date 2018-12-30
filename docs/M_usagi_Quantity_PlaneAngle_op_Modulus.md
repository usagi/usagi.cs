# PlaneAngle.Modulus 演算子 <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

角度の剰余を計算する2項演算子 

Note: 実用上の有意性を考慮し、剰余については正規化した場合の結果を計算する


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public static PlaneAngle operator %(
	PlaneAngle a,
	PlaneAngle b
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />平面角 a</dd><dt>b</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />平面角 b</dd></dl>

#### 戻り値
型: <a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle</a><br />a % b した剰余な平面角

## 関連項目


#### 参照
<a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle クラス</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />