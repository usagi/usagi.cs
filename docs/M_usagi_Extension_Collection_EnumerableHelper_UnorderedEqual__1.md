# EnumerableHelper.UnorderedEqual(*T*) メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

IEnumerable を実装する型 a, b について等価な値を保持するか判定する。 SequenceEqual と異なり列挙される順序の影響を受けない ref. https://stackoverflow.com/a/3670089/1211392


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Extension_Collection.md">usagi.Extension.Collection</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public static bool UnorderedEqual<T>(
	this IEnumerable<T> a,
	IEnumerable<T> b
)

```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">System.Collections.Generic.IEnumerable</a>(*T*)<br />IEnumerable を実装する型 a</dd><dt>b</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">System.Collections.Generic.IEnumerable</a>(*T*)<br />IEnumerable を実装する型 b</dd></dl>

#### 型パラメーター
&nbsp;<dl><dt>T</dt><dd>IEnumerable で取り出せる中身の型</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/a28wyd50" target="_blank">Boolean</a><br />等価な値を保持している場合は true

#### 使用上の注意
Visual Basic と C#では、<a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">IEnumerable</a>(*T*)型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_Extension_Collection_EnumerableHelper.md">EnumerableHelper クラス</a><br /><a href="N_usagi_Extension_Collection.md">usagi.Extension.Collection 名前空間</a><br />