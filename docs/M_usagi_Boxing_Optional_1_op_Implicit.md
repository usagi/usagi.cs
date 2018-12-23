# Optional(*T*)&nbsp;Implicit 変換 (Optional(*T*) to *T*)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

暗黙の型変換により T 型へ変換します。 Get と等価に機能します。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Boxing.md">usagi.Boxing</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public static implicit operator T (
	Optional<T> optional
)
```


#### パラメーター
&nbsp;<dl><dt>optional</dt><dd>型: <a href="T_usagi_Boxing_Optional_1.md">usagi.Boxing.Optional</a>(<a href="T_usagi_Boxing_Optional_1.md">*T*</a>)<br />ボクシングオブジェクト</dd></dl>

#### 戻り値
型: <a href="T_usagi_Boxing_Optional_1.md">*T*</a><br />内包するT型のインスタンス

## 関連項目


#### 参照
<a href="T_usagi_Boxing_Optional_1.md">Optional(T) クラス</a><br /><a href="N_usagi_Boxing.md">usagi.Boxing 名前空間</a><br />