namespace ParseTags
{
    using System;
    using System.Text;

    class Tags
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var upTag = "<upcase>";
            var downTag = "</upcase>";

            var currentIndex = input.IndexOf(upTag);
            var prevIndex = 0;

            bool isUpper = false;
            bool isMoreTags;

            var builder = new StringBuilder();

            if (currentIndex < 0)
            {
                isMoreTags = false;
                builder.Append(input);
            }
            else
            {
                isMoreTags = true;
            }

            while (isMoreTags)
            {
                if (isUpper)
                {
                    builder.Append(input.Substring(prevIndex, currentIndex - prevIndex).ToUpper());

                    prevIndex = currentIndex + downTag.Length;
                    currentIndex = input.IndexOf(upTag, prevIndex);
                }
                else
                {
                    builder.Append(input.Substring(prevIndex, currentIndex - prevIndex));

                    prevIndex = currentIndex + upTag.Length;
                    currentIndex = input.IndexOf(downTag, prevIndex);
                }

                isUpper = !isUpper;

                if (currentIndex < 0)
                {
                    isMoreTags = false;
                    builder.Append(input.Substring(prevIndex));
                }
            }

            Console.WriteLine(builder);
        }
    }
}
