namespace ReverseString
{
    using System;

    class Reverse
    {
        static void Main()
        {
            var input = Console.ReadLine();



            char[] processedChars = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                var inputIndex = input.Length - i - 1;

                processedChars[i] = input[inputIndex];
            }

            var output = new string(processedChars);

            Console.WriteLine(output);
        }
    }
}
