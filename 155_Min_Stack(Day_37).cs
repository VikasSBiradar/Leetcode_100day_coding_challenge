public class MinStack {
    private Stack<int> st;
    private Stack<int> min;

    public MinStack() {
        st = new Stack<int>();
        min = new Stack<int>();
        
    }
    
    public void Push(int val) {
        if(st.Count == 0 || min.Peek() >=val){
            min.Push(val);
        }
        st.Push(val);
    }
    
    public void Pop() {
        int element1 = st.Pop();
        int element2 = min.Peek();

        if(element1 == element2){
            min.Pop();
        }
        
    }
    
    public int Top() {
        return st.Peek();
    }
    
    public int GetMin() {
        return min.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */