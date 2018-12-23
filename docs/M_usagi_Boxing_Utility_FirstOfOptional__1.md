# Utility.FirstOfOptional(*T*) メソッド <small>[<<Back to Home](https://github.com/usagi/usagi.cs/blob/master/Help/Home.md)</small> 

列挙の先頭要素をボクシングオブジェクトで取り出します。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Boxing.md">usagi.Boxing</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public static Optional<T> FirstOfOptional<T>(
	this IEnumerable<T> values
)

```


#### パラメーター
&nbsp;<dl><dt>values</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">System.Collections.Generic.IEnumerable</a>(*T*)<br />列挙された任意の型のオブジェクト群</dd></dl>

#### 型パラメーター
&nbsp;<dl><dt>T</dt><dd>列挙された任意の型</dd></dl>

#### 戻り値
型: <a href="T_usagi_Boxing_Optional_1.md">Optional</a>(*T*)<br />列挙の先頭要素または空のボクシングオブジェクト

#### 使用上の注意
Visual Basic と C#では、<a href="http://msdn2.microsoft.com/ja-jp/library/9eekhta0" target="_blank">IEnumerable</a>(*T*)型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_Boxing_Utility.md">Utility クラス</a><br /><a href="N_usagi_Boxing.md">usagi.Boxing 名前空間</a><br />