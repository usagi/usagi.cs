# GeoURI.RegexPattern フィールド<small>[<<Back to Home](https://github.com/usagi/usagi.cs/blob/master/Help/Home.md)</small> 

GeoURI を解析可能な正規表現パターン


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_URI.md">usagi.URI</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public const string RegexPattern = "(?<scheme>geo):(?<lat>-?[\d.]+),(?<lon>-?[\d.]+)(?:,(?<alt>-?[\d.]+))?(?:(?:;crs=(?<crs>[^;]+))|(?:;u=(?<u>[^;]+)))*"
```


#### フィールド値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">String</a>

## 関連項目


#### 参照
<a href="T_usagi_URI_GeoURI.md">GeoURI クラス</a><br /><a href="N_usagi_URI.md">usagi.URI 名前空間</a><br />