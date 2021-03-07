using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stack_Console
{
    class Program
    {
        public static int Count=0;
        public static int Capacity=5;
        public static char[] Stack_Data=new char[5];
        //private bool _Isempty;
        public static bool Isempty
        {
            get
            {
                if(Count==0)
                {
                    return true;
                }
                return false;
            }
        }

        

        static void Main(string[] args)
        {
            Console.WriteLine(Reverse_String("ashraf ali"));
            //Push('a');
            //Push('b');
            //Push('c');
            //Push('d');
            //Push('s');
            //Push('d');
            //Console.WriteLine(Printstring());

            
           
        }
        public  static void Push(char value)
        {
            if (Count < Capacity)
            {
                Stack_Data[Count] = value;
                Count++;

            }
            else
            {
                Resize();
                Push(value);
            }
        }
        public static void Pop()
        {
            if (Isempty == false)
            {
                Peek();
                Stack_Data[Count--] = ' ';

            }
            else
            {
                throw new InvalidOperationException("The Stack is Empty");
            }

        }
        public static char Peek()
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
        public static string Printstring()
        {
            string s = "";
            for (int i = Count - 1; i >= 0; i--)
            {
                s =s+ Stack_Data[i];
            }
            return s.ToString();
        }
        public static void Resize()
        {
            int length = Stack_Data.Length * 2;
            char[] newarray = new char[length];
            Capacity = Capacity * 2;
            Array.Copy(Stack_Data, newarray, Stack_Data.Length);
            Stack_Data = newarray;
        }
        public static string Reverse_String(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                char ch = word[i];
                Push(ch);

            }
            return Printstring();
        }
    }
}
