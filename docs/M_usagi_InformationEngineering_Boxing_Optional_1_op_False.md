# Optional(*T*).False 演算子 <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

内包するオブジェクトが無効な場合に operator false として true を返します。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_InformationEngineering_Boxing.md">usagi.InformationEngineering.Boxing</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static bool operator false(
	Optional<T> optional
)
```


#### パラメーター
&nbsp;<dl><dt>optional</dt><dd>型: <a href="T_usagi_InformationEngineering_Boxing_Optional_1.md">usagi.InformationEngineering.Boxing.Optional</a>(<a href="T_usagi_InformationEngineering_Boxing_Optional_1.md">*T*</a>)<br />ボクシングオブジェクト</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/a28wyd50" target="_blank">Boolean</a><br />内包するオブジェクトが無効な場合は true 、そうでなければ false

## 関連項目


#### 参照
<a href="T_usagi_InformationEngineering_Boxing_Optional_1.md">Optional(T) クラス</a><br /><a href="N_usagi_InformationEngineering_Boxing.md">usagi.InformationEngineering.Boxing 名前空間</a><br />