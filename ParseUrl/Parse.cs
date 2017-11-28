namespace ParseUrl
{
    using System;

    class Parse
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var protocolSeparator = "://";
            var resourceSeparator = "/";

            var startIndex = 0;

            var endIndex = input.IndexOf(protocolSeparator);

            var protocol = input.Substring(0, endIndex);

            startIndex = endIndex + protocolSeparator.Length;
            endIndex = input.IndexOf(resourceSeparator, startIndex);

            var server = input.Substring(startIndex, endIndex - startIndex);

            startIndex = endIndex;

            var resource = input.Substring(startIndex);

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
