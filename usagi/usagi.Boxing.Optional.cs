using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// オブジェクトの Boxing に関する便利かもしれないおまけ機能を提供する
/// </summary>
namespace usagi.Boxing
{
  /// <summary>
  /// Optional&lt;T&gt; への糖衣構文
  /// </summary>
  abstract class Optional
  {
    /// <summary>
    /// Optional&lt;T&gt;.FromValu&lt;T&gt; への糖衣構文
    /// </summary>
    /// <typeparam name="T">ボクシングしたい任意のオブジェクトの型</typeparam>
    /// <param name="value">ボクシングしたい任意のオブジェクト</param>
    /// <returns>ボクシングされた任意のオブジェクト</returns>
    public static Optional<T> FromValue<T>( T value ) { return Optional<T>.FromValue( value ); }
  }

  /// <summary>
  /// 任意の型&lt;T&gt; についてオブジェクトの有無のチェック機構を設けたボクシングされた型を提供する
  /// オブジェクトを放り込むと暗黙的に T 型のオブジェクトとしても振る舞う
  /// null を放り込むと T 型の空のオブジェクトとして振る舞う
  /// IDisposable なオブジェクトに対してはボクシングしたまま IDisposable できる
  /// 内部表現は object による
  /// </summary>
  /// <typeparam name="T">ボクシングしたい任意の型</typeparam>
  public class Optional<T>
    : IDisposable
  {
    /// <summary>
    /// オブジェクトを内包していない状態でオブジェクトを要求するメソッドを呼んだりすると飛ばします。
    /// </summary>
    public class InvalidValueException: InvalidOperationException { public InvalidValueException( string m = "" ) : base( m ) { } }

    /// <summary>
    /// 内部表現
    /// </summary>
    object o = null;

    /// <summary>
    /// 空のボクシングオブジェクトを生成します。
    /// それはおおよそソフトな null っぽいものです。
    /// </summary>
    public Optional() { }
    /// <summary>
    /// オブジェクトを内包したボクシングオブジェクトを生成します。
    /// 生成されたボクシングオブジェクトはおおよそ暗黙の型変換によりT型のオブジェクトっぽく振る舞います。
    /// </summary>
    /// <param name="value">内包させるオブジェクト</param>
    public Optional( T value ) { Reset( value ); }

    /// <summary>
    /// ボクシングオブジェクトにオブジェクトを新たに内包させます。
    /// 既に内包しているオブジェクトがあった場合その運命はガベージコレクターに委ねられます。たぶん。
    /// </summary>
    /// <param name="value">新たに内包させるオブジェクト</param>
    /// <param name="dispose">既に内包しているオブジェクトがあり、かつ IDisposable を実装している場合に Dispose する場合は true 、しなくていい場合は false</param>
    /// <returns>新たなオブジェクトを内包した this</returns>
    public Optional<T> Reset( T value, bool dispose = true )
    {
      if ( dispose )
        Dispose();
      o = value;
      return this;
    }

    /// <summary>
    /// 新たなオブジェクトを内包させると同時に既に内包しているオブジェクトがあった場合には取り出せる版の Reset　です。
    /// </summary>
    /// <param name="value">新たに内包させるオブジェクト</param>
    /// <param name="previously">既に内包しているオブジェクトがあった場合に取り出す先</param>
    /// <returns>新たなオブジェクトを内包した this</returns>
    public Optional<T> Reset( T value, ref T previously )
    {
      TryGet( ref previously );
      return Reset( value );
    }

    /// <summary>
    /// 内包するオブジェクトがあれば取り出します。
    /// この機能は T 型への暗黙の型変換と等価です。
    /// </summary>
    /// <exception cref="InvalidValueException">内包するオブジェクトが無い場合に飛びます。</exception>
    /// <returns>内包するオブジェクト</returns>
    public T Get()
    {
      if ( o is T v )
        return v;
      throw new InvalidValueException( $"Optional<T>(T={ o.GetType().FullName.ToString()}) has not a valid value." );
    }

    /// <summary>
    /// 内包するオブジェクトがあれば value へ取り出し true を返します。
    /// 内包するオブジェクトが無ければ value には何もせず false を返します。
    /// Get や暗黙の型変換で例外が飛ぶ可能性を嫌う場合にどうぞ。
    /// </summary>
    /// <param name="value">内包するオブジェクトがあれば代入されます。無ければ何もされません。</param>
    /// <returns>内包するオブジェクトを value へ取り出せた場合は true 、そうでない場合には false が帰ります。</returns>
    public bool TryGet( ref T value )
    {
      if ( o is T v )
      {
        value = v;
        return true;
      }
      return false;
    }

    /// <summary>
    /// 内包するオブジェクトの有無を返します。
    /// </summary>
    /// <returns>内包するオブジェクトがあれば true 、無ければ false が返ります。</returns>
    public bool IsValid() { return o != null; }
    /// <summary>
    /// 内包するオブジェクトが有効な場合に operator true として true を返します。
    /// </summary>
    /// <param name="optional">ボクシングオブジェクト</param>
    /// <returns>内包するオブジェクトが有効な場合は true 、そうでなければ false</returns>
    static public bool operator true( Optional<T> optional ) { return optional.IsValid(); }
    /// <summary>
    /// 内包するオブジェクトが無効な場合に operator false として true を返します。
    /// </summary>
    /// <param name="optional">ボクシングオブジェクト</param>
    /// <returns>内包するオブジェクトが無効な場合は true 、そうでなければ false</returns>
    static public bool operator false( Optional<T> optional ) { return !optional.IsValid(); }
    /// <summary>
    /// 暗黙の型変換により T 型へ変換します。
    /// Get と等価に機能します。
    /// </summary>
    /// <param name="optional">ボクシングオブジェクト</param>
    static public implicit operator T( Optional<T> optional ) { return optional.Get(); }

    /// <summary>
    /// 内包させたいオブジェクトからボクシングオブジェクトを生成するファクトリー
    /// </summary>
    /// <param name="value">内包させたいオブジェクト</param>
    /// <returns>value を内包したボクシングオブジェクト</returns>
    static public Optional<T> FromValue( T value ) { return new Optional<T>( value ); }
    /// <summary>
    /// 空のボクシングオブジェクトを生成するファクトリーとして機能するプロパティー
    /// new Optional&ltT&gt;() の糖衣構文です。 new と ctor の ( ) をタイプしたくないあなたに。
    /// </summary>
    static public Optional<T> Null { get { return new Optional<T>(); } }

    /// <summary>
    /// 内包するオブジェクトが IDisposable を実装する場合には Dispose します。
    /// ボクシングオブジェクトとしても内包するオブジェクトの運命をガベージコレクターへ任せ、自身は何も内包しない状態へ変化します。
    /// </summary>
    public void Dispose()
    {
      if ( o is IDisposable v )
        v.Dispose();
      o = null;
    }
  }

  public static class Utility
  {
    /// <summary>
    /// 列挙の先頭要素をボクシングオブジェクトで取り出します。
    /// </summary>
    /// <typeparam name="T">列挙された任意の型</typeparam>
    /// <param name="values">列挙された任意の型のオブジェクト群</param>
    /// <returns>列挙の先頭要素または空のボクシングオブジェクト</returns>
    static public Optional<T> FirstOfOptional<T>( this IEnumerable<T> values )
    {
      if ( values.Count() > 0 )
        return Optional.FromValue( values.First() );
      return Optional<T>.Null;
    }

    /// <summary>
    /// 列挙の末尾要素をボクシングオブジェクトで取り出します。
    /// </summary>
    /// <typeparam name="T">列挙された任意の型</typeparam>
    /// <param name="values">列挙された任意の型のオブジェクト群</param>
    /// <returns>列挙の末尾要素または空のボクシングオブジェクト</returns>
    static public Optional<T> LastOfOptional<T>( this IEnumerable<T> values )
    {
      if ( values.Count() > 0 )
        return Optional.FromValue( values.Last() );
      return Optional<T>.Null;
    }
  }
}
