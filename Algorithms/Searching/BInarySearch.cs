namespace DSA.Algorithms.Searching
{
  public static class BinarySearch
  {
    /// <summary>
    /// Time O(log(n)) Space O(1)
    /// returns value from 0 to n, where n is no of elements in the list
    /// </summary>
    /// <param name="collection"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static int Search( IEnumerable<int> collection, int target)
    {
      var list = collection.ToList(); // Time O(n) Space O(n)
      int left = 0;
      int right = list.Count - 1;
      while (left <= right)
      {
        int mid  = (right-left)/2 + left;
        if(list[mid] == target) return mid;
        
        if(list[mid] < target)
        {
          left = mid +1;
        }
        else
        {
          right = mid -1;
        }
      }
    
    return left; //insert index
    }
  }
}