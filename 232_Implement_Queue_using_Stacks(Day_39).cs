public class MyQueue {
    private Stack<int> stack_in;
    private Stack<int> stack_out;

    public MyQueue() {
        stack_in = new Stack<int>();
        stack_out = new Stack<int>();
    }
    
    public void Push(int x) {
        stack_in.Push(x);
    }
    
    public int Pop() {
        if (stack_out.Count == 0) {
            // Transfer elements from stack_in to stack_out, reversing the order
            while (stack_in.Count > 0) {
                stack_out.Push(stack_in.Pop());
            }
        }
        if (stack_out.Count > 0) {
            return stack_out.Pop();  // Pop from stack_out
        }
        throw new InvalidOperationException("Queue is empty");
    }
    
    public int Peek() {
        if (stack_out.Count == 0) {
            // Transfer elements from stack_in to stack_out, reversing the order
            while (stack_in.Count > 0) {
                stack_out.Push(stack_in.Pop());
            }
        }
        if (stack_out.Count > 0) {
            return stack_out.Peek();  // Peek the top of stack_out
        }
        throw new InvalidOperationException("Queue is empty");
    }
    
    public bool Empty() {
        return stack_in.Count == 0 && stack_out.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */