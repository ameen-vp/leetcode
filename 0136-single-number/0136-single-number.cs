public class Solution {
    public int SingleNumber(int[] nums) {
        int result = nums.GroupBy(x => x).Where(k => k.Count() == 1)
        .Select(k =>k.Key).First();
            return result ;
    } 
 
}