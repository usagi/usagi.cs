using System;
using usagi.Quantity;
using usagi.Quantity.Extension;
using usagi.Quantity.GeoLocation;
using usagi.CivilEngineering.Planet;

namespace usagi.CivilEngineering.Extension
{
  /// <summary>
  /// 経緯度型 <see cref="LonLat"/>, 経緯度取得可能インターフェース <see cref="ILonLatGettable"/> 
  /// を拡張する
  /// </summary>
  public static class LonLatDistanceExtension
  {
    /// <summary>
    /// 平面角次元群による経緯度から長さ次元の距離を計算する際に使用するアルゴリズム
    /// </summary>
    public enum LonLatDistanceAlgorithm
    {
      /// <summary>
      /// Haversine 法（半正矢関数の公式）
      /// <list type="bullet">
      /// <item><description>惑星の赤道方向への半径から概算する。</description></item>
      /// <item><description>惑星の楕円体としての扁平率は無視する。</description></item>
      /// <item><description>負荷は軽いが高精度な計算結果を求めたい場合には向かない。</description></item>
      /// </list>
      /// </summary>
      /// <seealso href="https://en.wikipedia.org/wiki/Haversine_formula"/>
      /// <seealso href="https://ja.wikipedia.org/wiki/%E7%90%83%E9%9D%A2%E4%B8%89%E8%A7%92%E6%B3%95#haversine_%E5%8D%8A%E6%AD%A3%E7%9F%A2%E9%96%A2%E6%95%B0"/>
      Haversine
    ,
      /// <summary>
      /// Vincenty 法
      /// <list type="bullet">
      /// <item><description>惑星を楕円体近似した赤道方向への半径、回転軸方向への半径、扁平率を考慮し、十分な計算精度を反復計算により確保する。</description></item>
      /// <item><description>負荷は高いが高精度な計算結果を求めたい場合に向く。</description></item>
      /// </list>
      /// </summary>
      /// <seealso href="https://jsperf.com/vincenty-vs-haversine-distance-calculations"/>
      /// <seealso href="https://en.wikipedia.org/wiki/Vincenty%27s_formulae"/>
      /// <seealso href="https://ja.wikipedia.org/wiki/Vincenty%E6%B3%95"/>
      Vincenty
    }

    /// <summary>
    /// 経緯度の位置 a, b の惑星を楕円体近似した場合の距離が
    /// 許容範囲 tolerance 以下か判定
    /// </summary>
    /// <param name="a">経緯度の位置1つめ</param>
    /// <param name="b">経緯度の位置2つめ</param>
    /// <param name="tolerance">許容範囲</param>
    /// <param name="llda">経緯度の距離を計算するアルゴリズム</param>
    /// <param name="planet">楕円体近似した惑星の形状定義; null の場合は <see cref="GeometricalSpecification.Earth_WGS84"/> が採用されます </param>
    /// <returns>許容範囲以下なら true</returns>
    public static bool NearlyEqualsTo
    ( this ILonLatGettable a
    , ILonLatGettable b
    , Length tolerance = null
    , LonLatDistanceAlgorithm llda = LonLatDistanceAlgorithm.Haversine
    , IGeometricalSpecificationGettable planet = null
    )
    {
      return a.DistanceTo( b, llda, planet ) <= (tolerance?? Length.Meter );
    }

    /// <summary>
    /// 経緯度の位置 a と b の中間の緯度における経度方向の距離を計算する
    /// </summary>
    /// <param name="a">経緯度の位置1つめ</param>
    /// <param name="b">経緯度の位置2つめ</param>
    /// <param name="llda">経緯度の距離を計算するアルゴリズム</param>
    /// <param name="planet">楕円体近似した惑星の形状定義; null の場合は <see cref="GeometricalSpecification.Earth_WGS84"/> が採用されます </param>
    /// <returns>経度方向の距離</returns>
    public static Length LongitudeDistanceTo
    ( this ILonLatGettable a
    , ILonLatGettable b
    , LonLatDistanceAlgorithm llda = LonLatDistanceAlgorithm.Haversine
    , IGeometricalSpecificationGettable planet = null
    )
    {
      var alat = ( a.Latitude + b.Latitude ) / 2.0;
      var aa = new LonLat( a.Longitude, alat );
      var bb = new LonLat( b.Longitude, alat );
      return aa.DistanceTo( bb, llda, planet );
    }

