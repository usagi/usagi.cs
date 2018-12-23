# WebMercator メソッド<small>[<<Back to Home](https://github.com/usagi/usagi.cs/blob/master/Help/Home.md)</small><a href="T_usagi_CivilEngineering_WebMercator.md">WebMercator</a> 型は下記のメンバーを公開します。


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
<a href="#webmercator-メソッド">トップ</a>

## 関連項目


#### 参照
<a href="T_usagi_CivilEngineering_WebMercator.md">WebMercator クラス</a><br /><a href="N_usagi_CivilEngineering.md">usagi.CivilEngineering 名前空間</a><br />