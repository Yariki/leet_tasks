using System.Collections.Generic;

namespace LeetcodeTasks.MinStack
{
    public class MinStack 
    {

        private readonly Stack<int> _stack = new Stack<int>();
        private readonly Stack<int> _min = new Stack<int>();

        
        public MinStack() 
        {
            
        }
        
        public void Push(int x) 
        {
            _stack.Push(x);
            if(_min.Count == 0)
            {
                _min.Push(x);
            }
            else if(x <= _min.Peek())
            {
                _min.Push(x);
            }       
        }
        
        public void Pop() 
        {
            var removed = _stack.Pop();
            if(removed == _min.Peek())
            {                
                _min.Pop();
            }
        }
        
        public int Top() 
        {
            return _stack.Peek();
        }
        
        public int GetMin() 
        {
            return _min.Peek();
        }
    }
}