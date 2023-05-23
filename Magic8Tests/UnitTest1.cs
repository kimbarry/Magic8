
using ConsoleApp1;
using System;

namespace Magic8Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestReturnGetLost()
        {
            //arrange
            
            string expected = "Get Lost";
            var ball = new Ball();
            //act
            string actual = ball.GetResponse();


            //assert

            Assert.Equal(expected, actual);
        }
    }
}