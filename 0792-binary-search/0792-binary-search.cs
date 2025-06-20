public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length;
        int min = -1;
            for(int i =0 ; i<n;i++){
                if(nums[i] == target){
                    return i;
                }
            }
            return min;
    }
}