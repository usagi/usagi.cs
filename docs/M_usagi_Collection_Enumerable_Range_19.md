# Enumerable.Range メソッド (ValueTuple(Single, Single, Enumerable.RangeTermination)[])<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

複数の区間の要素をまとめて列挙する


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Collection.md">usagi.Collection</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static IEnumerable<float> Range(
	params (float , float , Enumerable.RangeTermination )[] ranges
)
```


#### パラメーター
&nbsp;<dl><dt>ranges</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/mt744799" target="_blank">System.ValueTuple</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/3www918f" target="_blank">Single</a>, <a href="http://msdn2.microsoft.com/ja-jp/library/3www918f" target="_blank">Single</a>, <a href="T_usagi_Collection_Enumerable_RangeTermination.md">Enumerable.RangeTermination</a>)[]<br />区間群</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">IEnumerable</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/3www918f" target="_blank">Single</a>)<br />区間群の要素の列挙

## 関連項目


#### 参照
<a href="T_usagi_Collection_Enumerable.md">Enumerable クラス</a><br /><a href="Overload_usagi_Collection_Enumerable_Range.md">Range オーバーロード</a><br /><a href="N_usagi_Collection.md">usagi.Collection 名前空間</a><br />