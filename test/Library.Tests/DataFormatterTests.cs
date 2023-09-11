using TestDateFormat;
namespace Library.Tests;

public class DataFormatterTests
{

    [Test]
    public void CorrectDateFormat()
    {
        string date = "28/02/2021";
        string expected = "2021-2-28";
        string actual = DateFormatter.ChangeFormat(date);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void IncorrectDateFormat()
    {
        string date = "02/28/2021";
        Assert.Throws<ArgumentException>(() =>
        {
            string actual = DateFormatter.ChangeFormat(date);
        });
    }

    [Test]
    public void VoidDate()
    {
        string date = "";
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            string actual = DateFormatter.ChangeFormat(date);
        });
    }

}




