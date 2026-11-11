public class Solution {
    public int CharacterReplacement(string s, int k) {        
        int l=0;
        int count = 0;
        int freq =0;
        int[] arr = new int[26];
        for(int r = 0;r<s.Length;r++){
            arr[s[r]-'A']++;
            freq = Math.Max(freq, arr[s[r]-'A']);
            if(r-l+1-freq > k){
                arr[s[l]-'A']--;
                l++;
            }
            count = Math.Max(r-l+1,count);
        }
        return count;
    }
}
