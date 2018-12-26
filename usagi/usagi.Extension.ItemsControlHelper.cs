using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Windows;

namespace usagi.Extension
{
  /// <summary>
  /// System.Windows.Control.ItemsControlHelper に対する機能拡張
  /// </summary>
  static public partial class ItemsControlHelper
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

// Deprecated=1.2.0, Obsoleted>1.2.0 予定
#if true
namespace usagi.Extension
{
  /// <summary>
  /// System.Windows.Control.ItemsControlHelper に対する機能拡張
  /// </summary>
  static public partial class ItemsControlHelper
  {

    /// <summary>
    /// ContentPresenter から name のコントロールを T 型で引っ張り出す
    /// </summary>
    /// <typeparam name="T">引っ張り出したいコントロールの型</typeparam>
    /// <param name="presenter">引っ張り出し元</param>
    /// <param name="name">引っ張り出したいコントロールの名前</param>
    /// <returns>引っ張り出された T 型のコントロールまたは null</returns>
    [Obsolete
      ( "Deprecated=1.2.0, Obsolete>1.2.0 削除予定。" +
        "FindChildAs で代用可能。" +
        "このメソッドは where T: Control だが意図としては FrameworkElement が正しく、" +
        "また実際にはその継承関係に無い object も Presenter から取得可能なため、" +
        "このメソッドは不要かつ危険性も高いと考え削除予定に至る。"
      )
    ]
    static public
    T
    FindControlAs<T>
    ( this ContentPresenter presenter, string name )
      where T : Control
    {
      return
        presenter
        .ContentTemplate
        .FindName( name, presenter )
        as T
        ;
    }

    /// <summary>
    /// ContentPresenter から name のコントロールを Control 型で引っ張り出す
    /// 必要に応じて結果を as って使いたい場合にどうぞ。
    /// </summary>
    /// <param name="presenter">引っ張り出し元</param>
    /// <param name="name">引っ張り出したいコントロールの名前</param>
    /// <returns>引っ張り出されたコントロールまたは null</returns>
    [Obsolete
      ( "Deprecated=1.2.0, Obsolete>1.2.0 削除予定。" +
        "FindChildAs<Control> で代用可能。" +
        "但し Control ではなく FrameworkElement を使うべきではないか留意すると良い。"
      )
    ]
    static public
    Control
    FindControl
    ( this ContentPresenter presenter, string name )
    { return FindControlAs<Control>( presenter, name ); }

    /// <summary>
    /// GetContentPresenter + FindControlAs の合体技
    /// <para/>control の index 番目のアイテムから名前が name のコントロールを T 型で引っ張り出す
    /// </summary>
    /// <example>
    /// <code>
    /// if ( control.FindControlAs&lt;TextBlock&gt;( 0, "Name1" ) is TextBlock c )
    ///   Console.WriteLine( c.Text );
    /// </code>
    /// </example>
    /// <typeparam name="T">引っ張り出したいコントロールの型</typeparam>
    /// <param name="control">引っ張り出し元</param>
    /// <param name="index">名前が name のコントロールを引っ張り出したい control のアイテムのインデックス</param>
    /// <param name="name">引っ張り出したいアイテムの名前</param>
    /// <returns>引っ張り出されたコントロールまたは null</returns>
    [Obsolete
      ( "Deprecated=1.2.0, Obsolete>1.2.0 削除予定。" +
        "FindChildren で代用可能。" +
        "このメソッドは where T: Control だが意図としては FrameworkElement が正しく、" +
        "また実際にはその継承関係に無い object も Presenter から取得可能なため、" +
        "このメソッドは不要かつ危険性も高いと考え削除予定に至る。"
      )
    ]
    static public
    T
    FindControlAs<T>
    ( this ItemsControl control, int index, string name )
      where T : Control
    {
      if ( GetContentPresenter( control, index ) is ContentPresenter p )
        return FindControlAs<T>( p, name );
      return null;
    }

    /// <summary>
    /// GetContentPresenter + FindControl の合体技
    /// <para/>control の index 番目のアイテムから名前が name のコントロールを Control 型で引っ張り出す
    /// </summary>
    /// <example>
    /// <code>
    /// if ( control.FindControl( 0, "Name1" ) is Control c )
    /// {
    ///   Console.WriteLine( c.IsTabStop );
    ///   if ( c is TextBlock cc )
    ///     ConsoleWriteLine( cc.Text );
    /// }
    /// </code>
    /// </example>
    /// <param name="control">引っ張り出し元</param>
    /// <param name="index">名前が name のコントロールを引っ張り出したい control のアイテムのインデックス</param>
    /// <param name="name">引っ張り出したいアイテムの名前</param>
    /// <returns>引っ張り出されたコントロールまたは null</returns>
    [Obsolete
      ( "Deprecated=1.2.0, Obsolete>1.2.0 削除予定。" +
        "FindChildAs<Control> で代用可能。" +
        "但し Control ではなく FrameworkElement を使うべきではないか留意すると良い。"
      )
    ]
    static public
    Control
    FindControl
    ( this ItemsControl control, int index, string name )
    { return FindControl( control, index, name ); }

