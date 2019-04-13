# Enumerable.Range(*T*) メソッド (*T*, *T*, Enumerable.RangeTermination, Func(*T*, *T*))<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

始端、終端、区間端の開閉、要素のインクリメントファンクターによる ジェネリック版 Range


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Collection.md">usagi.Collection</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static IEnumerable<T> Range<T>(
	T begin,
	T end,
	Enumerable.RangeTermination termination,
	Func<T, T> stepper
)
where T : Object, IComparable<T>

```


#### パラメーター
&nbsp;<dl><dt>begin</dt><dd>型: *T*<br />区間の始端</dd><dt>end</dt><dd>型: *T*<br />区間の終端</dd><dt>termination</dt><dd>型: <a href="T_usagi_Collection_Enumerable_RangeTermination.md">usagi.Collection.Enumerable.RangeTermination</a><br />区間端の開閉</dd><dt>stepper</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/bb549151" target="_blank">System.Func</a>(*T*, *T*)<br />T型をインクリメントするファンクター</dd></dl>

#### 型パラメーター
&nbsp;<dl><dt>T</dt><dd>区間の要素の型</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">IEnumerable</a>(*T*)<br />区間の要素の列挙

## 関連項目


#### 参照
<a href="T_usagi_Collection_Enumerable.md">Enumerable クラス</a><br /><a href="Overload_usagi_Collection_Enumerable_Range.md">Range オーバーロード</a><br /><a href="N_usagi_Collection.md">usagi.Collection 名前空間</a><br />