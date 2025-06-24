public class Solution {
    public bool DivideArray(int[] nums) {
        return nums.GroupBy(x =>x).All(j =>j.Count() % 2== 0);
    }
}