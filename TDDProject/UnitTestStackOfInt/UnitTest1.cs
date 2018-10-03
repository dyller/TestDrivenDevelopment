using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TDDProject;

namespace UnitTestStackOfInt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPushCheckInTop()
        {
            StackOfInt SOI = new StackOfInt();
            double expResult = 2; 
            SOI.Push(expResult);
            double result =SOI.StackInt.Peek();
            Assert.AreEqual(expResult, result);

            double expResult2 = 3;
            SOI.Push(expResult2);
            double result2 = SOI.StackInt.Peek();
            Assert.AreEqual(expResult2, result2);
        }
        [TestMethod]
        public void TestAddTwoException()
        {
            StackOfInt SOI = new StackOfInt();
            SOI.Clear();
            SOI.Push(2);
            try
            {
                SOI.AddTop2();
                Assert.Fail();
            }
            catch (System.Exception)
            {
                
            }

        }

        [TestMethod]
        public void Testpop()
        {
            StackOfInt SOI = new StackOfInt();

            double expResult=2 ;
            SOI.Push(expResult);
            SOI.Push(3);
            double expResult3 =  SOI.Pop();
            double result = SOI.StackInt.Peek();
            Assert.AreEqual(expResult, result);
            Assert.AreEqual(expResult3, 3);
            
            double expResult2 = 3;
            SOI.Push(expResult2);
            SOI.Push(2);
           double expResult4= SOI.Pop();
            double result2 = SOI.StackInt.Peek();
            Assert.AreEqual(expResult2, result2);
            Assert.AreEqual(expResult4, 2);

        }

        [TestMethod]
        public void TestTop()
        {
            StackOfInt SOI = new StackOfInt();
            double expResult = 2;
            SOI.Push(expResult);
            double result = SOI.Top();
            Assert.AreEqual(expResult, result);

            double expResult2 = 3;
            SOI.Push(expResult2);
            double result2 = SOI.Top();
            Assert.AreEqual(expResult2, result2);

        }

        [TestMethod]
        public void TestClear()
        {
            StackOfInt SOI = new StackOfInt();
           
            SOI.Push(1);
            SOI.Push(11);
            SOI.Push(21);
            SOI.Clear();
            Assert.AreEqual(0, SOI.StackInt.Count()) ;

        }

        [TestMethod]
        public void TestCount()
        {
            StackOfInt SOI = new StackOfInt();

            SOI.Push(1);
            SOI.Push(11);
            SOI.Push(21);
            Assert.AreEqual(3, SOI.Count());

        }
        [TestMethod]
        public void TestAddTop2()
        {
            StackOfInt SOI = new StackOfInt();
            
            SOI.Push(1);
            SOI.Push(11);
            SOI.Push(21);
            SOI.AddTop2();
            Assert.AreEqual(11+21, SOI.StackInt.Peek());

        }

        [TestMethod]
        public void TestsubTop2()
        {
            StackOfInt SOI = new StackOfInt();

            SOI.Push(1);
            SOI.Push(11);
            SOI.Push(21);
            SOI.SubTop2();
            Assert.AreEqual(21 - 11, SOI.StackInt.Peek());

        }

        [TestMethod]
        public void TestsubTop2Exception()
        {
            StackOfInt SOI = new StackOfInt();

            SOI.Push(1);
            try
            {
                SOI.SubTop2();
                Assert.Fail();
            }
            catch (Exception)
            {

            }

        }

        [TestMethod]
        public void TestMultiplyTop2()
        {
            StackOfInt SOI = new StackOfInt();

            SOI.Push(1);
            SOI.Push(11);
            SOI.Push(21);
            SOI.Multiplytop2();
            Assert.AreEqual(21 * 11, SOI.StackInt.Peek());

        }

        [TestMethod]
        public void TestMultiplyTop2Exception()
        {
            StackOfInt SOI = new StackOfInt();

            SOI.Push(1);
            try
            {
                SOI.Multiplytop2();
                Assert.Fail();
            }
            catch (Exception)
            {

            }

        }
        [TestMethod]
        public void TestDivisionTop2()
        {
            StackOfInt SOI = new StackOfInt();

            SOI.Push(1);
            SOI.Push(11);
            SOI.Push(21);
            SOI.DivisionTop2();
            Assert.AreEqual((double)21 /(double) 11, SOI.StackInt.Peek());

        }
        [TestMethod]
        public void TestDivsionTop2Exception()
        {
            StackOfInt SOI = new StackOfInt();

            SOI.Push(1);
            try
            {
                SOI.DivisionTop2();
                Assert.Fail();
            }
            catch (Exception)
            {

            }

        }
        [TestMethod]
        public void TestaddAll()
        {
            StackOfInt SOI = new StackOfInt();

            SOI.Push(1);
            SOI.Push(11);
            SOI.Push(21);
            SOI.AddAll();
            Assert.AreEqual(21+11+1, SOI.StackInt.Peek());

        }
        [TestMethod]
        public void TestMultiplyAll()
        {
            StackOfInt SOI = new StackOfInt();

            SOI.Push(1);
            SOI.Push(11);
            SOI.Push(21);
            SOI.MultiAllNumbers();
            Assert.AreEqual(21 * 11 * 1, SOI.StackInt.Peek());

        }
        [TestMethod]
        public void TestMultiplyAll1Number()
        {
            StackOfInt SOI = new StackOfInt();
            SOI.Clear();
            SOI.Push(1);
            SOI.MultiAllNumbers();
            Assert.AreEqual( 1, SOI.StackInt.Peek());

        }
        [TestMethod]
        public void TestAddAllNumber1Number()
        {
            StackOfInt SOI = new StackOfInt();
            SOI.Clear();
            SOI.Push(1);
            SOI.AddAll();
            Assert.AreEqual(1, SOI.StackInt.Peek());

        }
        [TestMethod]
        public void TestMultiplyAllIsempty()
        {
            StackOfInt SOI = new StackOfInt();
            SOI.Clear();
            try
            {
                SOI.MultiAllNumbers();
                Assert.Fail();
            }
            catch(Exception)
            {
                
            }

        }
        [TestMethod]
        public void TestAddAllIsempty()
        {
            StackOfInt SOI = new StackOfInt();
            SOI.Clear();
            try
            {
                SOI.AddAll();
                Assert.Fail();
            }
            catch(Exception)
            {

            }

        }

    }
}
