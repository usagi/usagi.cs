# ItemsControlHelper.FindChildrenAs(*T*) メソッド (ItemsControl, Int32, String[])<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div><a href="M_usagi_Extension_ItemsControlHelper_FindChildren_1.md">FindChildren(ItemsControl, String[])</a><strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Extension.md">usagi.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.2.0.0 (1.2.0.0)

## 構文

**C#**<br />
``` C#
public static IDictionary<string, T> FindChildrenAs<T>(
	this ItemsControl c,
	int index,
	params string[] names
)
where T : class

```


#### パラメーター
&nbsp;<dl><dt>c</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/ms611045" target="_blank">System.Windows.Controls.ItemsControl</a><br />引っ張り出し元</dd><dt>index</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/td2s409d" target="_blank">System.Int32</a><br />ContentPresenter を引っ張り出したいアイテムのインデックス</dd><dt>names</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">System.String</a>[]<br />引っ張り出し元の各アイテムごとに引っ張り出したいコントロールの名前群</dd></dl>

#### 型パラメーター
&nbsp;<dl><dt>T</dt><dd /></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/s4ys34ea" target="_blank">IDictionary</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">String</a>, *T*)<br /><<Key=名前, Value=引っ張り出されたアイテムまたは null>の辞書>の列挙

#### 使用上の注意
Visual Basic と C#では、<a href="http://msdn2.microsoft.com/ja-jp/library/ms611045" target="_blank">ItemsControl</a>型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_Extension_ItemsControlHelper.md">ItemsControlHelper クラス</a><br /><a href="Overload_usagi_Extension_ItemsControlHelper_FindChildrenAs.md">FindChildrenAs オーバーロード</a><br /><a href="N_usagi_Extension.md">usagi.Extension 名前空間</a><br />