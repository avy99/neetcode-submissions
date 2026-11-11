public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
        var longest =0;
        foreach(int a in nums){
            if(!set.Contains(a-1)){
                int count =1;
                while(set.Contains(a+count)){
                    count++;
                }
                longest = Math.Max(count,longest);
            }
        }
        return longest;
    }
}
