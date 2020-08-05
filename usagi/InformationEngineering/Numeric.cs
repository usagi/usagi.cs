using System;
using usagi.InformationEngineering.Extension;

namespace usagi.InformationEngineering
{
  /// <summary>
  /// 数値に対する機能を提供
  /// </summary>
  static public class Numeric
  {
    /// <summary>
    /// 値を可能な限り保持した別の型を取得する。
    /// 非負整数と符号付き整数、浮動小数点数と整数など変換したい場合にどうぞ。
    /// </summary>
    /// <remarks>
    /// NaN を整数型へキャストしようとしたり、
    /// キャスト先の型で表現不能な数値をキャストしようとすると
    /// <see cref="System.OverflowException"/> が飛ぶ。
    /// </remarks>
    /// <typeparam name="A">変換元の型</typeparam>
    /// <typeparam name="B">変換先の型</typeparam>
    /// <param name="a">型変換したい値</param>
    /// <returns>型変換された値</returns>
    public static B ConservationCast<A, B>( A a )
      where A : IConvertible
      where B : IConvertible
      => (B)Convert.ChangeType( a, typeof( B ) );

    /// <summary>
    /// 元の型の定義域内に必ず収まるクランプ付きの加算
    /// </summary>
    /// <param name="a">元の値</param>
    /// <param name="b">足す値</param>
    /// <returns>加算結果</returns>
    public static byte ClampAdd( this byte a, byte b ) => ( a + b ).ClampToByte();
    /// <summary>
    /// 元の型の定義域内に必ず収まるクランプ付きの加算
    /// </summary>
    /// <param name="a">元の値</param>
    /// <param name="b">足す値</param>
    /// <returns>加算結果</returns>
    public static sbyte ClampAdd( this sbyte a, sbyte b ) => ( a + b ).ClampToSByte();
    /// <summary>
    /// 元の型の定義域内に必ず収まるクランプ付きの加算
    /// </summary>
    /// <param name="a">元の値</param>
    /// <param name="b">足す値</param>
    /// <returns>加算結果</returns>
    public static UInt16 ClampAdd( this UInt16 a, UInt16 b ) => ( a + b ).ClampToUInt16();
    /// <summary>
    /// 元の型の定義域内に必ず収まるクランプ付きの加算
    /// </summary>
    /// <param name="a">元の値</param>
    /// <param name="b">足す値</param>
    /// <returns>加算結果</returns>
    public static Int16 ClampAdd( this Int16 a, Int16 b ) => ( a + b ).ClampToInt16();
    /// <summary>
    /// 元の型の定義域内に必ず収まるクランプ付きの加算
    /// </summary>
    /// <param name="a">元の値</param>
    /// <param name="b">足す値</param>
    /// <returns>加算結果</returns>
    public static UInt32 ClampAdd( this UInt32 a, UInt32 b ) => a - Math.Min( UInt32.MaxValue - a, b );
    /// <summary>
    /// 元の型の定義域内に必ず収まるクランプ付きの加算
    /// </summary>
    /// <param name="a">元の値</param>
    /// <param name="b">足す値</param>
    /// <returns>加算結果</returns>
    public static Int32 ClampAdd( this Int32 a, Int32 b ) => a - Math.Min( Int32.MaxValue - a, b );
    /// <summary>
    /// 元の型の定義域内に必ず収まるクランプ付きの加算
    /// </summary>
    /// <param name="a">元の値</param>
    /// <param name="b">足す値</param>
    /// <returns>加算結果</returns>
    public static UInt64 ClampAdd( this UInt64 a, UInt64 b ) => a - Math.Min( UInt64.MaxValue - a, b );
    /// <summary>
    /// 元の型の定義域内に必ず収まるクランプ付きの加算
    /// </summary>
    /// <param name="a">元の値</param>
    /// <param name="b">足す値</param>
    /// <returns>加算結果</returns>
    public static Int64 ClampAdd( this Int64 a, Int64 b ) => a - Math.Min( Int64.MaxValue - a, b );

    /// <summary>
    /// 元の値 + 1 を安全に返すメソッド。
    /// インクリメントが正常に行えない場合は
    /// <see cref="OverflowException"/> を飛ばす
    /// </summary>
    /// <param name="a">元の値</param>
    /// <returns>元の値 + 1</returns>
    public static byte SafeIncrement( this byte a )
    {
      if ( a == byte.MaxValue )
        throw new OverflowException( a );
      return (byte)(a + 1);
    }

