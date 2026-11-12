public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length>s2.Length){
            return false;
        }
        var basic = getkeys(s1);

        int l=0,r=s1.Length-1;
        while(r<s2.Length){
            string t = getkeys(s2.Substring(l,s1.Length));
            if(t.Equals(basic)) return true;
            l++;
            r++;
        }

        return false;
    }

    private string getkeys(string s){
        int[] arr =new int[26];
        for(int i=0;i<s.Length;i++){
            arr[s[i]-'a']+=1;
        }
        return string.Join('#',arr);
    }
}
