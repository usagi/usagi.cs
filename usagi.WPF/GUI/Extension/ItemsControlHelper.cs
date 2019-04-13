using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;

namespace usagi.WPF.GUI.Extension
{
  /// <summary>
  /// System.Windows.Control.ItemsControlHelper に対する機能拡張
  /// </summary>
  static public class ItemsControlHelper
  {
    /// <summary>
    /// ItemsControl から index 番目のアイテムの ContentPresenter を引っ張り出す
    /// </summary>
    /// <param name="c">引っ張り出し元</param>
    /// <param name="index">ContentPresenter を引っ張り出したいアイテムのインデックス</param>
    /// <returns>引っ張り出された ContentPresenter または null</returns>
    static public
    ContentPresenter
    GetContentPresenter
    ( this ItemsControl c, int index )
    {
      return
        c
        .ItemContainerGenerator
        .ContainerFromIndex( index )
        as ContentPresenter
        ;
    }

    /// <summary>
    /// ContentPresenter から name の object を引っ張り出す
    /// </summary>
    /// <param name="p">引っ張り出し元</param>
    /// <param name="name">引っ張り出したい object の名前</param>
    /// <returns>引っ張り出された object または null</returns>
    static public
    object
    FindChild
    ( this ContentPresenter p
    , string name
    )
    {
      return
        p
        .ContentTemplate
        .FindName( name, p )
        ;
    }

    /// <summary>
    /// ContentPresenter から name の object を T 型で引っ張り出す
    /// <para/>
    /// <see cref="FindChild(ContentPresenter, string)"/> の型キャスト付き版
    /// </summary>
    /// <typeparam name="T">引っ張り出したい object の型</typeparam>
    /// <param name="p">引っ張り出し元</param>
    /// <param name="name">引っ張り出したい object の名前</param>
    /// <returns>引っ張り出された T 型の object または null</returns>
    static public
    T
    FindChildAs<T>
    ( this ContentPresenter p
    , string name
    )
      where T : class
    {
      return p.FindChild( name ) as T;
    }

    /// <summary>
    /// <see cref="GetContentPresenter(ItemsControl, int)"/> +
    /// <see cref="FindChild(ContentPresenter, string)"/> の複合技。
    /// </summary>
    /// <remarks>
    /// 取り出したいアイテムが1つだけの場合に便利。
    /// 複数の場合は <see cref="FindChildren(ItemsControl, int, string[])"/> を使うと良い。
    /// </remarks>
    /// <param name="c">引っ張り出し元</param>
    /// <param name="index">ContentPresenter を引っ張り出したいアイテムのインデックス</param>
    /// <param name="name">引っ張り出したいアイテムの名前</param>
    /// <returns>引っ張り出したアイテムまたは null</returns>
    static public
    object
    FindChild
    ( this ItemsControl c, int index, string name )
    {
      if ( GetContentPresenter( c, index ) is ContentPresenter p )
        return p.FindChild( name );
      return null;
    }


    /// <summary>
    /// <see cref="FindChild(ItemsControl, int, string)"/> の型キャスト付き版
    /// </summary>
    /// <remarks>
    /// 取り出したいアイテムが1つだけの場合に便利。
    /// 複数の場合は <see cref="FindChildrenAs{T}(ItemsControl, int, string[])"/> を使うと良い。
    /// </remarks>
    /// <typeparam name="T">引っ張り出したいアイテムの型</typeparam>
    /// <param name="c">引っ張り出し元</param>
    /// <param name="index">ContentPresenter を引っ張り出したいアイテムのインデックス</param>
    /// <param name="name">引っ張り出したいアイテムの名前</param>
    /// <returns>引っ張り出したアイテムまたは null</returns>
    static public
    object
    FindChildAs<T>
    ( this ItemsControl c, int index, string name )
      where T : class
    {
      return c.FindChild( index, name ) as T;
    }

    /// <summary>
    /// <see cref="GetContentPresenter(ItemsControl, int)"/> +
    /// <see cref="FindChild(ContentPresenter, string)"/> の合体技
    /// </summary>
    /// <param name="c">引っ張り出し元</param>
    /// <param name="index">ContentPresenter を引っ張り出したいアイテムのインデックス</param>
    /// <param name="names">引っ張り出し元の各アイテムごとに引っ張り出したいコントロールの名前群</param>
    /// <returns>&lt;&lt;Key=名前, Value=引っ張り出されたアイテムまたは null&gt;の辞書&gt;の列挙</returns>
    static public
    IDictionary<string, object>
    FindChildren
    ( this ItemsControl c, int index, params string[] names )
    {
      var r = new Dictionary<string, object>();
      if ( GetContentPresenter( c, index ) is ContentPresenter p )
        foreach ( var name in names )
          r.Add( name, p.FindChild( name ) );
      return r;
    }