    /// <summary>
    /// 経緯度の位置 a と b の緯度方向の距離を計算する
    /// </summary>
    /// <param name="a">経緯度の位置1つめ</param>
    /// <param name="b">経緯度の位置2つめ</param>
    /// <param name="llda">経緯度の距離を計算するアルゴリズム</param>
    /// <param name="planet">楕円体近似した惑星の形状定義; null の場合は <see cref="GeometricalSpecification.Earth_WGS84"/> が採用されます </param>
    /// <returns>緯度方向の距離</returns>
    public static Length LatitudeDistanceTo
    ( this ILonLatGettable a
    , ILonLatGettable b
    , LonLatDistanceAlgorithm llda = LonLatDistanceAlgorithm.Haversine
    , IGeometricalSpecificationGettable planet = null
    )
    {
      var aa = new LonLat( PlaneAngle.Zero, a.Latitude );
      var bb = new LonLat( PlaneAngle.Zero, b.Latitude );
      return aa.DistanceTo( bb, llda, planet );
    }

    /// <summary>
    /// 2つの経緯度 a, b について、
    /// 楕円体近似した惑星の形状定義 planet 上における
    /// 惑星表面上の地点間の距離を長さ次元で計算します
    /// </summary>
    /// <param name="a">経緯度の位置1つめ</param>
    /// <param name="b">経緯度の位置2つめ</param>
    /// <param name="llda">経緯度の距離を計算するアルゴリズム</param>
    /// <param name="planet">楕円体近似した惑星の形状定義; null の場合は <see cref="GeometricalSpecification.Earth_WGS84"/> が採用されます </param>
    /// <returns>距離</returns>
    public static Length DistanceTo
  ( this ILonLatGettable a
  , ILonLatGettable b
  , LonLatDistanceAlgorithm llda = LonLatDistanceAlgorithm.Haversine
  , IGeometricalSpecificationGettable planet = null
  )
    {
      planet = planet ?? GeometricalSpecification.Earth_WGS84;

      switch ( llda )
      {
        case LonLatDistanceAlgorithm.Haversine:
          return a.DistanceToHaversine( b, planet );
        case LonLatDistanceAlgorithm.Vincenty:
          return a.DistanceToVincenty( b, planet );
        default:
          throw new NotImplementedException();
      }
    }

    /// <summary>
    /// DistanceTo の Haversine アルゴリズム版の実装詳細
    /// </summary>
    /// <param name="a">経緯度の位置1つめ</param>
    /// <param name="b">経緯度の位置2つめ</param>
    /// <param name="planet">楕円体近似した惑星の形状定義; null の場合は <see cref="GeometricalSpecification.Earth_WGS84"/> が採用されます </param>
    /// <returns>距離</returns>
    internal static Length DistanceToHaversine
    ( this ILonLatGettable a
    , ILonLatGettable b
    , IGeometricalSpecificationGettable planet
    )
    {
      var r = planet.EquatorialRadius;

      var dlat = b.Latitude - a.Latitude;
      var dlon = b.Longitude - a.Longitude;

      var p =
        ( dlat / 2.0 ).Sin() * ( dlat / 2.0 ).Sin()
        + a.Latitude.Cos() * b.Latitude.Cos()
        * ( dlon / 2.0 ).Sin() * ( dlon / 2.0 ).Sin()
        ;

      var q = 2.0 * Math.Atan2( Math.Sqrt( p ), Math.Sqrt( 1.0 - p ) );

      return r * q;
    }

