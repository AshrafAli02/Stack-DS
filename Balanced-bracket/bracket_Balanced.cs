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
            string s = "((a)+(b))";
            Console.WriteLine(s+" : "+CheckBracket(s));
           
            
        }
        public static bool CheckBracket(string Bracket)
        {
           for(int i=0;i<Bracket.Length;i++)
            {
                char ch = Bracket[i];
                if(ch=='(')
                {
                    my.Push(ch);
                }
                else if(ch==')')
                {
                    if(my.Isempty)
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
    }
}

