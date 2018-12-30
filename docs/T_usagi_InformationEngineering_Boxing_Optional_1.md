# Optional(*T*) クラス

<div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

任意の型<T> についてオブジェクトの有無のチェック機構を設けたボクシングされた型を提供する
&nbsp;<ul><li>オブジェクトを放り込むと暗黙的に T 型のオブジェクトとしても振る舞う</li><li>null を放り込むと T 型の空のオブジェクトとして振る舞う</li><li>IDisposable なオブジェクトに対してはボクシングしたまま IDisposable できる</li></ul>

## 継承階層
<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;usagi.InformationEngineering.Boxing.Optional(T)<br /><strong>名前空間:</strong>
&nbsp;<a href="N_usagi_InformationEngineering_Boxing.md">usagi.InformationEngineering.Boxing</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 2.0.0.0 (2.0.0.0)

## 構文

**C#**<br />
``` C#
public class Optional<T> : IDisposable

```


#### 型パラメーター
&nbsp;<dl><dt>T</dt><dd>ボクシングしたい任意の型</dd></dl>&nbsp;
Optional(T) 型は下記のメンバーを公開します。


## コンストラクター
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_InformationEngineering_Boxing_Optional_1__ctor.md">Optional(T)()</a></td><td>
空のボクシングオブジェクトを生成します。 

それはおおよそソフトな null っぽいものです。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_InformationEngineering_Boxing_Optional_1__ctor_1.md">Optional(T)(T)</a></td><td>
オブジェクトを内包したボクシングオブジェクトを生成します。 

生成されたボクシングオブジェクトはおおよそ暗黙の型変換によりT型のオブジェクトっぽく振る舞います。</td></tr></table>&nbsp;
<a href="#optional(*t*)-クラス">トップ</a>

## プロパティ
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public プロパティ](media/pubproperty.gif "Public プロパティ")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="P_usagi_InformationEngineering_Boxing_Optional_1_Null.md">Null</a></td><td>
空のボクシングオブジェクトを生成するファクトリーとして機能するプロパティー new Optional<T>() の糖衣構文です。 new と ctor の ( ) をタイプしたくないあなたに。</td></tr></table>&nbsp;
<a href="#optional(*t*)-クラス">トップ</a>

## メソッド
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_InformationEngineering_Boxing_Optional_1_Dispose.md">Dispose</a></td><td>
内包するオブジェクトが IDisposable を実装する場合には Dispose します。 

ボクシングオブジェクトとしても内包するオブジェクトの運命をガベージコレクターへ任せ、自身は何も内包しない状態へ変化します。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/bsc2ak47" target="_blank">Equals</a></td><td>
指定したオブジェクトが、現在のオブジェクトと等しいかどうかを判断します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Protected メソッド](media/protmethod.gif "Protected メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/4k87zsw7" target="_blank">Finalize</a></td><td>
オブジェクトが、ガベージ コレクションによって収集される前に、リソースの解放とその他のクリーンアップ操作の実行を試みることができるようにします。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_InformationEngineering_Boxing_Optional_1_FromValue.md">FromValue</a></td><td>
内包させたいオブジェクトからボクシングオブジェクトを生成するファクトリー</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_InformationEngineering_Boxing_Optional_1_Get.md">Get</a></td><td>
内包するオブジェクトがあれば取り出します。 この機能は T 型への暗黙の型変換と等価です。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
既定のハッシュ関数として機能します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/dfwy45w9" target="_blank">GetType</a></td><td>
現在のインスタンスの <a href="http://msdn2.microsoft.com/ja-jp/library/42892f65" target="_blank">Type</a> を取得します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_InformationEngineering_Boxing_Optional_1_IsValid.md">IsValid</a></td><td>
内包するオブジェクトの有無を返します。</td></tr><tr><td>![Protected メソッド](media/protmethod.gif "Protected メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
現在の <a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a> の簡易コピーを作成します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_InformationEngineering_Boxing_Optional_1_Reset.md">Reset(T, Boolean)</a></td><td>
ボクシングオブジェクトにオブジェクトを新たに内包させます。 

既に内包しているオブジェクトがあった場合その運命はガベージコレクターに委ねられます。たぶん。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_InformationEngineering_Boxing_Optional_1_Reset_1.md">Reset(T, T)</a></td><td>
新たなオブジェクトを内包させると同時に既に内包しているオブジェクトがあった場合には取り出せる版の Reset　です。</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="http://msdn2.microsoft.com/ja-jp/library/7bxwbwt2" target="_blank">ToString</a></td><td>
現在のオブジェクトを表す文字列を返します。
 (<a href="http://msdn2.microsoft.com/ja-jp/library/e5kfa45b" target="_blank">Object</a>から継承)</td></tr><tr><td>![Public メソッド](media/pubmethod.gif "Public メソッド")</td><td><a href="M_usagi_InformationEngineering_Boxing_Optional_1_TryGet.md">TryGet</a></td><td>
内包するオブジェクトがあれば value へ取り出し true を返します。 

内包するオブジェクトが無ければ value には何もせず false を返します。</td></tr></table>&nbsp;
<a href="#optional(*t*)-クラス">トップ</a>

## 演算子
&nbsp;<table><tr><th></th><th>名前</th><th>説明</th></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_InformationEngineering_Boxing_Optional_1_op_False.md">False</a></td><td>
内包するオブジェクトが無効な場合に operator false として true を返します。</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_InformationEngineering_Boxing_Optional_1_op_Implicit.md">Implicit(Optional(T) to T)</a></td><td>
暗黙の型変換により T 型へ変換します。 Get と等価に機能します。</td></tr><tr><td>![Public 演算子](media/puboperator.gif "Public 演算子")![静的メンバー](media/static.gif "静的メンバー")</td><td><a href="M_usagi_InformationEngineering_Boxing_Optional_1_op_True.md">True</a></td><td>
内包するオブジェクトが有効な場合に operator true として true を返します。</td></tr></table>&nbsp;
<a href="#optional(*t*)-クラス">トップ</a>

## 解説
内部表現は object による

## 関連項目


#### 参照
<a href="N_usagi_InformationEngineering_Boxing.md">usagi.InformationEngineering.Boxing 名前空間</a><br />