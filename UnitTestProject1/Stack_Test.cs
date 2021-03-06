using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack;

namespace UnitTestProject1
{
    [TestClass]
    public class Stack_Test
    {
        Stack_Class st = new Stack_Class(5);

        [TestMethod]
        public void push()
        {
            //Arrange
            int Expected_peek = 25;
            int count_e = 1;
            //Act
            st.Push(25);
            //Assert
            Assert.AreEqual(st.Count, count_e);
            Assert.AreEqual(st.Peek(), Expected_peek);    
        }
        [TestMethod]
        public void print()
        {
            //Arrange
            string Expected_data = "[25,10]";
            int count_e = 2;
            //Act
            st.Push(25);
            st.Push(10);
            //Assert
            Assert.AreEqual(st.Count, count_e);
            Assert.AreEqual(st.Print(), Expected_data);
        }
    }
}
