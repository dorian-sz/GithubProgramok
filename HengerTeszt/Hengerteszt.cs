using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Henger;

namespace HengerTeszt
{
    [TestClass]
    public class Hengerteszt
    {
        [TestMethod]

        public void KeruletTeszt()
        {
            Hengerclass h = new Hengerclass();
            h.setMagas();
            h.setSugar();

            //Arrange
            double vartEredmeny = 31.42;

            //Act
            double kapottEredmeny = h.getKerulet();

            Assert.AreEqual(kapottEredmeny, vartEredmeny);

        }
    }
}
