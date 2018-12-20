using Microsoft.VisualStudio.TestTools.UnitTesting;
using usagi.Extension.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usagi.Extension.Collection.Tests
{
  [TestClass()]
  public class EnumerableHelperTests
  {
    [TestMethod()]
    public void UnorderedEqualTest()
    {
      var a = Enumerable.Range( -100, 100 );
      IEnumerable<int> b;
      do
        b = a.OrderBy( _ => Guid.NewGuid() );
      while ( a.First() == b.First() );
      Assert.IsFalse( a.SequenceEqual( b ) );
      Assert.IsTrue( a.UnorderedEqual( b ) );
    }
  }
}