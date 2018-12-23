# PlaneAngle.FromDegrees メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

度数法からのファクトリー 

度, 分, 秒, °, ′, ′′, deg 

主に一般生活中の平面角、測地学でよく使われる。


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public static PlaneAngle FromDegrees(
	double degrees,
	double minutes = 0,
	double seconds = 0
)
```


#### パラメーター
&nbsp;<dl><dt>degrees</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">System.Double</a><br />度</dd><dt>minutes (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">System.Double</a><br />分</dd><dt>seconds (Optional)</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">System.Double</a><br />秒</dd></dl>

#### 戻り値
型: <a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle</a><br />生成された平面角インスタンス

## 解説
minutes, seconds の符号は自動的に degrees の符号に統一されます。 このお節介は degrees, minutes, seconds それぞれで異なる符号（方向）を与える事は通常ありえませんが、 3つのパラメーターに明示的に分離して実引数を与える際に全てに負の符号を付けるべきかユーザーが揺らぐ可能性を考慮し、 どのように与えても推定的に意図される degrees と同じ向きに minutes, seconds の符号を統一するものです。 万一、本当に異なる向きの degrees + minutes + seconds を与えたい場合は個別に生成して加算すると良いでしょう。

## 関連項目


#### 参照
<a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle クラス</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />