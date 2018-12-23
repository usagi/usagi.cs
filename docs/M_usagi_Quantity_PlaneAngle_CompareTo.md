# PlaneAngle.CompareTo メソッド <small>[<<Back to Home](https://github.com/usagi/usagi.cs/blob/master/Help/Home.md)</small> 

平面角オブジェクトを比較 

正規化せずに比較する。正規化が必要な場合は NormalizedCompareTo を使うとよい


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public int CompareTo(
	PlaneAngle other
)
```


#### パラメーター
&nbsp;<dl><dt>other</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />比較対象の平面角オブジェクト</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/td2s409d" target="_blank">Int32</a><br />this が小さければ -1, this==other なら 0, this が大きければ +1

#### 実装
<a href="http://msdn2.microsoft.com/ja-jp/library/43hc6wht" target="_blank">IComparable(T).CompareTo(T)</a><br />

## 関連項目


#### 参照
<a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle クラス</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />