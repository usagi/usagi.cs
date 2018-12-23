# MetricPrefix クラス<small>[<<Back to Home](https://github.com/usagi/usagi.cs/blob/master/Help/Home.md)</small> 

SI Metric Prefix
&nbsp;<ul><li>SI接頭辞について文字列と係数の相互変換を提供します。</li><li>(double) への暗黙の型変換を持ちます。</li><li>μ については慣用として u が当てられる事もあるため何れでも micro として扱います。</li></ul>

## 継承階層
<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;usagi.Quantity.Unit.SI.MetricPrefix<br /><strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity_Unit_SI.md">usagi.Quantity.Unit.SI</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public class MetricPrefix : IFormattable, 
	IComparable<MetricPrefix>, IEquatable<MetricPrefix>
```

MetricPrefix 型は下記のメンバーを公開します。


## コンストラクター
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_Unit_SI_MetricPrefix__ctor.md">MetricPrefix</a></td><td>MetricPrefixクラスの新しいインスタンスを初期化します</td></tr></table>&nbsp;
<a href="#metricprefix-クラス">トップ</a>

## プロパティ
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__a.md">_a</a></td><td>
アットを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__c.md">_c</a></td><td>
センチを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__d.md">_d</a></td><td>
デシを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__da.md">_da</a></td><td>
デカを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__E.md">_E</a></td><td>
エクサを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__f.md">_f</a></td><td>
フェムトを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__G.md">_G</a></td><td>
ギガを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__h.md">_h</a></td><td>
ヘクトを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__k.md">_k</a></td><td>
キロを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__m.md">_m</a></td><td>
ミリを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__M.md">_M</a></td><td>
メガを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__n.md">_n</a></td><td>
ナノを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__p.md">_p</a></td><td>
ピコを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__P.md">_P</a></td><td>
ペタを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__T.md">_T</a></td><td>
テラを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__u.md">_u</a></td><td>
マイクロを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__y.md">_y</a></td><td>
ヨクトを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__Y.md">_Y</a></td><td>
ヨッタを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__z.md">_z</a></td><td>
ゼプトを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__Z.md">_Z</a></td><td>
ゼッタを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix__μ.md">_μ</a></td><td>
マイクロを生成</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix_Multiplier.md">Multiplier</a></td><td>
数値としての倍率（係数）が得られる。</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")</td><td><a href="P_usagi_Quantity_Unit_SI_MetricPrefix_Prefix.md">Prefix</a></td><td>
文字列としてのSI接頭辞が得られる。 

等倍の場合は空文字列が得られる。</td></tr></table>&nbsp;
<a href="#metricprefix-クラス">トップ</a>

## メソッド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_Unit_SI_MetricPrefix_CompareTo.md">CompareTo</a></td><td>
大・小・等価を比較</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_Unit_SI_MetricPrefix_Equals.md">Equals(Object)</a></td><td>
SI補助単位として比較可能かつ等価か判定
 (<a href="http://msdn2.microsoft.com/ja-jp/library/bsc2ak47" target="_blank">Object.Equals(Object)</a>をオーバーライド)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_Unit_SI_MetricPrefix_Equals_1.md">Equals(MetricPrefix)</a></td><td>
等価な係数値か判定</td></tr><tr><td>![Protected メソッド](media/protmethod.gif "Protected メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/4k87zsw7" target="_blank">Finalize</a></td><td>
オブジェクトが、ガベージ コレクションによって収集される前に、リソースの解放とその他のクリーンアップ操作の実行を試みることができるようにします。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_Unit_SI_MetricPrefix_GetHashCode.md">GetHashCode</a></td><td>
ハッシュ値を取得
 (<a href="http://msdn2.microsoft.com/ja-jp/library/zdee4b3y" target="_blank">Object.GetHashCode()</a>をオーバーライド)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/dfwy45w9" target="_blank">GetType</a></td><td>
現在のインスタンスの <a href="http://msdn2.microsoft.com/ja-jp/library/42892f65" target="_blank">Type</a> を取得します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Protected メソッド](media/protmethod.gif "Protected メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
現在の <a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a> の簡易コピーを作成します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Unit_SI_MetricPrefix_Parse.md">Parse</a></td><td>
文字列からのファクトリー
&nbsp;<ul><li>与えられた文字列がSI接頭辞として有効な場合は MetricPrefix オブジェクトを返す。</li><li>与えられた文字列が空文字列の場合は等倍（1.0倍）の MetricPrefix オブジェクトを返す。</li><li>与えられた文字列がSI接頭辞として無効な場合は null を返す。</li></ul></td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_Unit_SI_MetricPrefix_ToString.md">ToString()</a></td><td>
文字列化
 (<a href="http://msdn2.microsoft.com/ja-jp/library/7bxwbwt2" target="_blank">Object.ToString()</a>をオーバーライド)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_Unit_SI_MetricPrefix_ToString_1.md">ToString(String, IFormatProvider)</a></td><td>
文字列化する</td></tr></table>&nbsp;
<a href="#metricprefix-クラス">トップ</a>

## 演算子
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Unit_SI_MetricPrefix_op_Equality.md">Equality</a></td><td>
等価な係数値か判定</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Unit_SI_MetricPrefix_op_GreaterThan.md">GreaterThan</a></td><td>
a が b より大きな係数値か判定</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Unit_SI_MetricPrefix_op_Implicit.md">Implicit(MetricPrefix to Double)</a></td><td>
MetricPrefix オブジェクトから暗黙の型変換で double の係数を得る</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Unit_SI_MetricPrefix_op_Implicit_1.md">Implicit(MetricPrefix to String)</a></td><td>
MetricPrefix オブジェクトから暗黙の型変換で string のSI接頭辞文字列を得る</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Unit_SI_MetricPrefix_op_Inequality.md">Inequality</a></td><td>
不等な係数値か判定</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Unit_SI_MetricPrefix_op_LessThan.md">LessThan</a></td><td>
a が b より小さな係数値か判定</td></tr></table>&nbsp;
<a href="#metricprefix-クラス">トップ</a>

## フィールド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public フィールド](media/pubfield.gif "Public フィールド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="F_usagi_Quantity_Unit_SI_MetricPrefix_RegexPattern.md">RegexPattern</a></td><td>
SI接頭辞の正規表現パターン</td></tr></table>&nbsp;
<a href="#metricprefix-クラス">トップ</a>

## 解説
内部表現は文字列、数値との変換は内蔵テーブルの参照を行います。 

この型は繰り返し頻繁に計算へそのまま用いる用途には向きませんから、そうした必要のある場合は Multiplier を取得して必要な計算を行う事をおすすめします。

## 関連項目


#### 参照
<a href="N_usagi_Quantity_Unit_SI.md">usagi.Quantity.Unit.SI 名前空間</a><br />