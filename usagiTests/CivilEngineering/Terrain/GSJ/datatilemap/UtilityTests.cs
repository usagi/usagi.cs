using Microsoft.VisualStudio.TestTools.UnitTesting;
using static usagi.CivilEngineering.Terrain.GSJ.datatilemap.Utility;
using System.Drawing;
using System;

namespace usagi.CivilEngineering.Terrain.GSJ.datatilemap.Tests
{
  [TestClass()]
  public class UtilityTests
  {
    [TestMethod()]
    public void LoadPNGNumberTileSTest()
    {
      const int z = 14;

      const int x = 14599;
      const int y = 6134;

      var uri = new Uri( $"https://cyberjapandata.gsi.go.jp/xyz/dem_png/{z}/{x}/{y}.png" );

      var vs = LoadPNGNumberTileS( out var has_invalid_value, uri, 1.0e-2, 0, Color.FromArgb( 128, 0, 0 ) );

      // デコード結果の値は同じ座標のテキスト版を参照して設定した
      // https://cyberjapandata.gsi.go.jp/xyz/dem/14/14599/6134.txt

      Assert.IsTrue( has_invalid_value );

      Assert.AreEqual( 2, vs.Rank );
      Assert.AreEqual( 256, vs.GetLength( 0 ) );
      Assert.AreEqual( 256, vs.GetLength( 1 ) );

      Assert.AreEqual( 129.50, vs[ 0, 0 ], 0.01 );
      Assert.AreEqual( 109.55, vs[ 255, 0 ], 0.01 );
      Assert.AreEqual( double.NaN, vs[ 0, 255 ] );
      Assert.AreEqual( 21.39, vs[ 255, 255 ], 0.01 );
    }
  }
}