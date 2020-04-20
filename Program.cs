using System;

namespace tomek_help
{
    class Program
    {
        public class Punkt
        {
            public int x;
            public int y;
	    public int dodaj(int a, int b){
	       return a+b;
	    }
	    public Punkt()
	    {
	    }

        }
        static void Main(string[] args)
        {
            Punkt punktA = new Punkt();
            punktA.x = 0;
            punktA.y = 0;
	    Console.WriteLine(punktA.dodaj(2,3));
            Console.WriteLine(punktA.x + "," + punktA.y);



            Console.WriteLine("Hello World!");
        }
    }
}
