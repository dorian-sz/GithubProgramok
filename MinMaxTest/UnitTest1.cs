using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using MinMaxmain;

namespace MinMaxTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MinMaxclass mmc = new MinMaxclass(5);
            var stringReader = new StringReader("5\r\n3\r\n2\r\n6\r\n4");

            var vartEredm = 1;


            Console.SetIn(stringReader);
            mmc.userFeltolt();
            
            mmc.arrSort();

            var kapottEredm = mmc.getMin();

            Assert.AreEqual(vartEredm, kapottEredm);

        }
    }
}
