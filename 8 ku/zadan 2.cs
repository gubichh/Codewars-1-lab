using System;

public static class Kata
{
  public static int Enough(int cap, int on, int wait)
  {
    if(wait > (cap - on)){

      return wait - (cap - on);

    }else{

      return 0;
      
    }
  }
}