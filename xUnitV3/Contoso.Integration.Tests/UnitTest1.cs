using Xunit;

namespace Contoso.Application;

public class IntegrationTest
{
    [Fact]
    public void Test1()
    {
        throw new Exception("this test shouldn't run");
    }
}