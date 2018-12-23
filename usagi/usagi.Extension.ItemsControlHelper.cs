using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;

namespace usagi.Extension
{
  /// <summary>
  /// System.Windows.Control.ItemsControlHelper に対する機能拡張
  /// </summary>
  static public class ItemsControlHelper
  {
    /// <summary>
    /// ItemsControl から index 番目のアイテムの ContentPresenter を引っ張り出す
    /// </summary>
    /// <param name="control">引っ張り出し元</param>
    /// <param name="index">ContentPresenter を引っ張り出したいアイテムのインデックス</param>
    /// <returns>引っ張り出された ContentPresenter または null</returns>
    static public
    ContentPresenter
    GetContentPresenter
    ( this ItemsControl control, int index )
    {
      return
        control
        .ItemContainerGenerator
        .ContainerFromIndex( index )
        as ContentPresenter
        ;
    }

    /// <summary>
    /// ContentPresenter から name のコントロールを T 型で引っ張り出す
    /// </summary>
    /// <typeparam name="T">引っ張り出したいコントロールの型</typeparam>
    /// <param name="presenter">引っ張り出し元</param>
    /// <param name="name">引っ張り出したいコントロールの名前</param>
    /// <returns>引っ張り出された T 型のコントロールまたは null</returns>
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
