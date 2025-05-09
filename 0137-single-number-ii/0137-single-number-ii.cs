public class Solution {
    public int SingleNumber(int[] nums) {
       var result = nums.GroupBy(n => n)
                         .Where(z =>z.Count() == 1)
                          .Select(z =>z.Key)
                          .First();
    return result ; 
    }
}