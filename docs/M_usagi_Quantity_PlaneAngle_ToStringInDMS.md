# PlaneAngle.ToStringInDMS メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

度数法の整数 Degrees 成分、整数 Minutes 成分、実数 Seconds 成分により文字列化する。数値に加え、単位として SymbolOfDegrees, SymbolOfMinutes, SymbolOfDegrees が付く。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public string ToStringInDMS(
	string seconds_format = "F2"
)
```


#### パラメーター
&nbsp;<dl><dt>seconds_format (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">System.String</a><br />フォーマット</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">String</a><br />文字列

## 関連項目


#### 参照
<a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle クラス</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />