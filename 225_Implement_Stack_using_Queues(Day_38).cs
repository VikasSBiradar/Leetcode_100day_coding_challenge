public class MyStack {
    private Queue<int> mainq;
    private Queue<int> helperq;

    public MyStack() {
        mainq = new Queue<int>();
        helperq = new Queue<int>();
    }
    
    public void Push(int x) {
        helperq.Enqueue(x);
        while(mainq.Count > 0){
            helperq.Enqueue(mainq.Dequeue());
        }
        Queue<int> temp = mainq;
        mainq = helperq;
        helperq = temp;
    }
    
    public int Pop() {
        if(mainq.Count == 0){
            throw new InvalidOperationException("Stack is Empty");
        }
        return mainq.Dequeue();
    }
    
    public int Top() {
        if (mainq.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        return mainq.Peek();
    }
    
    public bool Empty() {
        return mainq.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */