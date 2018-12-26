# EnumerableHelper.Range メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 


## オーバーロードの一覧
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Extension_Collection_EnumerableHelper_Range.md">Range(Int32)</a></td><td>
[ 0, ...., count ) な列挙を得る 

<a href="M_usagi_Extension_Collection_EnumerableHelper_Range_1.md">Range(Int32, Int32)</a> へ 
```
( 0, count )
```
 を渡す糖衣構文</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Extension_Collection_EnumerableHelper_Range__1.md">Range(T)(Int32, Func(T))</a></td><td>
generator で count 個の列挙を得る。 但し、 
```
count < 0
```
 では空の結果を得る。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Extension_Collection_EnumerableHelper_Range__1_1.md">Range(T)(Int32, Func(Int32, T))</a></td><td>
[ 0, ... , count ) を始域とし、 generator を写像として得られる 順序対の終域の要素の列挙を得る。 但し、 
```
count < 0
```
 では空の結果を得る。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Extension_Collection_EnumerableHelper_Range_1.md">Range(Int32, Int32)</a></td><td>
[ begin, ...., begin + count ) な列挙を得る。 但し、 
```
count < 0
```
 では空の結果を得る。 

<a href="http://msdn2.microsoft.com/ja-jp/library/bb341264" target="_blank">Range(Int32, Int32)</a> への糖衣構文</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Extension_Collection_EnumerableHelper_Range__1_2.md">Range(T)(Int32, Int32, Func(Int32, T))</a></td><td>
[ begin, ... , count ) を始域とし、 generator を写像として得られる 順序対の終域の要素の列挙を得る。 但し、 
```
count < 0
```
 では空の結果を得る。</td></tr></table>&nbsp;
<a href="#enumerablehelper.range-メソッド">トップ</a>

## 関連項目


#### 参照
<a href="T_usagi_Extension_Collection_EnumerableHelper.md">EnumerableHelper クラス</a><br /><a href="N_usagi_Extension_Collection.md">usagi.Extension.Collection 名前空間</a><br />