    /// <summary>
    /// 元の値 + 1 を安全に返すメソッド。
    /// インクリメントが正常に行えない場合は
    /// <see cref="OverflowException"/> を飛ばす
    /// </summary>
    /// <param name="a">元の値</param>
    /// <returns>元の値 + 1</returns>
    public static sbyte SafeIncrement( this sbyte a )
    {
      if ( a == sbyte.MaxValue )
        throw new OverflowException( a );
      return (sbyte)( a + 1 );
    }

    /// <summary>
    /// 元の値 + 1 を安全に返すメソッド。
    /// インクリメントが正常に行えない場合は
    /// <see cref="OverflowException"/> を飛ばす
    /// </summary>
    /// <param name="a">元の値</param>
    /// <returns>元の値 + 1</returns>
    public static UInt16 SafeIncrement( this UInt16 a )
    {
      if ( a == UInt16.MaxValue )
        throw new OverflowException( a );
      return (UInt16)( a + 1 );
    }

    /// <summary>
    /// 元の値 + 1 を安全に返すメソッド。
    /// インクリメントが正常に行えない場合は
    /// <see cref="OverflowException"/> を飛ばす
    /// </summary>
    /// <param name="a">元の値</param>
    /// <returns>元の値 + 1</returns>
    public static Int16 SafeIncrement( this Int16 a )
    {
      if ( a == Int16.MaxValue )
        throw new OverflowException( a );
      return (Int16)( a + 1 );
    }

    /// <summary>
    /// 元の値 + 1 を安全に返すメソッド。
    /// インクリメントが正常に行えない場合は
    /// <see cref="OverflowException"/> を飛ばす
    /// </summary>
    /// <param name="a">元の値</param>
    /// <returns>元の値 + 1</returns>
    public static UInt32 SafeIncrement( this UInt32 a )
    {
      if ( a == UInt32.MaxValue )
        throw new OverflowException( a );
      return  a + 1U;
    }

    /// <summary>
    /// 元の値 + 1 を安全に返すメソッド。
    /// インクリメントが正常に行えない場合は
    /// <see cref="OverflowException"/> を飛ばす
    /// </summary>
    /// <param name="a">元の値</param>
    /// <returns>元の値 + 1</returns>
    public static Int32 SafeIncrement( this Int32 a )
    {
      if ( a == Int32.MaxValue )
        throw new OverflowException( a );
      return a + 1;
    }

    /// <summary>
    /// 元の値 + 1 を安全に返すメソッド。
    /// インクリメントが正常に行えない場合は
    /// <see cref="OverflowException"/> を飛ばす
    /// </summary>
    /// <param name="a">元の値</param>
    /// <returns>元の値 + 1</returns>
    public static UInt64 SafeIncrement( this UInt64 a )
    {
      if ( a == UInt64.MaxValue )
        throw new OverflowException( a );
      return a + 1UL;
    }

    /// <summary>
    /// 元の値 + 1 を安全に返すメソッド。
    /// インクリメントが正常に行えない場合は
    /// <see cref="OverflowException"/> を飛ばす
    /// </summary>
    /// <param name="a">元の値</param>
    /// <returns>元の値 + 1</returns>
    public static Int64 SafeIncrement( this Int64 a )
    {
      if ( a == Int64.MaxValue )
        throw new OverflowException( a );
      return a + 1L;
    }

    /// <summary>
    /// 元の値 + 1 を安全に返すメソッド。
    /// インクリメントが正常に行えない場合は
    /// <see cref="OverflowException"/> を飛ばす
    /// </summary>
    /// <param name="a">元の値</param>
    /// <returns>元の値 + 1</returns>
    public static decimal SafeIncrement( decimal a )
    {
      var b = a + 1m;
      if ( b - a != 1m )
        throw new PrecisionException( a );
      return b;
    }

    /// <summary>
    /// 元の値 + 1 を安全に返すメソッド。
    /// インクリメントが正常に行えない場合は
    /// <see cref="OverflowException"/> を飛ばす
    /// </summary>
    /// <param name="a">元の値</param>
    /// <returns>元の値 + 1</returns>
    public static double SafeIncrement( double a )
    {
      var b = a + 1d;
      if ( b - a != 1d )
        throw new PrecisionException( a );
      return b;
    }

