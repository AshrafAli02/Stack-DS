using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDS
{
    public class StackDs
    {
        private int _count;
        private int _capacity;
        public int[] Stack_Data;
        private bool _isempty;
        public int Count
        {
            get
            {
                return _count;

            }
            set
            {
                _count = value;
            }

        }
        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
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


        public StackDs()
        {
            Count = 0;
            this.Capacity = 5;
            Stack_Data = new int[Capacity];
        }


        public void Push(int value)
        {
            if (Count < Capacity && Isempty == false)
            {
                Stack_Data[Count++] = value;

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
                Stack_Data[Count--] = 0;

            }
            else
            {
                throw new InvalidOperationException("The Stack is Empty");
            }

        }
        public int Peek()
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
            int[] newarray = new int[Capacity * 2];
            this.Capacity *= 2;
            Stack_Data = newarray;
        }
    }
}
