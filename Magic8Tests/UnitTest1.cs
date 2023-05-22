
using System;

namespace Magic8Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestReturnOne()
        {
            //arrange
            
            int expected = 1;

            //act

            int actual = ConsoleApp1.Class1.ReturnOne();


            //assert

            Assert.Equal(expected, actual);
        }
    }
}