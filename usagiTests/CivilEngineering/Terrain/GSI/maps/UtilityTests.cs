using Microsoft.VisualStudio.TestTools.UnitTesting;
using static usagi.CivilEngineering.Terrain.GSI.maps.Utility;
using static usagi.CivilEngineering.Terrain.GSJ.datatilemap.Utility;
using System.Drawing;

namespace usagi.CivilEngineering.Terrain.GSI.maps.Tests
{
  [TestClass()]
  public class UtilityTests
  {
    [TestMethod()]
    public void LoadDEMTest()
    {
      const byte z = 15;
      const uint x = 29632;
      const uint y = 12000;
      var vs = LoadDEM( z, x, y, DEMType.DEM_5A | DEMType.DEM_10B );
      Assert.IsNotNull( vs );
      Assert.AreEqual( 256, vs.GetLength( 0 ) );
      Assert.AreEqual( 256, vs.GetLength( 1 ) );
#if false
      var i = SavePNGNumberTileS( vs, 1.0e-2, 0, Color.FromArgb( 0, 128, 0, 0 ) );
      i.Save( System.IO.Path.Combine( System.Environment.GetFolderPath( System.Environment.SpecialFolder.DesktopDirectory ), "tmp", "fuga.png" ), System.Drawing.Imaging.ImageFormat.Png );
#endif
    }
  }
}