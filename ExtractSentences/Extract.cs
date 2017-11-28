namespace ExtractSentences
{
    using System;
    using System.Linq;
    using System.Text;

    class Extract
    {
        static void Main()
        {
            var pattern = Console.ReadLine();
            var input = Console.ReadLine();

            char[] sentenceSeparators = { '.' };
            char[] wordSeparators = input.Where(c => !char.IsLetter(c)).Distinct().ToArray();

            var builder = new StringBuilder();
            var sentences = input.Split(sentenceSeparators, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToArray();

            foreach (var sentence in sentences)
            {
                var words = sentence.Split(wordSeparators, StringSplitOptions.RemoveEmptyEntries);

                if (words.Contains(pattern))
                {
                    builder.Append(sentence);
                    builder.Append(". ");
                }
            }

            Console.WriteLine(builder.ToString().Trim());
        }
    }
}
