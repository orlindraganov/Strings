namespace SubStringInString
{
    using System;

    class Substring
    {
        static void Main()
        {
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();

            int counter = 0;

            int index = text.IndexOf(pattern);

            while (0 <= index && index < text.Length)
            {
                counter++;
                index = text.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
