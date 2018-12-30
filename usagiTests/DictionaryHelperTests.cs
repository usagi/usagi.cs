using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace usagi.Collection.Extension.Tests
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