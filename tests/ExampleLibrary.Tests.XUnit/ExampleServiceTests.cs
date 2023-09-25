namespace ExampleLibrary.Tests.XUnit;
public class ExampleServiceTests
{
    private readonly ExampleService _sut = new();
    private readonly ITestOutputHelper _output;

    public ExampleServiceTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void Guid_IsNotEmpty()
    {
        var id = _sut.Id;

        Assert.NotEqual(id, Guid.Empty);

        _output.WriteLine(id.ToString());
    }

    [Fact]
    public void Guid_IsNotEmpty2()
    {
        var id = _sut.Id;

        Assert.NotEqual(id, Guid.Empty);

        _output.WriteLine(id.ToString());
    }
}