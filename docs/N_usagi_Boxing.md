# usagi.Boxing 名前空間<small>[<<Back to Home](https://github.com/usagi/usagi.cs/blob/master/Help/Home.md)</small> 

オブジェクトの Boxing に関する便利かもしれないおまけ機能を提供する


## クラス
&nbsp;<table><tr><th></th><th>クラス</th><th>説明</th></tr><tr><td>![Public クラス](media/pubclass.gif "Public クラス")</td><td><a href="T_usagi_Boxing_Optional_1.md">Optional(T)</a></td><td>
任意の型<T> についてオブジェクトの有無のチェック機構を設けたボクシングされた型を提供する
&nbsp;<ul><li>オブジェクトを放り込むと暗黙的に T 型のオブジェクトとしても振る舞う</li><li>null を放り込むと T 型の空のオブジェクトとして振る舞う</li><li>IDisposable なオブジェクトに対してはボクシングしたまま IDisposable できる</li></ul></td></tr><tr><td>![Public クラス](media/pubclass.gif "Public クラス")</td><td><a href="T_usagi_Boxing_Optional_1_InvalidValueException.md">Optional(T).InvalidValueException</a></td><td>
オブジェクトを内包していない状態でオブジェクトを要求するメソッドを呼んだりすると飛ばします。</td></tr><tr><td>![Public クラス](media/pubclass.gif "Public クラス")</td><td><a href="T_usagi_Boxing_Utility.md">Utility</a></td><td>
Boxing を使ったちょっとした便利機能</td></tr></table>&nbsp;
