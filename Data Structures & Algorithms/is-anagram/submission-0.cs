
public class Solution {
    public bool IsAnagram(string s, string t) {
        // String S frequency
        Dictionary<char,int> freqS = new();

        //String t frequency
        Dictionary<char,int> freqT = new();

        if(s.Length != t.Length)  return false;

        //loop over string for frequency count
        for(int i=0; i< s.Length;i++){
            if(freqS.ContainsKey(s[i])) freqS[s[i]]++;
            else freqS[s[i]] = 1;

            if(freqT.ContainsKey(t[i])) freqT[t[i]]++;
            else freqT[t[i]] = 1;
        }

        //loop over on either string to check the frequcny
        for(int i=0;i<s.Length;i++){
                if(freqT.ContainsKey(s[i]) && freqS[s[i]] == freqT[s[i]]) continue;
                else return false;
        }

        return true;

    }
}
