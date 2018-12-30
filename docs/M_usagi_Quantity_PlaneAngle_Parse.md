# PlaneAngle.Parse メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

度数法による Degrees または Minutes または Seconds の組み合わせ または Radians, Points, Mils, Gradians, Turns で読み取り可能な文字列 から PlaneAngle オブジェクトを生成する。 

読み取り不能な場合は null を返す。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public static PlaneAngle Parse(
	string str,
	bool try_in_degrees = false
)
```


#### パラメーター
&nbsp;<dl><dt>str</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">System.String</a><br />任意の文字列</dd><dt>try_in_degrees (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/a28wyd50" target="_blank">System.Boolean</a><br />単位を検出できない場合は deg 単位としてパースを試みる場合は true</dd></dl>

#### 戻り値
型: <a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle</a><br />読み取りに成功した場合は PlaneAngle オブジェクト、読み取れなかった場合は null

## 関連項目


#### 参照
<a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle クラス</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />