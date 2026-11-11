public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> op = new ();
        int n = nums.Length;
        Array.Sort(nums);
        for(int i =0;i<n-2;i++){
            if(nums[i]>0) break;
            if(i>0 && nums[i]==nums[i-1]) continue;
            int target = -nums[i];
            int l =i+1, r = n-1;
            while(l<r){
                if(nums[l] +nums[r] == target) {
                    op.Add(new List<int>(){nums[i],nums[l],nums[r]});
                    l++;
                    r--;
                    while(l<r && nums[l]==nums[l-1]){
                        l++;
                    }
                }
                else if(nums[l] + nums[r] < target) l++;
                else r--;
            }
        }
        return op;
    }
}
