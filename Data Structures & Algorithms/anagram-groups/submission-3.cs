public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> store = new();

        for(int i =0;i<strs.Length;i++){
            var ip = getKey(strs[i]);
            if(!store.ContainsKey(ip)){
                store.Add(ip,new List<string>());
            }
            var li = store[ip];
            li.Add(strs[i]);
        }

        List<List<string>> op = store.Values.OrderBy(x=>x.Count).ToList();       
        return op;
        
    }

    private string getKey(string str){
        int[] arr = new int[26]; 
        for(int i =0; i<str.Length; i++){
            arr[str[i]-'a'] +=1;
        }
        return string.Join("#",arr);
    }
}
