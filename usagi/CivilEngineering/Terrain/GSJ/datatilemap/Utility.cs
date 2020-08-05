using System;
using System.Linq;
using System.Net;
using System.Drawing;

namespace usagi.CivilEngineering.Terrain.GSJ.datatilemap
{
  /// <summary>
  /// 国立研究開発法人 産業技術総合研究所 地質情報研究部門 の 西岡芳晴 と 長津樹理 らによる
  /// 「データタイルマップを用いたシームレス標高サービスの公開」 情報地質 第27巻 第2号 110-111頁 2016年 
  /// に基づくデータタイルマップ方式の処理機能群を提供するユーティリティー
  /// </summary>
  /// <remarks>仕様バージョン 2.1 ( 2019-04-03 ) に準拠</remarks>
  /// <seealso href="http://www.jsgi-map.org/geoinforum2016/28.pdf"/>
  /// <seealso href="https://www.jstage.jst.go.jp/article/geoinformatics/26/4/26_155/_pdf"/>
  /// <seealso href="http://gsj-seamless.jp/labs/datatilemap/"/>
  public static class Utility
  {
    /// <summary>
    /// URI からデータを取得する
    /// 「PNG Data Tile」仕様に基づくが、
    /// "Data" はつまるところただのRGBAピクセルフォーマットの Bitmap であり、
    /// セマンティクスに基づくデコード処理は呼び出し元で行う必要がある。
    /// </summary>
    /// <param name="uri">データソースURI</param>
    /// <returns>RGBAピクセルフォーマットの Bitmap または null ( 404 などの「無効値」群相当として)</returns>
    static public Bitmap LoadPNGDataTile( Uri uri )
    {
      try
      {
        using ( var c = new WebClient() )
        using ( var s = c.OpenRead( uri ) )
          return new Bitmap( s );
      }
      catch( WebException )
      { return null; }
    }

    /// <summary>
    /// PNG Number Tile （符号なし）として Bitmap 化する
    /// </summary>
    /// <param name="data">元データ</param>
    /// <param name="f">係数 f</param>
    /// <param name="o">オフセット o </param>
    /// <param name="invalid_value">非標準の無効値を使いたい場合はその値を指定する。 null なら Color.Transparent</param>
    /// <returns></returns>
    static public Bitmap SavePNGNumberTileU( double[,] data, double f = 1, double o = 0, Color? invalid_value = null )
    {
      if ( data == null )
        return null;

      invalid_value = invalid_value ?? Color.Transparent;

      using ( var r = new Bitmap( data.GetLength( 0 ), data.GetLength( 1 ) ) )
      {
        for ( var y = 0; y < r.Height; ++y )
          for ( var x = 0; x < r.Width; ++x )
          {
            var c = EncodeNumberPixelU( data[ x, y ], f, o, invalid_value );
            r.SetPixel( x, y, c );
          }
        return r;
      }
    }

    /// <summary>
    /// PNG Number Tile （符号付き）として Bitmap 化する
    /// </summary>
    /// <param name="data">元データ</param>
    /// <param name="f">係数 f</param>
    /// <param name="o">オフセット o </param>
    /// <param name="invalid_value">非標準の無効値を使いたい場合はその値を指定する。 null なら Color.Transparent</param>
    /// <returns></returns>
    static public Bitmap SavePNGNumberTileS( double[,] data, double f = 1, double o = 0, Color? invalid_value = null )
    {
      if ( data == null )
        return null;

      invalid_value = invalid_value ?? Color.Transparent;

      //using ( 
      var r = new Bitmap( data.GetLength( 0 ), data.GetLength( 1 ) );
        //)
      //{
        for ( var y = 0; y < r.Height; ++y )
          for ( var x = 0; x < r.Width; ++x )
          {
            var c = EncodeNumberPixelS( data[ x, y ], f, o, invalid_value );
            r.SetPixel( x, y, c );
          }
        return r;
//      }
    }

