namespace ExampleLibrary.Tests.NUnit;
public class ExampleServiceTests
{
    private readonly ExampleService _sut = new();


    [Test]
    public void Guid_IsNotEmpty()
    {
        var id = _sut.Id;

        Assert.That(id, Is.Not.EqualTo(Guid.Empty));

        TestContext.Out.WriteLine(id);
    }

    [Test]
    public void Guid_IsNotEmpty2()
    {
        var id = _sut.Id;

        Assert.That(id, Is.Not.EqualTo(Guid.Empty));

        TestContext.Out.WriteLine(id);
    }


}