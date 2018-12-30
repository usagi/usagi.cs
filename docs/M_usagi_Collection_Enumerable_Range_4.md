# Enumerable.Range メソッド (Int32)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

[ 0, ...., count ) な列挙を得る 

<a href="M_usagi_Collection_Enumerable_Range_5.md">Range(Int32, Int32)</a> へ 
```
( 0, count )
```
 を渡す糖衣構文


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Collection.md">usagi.Collection</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public static IEnumerable<int> Range(
	int count
)
```


#### パラメーター
&nbsp;<dl><dt>count</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/td2s409d" target="_blank">System.Int32</a><br />いくつ欲しいのか</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">IEnumerable</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/td2s409d" target="_blank">Int32</a>)<br />[ begin, ...., begin + count ) な列挙

## 解説
とかしても Enumerable.Range と EnumerableHelper.Range を 使い分けするの手間なのでこっちで .Range の面倒を全てみられるよう用意した。

## 関連項目


#### 参照
<a href="T_usagi_Collection_Enumerable.md">Enumerable クラス</a><br /><a href="Overload_usagi_Collection_Enumerable_Range.md">Range オーバーロード</a><br /><a href="N_usagi_Collection.md">usagi.Collection 名前空間</a><br />