    /// <summary>
    /// URI からデータを取得し、
    /// 「PNG Number Tile」仕様に基づき数値を「符号なし」モードでデコード
    /// </summary>
    /// <param name="has_invalid_value">無効値を含む場合は true を出力</param>
    /// <param name="uri">データソースURI</param>
    /// <param name="f">係数 f</param>
    /// <param name="o">オフセット o</param>
    /// <param name="additional_invalid_values">追加の無効値</param>
    /// <returns>デコードされた数値群または null ( 全域が無効値 )</returns>
    static public double[,] LoadPNGNumberTileU( out bool has_invalid_value, Uri uri, double f = 1, double o = 0, params Color[] additional_invalid_values )
    {
      var i = LoadPNGDataTile( uri );
      return LoadPNGNumberTileU( out has_invalid_value, i, f, o, additional_invalid_values );
    }

    /// <summary>
    /// URI からデータを取得し、
    /// 「PNG Number Tile」仕様に基づき数値を「符号なし」モードでデコード
    /// </summary>
    /// <param name="has_invalid_value">無効値を含む場合は true を出力</param>
    /// <param name="source">データソースBitmap</param>
    /// <param name="f">係数 f</param>
    /// <param name="o">オフセット o</param>
    /// <param name="additional_invalid_values">追加の無効値</param>
    /// <returns>デコードされた数値群または null ( 全域が無効値 )</returns>
    static public double[,] LoadPNGNumberTileU( out bool has_invalid_value, Bitmap source, double f = 1, double o = 0, params Color[] additional_invalid_values )
    {
      if ( source == null )
      {
        has_invalid_value = true;
        return null;
      }

      var r = new double[ source.Width, source.Height ];

      // 思案: i.LockBits して高速化しようかな、どうしようかな。
      // GetPixel がポインターイテレーションになっても Color を経由したら残念だから
      // やるならその辺も変えなきゃならない。

      has_invalid_value = false;

      for ( var y = 0; y < source.Height; ++y )
        for ( var x = 0; x < source.Width; ++x )
        {
          r[ x, y ] = DecodeNumberPixelU( source.GetPixel( x, y ), f, o, additional_invalid_values );
          if ( double.IsNaN( r[ x, y ] ) )
            has_invalid_value = true;
        }

      return r;
    }

    /// <summary>
    /// URI からデータを取得し、
    /// 「PNG Number Tile」仕様に基づき数値を「符号なし」モードでデコード
    /// 無効値を含む既存の数値群に対して補完を行う
    /// </summary>
    /// <param name="destination">無効値を含む既存の数値群</param>
    /// <param name="has_invalid_value">無効値を含む場合は true を出力</param>
    /// <param name="uri">データソースURI</param>
    /// <param name="f">係数 f</param>
    /// <param name="o">オフセット o</param>
    /// <param name="additional_invalid_values">追加の無効値</param>
    static public void LoadPNGNumberTileU( ref double[,] destination, out bool has_invalid_value, Uri uri, double f = 1, double o = 0, params Color[] additional_invalid_values )
    {
      var i = LoadPNGDataTile( uri );

      if ( i == null )
      {
        has_invalid_value = true;
        return;
      }

      has_invalid_value = false;

      for ( var y = 0; y < i.Height; ++y )
        for ( var x = 0; x < i.Width; ++x )
          if ( double.IsNaN( destination[ x, y ] ) )
          {
            destination[ x, y ] = DecodeNumberPixelU( i.GetPixel( x, y ), f, o, additional_invalid_values );
            if ( double.IsNaN( destination[ x, y ] ) )
              has_invalid_value = true;
          }
    }

    /// <summary>
    /// URI からデータを取得し、
    /// 「PNG Number Tile」仕様に基づき数値を「符号付き」モードでデコード
    /// </summary>
    /// <param name="has_invalid_value">無効値を含む場合は true を出力</param>
    /// <param name="uri">データソースURI</param>
    /// <param name="f">係数 f</param>
    /// <param name="o">オフセット o</param>
    /// <param name="additional_invalid_values">追加の無効値</param>
    /// <returns>デコードされた数値群または null ( 全域が無効値 )</returns>
    static public double[,] LoadPNGNumberTileS( out bool has_invalid_value, Uri uri, double f = 1, double o = 0, params Color[] additional_invalid_values )
    {
      var i = LoadPNGDataTile( uri );
      return LoadPNGNumberTileS( out has_invalid_value, i, f, o, additional_invalid_values );
    }

