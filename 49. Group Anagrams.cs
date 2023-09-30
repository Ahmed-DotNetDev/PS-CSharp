public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
            Dictionary<string, IList<string>> anagrams = new Dictionary<string, IList<string>>();
            foreach (var str in strs)
            {
                var SortStr = string.Concat(str.OrderBy(x => x));
                if (!anagrams.ContainsKey(SortStr))
                {
                    anagrams[SortStr] = new List<string>();
                }
                anagrams[SortStr].Add(str);
            }
            return anagrams.Values.ToList();
    }
}