public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new ();
        int l=0,r=0;
        int maxcount=0;
        while(r<s.Length){
            
            while(set.Contains(s[r])){
                set.Remove(s[l]);
                l++;
            }           
            
            set.Add(s[r]);
            maxcount = Math.Max(set.Count, maxcount);
            r++;
            
        }
        return maxcount;
    }
}
