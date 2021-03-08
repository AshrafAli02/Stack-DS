using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_bracket
{
   public class Balanced<T>
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
        public Balanced()
        {
            Count = 0;
            this.Capacity = 5;
            Stack_Data = new T[Capacity];
        }
        public void Push(T value)
        {
            if (Count < Capacity)
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
                Count--;

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
                return Stack_Data[Count - 1];
            }
            else
            {
                throw new InvalidOperationException("The Stack is Empty");
            }
        }
        public string Printstring()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = Count - 1; i >= 0; i--)
            {
                sb.Append(Stack_Data[i]);
            }
            return sb.ToString();
        }
        public void Resize()
        {
            T[] newarray = new T[Capacity * 2];
            Capacity = Capacity * 2;
            Array.Copy(Stack_Data, newarray, Count);
            Stack_Data = newarray;
        }
        
        
        
    }
}
