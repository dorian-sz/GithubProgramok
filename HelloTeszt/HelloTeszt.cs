using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Hello;



namespace HelloTeszt
{
    [TestClass]
    public class HelloTeszt
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string vartEredmeny = "Hello world";

            //Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Hello.Program.Main();
                var kapottEredmeny = sw.ToString().Trim();

                //Assert
                Assert.AreEqual(kapottEredmeny, vartEredmeny);
            }
        }
    }
}
