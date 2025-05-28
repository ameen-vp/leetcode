public class Solution {
    public int MostWordsFound(string[] sentences) {
        
        return sentences.Max(x => x.Split(" ").Length);
    }
}