    /// <summary>
    /// 元の値 + 1 を安全に返すメソッド。
    /// インクリメントが正常に行えない場合は
    /// <see cref="OverflowException"/> を飛ばす
    /// </summary>
    /// <param name="a">元の値</param>
    /// <returns>元の値 + 1</returns>
    public static float SafeIncrement( float a )
    {
      var b = a + 1f;
      if ( b - a != 1f )
        throw new PrecisionException( a );
      return b;
    }

    /// <summary>
    /// <see cref="usagi.InformationEngineering"/> 名前空間の
    /// <see cref="Numeric"/> または <see cref="NumericExtension"/> 系
    /// から発せられる例外である事を示すタグ・インターフェース
    /// </summary>
    public interface INumericException { }


    /// <summary>
    /// オーバーフローが発生する際に飛ばされる例外
    /// </summary>
    /// <remarks>
    /// <see cref="UnderflowException"/> とはトモダチ。
    /// <para/>
    /// <see cref="UnderflowException"/> と等価な作り、名前空間、共通の基底型を持つと扱い易いので
    /// それを作る手前、オーバーフローについても <see cref="System.OverflowException"/> も継承しつつ
    /// <see cref="UnderflowException"/> と対になるよう追加した。
    /// </remarks>
    public class OverflowException: System.OverflowException, INumericException
    {
      /// <summary>
      /// 発生原因の値についてメッセージを生成するコンストラクター
      /// </summary>
      /// <param name="a">発生原因の値</param>
      public OverflowException( object a )
        : base( $"op1<{a.GetType().FullName}>={a};" )
      { }
      /// <summary>
      /// 二項演算等で発生原因の値が2つある場合に
      /// それらの値からメッセージを生成するコンストラクター
      /// </summary>
      /// <param name="a">発生原因の値その1</param>
      /// <param name="b">発生原因の値その2</param>
      public OverflowException( object a, object b )
        : base( $"op1<{a.GetType().FullName}>={a} op2<{b.GetType().FullName}>={b}" )
      { }
    }

    /// <summary>
    /// アンダーフローが発生する際に飛ばされる例外。
    /// </summary>
    /// <remarks>
    /// <see cref="OverflowException"/> とはトモダチ。
    /// <para/>
    /// <see cref="System.OverflowException"/> はアンダーフローも扱うが、
    /// 例外処理としてアンダーフローかオーバーフローか判断できない不便さがあるから作った。
    /// </remarks>
    public class UnderflowException: System.OverflowException, INumericException
    {
      /// <summary>
      /// 発生原因の値についてメッセージを生成するコンストラクター
      /// </summary>
      /// <param name="a">発生原因の値</param>
      public UnderflowException( object a )
        : base( $"op1<{a.GetType().FullName}>={a};" )
      { }
      /// <summary>
      /// 二項演算等で発生原因の値が2つある場合に
      /// それらの値からメッセージを生成するコンストラクター
      /// </summary>
      /// <param name="a">発生原因の値その1</param>
      /// <param name="b">発生原因の値その2</param>
      public UnderflowException( object a, object b )
        : base( $"op1<{a.GetType().FullName}>={a} op2<{b.GetType().FullName}>={b}" )
      { }
    }

    /// <summary>
    /// 浮動小数点数に要求された計算に精度不足により正確な結果を得られない場合に飛ばされる。
    /// </summary>
    public class PrecisionException: System.Exception, INumericException
    {
      /// <summary>
      /// 発生原因の値についてメッセージを生成するコンストラクター
      /// </summary>
      /// <param name="a">発生原因の値</param>
      public PrecisionException( object a )
        : base( $"op1<{a.GetType().FullName}>={a};" )
      { }

      /// <summary>
      /// 二項演算等で発生原因の値が2つある場合に
      /// それらの値からメッセージを生成するコンストラクター
      /// </summary>
      /// <param name="a">発生原因の値その1</param>
      /// <param name="b">発生原因の値その2</param>
      public PrecisionException( object a, object b )
        : base( $"op1<{a.GetType().FullName}>={a} op2<{b.GetType().FullName}>={b}" )
      { }
    }
  }
}
