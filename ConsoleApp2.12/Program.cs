using System;

namespace ConsoleApp2._12
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int halfBrackets = 0;
            int fullBrackets = 0;
            int amountOfLeftBracket = 0;
            int amountOfRightBracket = 0;

            string text = "(()(()))";
            
            foreach (var symbol in text)
            {
                if (symbol == ')')
                {
                    halfBrackets--;
                    amountOfRightBracket++;
                }

                if(symbol == '(')
                {
                    halfBrackets++;
                    amountOfLeftBracket++;
                }

                if(amountOfLeftBracket == amountOfRightBracket +1)
                {
                    fullBrackets++;
                }

                if(halfBrackets < 0)
                {
                    Console.WriteLine("error");
                    break;
                }
            }

            if (halfBrackets > 0)
            {
                Console.WriteLine("error");
            }

            if(halfBrackets == 0)
            {
                Console.WriteLine(fullBrackets);
            }        
        }
    }
}
