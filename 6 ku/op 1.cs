using System;

public static class Kata 
{
    public static string ExpandedForm(long num) 
    {
       string stroka = "";
      string num1 = Convert.ToString(num);
      for(int i = 0; i < num1.Length; i++){
        string a = Convert.ToString(Convert.ToDouble(Convert.ToString(num1[i])) * Math.Pow(10, num1.Length - i - 1));
        if(a == "0"){
          continue;
        }
      stroka += a + " ";
      }
      return stroka.Substring(0, stroka.Length - 1).Replace(" ", " + ");
    }
}