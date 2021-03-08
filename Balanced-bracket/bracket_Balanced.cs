using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Balanced_bracket;

namespace Balanced_bracket
{
    class bracket_Balanced
    {
        //public static List<string> Ex1=new List<string>{"(","[","{","<"};
        //public static List<string> Ex2 = new List<string> { ")", "]", "}", ">" };
        //public static List<string> Symbol = new List<string> { "+", "-", "*", "%" };
       //public static Balanced<char> my = new Balanced<char>();
        static void Main(string[] args)
        {

            //string word = "Ashraf";
            //for(int i=0;i<word.Length;i++)
            //{
            //    Char ch = word[i];
            //    my.Push(ch);
            //}
            //Console.WriteLine(my.Printstring());
            //string s = "((a)+(b))";
            //Console.WriteLine(s+" : "+CheckBracket(s));
            //Console.WriteLine(Calculation(1,5,'+'));
            Console.WriteLine(ExpressionEvaluate("(1 + ((2 + 3) * (4 * 5)))"));
            //char ch = '3';
            //int a = int.Parse(ch.ToString());
            //Console.WriteLine(a);
            //Console.WriteLine(Isnumber('8'));
            //Console.WriteLine(Isnumber('a'));
           
            
        }
        #region Balanced Bracket
        public static bool CheckBracket(string Bracket)
        {
            for (int i = 0; i < Bracket.Length; i++)
            {
                char ch = Bracket[i];
                if (ch == '(')
                {
                    my.Push(ch);
                }
                else if (ch == ')')
                {
                    if (my.Isempty)
                    {
                        return false;
                    }
                    else
                    {
                        my.Pop();
                    }

                }

            }
            if (my.Isempty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region Expression Evaluate
        public static int ExpressionEvaluate(string Expression)
        {
            Balanced<int> NumberStack = new Balanced<int>();
            Balanced<char> ExpressionStack = new Balanced<char>();
            for(int i=0;i<Expression.Length;i++)
            {
                char ch = Expression[i];
                if (Isnumber(ch))
                {
                    int a = int.Parse(ch.ToString());
                    NumberStack.Push(a);
                }
                if(ch=='+'||ch=='-'||ch=='*'||ch=='/')
                {
                    ExpressionStack.Push(ch);
                }
                if(ch==')')
                {
                    int n1 =NumberStack.Peek();
                    NumberStack.Pop();
                    int n2 =NumberStack.Peek();
                    NumberStack.Pop();
                    char ch1 = ExpressionStack.Peek();
                    ExpressionStack.Pop();
                    int ans = Calculation(n1, n2, ch1);
                    NumberStack.Push(ans);
                }
                
            }
            return NumberStack.Peek();
            
        }
        public static int Calculation(int num1,int num2,char oper)
        {
            char a = oper;
            switch(a)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;

            }
            return 0;
        }
        public static bool Isnumber(char ch)
        {
            
            try
            {
                int a = int.Parse(ch.ToString());
                if (a >= 0 && a <= 9)
                {
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }
        #endregion

    }
}

