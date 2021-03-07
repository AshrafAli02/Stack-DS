using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_bracket
{
    class bracket_Balanced
    {
        static void Main(string[] args)
        {
            Stack<char> MyStack = new Stack<char>();
            MyStack.Push('(');
            MyStack.Push(')');
            Console.WriteLine(MyStack.Peek());
            Console.WriteLine(MyStack.ToArray());
        }
    }
}
