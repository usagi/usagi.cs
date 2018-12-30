using usagi.Quantity;

namespace usagi.CivilEngineering.Planet
{
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
}
