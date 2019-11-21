using XRemover.App;
using Xunit;

namespace xRemover
{
    public class StringFilterTest
    {
        [Fact]
        public void ShouldRemoveXsOfStringMaintainingFirstAndLastX()
        {
            StringFilter firstString = new StringFilter("xxHxix");
            firstString.removeXs();

            StringFilter secondString = new StringFilter("abcd");
            secondString.removeXs();

            StringFilter thirdString = new StringFilter("xabcdx");
            thirdString.removeXs();

            StringFilter fourthString = new StringFilter("");
            fourthString.removeXs();

            StringFilter fiftyString = new StringFilter("x");
            fiftyString.removeXs();

            
            Assert.Equal("abcd", secondString.GetString());
            Assert.Equal("xabcdx", thirdString.GetString());
            Assert.Equal("", fourthString.GetString());
            Assert.Equal("x", fiftyString.GetString());
            Assert.Equal("xHix", firstString.GetString());
        }
    }
}