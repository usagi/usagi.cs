# ItemsControlHelper.FindControlAs(*T*) メソッド (ItemsControl, Int32, String)<small>[<<Back to Home](https://github.com/usagi/usagi.cs/blob/master/Help/Home.md)</small> 

GetContentPresenter + FindControlAs の合体技 

control の index 番目のアイテムから名前が name のコントロールを T 型で引っ張り出す


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Extension.md">usagi.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public static T FindControlAs<T>(
	this ItemsControl control,
	int index,
	string name
)
where T : Control

```


#### パラメーター
&nbsp;<dl><dt>control</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/ms611045" target="_blank">System.Windows.Controls.ItemsControl</a><br />引っ張り出し元</dd><dt>index</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/td2s409d" target="_blank">System.Int32</a><br />名前が name のコントロールを引っ張り出したい control のアイテムのインデックス</dd><dt>name</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">System.String</a><br />引っ張り出したいアイテムの名前</dd></dl>

#### 型パラメーター
&nbsp;<dl><dt>T</dt><dd>引っ張り出したいコントロールの型</dd></dl>

#### 戻り値
型: *T*<br />引っ張り出されたコントロールまたは null

#### 使用上の注意
Visual Basic と C#では、<a href="http://msdn2.microsoft.com/ja-jp/library/ms611045" target="_blank">ItemsControl</a>型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 例

```
if ( control.FindControlAs<TextBlock>( 0, "Name1" ) is TextBlock c )
  Console.WriteLine( c.Text );
```


## 関連項目


#### 参照
<a href="T_usagi_Extension_ItemsControlHelper.md">ItemsControlHelper クラス</a><br /><a href="Overload_usagi_Extension_ItemsControlHelper_FindControlAs.md">FindControlAs オーバーロード</a><br /><a href="N_usagi_Extension.md">usagi.Extension 名前空間</a><br />