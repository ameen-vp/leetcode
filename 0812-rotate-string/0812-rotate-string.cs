public class Solution {
    public bool RotateString(string s, string goal) {
      if(s.Length != goal.Length)
        return false ;
     
      string add = s + s ;
      return add.Contains(goal);
    }
}