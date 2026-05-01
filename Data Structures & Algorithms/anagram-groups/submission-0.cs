public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if (strs.Length == 1) {
            return new List<List<string>> { new List<string> { strs[0] } };
        }

        Dictionary<string, List<string>> responseDict = new();
        foreach (string str in strs) {
            string anagramDict = GetAnagramDictionary(str);
            if (responseDict.ContainsKey(anagramDict)) {
                var lst = responseDict[anagramDict];
                lst.Add(str);
            } else {
                responseDict[anagramDict] = new List<string> { str };
            }
        }

        return responseDict.Values.ToList();
    }

    private string GetAnagramDictionary(string str) {
        int[] anagramDict = new int[26];

        foreach (char c in str) {
            anagramDict[c - 'a'] += 1;
        }

        return string.Join(',', anagramDict);
    }
}
