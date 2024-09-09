using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CheckOfPassword.Tests
{
    [TestClass]
    public class PassTests
    {
        [TestMethod]
        public void password_PasswordIsEmpty_0()
        {
            //arrange
            string password = "";
            int expected = 0;
            //act
            Pass pass = new Pass();
            int actual = pass.passwd(password);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void password_onlyCifra_1()
        {
            //arrange
            string password = "12";
            int expected = 1;
            //act
            Pass pass = new Pass();
            int actual = pass.passwd(password);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void password_CifraAndBukva_2()
        {
            //arrange
            string password = "12ab";
            int expected = 2;
            //act
            Pass pass = new Pass();
            int actual = pass.passwd(password);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void password_CifraAndBukvaAndBigBukva_3()
        {
            //arrange
            string password = "12abAB";
            int expected = 3;
            //act
            Pass pass = new Pass();
            int actual = pass.passwd(password);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void password_CifraAndBukvaAndBigBukvaAndSPEC_4()
        {
            //arrange
            string password = "12abAB!";
            int expected = 4;
            //act
            Pass pass = new Pass();
            int actual = pass.passwd(password);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void password_CifraAndBukvaAndBigBukvaAndSPECMoreThenTen_5()
        {
            //arrange
            string password = "12abAB!12ab";
            int expected = 5;
            //act
            Pass pass = new Pass();
            int actual = pass.passwd(password);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
