public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        HashSet<int> store= new HashSet<int>();
        for(int i=0;i<nums.Length;i++){
            if(!store.Contains(target-nums[i])) 
                store.Add(nums[i]);
            else{
                for(int j=0;j<i;j++){
                    if(nums[j]==(target-nums[i]))
                        return new int[]{j,i};
                }
            }
        }
        return new int[2];
    }
}
