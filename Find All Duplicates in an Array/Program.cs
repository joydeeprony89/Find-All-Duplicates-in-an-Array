using System;
using System.Collections.Generic;

namespace Find_All_Duplicates_in_an_Array
{
  class Program
  {
    static void Main(string[] args)
    {
      // contains no's from 1 to n. 1 to 10 for below input
      var nums = new int[] { 10, 2, 5, 10, 9, 1, 1, 4, 3, 7 };
      Solution s = new Solution();
      var answer = s.FindDuplicates(nums);
      foreach (int i in answer)
        Console.WriteLine(i);
    }
  }

  public class Solution
  {
    public IList<int> FindDuplicates(int[] nums)
    {
      // when find a number i, flip the number at position i-1 to negative. 
      // if the number at position i-1 is already negative, i is the number that occurs twice.3
      var result = new List<int>();
      for (int i = 0; i < nums.Length; ++i)
      {
        int n = nums[i];
        int index = Math.Abs(n) - 1;
        if (nums[index] < 0)
        {
          result.Add(Math.Abs(n));
        }
        // if a no is duplicate then first time when found we set the (that no - 1) index to negetive, now again the same no found, then (same no - 1) would give us the same index
        // and in that index will find negetive value, which tells a dplicate found
        nums[index] = -nums[index];
      }

      return result;
    }
  }
}
