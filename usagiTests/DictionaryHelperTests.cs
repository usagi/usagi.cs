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
  public class DictionaryHelperTests
  {
    [TestMethod()]
    public void UnorderedEqualTest()
    {
      var a = new Dictionary<int, string>();
      for ( int n = -100; n < 100; ++n )
        a.Add( n, n.ToString() );
      Dictionary<int, string> b;
      do
        b = a.OrderBy( _ => Guid.NewGuid() ).ToDictionary( ( p ) => p.Key, ( p ) => p.Value );
      while ( a.First().Key == b.First().Key );

      Assert.IsFalse( a.SequenceEqual( b ) );
      Assert.IsTrue( a.UnorderedEqual( b ) );
    }
  }
}