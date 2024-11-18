public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {

          object []array1 = new object [arr.Length%2==0? arr.Length/2: (arr.Length+1)/2];
          
          int g = 0;
          
          for(int i=0; i<arr.Length; i++){
            
            if(i%2==0){
              
            array1[g] = arr[i ];
            g++;
            }
          }
          return array1;
        }
    }