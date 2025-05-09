public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        return names.Zip(heights,(name,height) => new {name,height})
                    .OrderByDescending(x => x.height)
                    .Select(n => n.name)
                    .ToArray();
    }
}