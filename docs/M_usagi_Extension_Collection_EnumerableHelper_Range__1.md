# EnumerableHelper.Range(*T*) メソッド (Int32, Func(*T*))<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

generator で count 個の列挙を得る。 但し、 
```
count < 0
```
 では空の結果を得る。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Extension_Collection.md">usagi.Extension.Collection</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.2.0.0 (1.2.0.0)

## 構文

**C#**<br />
``` C#
public static IEnumerable<T> Range<T>(
	int count,
	Func<T> generator
)

```


#### パラメーター
&nbsp;<dl><dt>count</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/td2s409d" target="_blank">System.Int32</a><br />出力を得たい数量</dd><dt>generator</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/bb534960" target="_blank">System.Func</a>(*T*)<br />出力を生成可能なファンクター</dd></dl>

#### 型パラメーター
&nbsp;<dl><dt>T</dt><dd>generator 出力する型</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">IEnumerable</a>(*T*)<br />generator により生成される count 個の列挙

## 関連項目


#### 参照
<a href="T_usagi_Extension_Collection_EnumerableHelper.md">EnumerableHelper クラス</a><br /><a href="Overload_usagi_Extension_Collection_EnumerableHelper_Range.md">Range オーバーロード</a><br /><a href="N_usagi_Extension_Collection.md">usagi.Extension.Collection 名前空間</a><br />