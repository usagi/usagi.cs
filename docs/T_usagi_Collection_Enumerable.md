# Enumerable クラス

<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div><a href="http://msdn2.microsoft.com/ja-jp/library/bb345746" target="_blank">Enumerable</a> をより便利に した列挙機能を提供する。 

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

 後者は必ず引数を3つ以上とり、区間の始端、終端に続けて 区間端の開閉を <a href="T_usagi_Collection_Enumerable_RangeTermination.md">Enumerable.RangeTermination</a> で要求する。


## 継承階層
<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;usagi.Collection.Enumerable<br /><strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Collection.md">usagi.Collection</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static class Enumerable
```

Enumerable 型は下記のメンバーを公開します。


## メソッド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_4.md">Range(Int32)</a></td><td>
[ 0, ...., count ) な列挙を得る 

<a href="M_usagi_Collection_Enumerable_Range_5.md">Range(Int32, Int32)</a> へ 
```
( 0, count )
```
 を渡す糖衣構文</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_12.md">Range(ValueTuple(Byte, Byte, Enumerable.RangeTermination)[])</a></td><td>
複数の区間の要素をまとめて列挙する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_13.md">Range(ValueTuple(Decimal, Decimal, Enumerable.RangeTermination)[])</a></td><td>
複数の区間の要素をまとめて列挙する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_14.md">Range(ValueTuple(Double, Double, Enumerable.RangeTermination)[])</a></td><td>
複数の区間の要素をまとめて列挙する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_15.md">Range(ValueTuple(Int16, Int16, Enumerable.RangeTermination)[])</a></td><td>
複数の区間の要素をまとめて列挙する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_16.md">Range(ValueTuple(Int32, Int32, Enumerable.RangeTermination)[])</a></td><td>
複数の区間の要素をまとめて列挙する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_17.md">Range(ValueTuple(Int64, Int64, Enumerable.RangeTermination)[])</a></td><td>
複数の区間の要素をまとめて列挙する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_18.md">Range(ValueTuple(SByte, SByte, Enumerable.RangeTermination)[])</a></td><td>
複数の区間の要素をまとめて列挙する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_19.md">Range(ValueTuple(Single, Single, Enumerable.RangeTermination)[])</a></td><td>
複数の区間の要素をまとめて列挙する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_20.md">Range(ValueTuple(UInt16, UInt16, Enumerable.RangeTermination)[])</a></td><td>
複数の区間の要素をまとめて列挙する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_21.md">Range(ValueTuple(UInt32, UInt32, Enumerable.RangeTermination)[])</a></td><td>
複数の区間の要素をまとめて列挙する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_22.md">Range(ValueTuple(UInt64, UInt64, Enumerable.RangeTermination)[])</a></td><td>
複数の区間の要素をまとめて列挙する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_5.md">Range(Int32, Int32)</a></td><td>
[ begin, ...., begin + count ) な列挙を得る。 但し、 
```
count < 0
```
 では空の結果を得る。 

<a href="http://msdn2.microsoft.com/ja-jp/library/bb341264" target="_blank">Range(Int32, Int32)</a> への糖衣構文</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range.md">Range(Byte, Byte, Enumerable.RangeTermination)</a></td><td>
区間 { begin ... end } を列挙します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_1.md">Range(Decimal, Decimal, Enumerable.RangeTermination)</a></td><td>
区間 { begin ... end } を列挙します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_2.md">Range(Double, Double, Enumerable.RangeTermination)</a></td><td>
区間 { begin ... end } を列挙します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_3.md">Range(Int16, Int16, Enumerable.RangeTermination)</a></td><td>
区間 { begin ... end } を列挙します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_6.md">Range(Int32, Int32, Enumerable.RangeTermination)</a></td><td>
区間 { begin ... end } を列挙します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_7.md">Range(Int64, Int64, Enumerable.RangeTermination)</a></td><td>
区間 { begin ... end } を列挙します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_8.md">Range(SByte, SByte, Enumerable.RangeTermination)</a></td><td>
区間 { begin ... end } を列挙します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_9.md">Range(Single, Single, Enumerable.RangeTermination)</a></td><td>
区間 { begin ... end } を列挙します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_10.md">Range(UInt32, UInt32, Enumerable.RangeTermination)</a></td><td>
区間 { begin ... end } を列挙します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range_11.md">Range(UInt64, UInt64, Enumerable.RangeTermination)</a></td><td>
区間 { begin ... end } を列挙します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range__1.md">Range(T)(Func(T, T), ValueTuple(T, T, Enumerable.RangeTermination)[])</a></td><td>
複数の区間を列挙する。 区間間（タイポではない）は、連続でも、不連続でも、重複が無くても、重複があっても構わない。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_Range__1_1.md">Range(T)(T, T, Enumerable.RangeTermination, Func(T, T))</a></td><td>
始端、終端、区間端の開閉、要素のインクリメントファンクターによる ジェネリック版 Range</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Collection_Enumerable_RangeOO.md">RangeOO</a></td><td>
区間 { begin ... end } を列挙します。</td></tr></table>&nbsp;
<a href="#enumerable-クラス">トップ</a>

## 関連項目


#### 参照
<a href="N_usagi_Collection.md">usagi.Collection 名前空間</a><br />