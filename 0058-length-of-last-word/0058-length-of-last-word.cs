public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        string res = s.Split(" ").Last();
        return res.Length ;
        
    }
}