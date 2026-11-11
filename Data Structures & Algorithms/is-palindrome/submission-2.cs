public class Solution {
    public bool IsPalindrome(string str) {
        string s = str.ToLower();
        int l=0;
        int r= s.Length-1;
        while(r>l)
        {
            while(l<r && !(char.IsLetterOrDigit(s[l]))){ l++;}
            while(r>l && !(char.IsLetterOrDigit(s[r]))) {r--;}
           
            if(s[l] != s[r] )
                return false;          
            
            l++;
            r--;
        }
        return true;
    }
}
