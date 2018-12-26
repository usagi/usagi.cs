# EnumerableHelper.Range メソッド (Int32, Int32)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

[ begin, ...., begin + count ) な列挙を得る。 但し、 
```
count < 0
```
 では空の結果を得る。 

<a href="http://msdn2.microsoft.com/ja-jp/library/bb341264" target="_blank">Range(Int32, Int32)</a> への糖衣構文


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Extension_Collection.md">usagi.Extension.Collection</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.2.0.0 (1.2.0.0)

## 構文

**C#**<br />
``` C#
public static IEnumerable<int> Range(
	int begin,
	int count
)
```


#### パラメーター
&nbsp;<dl><dt>begin</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/td2s409d" target="_blank">System.Int32</a><br />はじまり</dd><dt>count</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/td2s409d" target="_blank">System.Int32</a><br />いくつ欲しいのか</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">IEnumerable</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/td2s409d" target="_blank">Int32</a>)<br />[ begin, ...., begin + count ) な列挙

## 解説
とかしても Enumerable.Range と EnumerableHelper.Range を 使い分けするの手間なのでこっちで .Range の面倒を全てみられるよう用意した。

## 関連項目


#### 参照
<a href="T_usagi_Extension_Collection_EnumerableHelper.md">EnumerableHelper クラス</a><br /><a href="Overload_usagi_Extension_Collection_EnumerableHelper_Range.md">Range オーバーロード</a><br /><a href="N_usagi_Extension_Collection.md">usagi.Extension.Collection 名前空間</a><br />