# GeoURI.Equals メソッド (GeoURI)<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

経度、緯度、標高、座標系、不確実性パラメーターが完全に一致するか比較する


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_URI.md">usagi.URI</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public bool Equals(
	GeoURI other
)
```


#### パラメーター
&nbsp;<dl><dt>other</dt><dd>型: <a href="T_usagi_URI_GeoURI.md">usagi.URI.GeoURI</a><br />比較対象</dd></dl>

#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/a28wyd50" target="_blank">Boolean</a><br />一致する場合は true

#### 実装
<a href="http://msdn2.microsoft.com/ja-jp/library/ms131190" target="_blank">IEquatable(T).Equals(T)</a><br />

## 解説
平面角の内部実装は浮動小数点数型なのでよほど意図しない限り完全一致はまずしない。 

必要に応じて <a href="M_usagi_URI_GeoURI_NearlyEquals.md">NearlyEquals(GeoURI, PlaneAngle, Length)</a> を使うとよい。

## 関連項目


#### 参照
<a href="T_usagi_URI_GeoURI.md">GeoURI クラス</a><br /><a href="Overload_usagi_URI_GeoURI_Equals.md">Equals オーバーロード</a><br /><a href="N_usagi_URI.md">usagi.URI 名前空間</a><br />