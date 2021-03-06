# MemoryStreamStringExtension.ToMemoryStream メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

MemoryStream へ変換


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_InformationEngineering_Extension.md">usagi.InformationEngineering.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static MemoryStream ToMemoryStream(
	this string s,
	Encoding e = null
)
```


#### パラメーター
&nbsp;<dl><dt>s</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">System.String</a><br />元文字列</dd><dt>e (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/86hf4sb8" target="_blank">System.Text.Encoding</a><br />エンコーディング; null の場合は <a href="http://msdn2.microsoft.com/ja-jp/library/teb7dbda" target="_blank">UTF8</a> を使う</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/9a84386f" target="_blank">MemoryStream</a><br />s を元にしたメモリーストリーム

#### 使用上の注意
Visual Basic と C#では、<a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">String</a>型のオブジェクトのインスタンスメソッドのようにこのメソッドを呼び出せます。このメソッドを呼び出すためにインスタンスメソッド構文を使う場合、最初のパラメーターを省略します。詳細は、<a href="http://msdn.microsoft.com/ja-jp/library/bb384936.aspx" target="_blank">拡張メソッド(Visual Basic)</a>または<a href="http://msdn.microsoft.com/ja-jp/library/bb383977.aspx" target="_blank">拡張メソッド(C# プログラミング ガイド)</a>を参照してください。

## 関連項目


#### 参照
<a href="T_usagi_InformationEngineering_Extension_MemoryStreamStringExtension.md">MemoryStreamStringExtension クラス</a><br /><a href="N_usagi_InformationEngineering_Extension.md">usagi.InformationEngineering.Extension 名前空間</a><br />