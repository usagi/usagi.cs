# ItemsControlHelper.FindControls メソッド (ItemsControl, String[])<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

FindControls のさらにずぼら横着進化した版 control の全てのアイテムごとに、一度に複数の名前を与えて対応する複数のコントロールを引っ張り出せる。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Extension.md">usagi.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public static IEnumerable<IDictionary<string, Control>> FindControls(
	this ItemsControl control,
	params string[] names
)
```


#### パラメーター
&nbsp;<dl><dt>control</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/ms611045" target="_blank">System.Windows.Controls.ItemsControl</a><br />引っ張り出し元</dd><dt>names</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">System.String</a>[]<br />引っ張り出し元の各アイテムごとに引っ張り出したいコントロールの名前群</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">IEnumerable</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/s4ys34ea" target="_blank">IDictionary</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">String</a>, <a href="http://msdn2.microsoft.com/ja-jp/library/ms609826" target="_blank">Control</a>))<br />{{Key=名前, Value=引っ張り出されたコントロールまたは null}の辞書}の列挙

#### 使用上の注意
Visual Basic と C#では、<a href="http://msdn2.microsoft.com/ja-jp/library/ms611045" target="_blank">ItemsControl</a>型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 例

```
var css = control.FindControls( "Name1", "Name2", "Name3" );
foreach ( var cs in css )
{
  cs[ "Name1" ].DataContext = hoge;
  cs[ "Name2" ].DataContext = fuga;
  if ( cs[ "Name3" ] is TextBlock c )
    Console.WriteLine( c.Text );
}
```


## 関連項目


#### 参照
<a href="T_usagi_Extension_ItemsControlHelper.md">ItemsControlHelper クラス</a><br /><a href="Overload_usagi_Extension_ItemsControlHelper_FindControls.md">FindControls オーバーロード</a><br /><a href="N_usagi_Extension.md">usagi.Extension 名前空間</a><br />