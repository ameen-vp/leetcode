public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var dis = nums.Distinct().ToArray();

        for(int i = 0;i < dis.Length;i++){
             nums[i] = dis[i];
        }
        return dis.Length;
    }
}