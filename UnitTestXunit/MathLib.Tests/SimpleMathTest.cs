using Xunit;

namespace MathLib.Tests
{
    public class SimpleMathTest
    {
        [Fact]
        public void AddTest()
        {
            var res = SimpleMath.Add(1, 2);
            Assert.True(3 == res);    
        }
        [Fact]
        public void SubtractTest()
        {
            var res = SimpleMath.Subtract(10, 3);
            Assert.True(7 == res);    
        }
        [Fact]
        public void MultiplyTest()
        {
            var res = SimpleMath.Multiply(7, 6);
            Assert.Equal(42, res);    
        }
        [Fact]
        public void DivideTest()
        {
            var res = SimpleMath.Divide(21, 3);
            Assert.Equal( 7, res);    
        }
        [Fact]
        public void RemainderTest()
        {
            var res = SimpleMath.Remainder(19, 4);
            Assert.Equal( 3, res);    
        }
    }
}