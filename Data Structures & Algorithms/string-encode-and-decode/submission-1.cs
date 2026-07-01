public class Solution {

    public string Encode(IList<string> strs) {

         StringBuilder sb = new StringBuilder();
        foreach(var str in strs){
            byte[] textBytes = Encoding.UTF8.GetBytes(str);
            string base64String = Convert.ToBase64String(textBytes);
            sb.Append(base64String);
            sb.Append("#");
        }
        Console.WriteLine(sb.ToString());
        return sb.ToString();
    }

    public List<string> Decode(string s) {

       List<string> res = new List<string>();

        string[] parts = s.Split('#'); // no RemoveEmptyEntries

        // last element is always "" because the string ends in a trailing '#'
        for (int i = 0; i < parts.Length - 1; i++) {
            byte[] decodedBytes = Convert.FromBase64String(parts[i]);
            res.Add(Encoding.UTF8.GetString(decodedBytes));
        }

        return res;
   }
}
