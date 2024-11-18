using System;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        string stroka = "";
      for(int i = 0; i < str.Length; i++){
        if(str[i] == 'e' || str[i] == 'E' || str[i] == 'a' || str[i] == 'A' || str[i] == 'o' || str[i] == 'O' || str[i] == 'u' || str[i] == 'U' || str[i] == 'i' || str[i] == 'I'){
          continue;
        }else{
          stroka += str[i];
        }
      }
      return stroka;
    }
}