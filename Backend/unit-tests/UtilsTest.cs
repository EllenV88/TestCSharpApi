using Xunit;
namespace WebApp;
public class UtilsTest
{
    [Fact]
    public void TestSumInt()
    { 
        Assert.Equal(12, Utils.SumInts(7, 5));
        Assert.Equal(-3, Utils.SumInts(6, -9));
    }

    [Fact]
    public void TestCreateMockUsers() 
    {
    }
}