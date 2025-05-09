public class Solution {
    public int[] SingleNumber(int[] nums) {
        int [] Result = nums.GroupBy(o => o)
                            .Where(x => x.Count() == 1)
                            .Select(x => x.Key).ToArray();
            return  Result;
    
    }
}