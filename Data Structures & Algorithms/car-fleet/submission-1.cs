public class Solution {
    public int CarFleet(int t, int[] p, int[] s) {
        List<(int s, int p)> ls = new();
        for(int i=0;i<s.Length;i++){
            ls.Add((s[i],p[i]));
        }
        ls.Sort((a,b)=>b.p.CompareTo(a.p));

        Stack<double> stack = new();
        foreach( var x in ls){
            var time = (double) (t-x.p)/x.s;
            if(stack.Count>=1 && stack.Peek()>=time){
                continue;
            }
            else{
                stack.Push(time);
            }
        }
        return stack.Count;
    }
}
