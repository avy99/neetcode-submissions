public class Solution {
    public List<List<string>> GroupAnagrams(string[] test) {
        Dictionary<string,List<string>> result=new();
        foreach(var item in test){
            int[] store=new int[26];
            for(int i=0;i<item.Length;i++){
                store[item[i]-'a']++;
            }
            var key=string.Join(",",store);
            if(!result.ContainsKey(key))
                result[key]=new List<string>();
            result[key].Add(item);
        }
        return new List<List<string>>(result.Values);
    }    
}
