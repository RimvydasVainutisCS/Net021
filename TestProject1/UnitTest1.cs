using Microsoft.VisualStudio.TestTools.UnitTesting;
using Net021;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
        public void TestBookIsbnFormat()
        {
            //private readonly Regex _regex1 = new Regex(@"\d{3}\-\d{1}\-\d{2}\-\d{6}\-\d{1}");
            //private readonly Regex _regex2 = new Regex(@"\d{13}");
            Author authorOne = new("Mad", "Max");
            Book bookOne = new("1234567890123",
                DateTime.Now,
                "Inception",
                new List<Author> { authorOne });
            Assert.AreEqual("1234567890123", bookOne.ISBN);
        }
    }
}