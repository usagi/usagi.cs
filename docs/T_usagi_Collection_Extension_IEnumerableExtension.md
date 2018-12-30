# IEnumerableExtension クラス

<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

Enumerable な何かの機能拡張群


## 継承階層
<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;usagi.Collection.Extension.IEnumerableExtension<br /><strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Collection_Extension.md">usagi.Collection.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public static class IEnumerableExtension
```

IEnumerableExtension 型は下記のメンバーを公開します。


## メソッド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Extension_IEnumerableExtension_Range__1.md">Range(T)(Int32, Func(T))</a></td><td>
generator で count 個の列挙を得る。 但し、 
```
count < 0
```
 では空の結果を得る。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Extension_IEnumerableExtension_Range__1_1.md">Range(T)(Int32, Func(Int32, T))</a></td><td>
[ 0, ... , count ) を始域とし、 generator を写像として得られる 順序対の終域の要素の列挙を得る。 但し、 
```
count < 0
```
 では空の結果を得る。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Extension_IEnumerableExtension_Range__1_2.md">Range(T)(Int32, Int32, Func(Int32, T))</a></td><td>
[ begin, ... , count ) を始域とし、 generator を写像として得られる 順序対の終域の要素の列挙を得る。 但し、 
```
count < 0
```
 では空の結果を得る。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Extension_IEnumerableExtension_UnorderedEqual__1.md">UnorderedEqual(T)</a></td><td>
IEnumerable を実装する型 a, b について等価な値を保持するか判定する。 SequenceEqual と異なり列挙される順序の影響を受けない ref. https://stackoverflow.com/a/3670089/1211392</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_usagi_Collection_Extension_IEnumerableExtension_WithIndexing__1.md">WithIndexing(T)</a></td><td>
IEnumerable を列挙順にインデックス付きにするやつ ref. https://ufcpp.net/blog/2016/12/tipsindexedforeach/</td></tr></table>&nbsp;
<a href="#ienumerableextension-クラス">トップ</a>

## 関連項目


#### 参照
<a href="N_usagi_Collection_Extension.md">usagi.Collection.Extension 名前空間</a><br />