    /// <summary>
    /// GetContentPresenter + FindControlAs の合体技 FindControlAs の進化版
    /// <para/>一度に複数の名前を与えて対応する複数のコントロールを引っ張り出せる。
    /// </summary>
    /// <example>
    /// <code>
    /// var cs = control.FindControlsAs&lt;TextBlock>( 0, "Name1", "Name2", "Name3" );
    /// cs[ "Name1" ].DataContext = hoge;
    /// cs[ "Name2" ].DataContext = fuga;
    /// Console.WriteLine( cs[ "Name3" ].Text );
    /// </code>
    /// </example>
    /// <typeparam name="T">引っ張り出したいコントロールの型</typeparam>
    /// <param name="control">引っ張り出し元</param>
    /// <param name="index">名前が name のコントロールを引っ張り出したい control のアイテムのインデックス</param>
    /// <param name="names">引っ張り出したいアイテムの名前群</param>
    /// <returns>{Key=名前, Value=引っ張り出されたコントロールまたは null}の辞書</returns>
    [Obsolete
      ( "Deprecated=1.2.0, Obsolete>1.2.0 削除予定。" +
        "FindChildrenAs<T> で代用可能。" +
        "このメソッドは where T: Control だが意図としては FrameworkElement が正しく、" +
        "また実際にはその継承関係に無い object も Presenter から取得可能なため、" +
        "このメソッドは不要かつ危険性も高いと考え削除予定に至る。"
      )
    ]
    static public
    IDictionary<string, T>
    FindControlsAs<T>
    ( this ItemsControl control, int index, params string[] names )
      where T : Control
    {
      if ( GetContentPresenter( control, index ) is ContentPresenter p )
      {
        return
          ( from name
            in names
            select FindControlAs<T>( p, name )
          ).ToDictionary( c => c.Name );
      }
      return new Dictionary<string, T>();
    }

    /// <summary>
    /// GetContentPresenter + FindControl の合体技 FindControls の進化版
    /// <para/>一度に複数の名前を与えて対応する複数のコントロールを引っ張り出せる。
    /// </summary>
    /// <example>
    /// <code>
    /// var cs = control.FindControls( 0, "Name1", "Name2", "Name3" );
    /// if ( cs[ "Name1" ] is Image c )
    ///   c.DataContext = hoge;
    /// if ( cs[ "Name2" ] is ComboBox c )
    ///   c.DataContext = fuga;
    /// if ( cs[ "Name3" ] is TextBlock )
    ///   Console.WriteLine( c.Text );
    /// </code>
    /// </example>
    /// <param name="control">引っ張り出し元</param>
    /// <param name="index">名前が name のコントロールを引っ張り出したい control のアイテムのインデックス</param>
    /// <param name="names">引っ張り出したいアイテムの名前群</param>
    /// <returns>{Key=名前, Value=引っ張り出されたコントロールまたは null}の辞書</returns>
    [Obsolete
      ( "Deprecated=1.2.0, Obsolete>1.2.0 削除予定。" +
        "FindChildren で代用可能。" +
        "このメソッドは where T: Control だが意図としては FrameworkElement が正しく、" +
        "また実際にはその継承関係に無い object も Presenter から取得可能なため、" +
        "このメソッドは不要かつ危険性も高いと考え削除予定に至る。"
      )
    ]
    static public
    IDictionary<string, Control>
    FindControls
    ( this ItemsControl control, int index, params string[] names )
    { return FindControls( control, index, names ); }

    /// <summary>
    /// FindControls のさらにずぼら横着進化した版
    /// control の全てのアイテムごとに、一度に複数の名前を与えて対応する複数のコントロールを引っ張り出せる。
    /// </summary>
    /// <example>
    /// <code>
    /// var css = control.FindControls( "Name1", "Name2", "Name3" );
    /// foreach ( var cs in css )
    /// {
    ///   cs[ "Name1" ].DataContext = hoge;
    ///   cs[ "Name2" ].DataContext = fuga;
    ///   if ( cs[ "Name3" ] is TextBlock c )
    ///     Console.WriteLine( c.Text );
    /// }
    /// </code>
    /// </example>
    /// <param name="control">引っ張り出し元</param>
    /// <param name="names">引っ張り出し元の各アイテムごとに引っ張り出したいコントロールの名前群</param>
    /// <returns>&lt;&lt;Key=名前, Value=引っ張り出されたコントロールまたは null&gt;の辞書&gt;の列挙</returns>
    [Obsolete
      ( "Deprecated=1.2.0, Obsolete>1.2.0 削除予定。" +
        "FindChildrenAs<Control> で代用可能。" +
        "但し Control ではなく FrameworkElement を使うべきではないか留意すると良い。"
      )
    ]
    static public
    IEnumerable<IDictionary<string, Control>>
    FindControls
    ( this ItemsControl control
    , params string[] names
    )
    {
      return
      ( from index
        in Enumerable.Range( 0, control.Items.Count )
        select FindControlsAs<Control>( control, index, names )
      );
    }
  }
}
#endif
