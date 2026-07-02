public class Solution {
    public bool IsPalindrome(string s) {
        
        StringBuilder sb = new StringBuilder();

        for(int i=0;i<s.Length;i++){
            if(s[i] == ' ') continue;
            else if(char.IsLetter(s[i]) || char.IsDigit(s[i])){
                    sb.Append(s[i]);
            }
        }

        var res  = sb.ToString().ToLower(); // converts the string to lower case
        int left=0; int right = res.Length -1;
        while(left < right){
            if(res[left] ==  res[right]){
                left++;
                right--;
            }

            else{
                return false;
            }
        }
        return true;
    }
}
