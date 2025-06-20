// Using System;
// Using Linq;
public class Solution {
    public int MaximumCount(int[] nums) {
       int pos = nums.Count(x => x > 0);
       int neg = nums.Count(z => z < 0);
       return Math.Max(pos,neg);
             }
       }
    