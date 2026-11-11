public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new();
        foreach(var str in strs){
            sb.Append(str.Length).Append("#").Append(str);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        int i=0;
        List<string> ls = new();
        while(i<s.Length){
            var hashIndex = s.IndexOf("#",i);
            int len = int.Parse(s.Substring(i,hashIndex-i));
            ls.Add(s.Substring(hashIndex+1,len));
            i = hashIndex +1+ len;
        }
        return ls;
   }
}
