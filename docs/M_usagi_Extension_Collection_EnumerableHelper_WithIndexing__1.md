# EnumerableHelper.WithIndexing(*T*) メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

IEnumerable を列挙順にインデックス付きにするやつ ref. https://ufcpp.net/blog/2016/12/tipsindexedforeach/


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Extension_Collection.md">usagi.Extension.Collection</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.2.0.0 (1.2.0.0)

## 構文

**C#**<br />
``` C#
public static IEnumerable<(int Index, T )> WithIndexing<T>(
	this IEnumerable<T> items
)

```


#### パラメーター
&nbsp;<dl><dt>items</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">System.Collections.Generic.IEnumerable</a>(*T*)<br />IEnumerable な何か</dd></dl>

#### 型パラメーター
&nbsp;<dl><dt>T</dt><dd>IEnumerable で取り出せる中身の型</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">IEnumerable</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/mt744804" target="_blank">ValueTuple</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/td2s409d" target="_blank">Int32</a>, *T*))<br />インデクシングされたアイテムの列挙

#### 使用上の注意
Visual Basic と C#では、<a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">IEnumerable</a>(*T*)型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 例

```
// 適当な IEnumerable な何か
var items = new string[]{ "aaa", "bbb", "ccc" };
// タプルで取り出すぱたーん
foreach ( var indexed_item in items )
  Console.WriteLine( $"index={indexed_item.Index} item={indexed_item.Item}" );
// タプルを構造化束縛で取り出すぱたーん
foreach ( var (index,item) in items )
  Console.WriteLine( $"index={index} item={item}" );
```


## 関連項目


#### 参照
<a href="T_usagi_Extension_Collection_EnumerableHelper.md">EnumerableHelper クラス</a><br /><a href="N_usagi_Extension_Collection.md">usagi.Extension.Collection 名前空間</a><br />