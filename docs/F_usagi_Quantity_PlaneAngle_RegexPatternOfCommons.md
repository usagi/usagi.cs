# PlaneAngle.RegexPatternOfCommons フィールド

<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

平面角系の単位の付いた数値文字列をパースする正規表現パターン


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.2.0.0 (1.2.0.0)

## 構文

**C#**<br />
``` C#
public const string RegexPatternOfCommons = "(?<negative>-)?(?:\s*)(?<value>[\d.]+)(?:\s*)(?<unit>(?<prefix>Y|Z|E|P|T|G|M|k|h|da|d|c|m|(?:μ|u)|n|p|a|z|y)?(?:(?<rad>rad)|(?<pts>pts?)|(?<mils>mils?)|(?<gradians>ᵍ|gon)|(?<turns>τ|turns?)))"
```


#### フィールド値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">String</a>

## 関連項目


#### 参照
<a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle クラス</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />