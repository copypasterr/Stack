using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;

namespace Stack
{
    public class StackTask<T>
    {
        private List<T> data = new List<T>();
        public int Count => data.Count;

        public void Push(T inputdata)
        {
            data.Add(inputdata);
        }

        public T Pop()
        {
            data.RemoveAt(Count);
            return data.LastOrDefault();
        }

        public void Clear()
        {
            data.Clear();
        }

        public T Peek() 
        {
            return data.LastOrDefault();
        }

        public T[] CopyTo()
        {
            T[] myarray = new T[data.Count];
            return myarray;
        }
    }
}
