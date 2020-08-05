using usagi.CivilEngineering.Terrain.GSI.maps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static usagi.CivilEngineering.Terrain.GSI.maps.Utility;
using static usagi.CivilEngineering.Terrain.GSJ.datatilemap.Utility;
using System.Drawing;
using usagi.Quantity;
using usagi.Quantity.GeoLocation;

namespace usagi.CivilEngineering.Terrain.GSI.maps.Tests
{
  [TestClass()]
  public class UtilityTests
  {
    // ↓このオーバーロード用
    // public static double[,] LoadDEM( TileLocation tile_location, DEMType dem_type = DEMType.DEM_5A_5B_10B )
    [TestMethod()]
    public void LoadDEMTest()
    {
      var tile_location = new TileLocation( 29632, 12000, 15 );
      var vs = LoadDEM( tile_location );
      Assert.IsNotNull( vs );
      Assert.AreEqual( 256, vs.GetLength( 0 ) );
      Assert.AreEqual( 256, vs.GetLength( 1 ) );
#if false
      var i = SavePNGNumberTileS( vs, 1.0e-2, 0, Color.FromArgb( 0, 128, 0, 0 ) );
      i.Save( System.IO.Path.Combine( System.Environment.GetFolderPath( System.Environment.SpecialFolder.DesktopDirectory ), "tmp", "fuga.png" ), System.Drawing.Imaging.ImageFormat.Png );
#endif
    }

    // ↓こちらのオーバーロード用
    // public static double[,] LoadDEM
    // (byte z
    // , ILonLatGettable center
    // , ILonLatGettable delta
    // , DEMType dem_type = DEMType.DEM_5A_5B_10B
    // )
    [TestMethod()]
    public void LoadDEMTest1()
    {
      const byte z = 12;
      const double lat = 41.797184;
      const double lon = 140.756831;
      var center = new LonLat( PlaneAngle.FromDegrees( lon ), PlaneAngle.FromDegrees( lat ) );
      var delta_angle = PlaneAngle.FromDegrees( 0, 8, 0 );
      var delta = new LonLat( delta_angle, delta_angle );
      //var vs = LoadDEM( z, center, delta );
      var vs = LoadDEM( out var d, z, center, Length.From_km( 18 ) );
      System.Console.WriteLine( $"{d}" );
      Assert.IsNotNull( vs );
      //Assert.AreEqual( 0.19, vs[ 694, 1014 ], 0.01 );
      //Assert.AreEqual( 4.01, vs[ 695, 1014 ], 0.01 );
      //Assert.AreEqual( 3.18, vs[ 696, 1014 ], 0.01 );
      //Assert.AreEqual( 3.18, vs[ 697, 1014 ], 0.01 );
      var i = SavePNGNumberTileS( vs, 1.0e-2, 0, Color.FromArgb( 255, 128, 0, 0 ) );
      i.Save( System.IO.Path.Combine( System.Environment.GetFolderPath( System.Environment.SpecialFolder.DesktopDirectory ), $"GK/tmp/neko{z}.png" ), System.Drawing.Imaging.ImageFormat.Png );
    }
  }
}