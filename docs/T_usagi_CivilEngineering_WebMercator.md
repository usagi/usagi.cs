# WebMercator クラス

<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

WebMercator な機能群


## 継承階層
<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;usagi.CivilEngineering.WebMercator<br /><strong>名前空間:</strong>
&nbsp;<a href="N_usagi_CivilEngineering.md">usagi.CivilEngineering</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.2.0.0 (1.2.0.0)

## 構文

**C#**<br />
``` C#
public static class WebMercator
```

WebMercator 型は下記のメンバーを公開します。


## プロパティ
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_CivilEngineering_WebMercator_CriticalLatitude.md">CriticalLatitude</a></td><td>
WebMercator における臨界緯度（限界緯度）</td></tr></table>&nbsp;
<a href="#webmercator-クラス">トップ</a>

## メソッド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_CivilEngineering_WebMercator_AngleToPixel.md">AngleToPixel(LonLat, Byte)</a></td><td>
経緯度 -> ピクセル座標系の位置</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_CivilEngineering_WebMercator_AngleToPixel_1.md">AngleToPixel(PlaneAngle, PlaneAngle, Byte)</a></td><td>
経緯度 -> ピクセル座標系の位置</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_CivilEngineering_WebMercator_AngleToTile.md">AngleToTile(LonLat, Byte)</a></td><td>
経緯度 -> 所属するタイル座標系の位置</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_CivilEngineering_WebMercator_AngleToTile_1.md">AngleToTile(PlaneAngle, PlaneAngle, Byte)</a></td><td>
経緯度 -> 所属するタイル座標系の位置</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_CivilEngineering_WebMercator_MapSize.md">MapSize</a></td><td>
LOD=z におけるピクセル空間の次元の広さを計算</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_CivilEngineering_WebMercator_NormalizeWebMercator.md">NormalizeWebMercator</a></td><td>
任意の経緯度を WebMercator で表現可能な適当な経緯度へ正規化する 緯度が90°を超える場合は経度は必要に応じて反転され、緯度も反転後の経度に合わせて正規化される。 正規化後の緯度は ± <a href="P_usagi_CivilEngineering_WebMercator_CriticalLatitude.md">CriticalLatitude</a> へ丸められる</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_CivilEngineering_WebMercator_PixelToTile_1.md">PixelToTile(PixelLocation, UInt32)</a></td><td>
ピクセル座標系の位置 -> 所属するタイル座標系の位置</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_CivilEngineering_WebMercator_PixelToTile.md">PixelToTile(UInt32, UInt32, Byte, UInt32)</a></td><td>
ピクセル座標系の位置 -> 所属するタイル座標系の位置</td></tr></table>&nbsp;
<a href="#webmercator-クラス">トップ</a>

## 関連項目


#### 参照
<a href="N_usagi_CivilEngineering.md">usagi.CivilEngineering 名前空間</a><br />

#### その他のリソース
<a href="https://en.wikipedia.org/wiki/Web_Mercator_projection" target="_blank">https://en.wikipedia.org/wiki/Web_Mercator_projection</a><br />