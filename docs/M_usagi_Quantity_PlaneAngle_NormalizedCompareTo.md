# PlaneAngle.NormalizedCompareTo メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

[0...360) deg へ正規化した場合の角度の比較を行います。 

例: a=-30, b=60 が与えられた場合、 330 vs. 60 となり結果は false となります。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public int NormalizedCompareTo(
	PlaneAngle a
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />比較対象の平面角</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/td2s409d" target="_blank">Int32</a><br />正規化した上で CompareTo した結果

## 関連項目


#### 参照
<a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle クラス</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />