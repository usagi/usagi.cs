# Numeric.SafeIncrement メソッド (Decimal)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

元の値 + 1 を安全に返すメソッド。 インクリメントが正常に行えない場合は <a href="T_usagi_InformationEngineering_Numeric_OverflowException.md">Numeric.OverflowException</a> を飛ばす


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_InformationEngineering.md">usagi.InformationEngineering</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static decimal SafeIncrement(
	decimal a
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/1k2e8atx" target="_blank">System.Decimal</a><br />元の値</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/1k2e8atx" target="_blank">Decimal</a><br />元の値 + 1

## 関連項目


#### 参照
<a href="T_usagi_InformationEngineering_Numeric.md">Numeric クラス</a><br /><a href="Overload_usagi_InformationEngineering_Numeric_SafeIncrement.md">SafeIncrement オーバーロード</a><br /><a href="N_usagi_InformationEngineering.md">usagi.InformationEngineering 名前空間</a><br />