namespace TestDateFormat;

public class DateVerify
{
  public static bool IsValid(int year, int month, int day)
  {

    try
    {
      DateTime date = new DateTime(year, month, day);
      return true;
    }
    catch (ArgumentOutOfRangeException)
    {
      return false;
    }
  }

}