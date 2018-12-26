# Optional(*T*).Get メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

内包するオブジェクトがあれば取り出します。 この機能は T 型への暗黙の型変換と等価です。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Boxing.md">usagi.Boxing</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.2.0.0 (1.2.0.0)

## 構文

**C#**<br />
``` C#
public T Get()
```


#### 戻り値
型: <a href="T_usagi_Boxing_Optional_1.md">*T*</a><br />内包するオブジェクト

## 例外
&nbsp;<table><tr><th>例外</th><th>条件</th></tr><tr><td><a href="T_usagi_Boxing_Optional_1_InvalidValueException.md">Optional(T).InvalidValueException</a></td><td>内包するオブジェクトが無い場合に飛びます。</td></tr></table>

## 関連項目


#### 参照
<a href="T_usagi_Boxing_Optional_1.md">Optional(T) クラス</a><br /><a href="N_usagi_Boxing.md">usagi.Boxing 名前空間</a><br />