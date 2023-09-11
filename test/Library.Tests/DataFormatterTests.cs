using TestDateFormat;
namespace Library.Tests;

public class DataFormatterTests
{

    [Test]
    public void TestChangeFormat()
    {
        string date = "01/01/2021";
        string expected = "2021-1-1";
        string actual = DateFormatter.ChangeFormat(date);
        Assert.That(actual, Is.EqualTo(expected));
    }
}

