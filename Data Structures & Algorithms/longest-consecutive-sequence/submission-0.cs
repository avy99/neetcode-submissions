public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> res=new(nums);
        int longest=0;
        foreach(int n in res){
            if(!res.Contains(n-1)){
                int count=1;
                while(res.Contains(n+count)){
                    count++;
                }
                longest=Math.Max(count,longest);
            }
        }
        return longest;
    }
}