    /// <summary>
    /// <see cref="FindChildren(ItemsControl, string[])"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="c">引っ張り出し元</param>
    /// <param name="index">ContentPresenter を引っ張り出したいアイテムのインデックス</param>
    /// <param name="names">引っ張り出し元の各アイテムごとに引っ張り出したいコントロールの名前群</param>
    /// <returns>&lt;&lt;Key=名前, Value=引っ張り出されたアイテムまたは null&gt;の辞書&gt;の列挙</returns>
    static public
    IDictionary<string, T>
    FindChildrenAs<T>
    ( this ItemsControl c, int index, params string[] names )
      where T : class
    {
      var r = new Dictionary<string, T>();
      if ( GetContentPresenter( c, index ) is ContentPresenter p )
        foreach ( var name in names )
          r.Add( name, p.FindChildAs<T>( name ) );
      return r;
    }

    /// <summary>
    /// <see cref="FindChildren(ItemsControl, int, string[])"/> のさらにずぼら横着進化した版
    /// control の全てのアイテムごとに、一度に複数の名前を与えて対応する複数の object を引っ張り出せる。
    /// </summary>
    /// <example>
    /// <code>
    /// var css = control.FindChildren( "Name1", "Name2", "Name3" );
    /// foreach ( var cs in css )
    /// {
    ///   if ( cs[ "Name1" ] is Image i )
    ///     i.DataContext = hoge;
    ///   if ( cs[ "Name2" ] is ComboBox c )
    ///     c.DataContext = fuga;
    ///   if ( cs[ "Name3" ] is TextBlock t )
    ///     Console.WriteLine( t.Text );
    /// }
    /// </code>
    /// </example>
    /// <param name="c">引っ張り出し元</param>
    /// <param name="names">引っ張り出し元の各アイテムごとに引っ張り出したいコントロールの名前群</param>
    /// <returns>&lt;&lt;Key=名前, Value=引っ張り出されたコントロールまたは null&gt;の辞書&gt;の列挙</returns>
    static public
    IEnumerable<IDictionary<string, object>>
    FindChildren
    ( this ItemsControl c
    , params string[] names
    )
    {
      return
      ( from index
        in Enumerable.Range( 0, c.Items.Count )
        select FindChildren( c, index, names )
      );
    }

    /// <summary>
    /// <see cref="FindChildrenAs{T}(ItemsControl, int, string[])"/> のさらにずぼら横着進化した版
    /// control の全てのアイテムごとに、一度に複数の名前を与えて対応する複数の object を引っ張り出せる。
    /// </summary>
    /// <remarks>
    /// 取り出したいアイテムが全て同じ型の場合に便利。
    /// そうでない場合は <see cref="FindChildren(ItemsControl, string[])"/> を使うと良い。
    /// </remarks>
    /// <example>
    /// <code>
    /// var tss = control.FindChildrenAs&lt;TextBlock>( "Name1", "Name2", "Name3" );
    /// var result = 
    ///   string.Join
    ///   ( "\n"
    ///   , from ts
    ///     in tss
    ///     select
    ///       string.Join
    ///       ( ", "
    ///       , from c
    ///         in cs
    ///         select ${c.Name}.Text={c.Text}
    ///       )
    ///   );
    /// Console.Write( result );
    /// </code>
    /// </example>
    /// <typeparam name="T">引っ張り出したい型</typeparam>
    /// <param name="c">引っ張り出し元</param>
    /// <param name="names">引っ張り出し元の各アイテムごとに引っ張り出したいコントロールの名前群</param>
    /// <returns>&lt;&lt;Key=名前, Value=引っ張り出されたコントロールまたは null&gt;の辞書&gt;の列挙</returns>
    static public
    IEnumerable<IDictionary<string, T>>
    FindChildrenAs<T>
    ( this ItemsControl c
    , params string[] names
    )
      where T : class
    {
      return
      ( from index
        in Enumerable.Range( 0, c.Items.Count )
        select FindChildrenAs<T>( c, index, names )
      );
    }
  }
}
