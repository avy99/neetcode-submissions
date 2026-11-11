public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int res =0;
        int l =0;
        HashSet<char> col =new ();
        for(int i=0;i<s.Length;i++){
            while(col.Contains(s[i])){
                col.Remove(s[l]);
                l++;
            }
            col.Add(s[i]);
            res =Math.Max(res,i-l+1);    
        }
        return res;
    }
}
