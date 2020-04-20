using System;

namespace tomek_help
{
    class Program
    {
        public struct Punkt
        {
            public int x;
            public int y;
        }
        static void Main(string[] args)
        {
            Punkt punktA;

            punktA.x = 0;
            punktA.y = 0;

            Console.WriteLine(punktA.x + "," + punktA.y);



            Console.WriteLine("Hello World!");
        }
    }
}
