namespace TestProject1;

public class UnitTest1
{
    public UnitTest1()
    {
        UseProjectRelativeDirectory("Snapshots");
    }

    [Theory]
    [InlineData("qwe")]
    [InlineData("qwe1")]
    [InlineData("qwe2")]
    [InlineData("qwe3")]
    public Task Test1(string result)
    {
        var settings = new VerifySettings();
        settings.UseFileName($"UnitTest1_Test1_{result}");
        return Verify(result, settings);
    }

    [Fact]
    public Task Test2()
    {
        return Verify("qwe");
    }
}