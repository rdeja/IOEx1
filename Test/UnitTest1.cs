using System;
using Xunit;
using Rect;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Rect r = new Rect();
            int res = r.Area(2, 3);
            Assert.Equal(5, res);            
        }
    }
}
