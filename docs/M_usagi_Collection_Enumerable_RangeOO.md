# Enumerable.RangeOO メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

区間 { begin ... end } を列挙します。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Collection.md">usagi.Collection</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static IEnumerable<ushort> RangeOO(
	ushort begin,
	ushort end,
	Enumerable.RangeTermination termination
)
```


#### パラメーター
&nbsp;<dl><dt>begin</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s6eyk10z" target="_blank">System.UInt16</a><br />区間の始端</dd><dt>end</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s6eyk10z" target="_blank">System.UInt16</a><br />区間の終端</dd><dt>termination</dt><dd>型: <a href="T_usagi_Collection_Enumerable_RangeTermination.md">usagi.Collection.Enumerable.RangeTermination</a><br />区間端の開閉</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">IEnumerable</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/s6eyk10z" target="_blank">UInt16</a>)<br />区間の列挙

## 関連項目


#### 参照
<a href="T_usagi_Collection_Enumerable.md">Enumerable クラス</a><br /><a href="N_usagi_Collection.md">usagi.Collection 名前空間</a><br />