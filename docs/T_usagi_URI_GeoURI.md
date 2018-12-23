# GeoURI クラス

<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

RFC5870 GeoURI を扱う型 

例: href='geo:48.198634,16.371648;crs=wgs84;u=40'


## 継承階層
<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;usagi.URI.GeoURI<br /><strong>名前空間:</strong>
&nbsp;<a href="N_usagi_URI.md">usagi.URI</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public class GeoURI : ILonLatGettable, IAltitudeGettable, 
	IToGeoCoordinate, IEquatable<GeoURI>
```

GeoURI 型は下記のメンバーを公開します。


## コンストラクター
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_URI_GeoURI__ctor.md">GeoURI(String)</a></td><td>
GeoURI が期待される任意の文字列を元に生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_URI_GeoURI__ctor_1.md">GeoURI(Uri)</a></td><td>
URI を元に生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_URI_GeoURI__ctor_2.md">GeoURI(LonLat, String, String)</a></td><td>
経緯度を元に生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_URI_GeoURI__ctor_3.md">GeoURI(LonLatAlt, String, String)</a></td><td>
経緯度高度を元に生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_URI_GeoURI__ctor_4.md">GeoURI(PlaneAngle, PlaneAngle, Length, String, String)</a></td><td>
指定可能な全てのパラメーターを元に生成</td></tr></table>&nbsp;
<a href="#geouri-クラス">トップ</a>

## プロパティ
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")</td><td><a href="P_usagi_URI_GeoURI_Altitude.md">Altitude</a></td><td>
標高（高度） デフォルト null</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")</td><td><a href="P_usagi_URI_GeoURI_CoordinateReferenceSystem.md">CoordinateReferenceSystem</a></td><td>
測地系を表す文字列 

デフォルト null</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")</td><td><a href="P_usagi_URI_GeoURI_Latitude.md">Latitude</a></td><td>
緯度</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")</td><td><a href="P_usagi_URI_GeoURI_Longitude.md">Longitude</a></td><td>
経度</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")</td><td><a href="P_usagi_URI_GeoURI_OriginalString.md">OriginalString</a></td><td>
与えられた元の URI 文字列</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")</td><td><a href="P_usagi_URI_GeoURI_Scheme.md">Scheme</a></td><td>
URI の Scheme</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")</td><td><a href="P_usagi_URI_GeoURI_Uncertainty.md">Uncertainty</a></td><td>
GeoURI の u (Uncertainty; 不確実性) パラメーター 

デフォルト null</td></tr></table>&nbsp;
<a href="#geouri-クラス">トップ</a>

## メソッド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/bsc2ak47" target="_blank">Equals(Object)</a></td><td>
指定したオブジェクトが、現在のオブジェクトと等しいかどうかを判断します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_URI_GeoURI_Equals.md">Equals(GeoURI)</a></td><td>
経度、緯度、標高、座標系、不確実性パラメーターが完全に一致するか比較する</td></tr><tr><td>![Protected メソッド](media/protmethod.gif "Protected メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/4k87zsw7" target="_blank">Finalize</a></td><td>
オブジェクトが、ガベージ コレクションによって収集される前に、リソースの解放とその他のクリーンアップ操作の実行を試みることができるようにします。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
既定のハッシュ関数として機能します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/dfwy45w9" target="_blank">GetType</a></td><td>
現在のインスタンスの <a href="http://msdn2.microsoft.com/ja-jp/library/42892f65" target="_blank">Type</a> を取得します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Protected メソッド](media/protmethod.gif "Protected メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
現在の <a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a> の簡易コピーを作成します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_URI_GeoURI_NearlyEquals.md">NearlyEquals</a></td><td>
経度、緯度、高度が許容範囲内で近似的に等価かつ測地系と不確実性パラメーターが完全に一致するか判定</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_URI_GeoURI_ToGeoCoordinate.md">ToGeoCoordinate</a></td><td><a href="http://msdn2.microsoft.com/ja-jp/library/ee425989" target="_blank">GeoCoordinate</a> を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_URI_GeoURI_ToString.md">ToString</a></td><td>
文字列化
 (<a href="http://msdn2.microsoft.com/ja-jp/library/7bxwbwt2" target="_blank">Object.ToString()</a>をオーバーライド)</td></tr></table>&nbsp;
<a href="#geouri-クラス">トップ</a>

## フィールド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public フィールド](media/pubfield.gif "Public フィールド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="F_usagi_URI_GeoURI_Regex.md">Regex</a></td><td>
GeoURI を解析可能な正規表現</td></tr><tr><td>![Public フィールド](media/pubfield.gif "Public フィールド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="F_usagi_URI_GeoURI_RegexPattern.md">RegexPattern</a></td><td>
GeoURI を解析可能な正規表現パターン</td></tr><tr><td>![Public フィールド](media/pubfield.gif "Public フィールド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="F_usagi_URI_GeoURI_UriSchemeGeo.md">UriSchemeGeo</a></td><td>
GeoURI の Scheme</td></tr></table>&nbsp;
<a href="#geouri-クラス">トップ</a>

## 拡張メソッド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public 拡張メソッド](media/pubextension.gif "Public 拡張メソッド")</td><td><a href="M_usagi_CivilEngineering_LonLatHelper_DistanceTo.md">DistanceTo</a></td><td>
2つの経緯度 a, b について、 楕円体近似した惑星の形状定義 planet 上における 惑星表面上の地点間の距離を長さ次元で計算します
 (<a href="T_usagi_CivilEngineering_LonLatHelper.md">LonLatHelper</a>により定義)</td></tr><tr><td>![Public 拡張メソッド](media/pubextension.gif "Public 拡張メソッド")</td><td><a href="M_usagi_CivilEngineering_LonLatHelper_LatitudeDistanceTo.md">LatitudeDistanceTo</a></td><td>
経緯度の位置 a と b の緯度方向の距離を計算する
 (<a href="T_usagi_CivilEngineering_LonLatHelper.md">LonLatHelper</a>により定義)</td></tr><tr><td>![Public 拡張メソッド](media/pubextension.gif "Public 拡張メソッド")</td><td><a href="M_usagi_CivilEngineering_LonLatHelper_LongitudeDistanceTo.md">LongitudeDistanceTo</a></td><td>
経緯度の位置 a と b の中間の緯度における経度方向の距離を計算する
 (<a href="T_usagi_CivilEngineering_LonLatHelper.md">LonLatHelper</a>により定義)</td></tr><tr><td>![Public 拡張メソッド](media/pubextension.gif "Public 拡張メソッド")</td><td><a href="M_usagi_CivilEngineering_LonLatHelper_NearlyEqualsTo.md">NearlyEqualsTo</a></td><td>
経緯度の位置 a, b の惑星を楕円体近似した場合の距離が 許容範囲 tolerance 以下か判定
 (<a href="T_usagi_CivilEngineering_LonLatHelper.md">LonLatHelper</a>により定義)</td></tr></table>&nbsp;
<a href="#geouri-クラス">トップ</a>

## 解説
pattern 1: geo:%lat%,%lon%;u=%unc% 

pattern 2: geo:%lat%,%lon%,%alt%;u=%unc% 

pattern 3: geo:%lat%,%lon%,%alt%;crs=%crs%;u=%unc% 

 %lat% is a Latitude 

 %lon% is a Longitude 

 %alt% is an Altitude ( optional ) 

 %unc% is an Uncertainty Parameter ( optional ) 

 %crs% is a Coordinate Reference System ( optional ) 

なお、 <a href="http://msdn2.microsoft.com/ja-jp/library/txt7706a" target="_blank">Uri</a> から派生させたかったが . 文字を含まない Host の検出で例外を出すため関わらない事にした。

## 関連項目


#### 参照
<a href="N_usagi_URI.md">usagi.URI 名前空間</a><br />

#### その他のリソース
<a href="https://tools.ietf.org/rfc/rfc5870" target="_blank">https://tools.ietf.org/rfc/rfc5870</a><br />