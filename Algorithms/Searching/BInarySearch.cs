namespace DSA.Algorithms.Searching
{
  public static class BinarySearch
  {
    public static int Search( IEnumerable<int> collection, int target)
    {
      var list = collection.ToList();
      int left = 0;
      int right = list.Count - 1;
      while (left <= right)
      {
        int mid  = (right-left)/2 + left;
        if(list[mid] == target)
        {
          return mid;
        }
        else if(list[mid] < target)
        {
          left = mid +1;
        }
        else
        {
          right = mid -1;
        }
      }
    
    return left;
    }
  }
}