public class Solution {
    public int[] ApplyOperations(int[] nums) {
        int n = nums.Length;

        
        for (int i = 0; i < n - 1; i++) {
            if (nums[i] == nums[i + 1]) {
                nums[i] *= 2;
                nums[i + 1] = 0;
            }
        }

        
        List<int> result = new List<int>();

        
        foreach (int num in nums) {
            if (num != 0) {
                result.Add(num);
            }
        }


        while (result.Count < n) {
            result.Add(0);
        }

        return result.ToArray();
    }
}
