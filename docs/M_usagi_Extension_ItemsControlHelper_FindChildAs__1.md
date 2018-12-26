# ItemsControlHelper.FindChildAs(*T*) メソッド (ContentPresenter, String)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

ContentPresenter から name の object を T 型で引っ張り出す 

<a href="M_usagi_Extension_ItemsControlHelper_FindChild.md">FindChild(ContentPresenter, String)</a> の型キャスト付き版


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Extension.md">usagi.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.2.0.0 (1.2.0.0)

## 構文

**C#**<br />
``` C#
public static T FindChildAs<T>(
	this ContentPresenter p,
	string name
)
where T : class

```


#### パラメーター
&nbsp;<dl><dt>p</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/ms609804" target="_blank">System.Windows.Controls.ContentPresenter</a><br />引っ張り出し元</dd><dt>name</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">System.String</a><br />引っ張り出したい object の名前</dd></dl>

#### 型パラメーター
&nbsp;<dl><dt>T</dt><dd>引っ張り出したい object の型</dd></dl>

#### 戻り値
型: *T*<br />引っ張り出された T 型の object または null

#### 使用上の注意
Visual Basic と C#では、<a href="http://msdn2.microsoft.com/ja-jp/library/ms609804" target="_blank">ContentPresenter</a>型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_Extension_ItemsControlHelper.md">ItemsControlHelper クラス</a><br /><a href="Overload_usagi_Extension_ItemsControlHelper_FindChildAs.md">FindChildAs オーバーロード</a><br /><a href="N_usagi_Extension.md">usagi.Extension 名前空間</a><br />