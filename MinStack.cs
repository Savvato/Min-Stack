namespace MinStack
{
    using System.Collections.Generic;
    using System.Linq;

    public class MinStack
    {
        private long min = long.MaxValue;

        private Stack<long> stack = new Stack<long>();        

        public void Push(long element)
        {
            stack.Push(element);

            if (element < min) 
                min = element;
        }

        public long Pop()
        {
            long element = stack.Pop();
            if (element > min) return element;

            min = stack.Min();

            return element;
        }

        public long Top()
        {
            return stack.Peek();
        }

        public long GetMin()
        {
            return min;
        }
    }
}