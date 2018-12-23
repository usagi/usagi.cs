# PlaneAngle.RegexPatternOfDegrees フィールド<small>[<<Back to Home](https://github.com/usagi/usagi.cs/blob/master/Help/Home.md)</small> 

度分秒系の文字列をパースする正規表現パターン


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public const string RegexPatternOfDegrees = "(?<negative>-)?(?:\s*)(?:(?<degrees>[\d.]+)(?:\s*)(?:°|度|deg))?(?:\s*)(?:(?<minutes>[\d.]+)(?:\s*)(?:′|分))?(?:\s*)(?:(?<seconds>[\d.]+)(?:\s*)(?:′′|″|秒))?"
```


#### フィールド値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">String</a>

## 関連項目


#### 参照
<a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle クラス</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />