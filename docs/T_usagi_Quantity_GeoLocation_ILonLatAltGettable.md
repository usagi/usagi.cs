# ILonLatAltGettable インターフェイス

<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

PlaneAngle 型の Longitude, Latitude プロパティーを読めて 

Length 型の Altitude プロパティーも読める


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity_GeoLocation.md">usagi.Quantity.GeoLocation</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public interface ILonLatAltGettable : ILonLatGettable, 
	IAltitudeGettable
```

ILonLatAltGettable 型は下記のメンバーを公開します。


## プロパティ
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")</td><td><a href="P_usagi_Quantity_GeoLocation_IAltitudeGettable_Altitude.md">Altitude</a></td><td>
標高（高度）を取得
 (<a href="T_usagi_Quantity_GeoLocation_IAltitudeGettable.md">IAltitudeGettable</a>から継承)</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")</td><td><a href="P_usagi_Quantity_GeoLocation_ILonLatGettable_Latitude.md">Latitude</a></td><td>
緯度を取得
 (<a href="T_usagi_Quantity_GeoLocation_ILonLatGettable.md">ILonLatGettable</a>から継承)</td></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")</td><td><a href="P_usagi_Quantity_GeoLocation_ILonLatGettable_Longitude.md">Longitude</a></td><td>
経度を取得
 (<a href="T_usagi_Quantity_GeoLocation_ILonLatGettable.md">ILonLatGettable</a>から継承)</td></tr></table>&nbsp;
<a href="#ilonlataltgettable-インターフェイス">トップ</a>

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
<a href="#ilonlataltgettable-インターフェイス">トップ</a>

## 関連項目


#### 参照
<a href="N_usagi_Quantity_GeoLocation.md">usagi.Quantity.GeoLocation 名前空間</a><br />