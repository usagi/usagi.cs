# IEnumerableExtension.Range(*T*) メソッド (Int32, Int32, Func(Int32, *T*))<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

[ begin, ... , count ) を始域とし、 generator を写像として得られる 順序対の終域の要素の列挙を得る。 但し、 
```
count < 0
```
 では空の結果を得る。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Collection_Extension.md">usagi.Collection.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public static IEnumerable<T> Range<T>(
	int begin,
	int count,
	Func<int, T> generator
)

```


#### パラメーター
&nbsp;<dl><dt>begin</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/td2s409d" target="_blank">System.Int32</a><br />始域のはじめに列挙される数</dd><dt>count</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/td2s409d" target="_blank">System.Int32</a><br />始域の要素数</dd><dt>generator</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/bb549151" target="_blank">System.Func</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/td2s409d" target="_blank">Int32</a>, *T*)<br />始域の要素から出力を生成可能なファンクター</dd></dl>

#### 型パラメーター
&nbsp;<dl><dt>T</dt><dd>generator の出力する型</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">IEnumerable</a>(*T*)<br />[ begin, ... , count ) を始域とし、 generator を写像として得られる 順序対の終域の要素の列挙

## 関連項目


#### 参照
<a href="T_usagi_Collection_Extension_IEnumerableExtension.md">IEnumerableExtension クラス</a><br /><a href="Overload_usagi_Collection_Extension_IEnumerableExtension_Range.md">Range オーバーロード</a><br /><a href="N_usagi_Collection_Extension.md">usagi.Collection.Extension 名前空間</a><br />