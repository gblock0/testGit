using System;

namespace TestGit
{
    public static class TestGit
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"{ParseOutFirstArg(args)} was input as the first arg ");
        }

        public static string ParseOutFirstArg(string[] args)
        {
            // change some stuff
            return args[0];
        }
    }
}
