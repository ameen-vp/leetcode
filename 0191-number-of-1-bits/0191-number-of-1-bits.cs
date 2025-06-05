public class Solution {
    public int HammingWeight(int n) {
        return Convert.ToString(n, 2).Count(c => c == '1');
    }
}
