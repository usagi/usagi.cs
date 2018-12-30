# usagi.Collection 名前空間

<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

集合とかそういうの


## クラス
&nbsp;<table><tr><th></th><th>クラス</th><th>説明</th></tr><tr><td>![Public クラス](media/pubclass.gif "Public クラス")</td><td><a href="T_usagi_Collection_Enumerable.md">Enumerable</a></td><td><a href="http://msdn2.microsoft.com/ja-jp/library/bb345746" target="_blank">Enumerable</a> をより便利に した列挙機能を提供する。 

 大別して2系統の Range が使用可能になる。 

 1. <a href="http://msdn2.microsoft.com/ja-jp/library/bb345746" target="_blank">Enumerable</a> 互換の 
```
Range( Begin, Count )
```
 系 2. 数学や工学で一般的な区間表現に互換の 
```
Range( Begin, End, Termination )
```
 系 

 後者は必ず引数を3つ以上とり、区間の始端、終端に続けて 区間端の開閉を <a href="T_usagi_Collection_Enumerable_RangeTermination.md">Enumerable.RangeTermination</a> で要求する。</td></tr></table>

## 列挙体
&nbsp;<table><tr><th></th><th>列挙体</th><th>説明</th></tr><tr><td>![Public 列挙体](media/pubenumeration.gif "Public 列挙体")</td><td><a href="T_usagi_Collection_Enumerable_RangeTermination.md">Enumerable.RangeTermination</a></td><td>
区間末尾の開閉を表す。</td></tr></table>&nbsp;
