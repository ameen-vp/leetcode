public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var res = nums.GroupBy(x =>x)
                       .SelectMany(x => x.Take(2))
                       .ToArray();
            for(int i = 1;i < res.Length;i++){
                nums[i] = res[i];
            }
            return res.Length;
    }
}