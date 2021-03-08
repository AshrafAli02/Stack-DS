using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDS
{
    public class StackDs<T>
    {
        private int _count;
        private int _capacity;
        public T[] Stack_Data;
        private bool _isempty;
        public int Count
        {
            get
            {
                return _count;

            }
            

        }
        public int Capacity
        {
            get
            {
                return _capacity;
            }
            
        }
        public bool Isempty
        {
            get
            {
                if (Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public StackDs(int Capacity)
        {
            this._capacity = Capacity;
            Stack_Data = new T[_capacity];
            _count = 0;
        }


        public void Push(T value)
        {
            if (_count < _capacity && Isempty == false)
            {
                Stack_Data[_count++] = value;

            }
            else
            {
                Resize();
                Push(value);
            }
        }
        public void Pop()
        {
            if (Isempty == false)
            {
                Peek();
                _count--;

            }
            else
            {
                throw new InvalidOperationException("The Stack is Empty");
            }

        }
        public T Peek()
        {
            if (Isempty == false)
            {
                return Stack_Data[Count-1];
            }
            else
            {
                throw new InvalidOperationException("The Stack is Empty");
            }
        }
        public string Print()
        {
            string s = "[";
            for (int i = Count - 1; i > 0; i--)
            {
                s += Stack_Data[Count] + ",";
            }
            return s + Stack_Data[0] + "]";
        }
        public void Resize()
        {
            T[] newarray = new T[Capacity * 2];
            _capacity = _capacity * 2;
            Stack_Data = newarray;
        }
    }
}
