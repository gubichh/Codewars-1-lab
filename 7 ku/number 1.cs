public class Kata
{
  public static double[] Multiples(int m, double n)
  {
    double[] mass = new double[m];
    for(int i = 0; i < m; i++){
      mass[i] = (i + 1) * n;
    }
    return mass;
  }
}