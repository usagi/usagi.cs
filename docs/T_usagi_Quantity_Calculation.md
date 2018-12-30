# Calculation クラス

<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

計算機能 

基本的に Generic


## 継承階層
<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;usagi.Quantity.Calculation<br /><strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public class Calculation
```

Calculation 型は下記のメンバーを公開します。


## コンストラクター
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_Quantity_Calculation__ctor.md">Calculation</a></td><td>Calculationクラスの新しいインスタンスを初期化します</td></tr></table>&nbsp;
<a href="#calculation-クラス">トップ</a>

## メソッド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_Clamp__1.md">Clamp(T)</a></td><td>
a を [ floor ... ceil ] に丸める</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_Distance__1.md">Distance(T)</a></td><td>
a と b の距離（差）を計算する 

a と b の順序はどうでもよい</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/bsc2ak47" target="_blank">Equals</a></td><td>
指定したオブジェクトが、現在のオブジェクトと等しいかどうかを判断します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Protected メソッド](media/protmethod.gif "Protected メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/4k87zsw7" target="_blank">Finalize</a></td><td>
オブジェクトが、ガベージ コレクションによって収集される前に、リソースの解放とその他のクリーンアップ操作の実行を試みることができるようにします。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
既定のハッシュ関数として機能します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/dfwy45w9" target="_blank">GetType</a></td><td>
現在のインスタンスの <a href="http://msdn2.microsoft.com/ja-jp/library/42892f65" target="_blank">Type</a> を取得します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_IsInRangeOf__1.md">IsInRangeOf(T)</a></td><td>
a が [ floor ... ceil ] に含まれるか判定する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_Max__1.md">Max(T)</a></td><td>
任意個の値から最大の値を1つ抽出する</td></tr><tr><td>![Protected メソッド](media/protmethod.gif "Protected メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
現在の <a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a> の簡易コピーを作成します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_Min__1.md">Min(T)</a></td><td>
任意個の値から最小の値を1つ抽出する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_NearlyEquals__1.md">NearlyEquals(T)</a></td><td>
a と b の差が tolerance 以下か判定する 

許容範囲（許容誤差）において近似的に等価</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/7bxwbwt2" target="_blank">ToString</a></td><td>
現在のオブジェクトを表す文字列を返します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr></table>&nbsp;
<a href="#calculation-クラス">トップ</a>

## 関連項目


#### 参照
<a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />