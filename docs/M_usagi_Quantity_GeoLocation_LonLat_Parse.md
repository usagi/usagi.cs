# LonLat.Parse メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

一般的な文章に出現しがちな文字列の経緯度表記から生成を試みるファクトリー 緯度、経度の順にカンマ文字または空白文字を区切りとし、 緯度の冒頭または末尾に 北緯, 南緯, N, S の何れかがあるか省略（＝北緯）され、 経度の冒頭または末尾に 東経, 西経, E, W の何れかがあるか省略（＝東経）され、 緯度と経度の角度値が何れも平面角型でパース可能な文字列に対して期待動作する。 

lonlat 例1: 
```
"43° 3′ 43.5″ N, 141° 21′ 15.8″ E"
```


lonlat 例2: 
```
"北緯43度3分43.5秒 東経141度21分15.8秒"
```



    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity_GeoLocation.md">usagi.Quantity.GeoLocation</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public static LonLat Parse(
	string lonlat
)
```


#### パラメーター
&nbsp;<dl><dt>lonlat</dt><dd>型: <a href="http://msdn2.microsoft.com/ja-jp/library/s1wwdcbf" target="_blank">System.String</a><br />緯度、経度の順にカンマ文字または空白文字を区切りとし、 緯度の冒頭または末尾に 北緯, 南緯, N, S の何れかがあるか省略（＝北緯）され、 経度の冒頭または末尾に 東経, 西経, E, W の何れかがあるか省略（＝東経）され、 緯度と経度の角度値が何れも平面角型でパース可能な文字列。</dd></dl>

#### 戻り値
型: <a href="T_usagi_Quantity_GeoLocation_LonLat.md">LonLat</a><br />パースに成功した場合は LonLat インスタンス、失敗した場合は null

## 例

```
// ありがちなパターン
var a = LonLat.Parse( "43° 3′ 43.5″ N, 141° 21′ 15.8″ E" );
var b = LonLat.Parse( "北緯43度3分43.5秒 東経141度21分15.8秒" );
// 単位が不明で実数が並んでいるだけの場合は deg 単位としてパースを試みます
var c = LonLat.Parse( "43.062083, 141.354389" );
var d = LonLat.Parse( "43.062083 141.354389" );
var e = LonLat.Parse( "N 43.062083, E 141.354389" );
// GeoURI 文字列からもパース可能
var f = LonLat.Parse( "geo:43.062083,141.354389" );
// 使いみちはさておき実装都合 PlaneAngle がパース可能な単位はパースに成功する
var g = LonLat.Parse( "0.751575131115 rad , 2.467099500189 rad" );
var h = LonLat.Parse( "0.11961689722τ , 0.39265108055τ" );
```


## 関連項目


#### 参照
<a href="T_usagi_Quantity_GeoLocation_LonLat.md">LonLat クラス</a><br /><a href="N_usagi_Quantity_GeoLocation.md">usagi.Quantity.GeoLocation 名前空間</a><br />