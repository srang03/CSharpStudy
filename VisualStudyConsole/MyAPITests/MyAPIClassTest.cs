using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAPITests
{
    [TestClass]
    public class MyAPIClassTest
    {
        [TestMethod]
        public void MyTestMethod()
        {
            Assert.AreEqual(10, 10);
        }

        [TestMethod]
        public void SelectionSort_ShouldReturnSortedArray()
        {
            // [1] Arrange (정렬), Setup
            int[] arr = { 33, 22, 11, 42, 51, 88, 75 };

            // [2] Act (동작), Execute
            int[] result = MyAPI.Program.SelectOrder(arr); // 테스트 메서드 작성

            // [3] Assert (어설션), Verify
            Assert.AreEqual(11, result[0]);
            Assert.AreEqual(22, result[1]);
   
        }

        [TestMethod]
        public void IsItPossibleToWork()
        {
            int[] arr = { 33, 44, 22, 55 };

            int[] result = DulAlgorithm.Algorithm.SelectionSort(arr);

            Assert.AreEqual(22, result[0]);
            Assert.AreEqual(33, result[1]);
            Assert.AreEqual(44, result[2]);
        }

        [TestMethod]
        public void ISEven_ShouldReturnTrue()
        {
            int x = 2;
            int y = 4;

            bool x_result = MyAPI.Program.IsEven(x);
            bool y_result = MyAPI.Program.IsEven(y);

            Assert.AreEqual(true, x_result);
            Assert.AreEqual(true, y_result);
        }

        [TestMethod]
        public void ISEven_ShouldReturnFalse()
        {
            int x = 3;
            int y = 5;

            bool x_result = MyAPI.Program.IsEven(x);
            bool y_result = MyAPI.Program.IsEven(y);

            Assert.AreEqual(false, x_result);
            Assert.AreEqual(false, y_result);
        }


        [TestMethod]
        public void ISOdd_ShouldReturnTrue()
        {

        }

        [TestMethod]
        public void ISOdd_ShouldReturnFalse()
        {

        }
    }
}
