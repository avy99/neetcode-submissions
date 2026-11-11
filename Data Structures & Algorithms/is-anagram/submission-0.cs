public class Solution {
    public bool IsAnagram(string s, string t) {
        int n=s.Length;
        if(n !=t.Length) return false; 
        Dictionary<Char,int> a=new();
        Dictionary<Char,int> b=new();   
        for(int i=0;i<n;i++){
            if(a.ContainsKey(s[i]))
                a[s[i]]++;
            else
                a.Add(s[i],0);
            
            if(b.ContainsKey(t[i]))
                b[t[i]]++;
            else
                b.Add(t[i],0);       
                  
        }
        if(a.Count!=b.Count) return false;
        foreach(var key in a.Keys){
            if(!b.ContainsKey(key)) return false;
            if(a[key]!=b[key]) return false;
        }
        return true;
    }
}
