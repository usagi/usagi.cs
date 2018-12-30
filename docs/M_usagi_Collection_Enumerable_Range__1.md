# Enumerable.Range(*T*) メソッド (Func(*T*, *T*), ValueTuple(*T*, *T*, Enumerable.RangeTermination)[])<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

複数の区間を列挙する。 区間間（タイポではない）は、連続でも、不連続でも、重複が無くても、重複があっても構わない。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Collection.md">usagi.Collection</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public static IEnumerable<T> Range<T>(
	Func<T, T> stepper,
	params (T , T , Enumerable.RangeTermination )[] ranges
)
where T : Object, IComparable<T>

```


#### パラメーター
&nbsp;<dl><dt>stepper</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/bb549151" target="_blank">System.Func</a>(*T*, *T*)<br />T型をインクリメントするファンクター</dd><dt>ranges</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/mt744799" target="_blank">System.ValueTuple</a>(*T*, *T*, <a href="T_usagi_Collection_Enumerable_RangeTermination.md">Enumerable.RangeTermination</a>)[]<br />任意個の ( 始端要素, 終端要素, 区間端の開閉) 群</dd></dl>

#### 型パラメーター
&nbsp;<dl><dt>T</dt><dd>要素の型</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">IEnumerable</a>(*T*)<br />すべての区間の列挙

## 関連項目


#### 参照
<a href="T_usagi_Collection_Enumerable.md">Enumerable クラス</a><br /><a href="Overload_usagi_Collection_Enumerable_Range.md">Range オーバーロード</a><br /><a href="N_usagi_Collection.md">usagi.Collection 名前空間</a><br />