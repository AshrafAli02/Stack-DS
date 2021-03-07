using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Excercise
{
    public class String_Stack
    {
        private int _count;
        private int _capacity;
        public string[] Stack_Data;
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


        public String_Stack()
        {
            Count = 0;
            this.Capacity = 5;
            Stack_Data = new string[Capacity];
        }


        public void Push(char value)
        {
            if (Count < Capacity && Isempty == false)
            {
                Stack_Data[Count++] =value.ToString();

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
                Stack_Data[Count--] = null;

            }
            else
            {
                throw new InvalidOperationException("The Stack is Empty");
            }

        }
        public string Peek()
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
            string s ="";
            for (int i = Count - 1; i > 0; i--)
            {
                s += Stack_Data[Count];
            }
            return s + Stack_Data[0];
        }
        public void Resize()
        {
            string[] newarray = new string[Capacity * 2];
            this.Capacity *= 2;
            Stack_Data = newarray;
        }
        public string Reverse_String(string word)
        {
            for(int i=0;i<word.Length;i++)
            {
                char ch = word[i];
                Push(ch);

            }
            return Printstring();
        }
    }
}