    /// <summary>
    /// DistanceTo の Vincenty アルゴリズム版の実装詳細
    /// </summary>
    /// <param name="a">経緯度の位置1つめ</param>
    /// <param name="b">経緯度の位置2つめ</param>
    /// <param name="planet">楕円体近似した惑星の形状定義; null の場合は <see cref="GeometricalSpecification.Earth_WGS84"/> が採用されます </param>
    /// <returns>距離</returns>
    internal static Length DistanceToVincenty
    ( this ILonLatGettable a
    , ILonLatGettable b
    , IGeometricalSpecificationGettable planet
    )
    {
      var L = b.Longitude - a.Longitude;
      var U1 = Math.Atan( ( 1.0 - planet.Flattening ) * a.Latitude.Tan() );
      var U2 = Math.Atan( ( 1.0 - planet.Flattening ) * b.Latitude.Tan() );
      var SinU1 = Math.Sin( U1 );
      var CosU1 = Math.Cos( U1 );
      var SinU2 = Math.Sin( U2 );
      var CosU2 = Math.Cos( U2 );

      var Lambda = L;
      var LambdaP = PlaneAngle.Zero;

      var IterationLimit = 256;

      var CosSqAlpha = 0.0;
      var Cos2SigmaM = 0.0;
      var CosSigma = 0.0;
      var SinSigma = 0.0;
      var Sigma = 0.0;

      do
      {
        var SinLambda = Lambda.Sin();
        var CosLambda = Lambda.Cos();
        SinSigma =
          Math.Sqrt
          ( ( CosU2 * SinLambda ) *
            ( CosU2 * SinLambda ) +
            ( CosU1 * SinU2 - SinU1 * CosU2 * CosLambda ) *
            ( CosU1 * SinU2 - SinU1 * CosU2 * CosLambda )
          );

        if ( SinSigma == 0 )
          return Length.Zero;

        CosSigma = SinU1 * SinU2 + CosU1 * CosU2 * CosLambda;
        Sigma = Math.Atan2( SinSigma, CosSigma );
        var SinAlpha = CosU1 * CosU2 * SinLambda / SinSigma;
        CosSqAlpha = 1 - SinAlpha * SinAlpha;
        Cos2SigmaM = CosSigma - 2 * SinU1 * SinU2 / CosSqAlpha;

        if ( double.IsNaN( Cos2SigmaM ) )
          Cos2SigmaM = 0;

        var C = planet.Flattening / 16.0 * CosSqAlpha * ( 4.0 + planet.Flattening * ( 4.0 - 3.0 * CosSqAlpha ) );
        LambdaP = Lambda;

        Lambda =
          L
          + PlaneAngle.FromRadians( 1.0 - C )
          * planet.Flattening
          * SinAlpha
          * ( Sigma + C * SinSigma *
              ( Cos2SigmaM + C * CosSigma *
                ( -1.0 + 2.0 * Cos2SigmaM * Cos2SigmaM
                )
              )
            )
          ;
      }
      while
      ( !Lambda.NearlyEquals( LambdaP, PlaneAngle.FromRadians( 0.5e-12 ) )
      && --IterationLimit > 0
      );

      if ( IterationLimit == 0 )
        return Length.NaN;

      var ERSq = planet.EquatorialRadius._m * planet.EquatorialRadius._m;
      var ARSq = planet.AxialRadius._m * planet.AxialRadius._m;

      var uSq = CosSqAlpha * ( ERSq - ARSq ) / ARSq;

      var A = 1.0 + uSq / 16384.0 * ( 4096.0 + uSq * ( -768.0 + uSq * ( 320.0 - 175.0 * uSq ) ) );
      var B = uSq / 1024.0 * ( 256.0 + uSq * ( -128.0 + uSq * ( 74.0 - 47.0 * uSq ) ) );

      var DeltaSigma =
        B
        * SinSigma
        * ( Cos2SigmaM + B / 4.0 *
            ( CosSigma
            * ( -1 + 2 * Cos2SigmaM * Cos2SigmaM )
            - B / 6 * Cos2SigmaM
            * ( -3 + 4 * SinSigma * SinSigma )
            * ( -3 + 4 * Cos2SigmaM * Cos2SigmaM )
            )
          )
        ;

      return Length.From_m( planet.AxialRadius._m * A * ( Sigma - DeltaSigma ) );
    }

