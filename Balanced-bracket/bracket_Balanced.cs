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
        public static List<char> Ex1=new List<char>{'(','[','{','<'};
        public static List<char> Ex2 = new List<char> { ')', ']', '}', '>' };
        public static List<char> Symbol = new List<char> { '+', '-', '*', '%','/' };
       public static Balanced<char> my = new Balanced<char>();
        static void Main(string[] args)
        {

            //string word = "Ashraf";
            //for(int i=0;i<word.Length;i++)
            //{
            //    Char ch = word[i];
            //    my.Push(ch);
            //}
            //Console.WriteLine(my.Printstring());
            //string s = "((a)+(b])";
            //Console.WriteLine(s+" : "+CheckBracket(s));
            //Console.WriteLine(Calculation(5,2,'%'));
            //Console.WriteLine(ExpressionEvaluate("(10 + ((22 + 3) * (6+2)))"));
            //Console.WriteLine(ExpressionEvaluate("(10+14)"));
            //char ch = '3';
            //int a = int.Parse(ch.ToString());
            //Console.WriteLine(a);
            //Console.WriteLine(Isnumber('8'));
            //Console.WriteLine(Isnumber('a'));
            //string s = "10";
            //string ch = null;
            //int i = 0;
            //while(i<s.Length)
            //{
               
            //    while(Isnumber(s[i])==true)
            //    {
            //        ch += s[i];
                    
            //    }
            //    i++;
            //}
            //int number = int.Parse(ch.ToString());
            //Console.WriteLine(number);
           
            
        }
        #region Balanced Bracket
        public static bool CheckBracket(string Bracket)
        {
            for (int i = 0; i < Bracket.Length; i++)
            {
                char ch = Bracket[i];
                if (Ex1.Contains(ch))
                {
                    my.Push(ch);
                }
                else if (Ex2.Contains(ch))
                {
                    if (my.Isempty)
                    {
                        return false;
                    }
                    else
                    {
                        if (Ex2.IndexOf(ch) == Ex1.IndexOf(my.Peek()))
                        {
                            my.Pop();
                        }
                        else
                        {
                            return false;
                        }
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
            string number = null;
            for(int i=0;i<Expression.Length;i++)
            {
                char ch = Expression[i];
                if (Isnumber(ch))
                {
                    number += ch;
                }
                if(!Isnumber(ch)&&number!=null)
                {
                    int num = int.Parse(number);
                    NumberStack.Push(num);
                    number = null;
                }
                if(Symbol.Contains(ch))
                {
                    ExpressionStack.Push(ch);
                }
                if(ch==')')
                {
                    int n2 =NumberStack.Peek();
                    NumberStack.Pop();
                    int n1 =NumberStack.Peek();
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
                case '%':
                    return num1 % num2;
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

