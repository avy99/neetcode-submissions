public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> store = new();
        for(int i=0;i<nums.Length;i++){
            if(!store.ContainsKey(nums[i])){
                store.Add(nums[i],0);
            }
            store[nums[i]]+=1;
        }
        return store.OrderByDescending(x=>x.Value).Take(k).Select(k=>k.Key).ToArray();
    }
}
