using System;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            RectCl r = new RectCl();
            int res = r.Area(2, 3);
            Assert.Equal(6, res);            
        }
    }
}
