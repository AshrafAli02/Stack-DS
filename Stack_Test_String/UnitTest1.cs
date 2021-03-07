using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack_Excercise;


namespace Stack_Test_String
{
    [TestClass]
    public class UnitTest1
    {
        String_Stack st = new String_Stack();
        [TestMethod]
        public void Reverse()
        {
            //Arrange
            string word = "ashraf";
            //Act
            String Expected = "farhsa";
            //Assert
            Assert.AreEqual(st.Reverse_String(word), Expected);
        }
    }
}