    /// <summary>
    /// Vincenty のアルゴリズムで経緯度 origin から距離 distance だけ角度 angle の方位へ射影した経緯度を計算するよ
    /// </summary>
    /// <param name="origin">基点とする位置</param>
    /// <param name="distance">射影先までの距離</param>
    /// <param name="angle">射影する方位。北=0deg, 西=+90deg, 東=-90deg, 南=180deg。 atans(y,x) 的には 北向き=+x, 西向き=+y の系</param>
    /// <param name="planet">惑星。null の場合は WGS84</param>
    /// <returns>射影先の経緯度</returns>
    public static LonLat ProjectionTo
    ( this ILonLatGettable origin
    , Length distance
    , PlaneAngle angle
    , IGeometricalSpecificationGettable planet = null
    )
    {
      planet = planet ?? GeometricalSpecification.Earth_WGS84;

      var SinAlphpa1 = angle.Sin();
      var CosAlpha1 = angle.Cos();

      var TanU1 = ( 1 - planet.Flattening ) * origin.Latitude.Tan();
      var CosU1 = 1 / Math.Sqrt( 1 + TanU1 * TanU1 );
      var SinU1 = TanU1 * CosU1;
      var Sigma1 = Math.Atan2( TanU1, CosAlpha1 );
      var SinAlpha = CosU1 * SinAlphpa1;
      var CosSqAlpha = 1 - SinAlpha * SinAlpha;

      var ERSq = planet.EquatorialRadius._m * planet.EquatorialRadius._m;
      var ARSq = planet.AxialRadius._m * planet.AxialRadius._m;

      var uSq = CosSqAlpha * ( ERSq - ARSq ) / ARSq;
      var A = 1 + uSq / 16384 * ( 4096 + uSq * ( -768 + uSq * ( 320 - 175 * uSq ) ) );
      var B = uSq / 1024 * ( 256 + uSq * ( -128 + uSq * ( 74 - 47 * uSq ) ) );

      var Sigma = distance._m / ( planet.AxialRadius._m * A );
      var SigmaP = 0.0;
      var SinSigma = 0.0;
      var CosSigma = 0.0;
      var Cos2SigmaM = 0.0;
      do
      {
        Cos2SigmaM = Math.Cos( 2 * Sigma1 + Sigma );
        SinSigma = Math.Sin( Sigma );
        CosSigma = Math.Cos( Sigma );
        var DeltaSigma =
          B * SinSigma * ( Cos2SigmaM + B / 4 * ( CosSigma * ( -1 + 2 * Cos2SigmaM * Cos2SigmaM ) -
          B / 6 * Cos2SigmaM * ( -3 + 4 * SinSigma * SinSigma ) * ( -3 + 4 * Cos2SigmaM * Cos2SigmaM ) ) )
          ;
        SigmaP = Sigma;
        Sigma = distance._m / ( planet.AxialRadius._m * A ) + DeltaSigma;
      } while ( Math.Abs( Sigma - SigmaP ) > 1e-12 );

      var tmp = SinU1 * SinSigma - CosU1 * CosSigma * CosAlpha1;
      var Phi2 = PlaneAngle.FromRadians( Math.Atan2( SinU1 * CosSigma + CosU1 * SinSigma * CosAlpha1, ( 1 - planet.Flattening ) * Math.Sqrt( SinAlpha * SinAlpha + tmp * tmp ) ) );
      var Labmda = Math.Atan2( SinSigma * SinAlphpa1, CosU1 * CosSigma - SinU1 * SinSigma * CosAlpha1 );
      var C = planet.Flattening / 16 * CosSqAlpha * ( 4 + planet.Flattening * ( 4 - 3 * CosSqAlpha ) );
      var L = Labmda - ( 1 - C ) * planet.Flattening * SinAlpha *
          ( Sigma + C * SinSigma * ( Cos2SigmaM + C * CosSigma * ( -1 + 2 * Cos2SigmaM * Cos2SigmaM ) ) );
      var Lambda2 = PlaneAngle.FromRadians( ( origin.Longitude._rad + L + 3 * Math.PI ) % ( 2 * Math.PI ) - Math.PI );  // normalise to -180...+180

      //var revAz = Math.Atan2( SinAlpha, -tmp );
      return new LonLat( Lambda2, Phi2 );
    }

  }
}
