# ItemsControlHelper クラス

<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

System.Windows.Control.ItemsControlHelper に対する機能拡張


## 継承階層
<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;usagi.GUI.Extension.ItemsControlHelper<br /><strong>名前空間:</strong>
&nbsp;<a href="N_usagi_GUI_Extension.md">usagi.GUI.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public static class ItemsControlHelper
```

ItemsControlHelper 型は下記のメンバーを公開します。


## メソッド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_GUI_Extension_ItemsControlHelper_FindChild.md">FindChild(ContentPresenter, String)</a></td><td>
ContentPresenter から name の object を引っ張り出す</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_GUI_Extension_ItemsControlHelper_FindChild_1.md">FindChild(ItemsControl, Int32, String)</a></td><td><a href="M_usagi_GUI_Extension_ItemsControlHelper_GetContentPresenter.md">GetContentPresenter(ItemsControl, Int32)</a> + <a href="M_usagi_GUI_Extension_ItemsControlHelper_FindChild.md">FindChild(ContentPresenter, String)</a> の複合技。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_GUI_Extension_ItemsControlHelper_FindChildAs__1.md">FindChildAs(T)(ContentPresenter, String)</a></td><td>
ContentPresenter から name の object を T 型で引っ張り出す 

<a href="M_usagi_GUI_Extension_ItemsControlHelper_FindChild.md">FindChild(ContentPresenter, String)</a> の型キャスト付き版</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_GUI_Extension_ItemsControlHelper_FindChildAs__1_1.md">FindChildAs(T)(ItemsControl, Int32, String)</a></td><td><a href="M_usagi_GUI_Extension_ItemsControlHelper_FindChild_1.md">FindChild(ItemsControl, Int32, String)</a> の型キャスト付き版</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_usagi_GUI_Extension_ItemsControlHelper_FindChildren_1.md">FindChildren(ItemsControl, String[])</a></td><td><a href="M_usagi_GUI_Extension_ItemsControlHelper_FindChildren.md">FindChildren(ItemsControl, Int32, String[])</a> のさらにずぼら横着進化した版 control の全てのアイテムごとに、一度に複数の名前を与えて対応する複数の object を引っ張り出せる。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_GUI_Extension_ItemsControlHelper_FindChildren.md">FindChildren(ItemsControl, Int32, String[])</a></td><td><a href="M_usagi_GUI_Extension_ItemsControlHelper_GetContentPresenter.md">GetContentPresenter(ItemsControl, Int32)</a> + <a href="M_usagi_GUI_Extension_ItemsControlHelper_FindChild.md">FindChild(ContentPresenter, String)</a> の合体技</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_usagi_GUI_Extension_ItemsControlHelper_FindChildrenAs__1_1.md">FindChildrenAs(T)(ItemsControl, String[])</a></td><td><a href="M_usagi_GUI_Extension_ItemsControlHelper_FindChildrenAs__1.md">FindChildrenAs(T)(ItemsControl, Int32, String[])</a> のさらにずぼら横着進化した版 control の全てのアイテムごとに、一度に複数の名前を与えて対応する複数の object を引っ張り出せる。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_GUI_Extension_ItemsControlHelper_FindChildrenAs__1.md">FindChildrenAs(T)(ItemsControl, Int32, String[])</a></td><td><a href="M_usagi_GUI_Extension_ItemsControlHelper_FindChildren_1.md">FindChildren(ItemsControl, String[])</a></td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_GUI_Extension_ItemsControlHelper_GetContentPresenter.md">GetContentPresenter</a></td><td>
ItemsControl から index 番目のアイテムの ContentPresenter を引っ張り出す</td></tr></table>&nbsp;
<a href="#itemscontrolhelper-クラス">トップ</a>

## 関連項目


#### 参照
<a href="N_usagi_GUI_Extension.md">usagi.GUI.Extension 名前空間</a><br />