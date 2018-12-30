# Numeric.ConservationCast(*A*, *B*) メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

値を可能な限り保持した別の型を取得する。 非負整数と符号付き整数、浮動小数点数と整数など変換したい場合にどうぞ。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_InformationEngineering.md">usagi.InformationEngineering</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public static B ConservationCast<A, B>(
	A a
)
where A : IConvertible
where B : IConvertible

```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: *A*<br />型変換したい値</dd></dl>

#### 型パラメーター
&nbsp;<dl><dt>A</dt><dd>変換元の型</dd><dt>B</dt><dd>変換先の型</dd></dl>

#### 戻り値
型: *B*<br />型変換された値

## 解説
NaN を整数型へキャストしようとしたり、 キャスト先の型で表現不能な数値をキャストしようとすると <a href="http://msdn2.microsoft.com/ja-jp/library/41ktf3wy" target="_blank">OverflowException</a> が飛ぶ。

## 関連項目


#### 参照
<a href="T_usagi_InformationEngineering_Numeric.md">Numeric クラス</a><br /><a href="N_usagi_InformationEngineering.md">usagi.InformationEngineering 名前空間</a><br />