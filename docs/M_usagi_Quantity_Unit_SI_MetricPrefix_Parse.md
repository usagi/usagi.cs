# MetricPrefix.Parse メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

文字列からのファクトリー
&nbsp;<ul><li>与えられた文字列がSI接頭辞として有効な場合は MetricPrefix オブジェクトを返す。</li><li>与えられた文字列が空文字列の場合は等倍（1.0倍）の MetricPrefix オブジェクトを返す。</li><li>与えられた文字列がSI接頭辞として無効な場合は null を返す。</li></ul>&nbsp;
<strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity_Unit_SI.md">usagi.Quantity.Unit.SI</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.2.0.0 (1.2.0.0)

## 構文

**C#**<br />
``` C#
public static MetricPrefix Parse(
	string str
)
```


#### パラメーター
&nbsp;<dl><dt>str</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">System.String</a><br />任意の文字列</dd></dl>

#### 戻り値
型: <a href="T_usagi_Quantity_Unit_SI_MetricPrefix.md">MetricPrefix</a><br />MetricPrefix オブジェクトまたは null

## 関連項目


#### 参照
<a href="T_usagi_Quantity_Unit_SI_MetricPrefix.md">MetricPrefix クラス</a><br /><a href="N_usagi_Quantity_Unit_SI.md">usagi.Quantity.Unit.SI 名前空間</a><br />