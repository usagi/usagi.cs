# Calculation クラス

<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

計算機能 

基本的に Generic


## 継承階層
<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;usagi.Quantity.Calculation<br /><strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity.md">usagi.Quantity</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 1.1.0.0 (1.1.0.0)

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
任意個の値から最小の値を1つ抽出する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_NearlyEquals.md">NearlyEquals(Byte, Byte, Byte)</a></td><td>
byte 特殊化版 

byte, UInt16, UInt32 に対しては内部的に1単位大きな符号付きの型で計算を行う。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_NearlyEquals_1.md">NearlyEquals(Char, Char, Char)</a></td><td>
char 特殊化版 

char, Int16, Int32 に対しては内部的に1単位大きな符号付きの型で計算を行う。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_NearlyEquals_2.md">NearlyEquals(Decimal, Decimal, Decimal)</a></td><td>
decimal 特殊化版 

double, float, decimal に対しては内部的にも同じ型のまま計算を行う。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_NearlyEquals_3.md">NearlyEquals(Double, Double, Double)</a></td><td>
double 特殊化版 

double, float, decimal に対しては内部的にも同じ型のまま計算を行う。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_NearlyEquals_4.md">NearlyEquals(Int16, Int16, Int16)</a></td><td>
Int16 特殊化版 

char, Int16, Int32 に対しては内部的に1単位大きな符号付きの型で計算を行う。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_NearlyEquals_5.md">NearlyEquals(Int32, Int32, Int32)</a></td><td>
Int32 特殊化版 

char, Int16, Int32 に対しては内部的に1単位大きな符号付きの型で計算を行う。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_NearlyEquals_6.md">NearlyEquals(Int64, Int64, Int64)</a></td><td>
Int64 特殊化版 

UInt64, Int64 に対しては内部的に decimal 型で計算を行う。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_NearlyEquals_7.md">NearlyEquals(Single, Single, Single)</a></td><td>
float 特殊化版 

double, float, decimal に対しては内部的にも同じ型のまま計算を行う。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_NearlyEquals_8.md">NearlyEquals(UInt16, UInt16, UInt16)</a></td><td>
UInt16 特殊化版 

byte, UInt16, UInt32 に対しては内部的に1単位大きな符号付きの型で計算を行う。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_NearlyEquals_9.md">NearlyEquals(UInt32, UInt32, UInt32)</a></td><td>
UInt32 特殊化版 

byte, UInt16, UInt32 に対しては内部的に1単位大きな符号付きの型で計算を行う。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_NearlyEquals_10.md">NearlyEquals(UInt64, UInt64, UInt64)</a></td><td>
UInt64 特殊化版 

UInt64, Int64 に対しては内部的に decimal 型で計算を行う。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Calculation_NearlyEquals__1.md">NearlyEquals(T)(T, T, T, Func(T, T, T), Func(T, T, T))</a></td><td>
a と b の差が tolerance 以下か判定する 

許容範囲（許容誤差）において近似的に等価</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/7bxwbwt2" target="_blank">ToString</a></td><td>
現在のオブジェクトを表す文字列を返します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr></table>&nbsp;
<a href="#calculation-クラス">トップ</a>

## 関連項目


#### 参照
<a href="N_usagi_Quantity.md">usagi.Quantity 名前空間</a><br />