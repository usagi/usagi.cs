# Optional(*T*).True 演算子 <small>[<<Back to Home](https://github.com/usagi/usagi.cs/blob/master/Help/Home.md)</small> 

内包するオブジェクトが有効な場合に operator true として true を返します。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Boxing.md">usagi.Boxing</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public static bool operator true(
	Optional<T> optional
)
```


#### パラメーター
&nbsp;<dl><dt>optional</dt><dd>型: <a href="T_usagi_Boxing_Optional_1.md">usagi.Boxing.Optional</a>(<a href="T_usagi_Boxing_Optional_1.md">*T*</a>)<br />ボクシングオブジェクト</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/a28wyd50" target="_blank">Boolean</a><br />内包するオブジェクトが有効な場合は true 、そうでなければ false

## 関連項目


#### 参照
<a href="T_usagi_Boxing_Optional_1.md">Optional(T) クラス</a><br /><a href="N_usagi_Boxing.md">usagi.Boxing 名前空間</a><br />