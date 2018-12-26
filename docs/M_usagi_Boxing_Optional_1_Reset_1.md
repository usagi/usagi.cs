# Optional(*T*).Reset メソッド (*T*, *T*)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

新たなオブジェクトを内包させると同時に既に内包しているオブジェクトがあった場合には取り出せる版の Reset　です。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Boxing.md">usagi.Boxing</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.2.0.0 (1.2.0.0)

## 構文

**C#**<br />
``` C#
public Optional<T> Reset(
	T value,
	ref T previously
)
```


#### パラメーター
&nbsp;<dl><dt>value</dt><dd>型: <a href="T_usagi_Boxing_Optional_1.md">*T*</a><br />新たに内包させるオブジェクト</dd><dt>previously</dt><dd>型: <a href="T_usagi_Boxing_Optional_1.md">*T*</a><br />既に内包しているオブジェクトがあった場合に取り出す先</dd></dl>

#### 戻り値
型: <a href="T_usagi_Boxing_Optional_1.md">Optional</a>(<a href="T_usagi_Boxing_Optional_1.md">*T*</a>)<br />新たなオブジェクトを内包した this

## 関連項目


#### 参照
<a href="T_usagi_Boxing_Optional_1.md">Optional(T) クラス</a><br /><a href="Overload_usagi_Boxing_Optional_1_Reset.md">Reset オーバーロード</a><br /><a href="N_usagi_Boxing.md">usagi.Boxing 名前空間</a><br />