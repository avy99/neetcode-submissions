public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hs=new();
        for(int i=0;i<nums.Length;i++){
            if(hs.Contains(nums[i]))
                return true;
            else
                hs.Add(nums[i]);
        }
        return false;
    }
}
