# Calculation.NearlyEquals メソッド (Byte, Byte, Byte)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

byte 特殊化版 

byte, UInt16, UInt32 に対しては内部的に1単位大きな符号付きの型で計算を行う。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.2.0.0 (1.2.0.0)

## 構文

**C#**<br />
``` C#
public static bool NearlyEquals(
	byte a,
	byte b,
	byte tolerance
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/yyb1w04y" target="_blank">System.Byte</a><br />値 a</dd><dt>b</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/yyb1w04y" target="_blank">System.Byte</a><br />値 b</dd><dt>tolerance</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/yyb1w04y" target="_blank">System.Byte</a><br />許容範囲</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/a28wyd50" target="_blank">Boolean</a><br />近似的に等しいと見做せる場合は true

## 関連項目


#### 参照
<a href="T_usagi_Quantity_Calculation.md">Calculation クラス</a><br /><a href="Overload_usagi_Quantity_Calculation_NearlyEquals.md">NearlyEquals オーバーロード</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />