using System;
using System.Linq;

public class Solution {
    public int[] ApplyOperations(int[] nums) {
        
        for (int i = 0; i < nums.Length - 1; i++) {
            if (nums[i] == nums[i + 1]) {
                nums[i] *= 2;
                nums[i + 1] = 0;
            }
        }

      
        var check = nums.Where(x => x != 0).ToList();

        
        while (check.Count < nums.Length) {
            check.Add(0);
        }

        return check.ToArray();
    }
}
