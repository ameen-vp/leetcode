public class Solution {
    public int Reverse(int x) {
         if (x == int.MinValue) return 0;
        bool hy = x < 0;
        string rev = new string( Math.Abs(x)
                                .ToString().Reverse().ToArray());
        try{
        int num = int.Parse(rev);
        return hy ? -num : num;
        }catch{
               return 0;
        }
    }
}