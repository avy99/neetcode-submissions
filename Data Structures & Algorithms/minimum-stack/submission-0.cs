public class MinStack {

    private Stack<int> stack;

    public MinStack() {
        stack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        if(stack.Count>0) return stack.Peek();
        return 0;
    }
    
    public int GetMin() {
        if (stack.Count > 0) return stack.Min();
        return 0;
    }
}
