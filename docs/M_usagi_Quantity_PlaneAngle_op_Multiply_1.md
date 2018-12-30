# PlaneAngle.Multiply 演算子 (PlaneAngle, Double)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

角度を無次元数により掛け算する2項演算子


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public static PlaneAngle operator *(
	PlaneAngle a,
	double b
)
```


#### パラメーター
&nbsp;<dl><dt>a</dt><dd>型: <a href="T_usagi_Quantity_PlaneAngle.md">usagi.Quantity.PlaneAngle</a><br />平面角</dd><dt>b</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">System.Double</a><br />無次元の係数</dd></dl>

#### 戻り値
型: <a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle</a><br />無次元の係数を掛けた平面角

## 解説
Note: 角度次元同士の掛け算は角度2乗次元の結果を生じるが PlaneAngle 型では取り扱いの範疇を超えるため実装していない。

## 関連項目


#### 参照
<a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle クラス</a><br /><a href="Overload_usagi_Quantity_PlaneAngle_op_Multiply.md">Multiply オーバーロード</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />