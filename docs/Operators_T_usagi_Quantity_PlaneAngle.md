# PlaneAngle 演算子<small>[<<Back to Home](https://github.com/usagi/usagi.cs/blob/master/Help/Home.md)</small><a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle</a> 型は下記のメンバーを公開します。


## 演算子
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_op_Addition.md">Addition</a></td><td>
加算する2項演算子</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_op_Division.md">Division(PlaneAngle, Double)</a></td><td>
角度を無次元数により割り算する2項演算子 

Note: 角度次元同士の割り算は無次元の結果を生じるが PlaneAngle 型では取り扱いの範疇を超えるため実装していない。</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_op_Division_1.md">Division(PlaneAngle, PlaneAngle)</a></td><td>
平面角を平面角で除算した比を得る2項演算子</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_op_Equality.md">Equality</a></td><td>
正規化せずに角度が等しいか判定する 

正規化が必要な場合は NormalizedEquals を使うとよい</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_op_GreaterThan.md">GreaterThan</a></td><td>
正規化せずに角度が a > b か判定する 

正規化が必要な場合は NormalizedGreaterThan を使うとよい</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_op_GreaterThanOrEqual.md">GreaterThanOrEqual</a></td><td>
正規化せずに角度が a >= b か判定する 

正規化が必要な場合は NormalizedGreaterThan を使うとよい</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_op_Inequality.md">Inequality</a></td><td>
正規化せずに角度が等しいか判定する 

正規化が必要な場合は NormalizedNotEquals を使うとよい</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_op_LessThan.md">LessThan</a></td><td>
正規化せずに角度が a < b か判定する 

正規化が必要な場合は NormalizedLessThan を使うとよい</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_op_LessThanOrEqual.md">LessThanOrEqual</a></td><td>
正規化せずに角度が a <= b か判定する 

正規化が必要な場合は NormalizedLessThan を使うとよい</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_op_Modulus.md">Modulus</a></td><td>
角度の剰余を計算する2項演算子 

Note: 実用上の有意性を考慮し、剰余については正規化した場合の結果を計算する</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_op_Multiply.md">Multiply(Double, PlaneAngle)</a></td><td>
角度を無次元数により掛け算する2項演算子</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_op_Multiply_1.md">Multiply(PlaneAngle, Double)</a></td><td>
角度を無次元数により掛け算する2項演算子</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_op_Subtraction.md">Subtraction</a></td><td>
減算する2項演算子</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_op_UnaryNegation.md">UnaryNegation</a></td><td>
符号を反転する単項演算子</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_op_UnaryPlus.md">UnaryPlus</a></td><td>
符号をどうもしない単項演算子</td></tr></table>&nbsp;
<a href="#planeangle-演算子">トップ</a>

## 関連項目


#### 参照
<a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle クラス</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />