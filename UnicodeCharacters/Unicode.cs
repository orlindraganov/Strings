namespace UnicodeCharacters
{
    using System;
    using System.Text;

    class Unicode
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var builder = new StringBuilder();

            foreach (var symbol in input)
            {
                builder.Append(ConvertToUnicode(symbol));
            }

            Console.WriteLine(builder);
        }

        private static string ConvertToUnicode(char input)
        {
            return @"\u" + ((int)input).ToString("X4");
        }
    }
}