    /// <summary>
    /// URI からデータを取得し、
    /// 「PNG Number Tile」仕様に基づき数値を「符号付き」モードでデコード
    /// </summary>
    /// <param name="has_invalid_value">無効値を含む場合は true を出力</param>
    /// <param name="source">データソースBitmap</param>
    /// <param name="f">係数 f</param>
    /// <param name="o">オフセット o</param>
    /// <param name="additional_invalid_values">追加の無効値</param>
    /// <returns>デコードされた数値群または null ( 全域が無効値 )</returns>
    static public double[,] LoadPNGNumberTileS( out bool has_invalid_value, Bitmap source, double f = 1, double o = 0, params Color[] additional_invalid_values )
    {
      if ( source == null )
      {
        has_invalid_value = true;
        return null;
      }

      var r = new double[ source.Width, source.Height ];

      has_invalid_value = false;

      for ( var y = 0; y < source.Height; ++y )
        for ( var x = 0; x < source.Width; ++x )
        {
          r[ x, y ] = DecodeNumberPixelS( source.GetPixel( x, y ), f, o, additional_invalid_values );
          if ( double.IsNaN( r[ x, y ] ) )
            has_invalid_value = true;
        }

      return r;
    }

    /// <summary>
    /// URI からデータを取得し、
    /// 「PNG Number Tile」仕様に基づき数値を「符号付き」モードでデコードし、
    /// 無効値を含む既存の数値群に対して補完を行う
    /// </summary>
    /// <param name="destination">無効値を含む補完先</param>
    /// <param name="has_invalid_value">無効値を含む場合またはソース全域が無効値な場合は true を出力</param>
    /// <param name="uri">データソースURI</param>
    /// <param name="f">係数 f</param>
    /// <param name="o">オフセット o</param>
    /// <param name="additional_invalid_values">追加の無効値</param>
    static public void LoadPNGNumberTileS( ref double[,] destination, out bool has_invalid_value, Uri uri, double f = 1, double o = 0, params Color[] additional_invalid_values )
    {
      var i = LoadPNGDataTile( uri );

      if ( i == null )
      {
        has_invalid_value = true;
        return;
      }

      has_invalid_value = false;

      for ( var y = 0; y < i.Height; ++y )
        for ( var x = 0; x < i.Width; ++x )
          if ( double.IsNaN( destination[ x, y ] ) )
          {
            destination[ x, y ] = DecodeNumberPixelS( i.GetPixel( x, y ), f, o, additional_invalid_values );
            if ( double.IsNaN( destination[ x, y ] ) )
              has_invalid_value = true;
          }
    }

    /// <summary>
    /// Bitmap からデータを取得し、
    /// 「PNG Number Tile」仕様に基づき数値を「符号なし」モードでデコードし、
    /// 無効値を含む既存の数値群に対して補完を行う
    /// </summary>
    /// <param name="destination">無効値を含む補完先</param>
    /// <param name="has_invalid_value">無効値を含む場合またはソース全域が無効値な場合は true を出力</param>
    /// <param name="source">データソースBitmap</param>
    /// <param name="f">係数 f</param>
    /// <param name="o">オフセット o</param>
    /// <param name="additional_invalid_values">追加の無効値</param>
    static public void LoadPNGNumberTileU( ref double[,] destination, out bool has_invalid_value, Bitmap source, double f = 1, double o = 0, params Color[] additional_invalid_values )
    {
      if ( source == null )
      {
        has_invalid_value = true;
        return;
      }

      has_invalid_value = false;

      for ( var y = 0; y < source.Height; ++y )
        for ( var x = 0; x < source.Width; ++x )
          if ( double.IsNaN( destination[ x, y ] ) )
          {
            destination[ x, y ] = DecodeNumberPixelU( source.GetPixel( x, y ), f, o, additional_invalid_values );
            if ( double.IsNaN( destination[ x, y ] ) )
              has_invalid_value = true;
          }
    }

