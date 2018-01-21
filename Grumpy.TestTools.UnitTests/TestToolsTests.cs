using Xunit;

namespace Grumpy.TestTools.UnitTests
{
    public class TestToolsTests
    {
        [Fact]
        public void CanTest()
        {
            TestTools.Dummy();
        }
    }
}