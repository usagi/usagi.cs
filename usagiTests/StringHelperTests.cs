using Microsoft.VisualStudio.TestTools.UnitTesting;
using usagi.Quantity.Ratio.Extension;
using System.Windows.Media;
using static usagi.ColorSpace.Extension.StringExtetnsion;

namespace usagi.ColorSpace.Extension.Tests
{
  [TestClass()]
  public class StringExtensionTests
  {
    [TestMethod()]
    public void ToColorTest_HexARGB8()
    {
      var patterns = new (Color, string)[]
      { ( Color.FromArgb( 0x11,0x22,0x33,0x44), "#11223344" )
      , ( Color.FromArgb( 0xff,0xcc,0xdd,0xaa), "#ffCCddAA" )
      };

      foreach ( var (Expect, TestPattern) in patterns )
      {
        Assert.AreEqual( Expect, TestPattern.ToColor(), TestPattern );
        Assert.IsNull( TestPattern.ToColor( ColorPatternTrial._All & ~ColorPatternTrial.Hex ), TestPattern );
      }
    }

    [TestMethod()]
    public void ToColorTest_HexRGB8()
    {
      var patterns = new (Color, string)[]
      { ( Color.FromRgb( 0xFF, 0x80, 0x00 ), "#FF8000" )
      , ( Color.FromRgb( 0xAB, 0xCD, 0xEF ), "#ABCDEF" )
      , ( Color.FromRgb( 0x33, 0x99, 0xAA ), "#3399aa" )
      };

      foreach ( var (Expect, TestPattern) in patterns )
      {
        Assert.AreEqual( Expect, TestPattern.ToColor(), TestPattern );
        Assert.IsNull( TestPattern.ToColor( ColorPatternTrial._All & ~ColorPatternTrial.Hex ), TestPattern );
      }
    }

    [TestMethod()]
    public void ToColorTest_HexARGB7()
    {
      var patterns = new (Color, string)[]
      { ( Color.FromArgb( 0x11,0x22,0x33,0x44), "#1234" )
      , ( Color.FromArgb( 0xff,0xcc,0xdd,0xaa), "#fCdA" )
      };

      foreach ( var (Expect, TestPattern) in patterns )
        Assert.AreEqual( Expect, TestPattern.ToColor(), TestPattern );
    }

    [TestMethod()]
    public void ToColorTest_HexRGB7()
    {
      var patterns = new (Color, string)[]
      { ( Color.FromRgb( 0xFF, 0x88, 0x00 ), "#F80" )
      , ( Color.FromRgb( 0xAA, 0xCC, 0xEE ), "#ACE" )
      , ( Color.FromRgb( 0x33, 0x99, 0xAA ), "#39a" )
      };

      foreach ( var (Expect, TestPattern) in patterns )
        Assert.AreEqual( Expect, TestPattern.ToColor(), TestPattern );
    }

    [TestMethod()]
    public void ToColorTest_ColorName()
    {
      var patterns = new (Color?, string)[]
      { ( Colors.Red, "Red" )
      , ( Colors.AliceBlue, "AliceBlue" )
      , ( Colors.LightCyan, "lightcyan" )
      };

      foreach ( var (Expect, TestPattern) in patterns )
        Assert.AreEqual( Expect, TestPattern.ToColor(), TestPattern );
    }

    [TestMethod()]
    public void ToColorTest_Null()
    {
      var patterns = new (Color?, string)[]
      { ( null, "sushi" )
      , ( null, "だめぽ" )
      , ( null, string.Empty )
      };

      foreach ( var (Expect, TestPattern) in patterns )
        Assert.AreEqual( Expect, TestPattern.ToColor(), TestPattern );
    }

    [TestMethod()]
    public void ToColorTest_CSS_RGBA()
    {
      var patterns = new (Color?, string)[]
      { ( Color.FromRgb(1,2,3), "rgb(1,2,3)" )
      , ( Color.FromRgb(0,127,255), "rgb(0,127,255)" )
      , ( Color.FromRgb(0,127,255), " rgb( 0 , 127 , 255 ) " )
      , ( Color.FromArgb( (0.7).UNormToByte(),0,127,255), " rgba( 0 , 127 , 255, 0.7 ) " )
      };

      foreach ( var (Expect, TestPattern) in patterns )
      {
        Assert.AreEqual( Expect, TestPattern.ToColor(), $"ALL/{TestPattern}" );
        Assert.AreEqual( Expect, TestPattern.ToColor( ColorPatternTrial.CSS_RGBA ), $"CSS_RGB/{TestPattern}" );
        Assert.IsNull( TestPattern.ToColor( ColorPatternTrial._All & ~ColorPatternTrial.CSS_RGBA ), $"&~/{TestPattern}" );
      }
    }

    [TestMethod()]
    public void ToColorTest_CSS_HSLA()
    {
      var patterns = new (Color?, string)[]
      { ( Colors.Red, "hsl(0,100%,50%)" )
      , ( Colors.White, "hsl(0,100%,100%)" )
      , ( Colors.Black, "hsl(0,100%,0%)" )
      , ( Color.FromArgb( (0.7).UNormToByte(),240,248,255), " hsla( 208, 100%, 97%, 0.7 ) " )
      };

      foreach ( var (Expect, TestPattern) in patterns )
      {
        Assert.AreEqual( Expect, TestPattern.ToColor(), $"ALL/{TestPattern}" );
        Assert.AreEqual( Expect, TestPattern.ToColor( ColorPatternTrial.CSS_HSLA ), $"CSS_HSLA/{TestPattern}" );
        Assert.IsNull( TestPattern.ToColor( ColorPatternTrial._All & ~ColorPatternTrial.CSS_HSLA ), $"&~/{TestPattern}" );
      }
    }
  }
}