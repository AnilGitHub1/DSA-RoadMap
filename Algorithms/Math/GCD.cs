using System.Runtime.CompilerServices;

namespace DSA.Algorithms.Math
{
  /// <summary>
  /// Time O(log(n)) Space O(1) 
  /// </summary>
  public static class GCD
  {
    public static int FindGCD(int A, int B)
    {
      A = System.Math.Abs(A);
      B = System.Math.Abs(B);
      if(A == 0 && B ==0 ) return 0;
      if(A ==0 || B == 0) return A+B;
      while(B != 0)
      {
        int temp = B;
        B = A%B;
        A = temp;
      }
      return A;
    }
  }
}
