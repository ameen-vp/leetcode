public class Solution {
    public int[] SortArray(int[] nums) {
      var sorting =  nums.OrderBy(x => x).ToArray();
      return sorting ;
    }
}