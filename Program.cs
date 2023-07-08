using System;

namespace SoundexMap
{
    internal class Program
    {
        public static string KeepInitialFilter(string input)
        {
            return input[0].ToString();
        }
        public static int SoundexMap(string input) 
        {
            string result = 
                KeepInitialFilter(input)
                ;
            return 5;
        }
        static void Main(string[] args)
        {
            //var name1 = "Jackson";
            var name2 = "Jaxen";
            var name = new Name (name2);
            Console.WriteLine(name.Initial + name.Remains+ " " + name
            .RemoveConsecutiveConsonants()
            .RemoveAllVowels()
            .ReplaceByDigits()
            .EndingZero()
            .ToString());
        }
    }
}