# NumericExtension クラス

<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

比率、係数、無次元数、 そういったようなものとして <a href="http://msdn2.microsoft.com/ja-jp/library/643eft0t" target="_blank">Double</a> を中心に <a href="http://msdn2.microsoft.com/ja-jp/library/3www918f" target="_blank">Single</a>, <a href="http://msdn2.microsoft.com/ja-jp/library/1k2e8atx" target="_blank">Decimal</a> による 実数値としての表現形式と <a href="http://msdn2.microsoft.com/ja-jp/library/f71b253d" target="_blank">SByte</a>, <a href="http://msdn2.microsoft.com/ja-jp/library/yyb1w04y" target="_blank">Byte</a> 等の 整数型に比率としてのセマンティクスを持たせた表現形式を 便利に扱えるようにする拡張。


## 継承階層
<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;usagi.Quantity.Ratio.Extension.NumericExtension<br /><strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Quantity_Ratio_Extension.md">usagi.Quantity.Ratio.Extension</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public static class NumericExtension
```

NumericExtension 型は下記のメンバーを公開します。


## メソッド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ClampToSNorm.md">ClampToSNorm(Decimal)</a></td><td>
[ -1 ... 1 ] へクランプ</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ClampToSNorm_1.md">ClampToSNorm(Double)</a></td><td>
[ -1 ... 1 ] へクランプ</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ClampToSNorm_2.md">ClampToSNorm(Single)</a></td><td>
[ -1 ... 1 ] へクランプ</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ClampToUNorm.md">ClampToUNorm(Decimal)</a></td><td>
[ 0 ... 1 ] へクランプ</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ClampToUNorm_1.md">ClampToUNorm(Double)</a></td><td>
[ 0 ... 1 ] へクランプ</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ClampToUNorm_2.md">ClampToUNorm(Single)</a></td><td>
[ 0 ... 1 ] へクランプ</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_DecompositionToCommonFraction.md">DecompositionToCommonFraction</a></td><td>
分子と分母からなる分数表現へ変換する</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_SNormCollapseToUNorm.md">SNormCollapseToUNorm(Decimal)</a></td><td>
始域 [ -1 ... 1 ] から終域 [ 0 ... 1 ] への射</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_SNormCollapseToUNorm_1.md">SNormCollapseToUNorm(Double)</a></td><td>
始域 [ -1 ... 1 ] から終域 [ 0 ... 1 ] への射</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_SNormCollapseToUNorm_2.md">SNormCollapseToUNorm(Single)</a></td><td>
始域 [ -1 ... 1 ] から終域 [ 0 ... 1 ] への射</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_SNormToInt16.md">SNormToInt16(Decimal)</a></td><td>
始域 [ -1 ... 1 ] から Int16 型の最小値を除く値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_SNormToInt16_1.md">SNormToInt16(Double)</a></td><td>
始域 [ -1 ... 1 ] から Int16 型の最小値を除く値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_SNormToInt16_2.md">SNormToInt16(Single)</a></td><td>
始域 [ -1 ... 1 ] から Int16 型の最小値を除く値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_SNormToInt32.md">SNormToInt32(Decimal)</a></td><td>
始域 [ -1 ... 1 ] から Int32 型の最小値を除く値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_SNormToInt32_1.md">SNormToInt32(Double)</a></td><td>
始域 [ -1 ... 1 ] から Int32 型の最小値を除く値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_SNormToInt32_2.md">SNormToInt32(Single)</a></td><td>
始域 [ -1 ... 1 ] から Int32 型の最小値を除く値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_SNormToInt64.md">SNormToInt64(Decimal)</a></td><td>
始域 [ -1 ... 1 ] から Int64 型の最小値を除く値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_SNormToInt64_1.md">SNormToInt64(Double)</a></td><td>
始域 [ -1 ... 1 ] から Int64 型の最小値を除く値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_SNormToInt64_2.md">SNormToInt64(Single)</a></td><td>
始域 [ -1 ... 1 ] から Int64 型の最小値を除く値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_SNormToSByte.md">SNormToSByte(Decimal)</a></td><td>
始域 [ -1 ... 1 ] から SByte 型の最小値を除く値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_SNormToSByte_1.md">SNormToSByte(Double)</a></td><td>
始域 [ -1 ... 1 ] から SByte 型の最小値を除く値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_SNormToSByte_2.md">SNormToSByte(Single)</a></td><td>
始域 [ -1 ... 1 ] から SByte 型の最小値を除く値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToRatio.md">ToRatio(Decimal, Decimal, Decimal, Decimal)</a></td><td>
比率を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToRatio_1.md">ToRatio(Double, Double, Double, Double)</a></td><td>
比率を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToRatio_2.md">ToRatio(Single, Single, Single, Single)</a></td><td>
比率を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToSNorm.md">ToSNorm(Byte, Boolean)</a></td><td>
[ -1 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToSNorm_2.md">ToSNorm(Int16, Boolean)</a></td><td>
[ -1 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToSNorm_4.md">ToSNorm(Int32, Boolean)</a></td><td>
[ -1 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToSNorm_6.md">ToSNorm(Int64, Boolean)</a></td><td>
[ -1 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToSNorm_8.md">ToSNorm(SByte, Boolean)</a></td><td>
[ -1 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToSNorm_10.md">ToSNorm(UInt16, Boolean)</a></td><td>
[ -1 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToSNorm_12.md">ToSNorm(UInt32, Boolean)</a></td><td>
[ -1 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToSNorm_14.md">ToSNorm(UInt64, Boolean)</a></td><td>
[ -1 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToSNorm_1.md">ToSNorm(Byte, Double, Double, Double)</a></td><td>
[ -1 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToSNorm_3.md">ToSNorm(Int16, Double, Double, Double)</a></td><td>
[ -1 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToSNorm_5.md">ToSNorm(Int32, Double, Double, Double)</a></td><td>
[ -1 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToSNorm_7.md">ToSNorm(Int64, Double, Double, Double)</a></td><td>
[ -1 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToSNorm_9.md">ToSNorm(SByte, Double, Double, Double)</a></td><td>
[ -1 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToSNorm_11.md">ToSNorm(UInt16, Double, Double, Double)</a></td><td>
[ -1 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToSNorm_13.md">ToSNorm(UInt32, Double, Double, Double)</a></td><td>
[ -1 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToSNorm_15.md">ToSNorm(UInt64, Double, Double, Double)</a></td><td>
[ -1 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringBell.md">ToStringBell</a></td><td>
B 単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringNeper.md">ToStringNeper</a></td><td>
Np 単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPercent.md">ToStringPercent(Decimal, String, String)</a></td><td>
パーセント単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPercent_1.md">ToStringPercent(Double, String, String)</a></td><td>
パーセント単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPercent_2.md">ToStringPercent(Single, String, String)</a></td><td>
パーセント単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPermil.md">ToStringPermil(Decimal, String, String)</a></td><td>
パーミル単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPermil_1.md">ToStringPermil(Double, String, String)</a></td><td>
パーミル単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPermil_2.md">ToStringPermil(Single, String, String)</a></td><td>
パーミル単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPermyriad.md">ToStringPermyriad(Decimal, String, String)</a></td><td>
パーミリアド単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPermyriad_1.md">ToStringPermyriad(Double, String, String)</a></td><td>
パーミリアド単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPermyriad_2.md">ToStringPermyriad(Single, String, String)</a></td><td>
パーミリアド単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPPB.md">ToStringPPB(Decimal, String, String)</a></td><td>
ppb 単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPPB_1.md">ToStringPPB(Double, String, String)</a></td><td>
ppb 単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPPB_2.md">ToStringPPB(Single, String, String)</a></td><td>
ppb 単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPPM.md">ToStringPPM(Decimal, String, String)</a></td><td>
ppm 単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPPM_1.md">ToStringPPM(Double, String, String)</a></td><td>
ppm 単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPPM_2.md">ToStringPPM(Single, String, String)</a></td><td>
ppm 単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPPQ.md">ToStringPPQ(Decimal, String, String)</a></td><td>
ppq 単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPPQ_1.md">ToStringPPQ(Double, String, String)</a></td><td>
ppq 単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPPQ_2.md">ToStringPPQ(Single, String, String)</a></td><td>
ppq 単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPPT.md">ToStringPPT(Decimal, String, String)</a></td><td>
ppt 単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPPT_1.md">ToStringPPT(Double, String, String)</a></td><td>
ppt 単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToStringPPT_2.md">ToStringPPT(Single, String, String)</a></td><td>
ppt 単位の文字列を生成</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToUNorm.md">ToUNorm(Byte, Double, Double, Double)</a></td><td>
[ 0 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToUNorm_1.md">ToUNorm(Int16, Double, Double, Double)</a></td><td>
[ 0 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToUNorm_2.md">ToUNorm(Int32, Double, Double, Double)</a></td><td>
[ 0 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToUNorm_3.md">ToUNorm(Int64, Double, Double, Double)</a></td><td>
[ 0 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToUNorm_4.md">ToUNorm(SByte, Double, Double, Double)</a></td><td>
[ 0 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToUNorm_5.md">ToUNorm(UInt16, Double, Double, Double)</a></td><td>
[ 0 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToUNorm_6.md">ToUNorm(UInt32, Double, Double, Double)</a></td><td>
[ 0 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_ToUNorm_7.md">ToUNorm(UInt64, Double, Double, Double)</a></td><td>
[ 0 ... 1 ] へ射影します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormExpandToSNorm.md">UNormExpandToSNorm(Decimal)</a></td><td>
始域 [ 0 ... 1 ] から終域 [ -1 ... 1 ] への射</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormExpandToSNorm_1.md">UNormExpandToSNorm(Double)</a></td><td>
始域 [ 0 ... 1 ] から終域 [ -1 ... 1 ] への射</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormExpandToSNorm_2.md">UNormExpandToSNorm(Single)</a></td><td>
始域 [ 0 ... 1 ] から終域 [ -1 ... 1 ] への射</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToByte.md">UNormToByte(Decimal)</a></td><td>
始域 [ 0 ... 1 ] から Byte 型の全域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToByte_1.md">UNormToByte(Double)</a></td><td>
始域 [ 0 ... 1 ] から Byte 型全域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToByte_2.md">UNormToByte(Single)</a></td><td>
始域 [ 0 ... 1 ] から Byte 型の全域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToInt16.md">UNormToInt16(Decimal)</a></td><td>
始域 [ 0 ... 1 ] から Int16 型の正の値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToInt16_1.md">UNormToInt16(Double)</a></td><td>
始域 [ 0 ... 1 ] から Int16 型の正の値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToInt16_2.md">UNormToInt16(Single)</a></td><td>
始域 [ 0 ... 1 ] から SByte 型の正の値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToInt32.md">UNormToInt32(Decimal)</a></td><td>
始域 [ 0 ... 1 ] から Int32 型の正の値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToInt32_1.md">UNormToInt32(Double)</a></td><td>
始域 [ 0 ... 1 ] から Int32 型の正の値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToInt32_2.md">UNormToInt32(Single)</a></td><td>
始域 [ 0 ... 1 ] から SByte 型の正の値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToInt64.md">UNormToInt64(Decimal)</a></td><td>
始域 [ 0 ... 1 ] から Int64 型の正の値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToInt64_1.md">UNormToInt64(Double)</a></td><td>
始域 [ 0 ... 1 ] から Int64 型の正の値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToInt64_2.md">UNormToInt64(Single)</a></td><td>
始域 [ 0 ... 1 ] から SByte 型の正の値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToSByte.md">UNormToSByte(Decimal)</a></td><td>
始域 [ 0 ... 1 ] から SByte 型の正の値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToSByte_1.md">UNormToSByte(Double)</a></td><td>
始域 [ 0 ... 1 ] から SByte 型の正の値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToSByte_2.md">UNormToSByte(Single)</a></td><td>
始域 [ 0 ... 1 ] から SByte 型の正の値域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToUInt16.md">UNormToUInt16(Decimal)</a></td><td>
始域 [ 0 ... 1 ] から UInt16 型の全域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToUInt16_1.md">UNormToUInt16(Double)</a></td><td>
始域 [ 0 ... 1 ] から UInt16 型全域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToUInt16_2.md">UNormToUInt16(Single)</a></td><td>
始域 [ 0 ... 1 ] から UInt16 型の全域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToUInt32.md">UNormToUInt32(Decimal)</a></td><td>
始域 [ 0 ... 1 ] から UInt32 型の全域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToUInt32_1.md">UNormToUInt32(Double)</a></td><td>
始域 [ 0 ... 1 ] から UInt32 型全域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToUInt32_2.md">UNormToUInt32(Single)</a></td><td>
始域 [ 0 ... 1 ] から UInt32 型の全域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToUInt64.md">UNormToUInt64(Decimal)</a></td><td>
始域 [ 0 ... 1 ] から UInt64 型の全域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToUInt64_1.md">UNormToUInt64(Double)</a></td><td>
始域 [ 0 ... 1 ] から UInt64 型全域を終域として射る</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_Quantity_Ratio_Extension_NumericExtension_UNormToUInt64_2.md">UNormToUInt64(Single)</a></td><td>
始域 [ 0 ... 1 ] から UInt64 型の全域を終域として射る</td></tr></table>&nbsp;
<a href="#numericextension-クラス">トップ</a>

## 例

```
// 赤の輝度を byte の値域 [ 0 ... 255 ] で表現しているよくある状況で
byte u8_red = 211;
// やっぱり double の値域 [ 0 ... 1 ] で計算とかしたくなったり
double f64_red = u8_red.ToUNorm(); // 0.82745098039
// その後 UInt16 形式で保存したくなったり
byte u16_red = f64_red.UNormToUInt16(); // 54227
// アスペクト比を保持していたけれど…
var aspect_ratio = 16.0 / 9.0;
// 分数表現に分解したくなったり
var ( numerator, denominator ) = aspect_ratio.DecompositionToCommonFraction(); // ( 16, 9 )
```


## 関連項目


#### 参照
<a href="N_usagi_Quantity_Ratio_Extension.md">usagi.Quantity.Ratio.Extension 名前空間</a><br />