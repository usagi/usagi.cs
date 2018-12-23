# LonLatHelper.LonLatDistanceAlgorithm 列挙体<small>[<<Back to Home](https://github.com/usagi/usagi.cs/blob/master/Help/Home.md)</small> 

平面角次元群による経緯度から長さ次元の距離を計算する際に使用するアルゴリズム


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_CivilEngineering.md">usagi.CivilEngineering</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

## 構文

**C#**<br />
``` C#
public enum LonLatDistanceAlgorithm
```


## メンバー
&nbsp;<table><tr><th></th><th>メンバー</th><th>値</th><th>説明</th></tr><tr><td /><td target="F:usagi.CivilEngineering.LonLatHelper.LonLatDistanceAlgorithm.Haversine">**Haversine**</td><td>0</td><td>Haversine 法（半正矢関数の公式）
&nbsp;<ul><li>惑星の赤道方向への半径から概算する。</li><li>惑星の楕円体としての扁平率は無視する。</li><li>負荷は軽いが高精度な計算結果を求めたい場合には向かない。</li></ul></td></tr><tr><td /><td target="F:usagi.CivilEngineering.LonLatHelper.LonLatDistanceAlgorithm.Vincenty">**Vincenty**</td><td>1</td><td>Vincenty 法
&nbsp;<ul><li>惑星を楕円体近似した赤道方向への半径、回転軸方向への半径、扁平率を考慮し、十分な計算精度を反復計算により確保する。</li><li>負荷は高いが高精度な計算結果を求めたい場合に向く。</li></ul></td></tr></table>

## 関連項目


#### 参照
<a href="N_usagi_CivilEngineering.md">usagi.CivilEngineering 名前空間</a><br />