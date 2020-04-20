using System;

namespace tomek_help
{
    class Program
    {
        static void Main(string[] args)
        {
            void Method(ref int refArgument)
            {
                refArgument = refArgument + 1;
				System.Console.WriteLine(refArgument);
            }

            int number = 1;
            Method(ref number);
            Console.WriteLine(number);



            Console.WriteLine("Hello World!");
        }
    }
}
