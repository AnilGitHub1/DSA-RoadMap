namespace DSA.Algorithms.Matrix
{
  public static class PrefixSumAlgo
  {
    /// <summary>
    /// Time O(n*m) Space O(n*m)
    /// </summary>
    /// <param name="A"></param>
    /// <returns></returns>
    public static int[][] FindPreFixSum(int[][] A)
    {
      int n = A.Length;
      int m = A[0].Length;

      var p = new int[n][]; // space O(n*m)
      
      for(int i = 0; i < n; i++)
      {
        p[i] = new int[m]; // initialize each row
        for(int j = 0; j < m; j++)        
        {
          int PiJ = i > 0 ? p[i-1][j]: 0;
          int PJi = j > 0 ? p[i][j-1]: 0;
          int Pij = i > 0 && j > 0 ? p[i-1][j-1]: 0;
          p[i][j] = A[i][j] + PiJ + PJi - Pij;
        }
      }
      return p;
    }
  }
}