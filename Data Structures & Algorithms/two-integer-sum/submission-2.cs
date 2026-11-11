public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> store= new Dictionary<int,int>();
        for(int i =0; i<nums.Length; i++){
            if(store.ContainsKey(target-nums[i])){
                return new int[]{store[target-nums[i]],i};
            }
            store.Add(nums[i],i);
        }
        return new int[2];
    }
}
