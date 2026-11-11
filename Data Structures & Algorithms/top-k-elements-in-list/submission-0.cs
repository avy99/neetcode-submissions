public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> store=new();
        int[] res=new int[k];
        foreach( var item in nums){
            if(!store.ContainsKey(item))
                store[item]=0;
            store[item]+=1;
        }
        var sorted=store.OrderByDescending(k=>k.Value).Take(k);
        
        int i=0;
        foreach(var item in sorted){
            res[i]=item.Key;
            i++;
        }
        return res;
    }
}
