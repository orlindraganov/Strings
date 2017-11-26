namespace CorrectBrackets
{
    using System;

    class Brackets
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int bracketCounter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                if (currentSymbol == '(')
                {
                    bracketCounter++;
                }
                else if (currentSymbol == ')')
                {
                    bracketCounter--;
                }
            }

            string output;

            if (bracketCounter == 0)
            {
                output = "Correct";
            }
            else
            {
                output = "Incorrect";
            }

            Console.WriteLine(output);
        }
    }
}
