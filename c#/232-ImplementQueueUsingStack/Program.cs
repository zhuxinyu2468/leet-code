namespace _232_ImplementQueueUsingStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue obj = new MyQueue();
            obj.Push(1);
            obj.Push(2);
            obj.Peek();
            obj.Pop();
            obj.Empty();
            Console.WriteLine(obj);
        }
    }
}

public class MyQueue
{
    Stack<int> data = new Stack<int>();
    public MyQueue()
    {

    }

    public void Push(int x)
    {
        Stack<int> reverse = new Stack<int>();
        while (data.Count > 0)
        {
            reverse.Push(data.Pop());
        }
        data.Push(x);
        while (reverse.Count > 0)
        {
            data.Push(reverse.Pop());
        }
    }

    public int Pop()
    {
        return data.Pop();
    }

    public int Peek()
    {
        return data.Peek();
    }

    public bool Empty()
    {
        return data.Count == 0;
    }
}
