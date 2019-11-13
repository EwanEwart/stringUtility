using System;

namespace ConsumeStringUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Consume StringUtility.");

            StringUtility.StringLibrary clsString = new StringUtility.StringLibrary();
            Console.WriteLine(clsString.StartsWithUpper("Sts"));
        }
    }
}
/*
http://www.authorcode.com/creating-a-class-library-with-c-and-net-core-in-visual-studio-code/
*/
