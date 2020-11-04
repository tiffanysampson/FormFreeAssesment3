using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumbers;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;


namespace PrimeNumbers.Tests
{
    [TestClass()]
    public class PrimeNumberProcessorTests
    {
        List<DataNumberModel> results = new List<DataNumberModel>();
        public List<string> datastrings = new List<string> {"4","32" };
        
       [TestMethod()]
        public void ProcessDataTest()
        {
            List<int> primenum = new List<int>();

            IPrimeNumberProcessor pp = Factory.CreatePrimeNumberProcessor();
            primenum = pp.ProcessData(4);

            Assert.AreEqual(2, primenum.Count);
        }
    }
}