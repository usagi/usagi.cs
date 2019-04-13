# Utility.SanitizePath メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

パスに使用不能な文字があったら置き換えまたは削除する


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_FileSystem.md">usagi.FileSystem</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static string SanitizePath(
	string path,
	Nullable<char> replacement = null
)
```


#### パラメーター
&nbsp;<dl><dt>path</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">System.String</a><br />きたない可能性のあるパス</dd><dt>replacement (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/b3h38hb0" target="_blank">System.Nullable</a>(<a href="http://msdn2.microsoft.com/ja-jp/library/k493b04s" target="_blank">Char</a>)<br />置き換え先文字。 null またはパスに使用できない文字が指定された場合は置き換えではなく削除動作。</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">String</a><br />きれいになった文字列

## 関連項目


#### 参照
<a href="T_usagi_FileSystem_Utility.md">Utility クラス</a><br /><a href="N_usagi_FileSystem.md">usagi.FileSystem 名前空間</a><br />