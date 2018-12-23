# PlaneAngle メソッド<small>[<<Back to Home](https://github.com/usagi/usagi.cs/blob/master/Help/Home.md)</small><a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle</a> 型は下記のメンバーを公開します。


## メソッド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_CompareTo.md">CompareTo</a></td><td>
平面角オブジェクトを比較 

正規化せずに比較する。正規化が必要な場合は NormalizedCompareTo を使うとよい</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_Equals.md">Equals(Object)</a></td><td>
正規化せずに角度が等しいか判定する 

正規化が必要な場合は NormalizedEquals を使うとよい
 (<a href="http://msdn2.microsoft.com/ja-jp/library/bsc2ak47" target="_blank">Object.Equals(Object)</a>をオーバーライド)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_Equals_1.md">Equals(PlaneAngle)</a></td><td>
正規化せずに角度が等しいか判定する 正規化が必要な場合は NormalizedEquals を使うとよい</td></tr><tr><td>![Protected メソッド](media/protmethod.gif "Protected メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/4k87zsw7" target="_blank">Finalize</a></td><td>
オブジェクトが、ガベージ コレクションによって収集される前に、リソースの解放とその他のクリーンアップ操作の実行を試みることができるようにします。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_From_acos.md">From_acos</a></td><td>
比から逆余弦で平面角を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_From_asin.md">From_asin</a></td><td>
比から逆正弦で平面角を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_From_atan.md">From_atan</a></td><td>
比から逆正接で平面角を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_FromDegrees.md">FromDegrees</a></td><td>
度数法からのファクトリー 

度, 分, 秒, °, ′, ′′, deg 

主に一般生活中の平面角、測地学でよく使われる。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_FromGradians.md">FromGradians</a></td><td>
グラヂアンからのファクトリー 

グラヂアン, グラード, グレイド, ゴン, gradian, graded, gon 

主にフランス及びその周辺国の一部の測量系に用いられる。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_FromMils.md">FromMils</a></td><td>
ミルからのファクトリー 

ミル, 密位, シュトリヒ, strich, mils 

主に軍事系で用いられる。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_FromPoints.md">FromPoints</a></td><td>
ポイントからのファクトリー 

ポイント, 点, pt 

主に航海系、航空系で用いられる。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_FromRadians.md">FromRadians</a></td><td>
ラジアンからのファクトリー rad 主に数学系、電気工学系でよく使われる。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_FromTurns.md">FromTurns</a></td><td>
ターンからのファクトリー 

ターン, turns, 回転 

主に円周全体の回転を視覚的にわかりやすく表現したい目的で用いられる。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_GetHashCode.md">GetHashCode</a></td><td>
ハッシュ値を取得
 (<a href="http://msdn2.microsoft.com/ja-jp/library/zdee4b3y" target="_blank">Object.GetHashCode()</a>をオーバーライド)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/dfwy45w9" target="_blank">GetType</a></td><td>
現在のインスタンスの <a href="http://msdn2.microsoft.com/ja-jp/library/42892f65" target="_blank">Type</a> を取得します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_IsInfinity.md">IsInfinity</a></td><td>
∞ 判定 符号は何れであれ∞か判定する。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_IsNaN.md">IsNaN</a></td><td>
NaN 判定</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_IsNegativeInfinity.md">IsNegativeInfinity</a></td><td>
-∞判定</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_IsPositiveInfinity.md">IsPositiveInfinity</a></td><td>
+∞判定</td></tr><tr><td>![Protected メソッド](media/protmethod.gif "Protected メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
現在の <a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a> の簡易コピーを作成します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_NearlyEquals.md">NearlyEquals</a></td><td>
a と b の差が tolerance 以下か判定する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_NearlyEqualsTo.md">NearlyEqualsTo</a></td><td>
NearlyEquals( this, a tolerance ) への糖衣構文</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_Normalize180.md">Normalize180()</a></td><td>
this 自身を [ -180 ... 180 ) へ正規化する。正規化前の情報は失われる。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_Normalize180_1.md">Normalize180(PlaneAngle)</a></td><td>
a を元に新たに [ -180 ... 180 ) へ正規化した平面角オブジェクトを生成するファクトリー</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_Normalize360.md">Normalize360()</a></td><td>
this 自身を [ 0 ... 360 ) へ正規化する。正規化前の情報は失われる。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_Normalize360_1.md">Normalize360(PlaneAngle)</a></td><td>
a を元に新たに [ 0 ... 360 ) へ正規化した平面角オブジェクトを生成するファクトリー</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_NormalizedCompareTo.md">NormalizedCompareTo</a></td><td>
[0...360) deg へ正規化した場合の角度の比較を行います。 

例: a=-30, b=60 が与えられた場合、 330 vs. 60 となり結果は false となります。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_NormalizedEqualsTo.md">NormalizedEqualsTo</a></td><td>
正規化した場合の this == a の判定</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_NormalizedGreaterThan.md">NormalizedGreaterThan(PlaneAngle)</a></td><td>
正規化した場合の this > a の判定</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_NormalizedGreaterThan_1.md">NormalizedGreaterThan(PlaneAngle, PlaneAngle)</a></td><td>
正規化した場合に角度が a > b か判定する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_NormalizedLessThan.md">NormalizedLessThan(PlaneAngle)</a></td><td>
正規化した場合の this < a の判定</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_NormalizedLessThan_1.md">NormalizedLessThan(PlaneAngle, PlaneAngle)</a></td><td>
正規化した場合に角度が a < b か判定する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_NormalizedNearlyEqualsTo.md">NormalizedNearlyEqualsTo</a></td><td>
正規化した場合の this ≃ a の判定</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_Parse.md">Parse</a></td><td>
度数法による Degrees または Minutes または Seconds の組み合わせ または Radians, Points, Mils, Gradians, Turns で読み取り可能な文字列 から PlaneAngle オブジェクトを生成する。 

読み取り不能な場合は null を返す。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_ParseCommons.md">ParseCommons</a></td><td>
Radians, Points, Mils, Gradians, Turns で読み取り可能な文字列 から PlaneAngle オブジェクトを生成する。 

読み取り不能な場合は null を返す。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_ParseDegrees.md">ParseDegrees</a></td><td>
度数法による Degrees または Minutes または Seconds の組み合わせ から PlaneAngle オブジェクトを生成する。 

読み取り不能な場合は null を返す。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_ToDegrees.md">ToDegrees</a></td><td>
弧度法の Radians 量を度数法の Degrees 量へ変換</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_PlaneAngle_ToRadians.md">ToRadians</a></td><td>
度数法の Degrees 量を弧度法の Radians 量へ変換</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_ToString.md">ToString()</a></td><td>
度単位で文字列化
 (<a href="http://msdn2.microsoft.com/ja-jp/library/7bxwbwt2" target="_blank">Object.ToString()</a>をオーバーライド)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_ToString_1.md">ToString(String, IFormatProvider)</a></td><td>
度数法の整数 Degrees 成分、整数 Minutes 成分、実数 Seconds 成分により文字列化する。数値に加え、単位として SymbolOfDegrees, SymbolOfMinutes, SymbolOfDegrees が付く。 

ToStringInDMS のプロクシー</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_ToStringInDegrees.md">ToStringInDegrees</a></td><td>
度数法の Degrees 単位で文字列化する。数値に加え、単位として SymbolOfDegrees が付く。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_ToStringInDMS.md">ToStringInDMS</a></td><td>
度数法の整数 Degrees 成分、整数 Minutes 成分、実数 Seconds 成分により文字列化する。数値に加え、単位として SymbolOfDegrees, SymbolOfMinutes, SymbolOfDegrees が付く。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_ToStringInGradians.md">ToStringInGradians</a></td><td>
Gradian 単位で文字列化する。数値に加え、単位として SymbolOfGradians が付く。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_ToStringInMils.md">ToStringInMils</a></td><td>
Mils 単位で文字列化する。数値に加え、単位として SymbolOfMils が付く。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_ToStringInMinutes.md">ToStringInMinutes</a></td><td>
度数法の Minutes 単位で文字列化する。数値に加え、単位として SymbolOfMinutes が付く。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_ToStringInPoints.md">ToStringInPoints</a></td><td>
Points 単位で文字列化する。数値に加え、単位として SymbolOfPoints が付く。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_ToStringInRadians.md">ToStringInRadians</a></td><td>
Radians 単位で文字列化する。数値に加え、単位として SymbolOfRadians が付く。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_ToStringInSeconds.md">ToStringInSeconds</a></td><td>
度数法の Seconds 単位で文字列化する。数値に加え、単位として SymbolOfSeconds が付く。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngle_ToStringInTurns.md">ToStringInTurns</a></td><td>
Turns 単位で文字列化する。数値に加え、単位として SymbolOfTurns が付く。</td></tr></table>&nbsp;
<a href="#planeangle-メソッド">トップ</a>

## 拡張メソッド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public 拡張メソッド](media/pubextension.gif "Public 拡張メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngleMathExtension_PlaneAngleMathHelper_Abs.md">Abs</a></td><td>
符号を正に強制します
 (<a href="T_usagi_Quantity_PlaneAngleMathExtension_PlaneAngleMathHelper.md">PlaneAngleMathHelper</a>により定義)</td></tr><tr><td>![Public 拡張メソッド](media/pubextension.gif "Public 拡張メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngleMathExtension_PlaneAngleMathHelper_Cos.md">Cos</a></td><td>
余弦値を計算しますよ
 (<a href="T_usagi_Quantity_PlaneAngleMathExtension_PlaneAngleMathHelper.md">PlaneAngleMathHelper</a>により定義)</td></tr><tr><td>![Public 拡張メソッド](media/pubextension.gif "Public 拡張メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngleMathExtension_PlaneAngleMathHelper_Cosh.md">Cosh</a></td><td>
双曲線余弦値を計算しますよ
 (<a href="T_usagi_Quantity_PlaneAngleMathExtension_PlaneAngleMathHelper.md">PlaneAngleMathHelper</a>により定義)</td></tr><tr><td>![Public 拡張メソッド](media/pubextension.gif "Public 拡張メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngleMathExtension_PlaneAngleMathHelper_Sin.md">Sin</a></td><td>
正弦値を計算しますよ
 (<a href="T_usagi_Quantity_PlaneAngleMathExtension_PlaneAngleMathHelper.md">PlaneAngleMathHelper</a>により定義)</td></tr><tr><td>![Public 拡張メソッド](media/pubextension.gif "Public 拡張メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngleMathExtension_PlaneAngleMathHelper_Sinh.md">Sinh</a></td><td>
双曲線正弦値を計算しますよ
 (<a href="T_usagi_Quantity_PlaneAngleMathExtension_PlaneAngleMathHelper.md">PlaneAngleMathHelper</a>により定義)</td></tr><tr><td>![Public 拡張メソッド](media/pubextension.gif "Public 拡張メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngleMathExtension_PlaneAngleMathHelper_Tan.md">Tan</a></td><td>
正接値を計算しますよ
 (<a href="T_usagi_Quantity_PlaneAngleMathExtension_PlaneAngleMathHelper.md">PlaneAngleMathHelper</a>により定義)</td></tr><tr><td>![Public 拡張メソッド](media/pubextension.gif "Public 拡張メソッド")</td><td><a href="M_usagi_Quantity_PlaneAngleMathExtension_PlaneAngleMathHelper_Tanh.md">Tanh</a></td><td>
双曲線正接値を計算しますよ
 (<a href="T_usagi_Quantity_PlaneAngleMathExtension_PlaneAngleMathHelper.md">PlaneAngleMathHelper</a>により定義)</td></tr></table>&nbsp;
<a href="#planeangle-メソッド">トップ</a>

## 関連項目


#### 参照
<a href="T_usagi_Quantity_PlaneAngle.md">PlaneAngle クラス</a><br /><a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />