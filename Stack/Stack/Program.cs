using Stack;
using System.ComponentModel.Design;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BracketCheck bracketCheck = new BracketCheck();

            
            string s = "[{{[{}()]}}]";
            switch (bracketCheck.Check(ref s))
            {
                case true:
                    Console.WriteLine("유효합니다.");
                    break;
                case false:
                    Console.WriteLine("유효하지 않습니다.");
                    break;
            }

        }

    }

    public class BracketCheck
    {
        public bool Check(ref string s)
        {
            Stack<char> bracketCheck = new Stack<char>();

            foreach (char word in s)
            { // ({{[}


                if (word == '(')
                {
                    bracketCheck.Push(word);
                    continue;
                }
                else if (word == '{')
                {
                    bracketCheck.Push(word);
                    continue;
                }
                else if (word == '[')
                {
                    bracketCheck.Push(word);
                    continue;
                }
                

                if (bracketCheck.Count == 0)
                {
                    return false;
                }
                
                if (word == (bracketCheck.Peek()) + 1)
                {
                    bracketCheck.Pop();
                    continue;
                }
                else if (word == ((bracketCheck.Peek()) + 2))
                {
                    bracketCheck.Pop();
                    continue;
                }
                else
                {
                    return false;
                }


            }
            return bracketCheck.Count == 0;
        }



    }
}


