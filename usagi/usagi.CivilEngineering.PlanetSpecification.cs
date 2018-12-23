using usagi.Quantity;
using System;

namespace usagi.CivilEngineering.Planet
{
  /// <summary>
  /// 惑星の諸元
  /// </summary>
  [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
  internal class NamespaceDoc { }

  /// <summary>
  /// 惑星の幾何学的な諸元を取得可能
  /// </summary>
  public interface IGeometricalSpecificationGettable
  {
    /// <summary>
    /// 楕円体近似した場合の扁平率
    /// </summary>
    double Flattening { get; }
    /// <summary>
    /// 楕円体近似した場合の中心から赤道方向への半径
    /// </summary>
    Length EquatorialRadius { get; }
    /// <summary>
    /// 楕円体近似した場合の赤道長
    /// </summary>
    Length EquatorLength { get; }
    /// <summary>
    /// 楕円体近似した場合の回転軸方向への半径
    /// </summary>
    Length AxialRadius { get; }
    /// <summary>
    /// 楕円体近似した場合の緯度範囲 [ 0 ... 90 ] deg 間の距離
    /// </summary>
    Length MaximumLatitudeLength { get; }
  }

  /// <summary>
  /// 惑星の楕円体近似した形状の定義を取得できる
  /// </summary>
  public sealed class GeometricalSpecification
  {
    /// <summary>
    /// 地球の幾何学的な諸元(WGS84測地系)
    /// </summary>
    static public IGeometricalSpecificationGettable Earth_WGS84
    { get; } = new _Earth_WGS84();

    /// <summary>
    /// 地球の幾何学的な諸元(WGS84)
    /// </summary>
    internal sealed class _Earth_WGS84
      : IGeometricalSpecificationGettable
    {
      public double Flattening => 1.0 / 298.257_223_563;
      public Length EquatorialRadius => Length.From_m( 6_356_752.314_2 );
      public Length EquatorLength => EquatorialRadius * 2 * Math.PI;
      public Length AxialRadius => EquatorialRadius * ( 1 - Flattening );
      /// <remarks>
      /// 楕円の円周の計算は負荷がそこそこ高くなるので事前に計算した値を入れた。
      /// </remarks>
      public Length MaximumLatitudeLength => Length.From_m( 9_968_431.031_9 );
    }
  }
}
