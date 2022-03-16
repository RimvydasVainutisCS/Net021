using Microsoft.VisualStudio.TestTools.UnitTesting;
using Net021;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAuthorNameValuesNotNull()
        {
            Author authorOne = new("Mad", "Max");
            Assert.IsNotNull(authorOne.FirstName);
            Assert.IsNotNull(authorOne.LastName);
        }

        [TestMethod]
        public void TestAuthorNameLenghtLessThan200()
        {
            Author authorOne = new("Mad", "Max");
            Assert.IsTrue(authorOne.FirstName.Length <= 200);
            Assert.IsTrue(authorOne.LastName.Length <= 200);
        }

        [TestMethod]
        public void TestBookIsbnFormatOne()
        {
            Author authorOne = new("Mad", "Max");
            Book bookOne = new("1234567890123",
                DateTime.Now,
                "Inception",
                new List<Author> { authorOne });
            Assert.AreEqual("1234567890123", bookOne.ISBN);
        }

        [TestMethod]
        public void TestBookIsbnFormatTwo()
        {
            Author authorOne = new("Mad", "Max");
            Book bookOne = new("123-4-56-789012-3",
                DateTime.Now,
                "Inception",
                new List<Author> { authorOne });
            Assert.AreEqual("123-4-56-789012-3", bookOne.ISBN);
        }
    }
}