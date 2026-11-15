public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new();

        foreach(string c in tokens){
            if(c == "+" || c == "-" ||c == "*" ||c == "/"){
                int a = stack.Pop();
                int b = stack.Pop();
                switch(c){
                    case "+": stack.Push(a+b); break;
                    case "-": stack.Push(b-a); break;
                    case "*": stack.Push(a*b); break;
                    case "/": stack.Push(b/a); break;
                    default: break;
                }
            }
            else{
                stack.Push(int.Parse(c));
            }
        }
        return stack.Pop();
    }
}
