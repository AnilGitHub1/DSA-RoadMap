namespace DSA.Algorithms.Math
{
  /// <summary>
  /// Time O(M) Space O(1)
  /// 13 in binary is 1101
  /// a^13 = a^(1*8 + 1*4 + 0*2 + 1*1) = a^8 * a^4 * a^1
  /// Notes:
  /// - Handles only non-negative exponents (M >= 0).
  /// - Uses modulo at every multiplication to prevent overflow.
  /// - Casting to long prevents integer overflow before modulo.
  /// </summary>
  public static class ModPowAlgo
  {
    public const int Mod = 1000007;
    public static int ModPow(int A, int M)
    {
      int result = 1;       // start with 1
      A %= Mod;           // reduce A modulo Mod
      M = System.Math.Abs(M);
      while(M > 0)
      {
        if((M & 1) == 1)
        {
            result = (int)((long)result * A % Mod); // multiply modulo
        }
        A = (int)((long)A * A % Mod);              // square A modulo
        M >>= 1;                                    // divide M by 2
      }
      return result;
    }
  }
}