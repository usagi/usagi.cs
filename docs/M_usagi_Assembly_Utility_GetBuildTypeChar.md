# Utility.GetBuildTypeChar メソッド <div style="font-size:30%"><a href="https://github.com/usagi/usagi.cs/blob/master/docs/Home.md">≪Back to Home</a></div> 

ビルドに応じて D, R を返す。この機能はソースから翻訳される際に結果が決定される。 （ライブラリーとしてこの機能がコンパイル済みの場合、コンパイル済みのライブラリーが D, R の何れかに確定される点に注意）


    <strong>名前空間:</strong>
&nbsp;<a href="N_usagi_Assembly.md">usagi.Assembly</a><br /><strong>アセンブリ:</strong>
&nbsp;usagi (in usagi.dll) バージョン: 3.0.0.0

## 構文

**C#**<br />
``` C#
public static char GetBuildTypeChar()
```


#### 戻り値
型: <a href="http://msdn2.microsoft.com/ja-jp/library/k493b04s" target="_blank">Char</a><br />デバッグビルドされていれば 'D', リリースビルドされていれば 'R'

## 関連項目


#### 参照
<a href="T_usagi_Assembly_Utility.md">Utility クラス</a><br /><a href="N_usagi_Assembly.md">usagi.Assembly 名前空間</a><br />