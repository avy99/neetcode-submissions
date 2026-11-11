public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length>s2.Length){
            return false;
        }
        int matches = 0;
        int left = 0;
        int[] s1Count = new int[26];
        int[] s2Count = new int[26];

        for(int i=0;i<s1.Length;i++){
            s1Count[s1[i]-'a']++;
            s2Count[s2[i]-'a']++;
        }

        for(int i =0;i<26;i++){
            if(s1Count[i]==s2Count[i])
                matches++;
        }

        

        for(int i =s1.Length; i<s2.Length; i++){
            if(matches ==26){return true;}
            int index = s2[i]-'a';
            s2Count[index]++;
            if(s1Count[index]==s2Count[index])
                matches++;
            else if(s1Count[index] + 1 ==s2Count[index])
                matches--;
            
                
            index = s2[left]-'a';
            s2Count[index]--;
            if(s1Count[index]==s2Count[index])
                matches++;
            else if(s1Count[index] - 1 ==s2Count[index])
                matches--;

            left++;
        }
        return matches == 26;
    }
}
