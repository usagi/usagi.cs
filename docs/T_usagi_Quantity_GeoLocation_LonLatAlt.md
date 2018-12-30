# LonLatAlt クラス

<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

経緯度＋標高 

LonLat の派生で長さオブジェクトの標高を追加で持つ


## 継承階層
<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="T_usagi_Quantity_GeoLocation_LonLat.md">usagi.Quantity.GeoLocation.LonLat</a><br />&nbsp;&nbsp;&nbsp;&nbsp;usagi.Quantity.GeoLocation.LonLatAlt<br /><strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity_GeoLocation.md">usagi.Quantity.GeoLocation</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public class LonLatAlt : LonLat, ILonLatAlt, 
	ILonLatAltGettable, ILonLatGettable, IAltitudeGettable, ILonLatAltSettable, ILonLatSettable, 
	IAltitudeSetttable
```

LonLatAlt 型は下記のメンバーを公開します。


## コンストラクター
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLatAlt__ctor.md">LonLatAlt()</a></td><td>
0 値の経緯度標高を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLatAlt__ctor_1.md">LonLatAlt(GeoCoordinate)</a></td><td><a href="http://msdn2.microsoft.com/ja-jp/library/ee425989" target="_blank">GeoCoordinate</a> を元に生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLatAlt__ctor_2.md">LonLatAlt(ILonLatAltGettable)</a></td><td>
経緯度標高取得可能インターフェースを実装する何かから生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLatAlt__ctor_3.md">LonLatAlt(ILonLatGettable)</a></td><td>
経緯度取得可能インターフェースを実装する何かから生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLatAlt__ctor_4.md">LonLatAlt(ILonLatGettable, IAltitudeGettable)</a></td><td>
経緯度取得可能インターフェースを実装する何かと標高取得可能インターフェースを実装する何かから生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLatAlt__ctor_5.md">LonLatAlt(PlaneAngle, PlaneAngle)</a></td><td>
経緯度を基に Altitude=0 で生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLatAlt__ctor_6.md">LonLatAlt(PlaneAngle, PlaneAngle, Length)</a></td><td>
経緯度、標高を基に生成</td></tr></table>&nbsp;
<a href="#lonlatalt-クラス">トップ</a>

## プロパティ
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")</td><td><a href="P_usagi_Quantity_GeoLocation_LonLatAlt_Altitude.md">Altitude</a></td><td>
標高（高度）</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")</td><td><a href="P_usagi_Quantity_GeoLocation_LonLat_Latitude.md">Latitude</a></td><td>
緯度
 (<a href="T_usagi_Quantity_GeoLocation_LonLat.md">LonLat</a>から継承)</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")</td><td><a href="P_usagi_Quantity_GeoLocation_LonLat_Longitude.md">Longitude</a></td><td>
経度
 (<a href="T_usagi_Quantity_GeoLocation_LonLat.md">LonLat</a>から継承)</td></tr></table>&nbsp;
<a href="#lonlatalt-クラス">トップ</a>

## メソッド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLat_DistanceToPlaneAngle.md">DistanceToPlaneAngle</a></td><td>
経緯度間の距離を平面角で計算 

計算はまあまあ早いが地球のような楕円体のフラッディングレートは考慮しないのでかなり大雑把。
 (<a href="T_usagi_Quantity_GeoLocation_LonLat.md">LonLat</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/bsc2ak47" target="_blank">Equals</a></td><td>
指定したオブジェクトが、現在のオブジェクトと等しいかどうかを判断します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Protected メソッド](media/protmethod.gif "Protected メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/4k87zsw7" target="_blank">Finalize</a></td><td>
オブジェクトが、ガベージ コレクションによって収集される前に、リソースの解放とその他のクリーンアップ操作の実行を試みることができるようにします。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLatAlt_FromGeoCoordinate.md">FromGeoCoordinate</a></td><td><a href="http://msdn2.microsoft.com/ja-jp/library/ee425989" target="_blank">GeoCoordinate</a> から値を取り込む
 (<a href="M_usagi_Quantity_GeoLocation_LonLat_FromGeoCoordinate.md">LonLat.FromGeoCoordinate(GeoCoordinate)</a>をオーバーライド)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
既定のハッシュ関数として機能します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/dfwy45w9" target="_blank">GetType</a></td><td>
現在のインスタンスの <a href="http://msdn2.microsoft.com/ja-jp/library/42892f65" target="_blank">Type</a> を取得します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Protected メソッド](media/protmethod.gif "Protected メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
現在の <a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a> の簡易コピーを作成します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLat_NearlyEqualsTo.md">NearlyEqualsTo(ILonLatGettable, PlaneAngle)</a></td><td>
平面角次元の距離が許容範囲以内で近似的に等価と未為せるか判定
 (<a href="T_usagi_Quantity_GeoLocation_LonLat.md">LonLat</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLat_NearlyEqualsTo_1.md">NearlyEqualsTo(ILonLatGettable, PlaneAngle, PlaneAngle)</a></td><td>
平面角次元の距離が経度軸、緯度軸それぞれで許容範囲以内で近似的に等価と未為せるか判定
 (<a href="T_usagi_Quantity_GeoLocation_LonLat.md">LonLat</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLatAlt_ToGeoCoordinate.md">ToGeoCoordinate</a></td><td><a href="http://msdn2.microsoft.com/ja-jp/library/ee425989" target="_blank">GeoCoordinate</a> を生成
 (<a href="M_usagi_Quantity_GeoLocation_LonLat_ToGeoCoordinate.md">LonLat.ToGeoCoordinate()</a>をオーバーライド)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLatAlt_ToString.md">ToString()</a></td><td>
文字列化
 (<a href="M_usagi_Quantity_GeoLocation_LonLat_ToString.md">LonLat.ToString()</a>をオーバーライド)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLat_ToString_1.md">ToString(Int32)</a></td><td>
浮動小数点数の少数部の桁数指定付きの文字列化
 (<a href="T_usagi_Quantity_GeoLocation_LonLat.md">LonLat</a>から継承)</td></tr></table>&nbsp;
<a href="#lonlatalt-クラス">トップ</a>

## 拡張メソッド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public 拡張メソッド](media/pubextension.gif "Public 拡張メソッド")</td><td><a href="M_usagi_CivilEngineering_Extension_LonLatDistanceExtension_DistanceTo.md">DistanceTo</a></td><td>
2つの経緯度 a, b について、 楕円体近似した惑星の形状定義 planet 上における 惑星表面上の地点間の距離を長さ次元で計算します
 (<a href="T_usagi_CivilEngineering_Extension_LonLatDistanceExtension.md">LonLatDistanceExtension</a>により定義)</td></tr><tr><td>![Public 拡張メソッド](media/pubextension.gif "Public 拡張メソッド")</td><td><a href="M_usagi_CivilEngineering_Extension_LonLatDistanceExtension_LatitudeDistanceTo.md">LatitudeDistanceTo</a></td><td>
経緯度の位置 a と b の緯度方向の距離を計算する
 (<a href="T_usagi_CivilEngineering_Extension_LonLatDistanceExtension.md">LonLatDistanceExtension</a>により定義)</td></tr><tr><td>![Public 拡張メソッド](media/pubextension.gif "Public 拡張メソッド")</td><td><a href="M_usagi_CivilEngineering_Extension_LonLatDistanceExtension_LongitudeDistanceTo.md">LongitudeDistanceTo</a></td><td>
経緯度の位置 a と b の中間の緯度における経度方向の距離を計算する
 (<a href="T_usagi_CivilEngineering_Extension_LonLatDistanceExtension.md">LonLatDistanceExtension</a>により定義)</td></tr><tr><td>![Public 拡張メソッド](media/pubextension.gif "Public 拡張メソッド")</td><td><a href="M_usagi_CivilEngineering_Extension_LonLatDistanceExtension_NearlyEqualsTo.md">NearlyEqualsTo</a></td><td>
経緯度の位置 a, b の惑星を楕円体近似した場合の距離が 許容範囲 tolerance 以下か判定
 (<a href="T_usagi_CivilEngineering_Extension_LonLatDistanceExtension.md">LonLatDistanceExtension</a>により定義)</td></tr></table>&nbsp;
<a href="#lonlatalt-クラス">トップ</a>

## 関連項目


#### 参照
<a href="N_usagi_Quantity_GeoLocation.md">usagi.Quantity.GeoLocation 名前空間</a><br />