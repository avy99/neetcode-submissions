public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] arr = new int[26];
        int l=0, r=0, freq=0, max=0;
        while(r<s.Length){
            arr[s[r]-'A']+=1;
            freq= Math.Max(freq, arr[s[r]-'A']);
            if(r-l+1 - freq >k){
                arr[s[l]-'A']-=1;
                l++;
            }
            max = Math.Max(max, r-l+1);
            r++;
        }
        return max;
    }
}