    /// <summary>
    /// Bitmap からデータを取得し、
    /// 「PNG Number Tile」仕様に基づき数値を「符号付き」モードでデコードし、
    /// 無効値を含む既存の数値群に対して補完を行う
    /// </summary>
    /// <param name="destination">無効値を含む補完先</param>
    /// <param name="has_invalid_value">無効値を含む場合またはソース全域が無効値な場合は true を出力</param>
    /// <param name="source">データソースBitmap</param>
    /// <param name="f">係数 f</param>
    /// <param name="o">オフセット o</param>
    /// <param name="additional_invalid_values">追加の無効値</param>
    static public void LoadPNGNumberTileS( ref double[,] destination, out bool has_invalid_value, Bitmap source, double f = 1, double o = 0, params Color[] additional_invalid_values )
    {
      if ( source == null )
      {
        has_invalid_value = true;
        return;
      }

      has_invalid_value = false;

      for ( var y = 0; y < source.Height; ++y )
        for ( var x = 0; x < source.Width; ++x )
          if ( double.IsNaN( destination[ x, y ] ) )
          {
            destination[ x, y ] = DecodeNumberPixelS( source.GetPixel( x, y ), f, o, additional_invalid_values );
            if ( double.IsNaN( destination[ x, y ] ) )
              has_invalid_value = true;
          }
    }

    /// <summary>
    /// URI からデータを取得し、
    /// 「PNG Palette Tile」仕様に基づき「ピクセル値」群をデコード
    /// </summary>
    /// <remarks>
    /// 用語「ピクセル値」は一般的な意味でのピクセルの値ではなく、
    /// 一般的な意味でのピクセルの値を PNG Palette Tile 仕様に基づいて
    /// デコードして取り出された値の事を意味する点に注意する。
    /// また、 PNG Palette Tile は PNG Data Tile の一種なので無効値が Alpha 値により発生する事にも注意する。
    /// </remarks>
    /// <param name="has_invalid_value">無効値を含む場合は true を出力</param>
    /// <param name="uri">データソースURI</param>
    /// <returns>デコードされた「ピクセル値」群または null ( 全域が無効値 )</returns>
    static public UInt32?[,] LoadPNGPaletteTile( out bool has_invalid_value, Uri uri )
    {
      var i = LoadPNGDataTile( uri );

      if (  i == null )
      {
        has_invalid_value = true;
        return null;
      }

      var r = new UInt32?[ i.Width, i.Height ];

      has_invalid_value = false;

      for ( var y = 0; y < i.Height; ++y )
        for ( var x = 0; x < i.Width; ++x )
        {
          r[ x, y ] = DecodePalettePixel( i.GetPixel( x, y ) );
          if ( !r[ x, y ].HasValue )
            has_invalid_value = true;
        }

      return r;
    }

    /// <summary>
    /// 「PNG Number Tile」仕様に基づき数値を「符号なし」モードでデコード
    /// </summary>
    /// <remarks>
    /// 符号の有無によりメソッド名のサフィックスに U と S の2つのバージョンがある点に注意。
    /// </remarks>
    /// <param name="pixel">ピクセルの値</param>
    /// <param name="f">係数 f</param>
    /// <param name="o">オフセット o</param>
    /// <param name="additional_invalid_values">追加の無効値群</param>
    /// <returns>デコードされた有効な数値または NaN （無効値）</returns>
    static public double DecodeNumberPixelU( Color pixel, double f = 1, double o = 0, params Color[] additional_invalid_values )
    {
      if ( additional_invalid_values.Contains( pixel ) )
        return double.NaN;

      var iu = DecodePalettePixel( pixel );

      if ( !iu.HasValue )
        return double.NaN;

      return f * iu.Value + o;
    }

    /// <summary>
    /// 「PNG Number Tile」仕様に基づき数値を「符号付き」モードでデコード
    /// </summary>
    /// <remarks>
    /// 符号の有無によりメソッド名のサフィックスに U と S の2つのバージョンがある点に注意。
    /// </remarks>
    /// <param name="pixel">ピクセルの値</param>
    /// <param name="f">係数 f</param>
    /// <param name="o">オフセット o</param>
    /// <param name="additional_invalid_values">追加の無効値群</param>
    /// <returns>デコードされた有効な数値または NaN （無効値）</returns>
    static public double DecodeNumberPixelS( Color pixel, double f = 1, double o = 0, params Color[] additional_invalid_values )
    {
      if ( additional_invalid_values.Contains( pixel ) )
        return double.NaN;

      var iu = DecodePalettePixel( pixel );

      if ( !iu.HasValue )
        return double.NaN;

      const UInt32 critical_value = 1 << 23;
      const UInt32 critical_diff = 1 << 24;
      var s = ( iu.Value < critical_value )
        ? (double)iu.Value
        : ( (double)iu.Value - critical_diff )
        ;

      return f * s + o;
    }

