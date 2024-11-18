public class Number
{
  public static int DigitalRoot(long n)
  {
    return (int)(n == 0? 0 : (n - 1) % 9 + 1);
  }
}