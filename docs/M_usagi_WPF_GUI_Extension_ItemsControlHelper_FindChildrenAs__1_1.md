# ItemsControlHelper.FindChildrenAs(*T*) メソッド (ItemsControl, String[])<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div><p style="color: #dc143c; font-size: 8.5pt; font-weight: bold;">["M:usagi.WPF.GUI.Extension.ItemsControlHelper.FindChildrenAs``1(System.Windows.Controls.ItemsControl,System.String[])"に対する<summary>がありません]</p><strong>名前空間:</strong>
&nbsp;<a href="N_usagi_WPF_GUI_Extension.md">usagi.WPF.GUI.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi.WPF (in usagi.WPF.dll) バージョン: 0.0.0.0

## 構文

**C#**<br />
``` C#
public static IEnumerable<IDictionary<string, T>> FindChildrenAs<T>(
	this ItemsControl c,
	params string[] names
)
where T : class

```


#### パラメーター
&nbsp;<dl><dt>c</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/ms611045" target="_blank">System.Windows.Controls.ItemsControl</a><br /><p style="color: #dc143c; font-size: 8.5pt; font-weight: bold;">["M:usagi.WPF.GUI.Extension.ItemsControlHelper.FindChildrenAs``1(System.Windows.Controls.ItemsControl,System.String[])"に対する<param name="c"/>がありません</p></dd><dt>names</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">System.String</a>[]<br /><p style="color: #dc143c; font-size: 8.5pt; font-weight: bold;">["M:usagi.WPF.GUI.Extension.ItemsControlHelper.FindChildrenAs``1(System.Windows.Controls.ItemsControl,System.String[])"に対する<param name="names"/>がありません</p></dd></dl>

#### 型パラメーター
&nbsp;<dl><dt>T</dt><dd><p style="color: #dc143c; font-size: 8.5pt; font-weight: bold;">["M:usagi.WPF.GUI.Extension.ItemsControlHelper.FindChildrenAs``1(System.Windows.Controls.ItemsControl,System.String[])"に対する<typeparam name="T"/>がありません</p></dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">IEnumerable</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/s4ys34ea" target="_blank">IDictionary</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">String</a>, *T*))<br /><p style="color: #dc143c; font-size: 8.5pt; font-weight: bold;">["M:usagi.WPF.GUI.Extension.ItemsControlHelper.FindChildrenAs``1(System.Windows.Controls.ItemsControl,System.String[])"に対する<returns>がありません]</p>

#### 使用上の注意
Visual Basic と C#では、<a href="http://msdn2.microsoft.com/ja-jp/library/ms611045" target="_blank">ItemsControl</a>型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_WPF_GUI_Extension_ItemsControlHelper.md">ItemsControlHelper クラス</a><br /><a href="Overload_usagi_WPF_GUI_Extension_ItemsControlHelper_FindChildrenAs.md">FindChildrenAs オーバーロード</a><br /><a href="N_usagi_WPF_GUI_Extension.md">usagi.WPF.GUI.Extension 名前空間</a><br />