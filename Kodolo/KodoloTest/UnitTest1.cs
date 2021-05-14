using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Kodolo;

namespace KodoloTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void urestomb()
        {
            Kodolas.collection.Add(new Kodolas('a'));
            int result = Kodolas.collection.Count;
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void elsokarakter()
        {
            List<Kodolas> collection = new List<Kodolas>();
            collection.Add(new Kodolas('a'));
            string result = Kodolas.szamkodolo(collection);
            Assert.AreEqual(result, "97");
        }

        [TestMethod]
        public void masodikkarakter()
        {
            List<Kodolas> collection = new List<Kodolas>();
            collection.Add(new Kodolas('a'));
            collection.Add(new Kodolas('l'));
            string result = Kodolas.szamkodolo(collection);
            Assert.AreEqual(result, "9711");
        }

        [TestMethod]
        public void tobbkarakter()
        {
            List<Kodolas> l = new List<Kodolas>();
            l.Add(new Kodolas('a'));
            l.Add(new Kodolas('l'));
            l.Add(new Kodolas('m'));
            string result = Kodolas.szamkodolo(l);
            Assert.AreEqual(result, "97111");
        }

    }
}