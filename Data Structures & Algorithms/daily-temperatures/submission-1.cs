public class Solution {
    public int[] DailyTemperatures(int[] temp) {
        int[] op = new int[temp.Length];
        Stack<(int value, int index)> stack = new();
        for(int i =0;i<temp.Length;i++){
            while(stack.Count>0 && stack.Peek().value<temp[i]){
                var (x,y) = stack.Pop();
                op[y]=i-y;
            }
            stack.Push((temp[i], i));    
            
        }
        return op;
    }
}
