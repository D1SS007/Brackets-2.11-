using System;

namespace ConsoleApp2._12
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int halfBracketsCount = 0;
            int fullBracketsCount = 0;
            int amountOfRightBrackets = 0;
            int amountOfLeftBrackets = 0;

            string  text = "(())";
            
            foreach (var symbol in text)
            {                    
                Console.Write(symbol);
                if (symbol == '(')
                {
                    amountOfLeftBrackets++;
                    halfBracketsCount++;                                       
                }
                else if (symbol == ')' || halfBracketsCount != 0)
                {
                    amountOfRightBrackets++;
                    halfBracketsCount--;
                    fullBracketsCount++;                    
                }                
            }
            if (amountOfRightBrackets == amountOfLeftBrackets)
            {
                Console.WriteLine("\nМаксимальная глубина скобок: " + fullBracketsCount);                
            }
            else if(amountOfLeftBrackets != amountOfRightBrackets)
            {
                Console.WriteLine("\nНекорректное количество скобок");
            }            
        }
    }
}
