# MetricPrefix.ToString メソッド (String, IFormatProvider)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

文字列化する


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity_Unit_SI.md">usagi.Quantity.Unit.SI</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public string ToString(
	string format,
	IFormatProvider formatProvider
)
```


#### パラメーター
&nbsp;<dl><dt>format</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">System.String</a><br />フォーマット</dd><dt>formatProvider</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/efh2ww9y" target="_blank">System.IFormatProvider</a><br />フォーマットプロバイダー</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">String</a><br />SI接頭辞の文字列または等倍の場合は空文字列

#### 実装
<a href="http://msdn2.microsoft.com/ja-jp/library/bhf180ey" target="_blank">IFormattable.ToString(String, IFormatProvider)</a><br />

## 関連項目


#### 参照
<a href="T_usagi_Quantity_Unit_SI_MetricPrefix.md">MetricPrefix クラス</a><br /><a href="Overload_usagi_Quantity_Unit_SI_MetricPrefix_ToString.md">ToString オーバーロード</a><br /><a href="N_usagi_Quantity_Unit_SI.md">usagi.Quantity.Unit.SI 名前空間</a><br />