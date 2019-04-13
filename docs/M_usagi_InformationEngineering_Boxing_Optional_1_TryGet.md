# Optional(*T*).TryGet メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

内包するオブジェクトがあれば value へ取り出し true を返します。 

内包するオブジェクトが無ければ value には何もせず false を返します。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_InformationEngineering_Boxing.md">usagi.InformationEngineering.Boxing</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public bool TryGet(
	ref T value
)
```


#### パラメーター
&nbsp;<dl><dt>value</dt><dd>型: <a href="T_usagi_InformationEngineering_Boxing_Optional_1.md">*T*</a><br />内包するオブジェクトがあれば代入されます。無ければ何もされません。</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/a28wyd50" target="_blank">Boolean</a><br />内包するオブジェクトを value へ取り出せた場合は true 、そうでない場合には false が帰ります。

## 解説
Get や暗黙の型変換で例外が飛ぶ可能性を嫌う場合にどうぞ。

## 関連項目


#### 参照
<a href="T_usagi_InformationEngineering_Boxing_Optional_1.md">Optional(T) クラス</a><br /><a href="N_usagi_InformationEngineering_Boxing.md">usagi.InformationEngineering.Boxing 名前空間</a><br />