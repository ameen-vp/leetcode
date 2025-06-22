public class Solution {
    public int DifferenceOfSums(int n, int m) {
      var numbers = Enumerable.Range(1,n);
      int num1 = numbers.Where(x => x % m != 0).Sum();
      int num2 = numbers.Where(x => x % m == 0).Sum();
      return num1 - num2;
    }
}