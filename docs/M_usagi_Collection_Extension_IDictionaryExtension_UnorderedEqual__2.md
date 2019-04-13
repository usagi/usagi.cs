# IDictionaryExtension.UnorderedEqual(*TK*, *TV*) メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

IDictionary を実装する型 a, b について等価な Key と Value の組み合わせ群を保持するか判定する。 SequenceEqual と異なり列挙される順序の影響を受けない ref. https://stackoverflow.com/a/3928856/1211392


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Collection_Extension.md">usagi.Collection.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static bool UnorderedEqual<TK, TV>(
	this IDictionary<TK, TV> a,
	IDictionary<TK, TV> b,
	IEqualityComparer<TV> c = null
)

```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s4ys34ea" target="_blank">System.Collections.Generic.IDictionary</a>(*TK*, *TV*)<br />比較において this となる IDictionary を実装する型のインスタンス</dd><dt>b</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s4ys34ea" target="_blank">System.Collections.Generic.IDictionary</a>(*TK*, *TV*)<br />比較において this と比較される IDictionary を実装する型のインスタンス</dd><dt>c (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/ms132151" target="_blank">System.Collections.Generic.IEqualityComparer</a>(*TV*)<br />TV型の等価判定関数。 null を与えた場合は EqualityComparer<TV>.Default を採用する</dd></dl>

#### 型パラメーター
&nbsp;<dl><dt>TK</dt><dd>Key の型</dd><dt>TV</dt><dd>Value の型</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/a28wyd50" target="_blank">Boolean</a><br />a, b が等価な Key と Value の組み合わせ群を保持する場合は true 、そうでなければ false

#### 使用上の注意
Visual Basic と C#では、<a href="http://msdn2.microsoft.com/ja-jp/library/s4ys34ea" target="_blank">IDictionary</a>(*TK*, *TV*)型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_Collection_Extension_IDictionaryExtension.md">IDictionaryExtension クラス</a><br /><a href="N_usagi_Collection_Extension.md">usagi.Collection.Extension 名前空間</a><br />