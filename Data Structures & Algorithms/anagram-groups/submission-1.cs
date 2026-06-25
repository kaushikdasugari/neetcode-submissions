public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, List<string>> res = new Dictionary<string, List<string>>();

        //Calculate frequencies of each string in an array
        //lets loop over the string array and the comapre  for the frequencies
        for(int i=0;i<strs.Length;i++){
           var freq = Calculate_frequeny(strs[i]);
           var  key = DictToKey(freq);

            if(res.ContainsKey(key))
                res[key].Add(strs[i]);
            else
                res[key] = new List<string> {strs[i]};
        }
        return res.Values.ToList();
    }

   //Calculate frequency of a string
   public Dictionary<char,int> Calculate_frequeny(string s){
    Dictionary<char,int> freq = new Dictionary<char,int>();
    //loop over for frequency
    for(int i=0;i<s.Length;i++){
        if(freq.ContainsKey(s[i])){
            freq[s[i]]++;
        }
        else{
            freq[s[i]] = 1;
        }
    }

    return freq; // return string frequency
   }
    // create a sequence of frequencies 
   public string DictToKey(Dictionary<char,int> freq){

        StringBuilder str = new StringBuilder();

        for(char c = 'a';c<='z';c++){
            if(freq.ContainsKey(c)){
                str.Append(c);
                str.Append(freq[c]);
            }

            else{
                str.Append(c);
                str.Append(0);
            }
        }
        return str.ToString();

   }
}
