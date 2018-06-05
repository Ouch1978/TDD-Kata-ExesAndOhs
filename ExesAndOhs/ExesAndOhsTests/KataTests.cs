using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExesAndOhs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExesAndOhs.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void ExampleTests()
        {
            Assert.AreEqual( true , Kata.XO( "xo" ) );
            Assert.AreEqual( true , Kata.XO( "xxOo" ) );
            Assert.AreEqual( false , Kata.XO( "xxxm" ) );
            Assert.AreEqual( false , Kata.XO( "Oo" ) );
            Assert.AreEqual( false , Kata.XO( "ooom" ) );
        }
    }
}