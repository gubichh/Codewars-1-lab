using System;

public class Kata
{
  public static int SquareDigits(int n)
  {
    if(n == 0){
      return 0;
    }
    String str="";
   while(n>0){
     int digit=n%10;
     str=Convert.ToString((digit*digit)) + str;
     n/=10;
   }
    return Convert.ToInt32(str);
    }
}