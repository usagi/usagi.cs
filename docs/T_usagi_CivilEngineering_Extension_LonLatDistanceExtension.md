# LonLatDistanceExtension クラス

<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

経緯度型 <a href="T_usagi_Quantity_GeoLocation_LonLat.md">LonLat</a>, 経緯度取得可能インターフェース <a href="T_usagi_Quantity_GeoLocation_ILonLatGettable.md">ILonLatGettable</a> を拡張する


## 継承階層
<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;usagi.CivilEngineering.Extension.LonLatDistanceExtension<br /><strong>名前空間:</strong>
&nbsp;<a href="N_usagi_CivilEngineering_Extension.md">usagi.CivilEngineering.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static class LonLatDistanceExtension
```

LonLatDistanceExtension 型は下記のメンバーを公開します。


## メソッド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_CivilEngineering_Extension_LonLatDistanceExtension_DistanceTo.md">DistanceTo</a></td><td>
2つの経緯度 a, b について、 楕円体近似した惑星の形状定義 planet 上における 惑星表面上の地点間の距離を長さ次元で計算します</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_CivilEngineering_Extension_LonLatDistanceExtension_LatitudeDistanceTo.md">LatitudeDistanceTo</a></td><td>
経緯度の位置 a と b の緯度方向の距離を計算する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_CivilEngineering_Extension_LonLatDistanceExtension_LongitudeDistanceTo.md">LongitudeDistanceTo</a></td><td>
経緯度の位置 a と b の中間の緯度における経度方向の距離を計算する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_CivilEngineering_Extension_LonLatDistanceExtension_NearlyEqualsTo.md">NearlyEqualsTo</a></td><td>
経緯度の位置 a, b の惑星を楕円体近似した場合の距離が 許容範囲 tolerance 以下か判定</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_CivilEngineering_Extension_LonLatDistanceExtension_ProjectionTo.md">ProjectionTo</a></td><td>
Vincenty のアルゴリズムで経緯度 origin から距離 distance だけ角度 angle の方位へ射影した経緯度を計算するよ</td></tr></table>&nbsp;
<a href="#lonlatdistanceextension-クラス">トップ</a>

## 関連項目


#### 参照
<a href="N_usagi_CivilEngineering_Extension.md">usagi.CivilEngineering.Extension 名前空間</a><br />