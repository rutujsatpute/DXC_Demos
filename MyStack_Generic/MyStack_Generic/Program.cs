namespace MyStack_Generic
{
    class MyStack<T>
    {
        public T[] stack;
        public int count;



        public MyStack()
        {
            stack = new T[0];
            count = 0;
        }



        public void Push(T item)
        {
            Array.Resize(ref stack, count + 1);
            stack[count] = item;
            count++;
        }



        public T Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }



            T item = stack[count - 1];
            Array.Resize(ref stack, count - 1);
            count--;



            return item;
        }



        public int Count
        {
            get { return count; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> obj = new MyStack<int>();
            obj.Pop();
            Console.WriteLine(obj.Pop());
        }
    }
}