# LonLat メソッド<small>[<<Back to Home](https://github.com/usagi/usagi.cs/blob/master/Help/Home.md)</small><a href="T_usagi_Quantity_GeoLocation_LonLat.md">LonLat</a> 型は下記のメンバーを公開します。


## メソッド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLat_DistanceToPlaneAngle.md">DistanceToPlaneAngle</a></td><td>
経緯度間の距離を平面角で計算 

計算はまあまあ早いが地球のような楕円体のフラッディングレートは考慮しないのでかなり大雑把。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/bsc2ak47" target="_blank">Equals</a></td><td>
指定したオブジェクトが、現在のオブジェクトと等しいかどうかを判断します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Protected メソッド](media/protmethod.gif "Protected メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/4k87zsw7" target="_blank">Finalize</a></td><td>
オブジェクトが、ガベージ コレクションによって収集される前に、リソースの解放とその他のクリーンアップ操作の実行を試みることができるようにします。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLat_FromDegrees.md">FromDegrees</a></td><td>
経緯度を degrees 単位の平面角から生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLat_FromGeoCoordinate.md">FromGeoCoordinate</a></td><td><a href="http://msdn2.microsoft.com/ja-jp/library/ee425989" target="_blank">GeoCoordinate</a> から経緯度を取り込む</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
既定のハッシュ関数として機能します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/dfwy45w9" target="_blank">GetType</a></td><td>
現在のインスタンスの <a href="http://msdn2.microsoft.com/ja-jp/library/42892f65" target="_blank">Type</a> を取得します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Protected メソッド](media/protmethod.gif "Protected メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
現在の <a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a> の簡易コピーを作成します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLat_NearlyEqualsTo.md">NearlyEqualsTo(ILonLatGettable, PlaneAngle)</a></td><td>
平面角次元の距離が許容範囲以内で近似的に等価と未為せるか判定</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLat_NearlyEqualsTo_1.md">NearlyEqualsTo(ILonLatGettable, PlaneAngle, PlaneAngle)</a></td><td>
平面角次元の距離が経度軸、緯度軸それぞれで許容範囲以内で近似的に等価と未為せるか判定</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLat_Parse.md">Parse</a></td><td>
一般的な文章に出現しがちな文字列の経緯度表記から生成を試みるファクトリー 緯度、経度の順にカンマ文字または空白文字を区切りとし、 緯度の冒頭または末尾に 北緯, 南緯, N, S の何れかがあるか省略（＝北緯）され、 経度の冒頭または末尾に 東経, 西経, E, W の何れかがあるか省略（＝東経）され、 緯度と経度の角度値が何れも平面角型でパース可能な文字列に対して期待動作する。 

lonlat 例1: 
```
"43° 3′ 43.5″ N, 141° 21′ 15.8″ E"
```


lonlat 例2: 
```
"北緯43度3分43.5秒 東経141度21分15.8秒"
```</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLat_ToGeoCoordinate.md">ToGeoCoordinate</a></td><td><a href="http://msdn2.microsoft.com/ja-jp/library/ee425989" target="_blank">GeoCoordinate</a> を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLat_ToString.md">ToString()</a></td><td>
文字列化
 (<a href="http://msdn2.microsoft.com/ja-jp/library/7bxwbwt2" target="_blank">Object.ToString()</a>をオーバーライド)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_GeoLocation_LonLat_ToString_1.md">ToString(Int32)</a></td><td>
浮動小数点数の少数部の桁数指定付きの文字列化</td></tr></table>&nbsp;
<a href="#lonlat-メソッド">トップ</a>

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
<a href="#lonlat-メソッド">トップ</a>

## 関連項目


#### 参照
<a href="T_usagi_Quantity_GeoLocation_LonLat.md">LonLat クラス</a><br /><a href="N_usagi_Quantity_GeoLocation.md">usagi.Quantity.GeoLocation 名前空間</a><br />