    /// <summary>
    /// 「PNG Palette Tile」仕様に基づき「ピクセル値」を「符号なし」モードでエンコード
    /// </summary>
    /// <remarks>
    /// 無効値が生成される場合は v が NaN の場合または v が想定外の領域または f, o の設計ミスにより中間値が 24-32 bit 域に値を持つ場合の可能性がある。
    /// </remarks>
    /// <param name="v">数値</param>
    /// <param name="f">係数 f</param>
    /// <param name="o">オフセット o</param>
    /// <param name="invalid_value">無効値, null の場合は Color.Transparent</param>
    /// <returns>ピクセルの値</returns>
    static public Color EncodeNumberPixelU( double v, double f = 1, double o = 0, Color? invalid_value = null )
    {
      if ( double.IsNaN( v ) )
        return invalid_value ?? Color.Transparent;

      var iu = ( UInt32 )( ( v - o ) / f );

      return EncodePalattePixel( iu );
    }

    /// <summary>
    /// 「PNG Palette Tile」仕様に基づき「ピクセル値」を「符号付き」モードでエンコード
    /// </summary>
    /// <remarks>
    /// 無効値が生成される場合は v が NaN の場合または v が想定外の領域または f, o の設計ミスにより中間値が 24-32 bit 域に値を持つ場合の可能性がある。
    /// </remarks>
    /// <param name="v">数値</param>
    /// <param name="f">係数 f</param>
    /// <param name="o">オフセット o</param>
    /// <param name="invalid_value">無効値, null の場合は Color.Transparent</param>
    /// <returns>ピクセルの値</returns>
    static public Color EncodeNumberPixelS( double v, double f = 1, double o = 0, Color? invalid_value = null )
    {
      if ( double.IsNaN( v ) )
        return invalid_value ?? Color.Transparent;

      var s = ( Int32 )( ( v - o ) / f );

      const UInt32 critical_diff = 1 << 24;

      var iu = ( s >= 0 )
        ? ( UInt32 )s
        : ( UInt32 )( s + critical_diff )
        ;

      return EncodePalattePixel( iu );
    }

    /// <summary>
    /// 「PNG Palette Tile」仕様に基づき「ピクセル値」をデコード
    /// </summary>
    /// <remarks>
    /// 用語「ピクセル値」は一般的な意味でのピクセルの値ではなく、
    /// 一般的な意味でのピクセルの値を PNG Palette Tile 仕様に基づいて
    /// デコードして取り出された値の事を意味する点に注意する。
    /// また、 PNG Palette Tile は PNG Data Tile の一種なので無効値が Alpha 値により発生する事にも注意する。
    /// </remarks>
    /// <param name="pixel">一般的な意味でのピクセル</param>
    /// <returns>
    /// PNG Palette Tile 仕様で言うところの「ピクセル値」。
    /// 無効値の場合は null
    /// </returns>
    static public UInt32? DecodePalettePixel( Color pixel )
    {
      if ( pixel.A == 0 )
        return null;

      const UInt32 cr = 1 << 16;
      const UInt32 cg = 1 << 8;
      return cr * pixel.R + cg * pixel.G + pixel.B;
    }

    /// <summary>
    /// 「PNG Palette Tile」仕様に基づき「ピクセル値」をエンコード
    /// </summary>
    /// <remarks>
    /// 用語「ピクセル値」は一般的な意味でのピクセルの値ではなく、
    /// 一般的な意味でのピクセルの値を PNG Palette Tile 仕様に基づいて
    /// エンコードして生成される値の事を意味する点に注意する。
    /// 無効値が生成される場合は pv が null の場合または 24-32 bit 域に値を持つ可能性がある。
    /// </remarks>
    /// <param name="pv">「ピクセル値」または null （無効値を生成）</param>
    /// <returns>一般的な意味でのピクセルの値</returns>
    static public Color EncodePalattePixel( UInt32? pv )
    {
      if ( !pv.HasValue || ( pv.Value >> 24 ) != 0 )
        return Color.Transparent;

      var b = ( byte )( pv.Value & 0xFF );
      var g = ( byte )( ( pv.Value >> 8 ) & 0xFF );
      var r = ( byte )( ( pv.Value >> 16 ) & 0xFF );

      return Color.FromArgb( r, g, b );
    }
  }
}
