using Microsoft.VisualStudio.TestTools.UnitTesting;
using usagi.Collection.Extension;
using static usagi.Collection.Enumerable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usagi.Collection.Extension.Tests
{
  [TestClass()]
  public class EnumerableHelperTests
  {
    [TestMethod()]
    public void UnorderedEqualTest()
    {
      var a = Range( -100, 100 );
      IEnumerable<int> b;
      do
        b = a.OrderBy( _ => Guid.NewGuid() );
      while ( a.First() == b.First() );
      Assert.IsFalse( a.SequenceEqual( b ) );
      Assert.IsTrue( a.UnorderedEqual( b ) );
    }

    [TestMethod()]
    public void WithIndexingTest()
    {
      var vs = Range( 100 );
      foreach ( var (i, v) in vs.WithIndexing() )
        Assert.AreEqual( i, v );
    }
  }
}