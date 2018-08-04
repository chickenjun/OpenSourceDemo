using System;
using Xunit;

namespace OpenSourceDemo.Test
{
    public class MyMathTest
    {
        [Theory(DisplayName = "Add Test")]
        [InlineData(1, 2)]
        public void AddTest(int a, int b)
        {
            int c = MyMath.Add(a, b);
            Assert.Equal<int>(a + b, c);
        }
    }
}
