using System;
using Xunit;

namespace DevOpsDemo1.Tests
{
    public class UnitTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
        [Fact]
        public void Test2()
        {
            Assert.True(true);
        }
        [Fact]
        public void Test3()
        {
            Assert.True(false);
        }
        [Fact]
        public void Test4()
        {
            Assert.True(true);
        }
    }
}
