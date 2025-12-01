namespace DSA.Algorithms.Math
{
  public static class Primes
  {
    /// <summary>
    /// Returns an array where primes[i] == 0 indicates i is prime, 1 indicates non-prime
    /// Time O(n log log n), Space O(n)
    /// </summary>
    /// <param name="A"></param>
    /// <returns></returns>
    public static int[] FindPrimes(int A)
    {
      // 0 means prime, 1 means not prime, initially all are primes
      var primes = new int[A+1]; //Space O(n)
      primes[0] = 1;// 0 is not a prime
      primes[1] = 1;// 1 is not a prime
      for(int i = 2; i*i <= A; i++)
      {
        if (primes[i] == 1) continue; // skip non-primes

        for (int j = i * i; j <= A; j += i)
        {
            primes[j] = 1; // mark multiples as non-prime
        }
      }
      
      return primes;
    }
  }
}