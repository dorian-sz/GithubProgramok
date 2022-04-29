using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using NegySzog;

namespace NegySzogTeszt
{
    [TestClass]
    public class NegyszogTest
    {
        static double s = 2.0;
        Negyszog ns = new Negyszog(s);

        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            double vartEredmeny = 8.0;

            //Act
            double kapottEredmeny = ns.Kerulet();
            
            //Assert
            Assert.AreEqual(vartEredmeny, kapottEredmeny);
        }
    }
}
