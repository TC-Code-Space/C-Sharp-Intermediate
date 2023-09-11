namespace PsuedoStack
{
    public class Stack
    {
        private List<object> _stack = new();

        public void Push(object obj)
        {
            _stack.Insert(0, obj);
        }

        public object Pop()
        {
            var temp = _stack[0];
            _stack.RemoveAt(0);
            return temp;
        }

        public void Clear()
        {
            if( _stack.Count > 0 )
            {
                _stack.Clear();
                Console.WriteLine("Stack cleared.");
            }
            else
            {
                throw new InvalidOperationException("Stack already empty. Cannot clear.");
            }
        }

    }
}
