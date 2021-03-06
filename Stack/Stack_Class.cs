using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack_Class
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
                if(Count==0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        
        public Stack_Class(int Capacity)
        {
            Count = 0;
            this.Capacity = Capacity;
            Stack_Data = new int[Capacity];
        }
        
        
        public void Push(int value)
        {
            if(Count<Capacity&&Isempty==false)
            {
                Stack_Data[Count++] = value;
                
            }
            else
            {
                throw new InvalidOperationException("The Stack is Full");
            }
        }
        public void Pop()
        {
            if (Isempty==false)
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
          if(Isempty==false)
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
            for(int i=Count-1;i>0;i--)
            {
                s += Stack_Data[Count]+",";
            }
            return s + Stack_Data[0] + "]";
            
        }
    }
   
}
