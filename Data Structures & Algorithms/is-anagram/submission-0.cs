public class Solution {
    public bool IsAnagram(string s, string t) {
        int sLength = s.Length;
        int tLength = t.Length;
        Dictionary<int,int> seenS = new();
        Dictionary<int,int> seenT = new();

        if(sLength == 0 && tLength == 0)
        {
            return true;
        }

        if(sLength != tLength)
        {
            return false;
        }

        if(sLength == 1)
        {
            return s[0] == t[0];
        }

        for(int i =0; i<sLength; i++)
        {
            if(seenS.ContainsKey(s[i]))
            {
                seenS[s[i]]++;
            }
            else
            {
                seenS[s[i]] = 1;
            }

            if(seenT.ContainsKey(t[i]))
            {
                seenT[t[i]]++;
            }
            else
            {
                seenT[t[i]] = 1;
            }
        }

        foreach(var key in seenS.Keys)
        {
            if(!seenT.ContainsKey(key))
            {
                return false;
            }
            else
            {
                if(seenT[key] != seenS[key])
                {
                    return false;
                }
            } 
        }
        return true;
    }
}
