using System;
using System.Linq;
public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
       int n = grid.Length;
       int size = n * n;

       var gro = grid.SelectMany(x => x);

       int rep = gro.GroupBy(x => x)
                    .Where(x =>x.Count() == 2)
                    .Select(x =>x.Key)
                    .First();
        int result = Enumerable.Range(1,size)
                                .Except(gro)
                                .First();
        return new int[] { rep,result};
    }
}