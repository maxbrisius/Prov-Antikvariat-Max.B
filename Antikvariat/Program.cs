using System.Runtime.InteropServices;
using System;


namespace Antikvariat
{
    class Program
    {
        
        static void Main(string[] args)
        {
            antique t = new antique();
            //skapar en ny instans av books som i det här fallet heter antique då jag inte kan läsa instruktioner när jag behöver

            System.Console.WriteLine("vad heter boken?");

            t.name = Console.ReadLine();

            System.Console.WriteLine( t + "...Cool bok...");


            string buysell = Console.ReadLine();

            if (buysell == "Book")
            {
                System.Console.WriteLine("rarity: " + );
            }

           


            //*while(buysell != "köpa")
            // {
            //     System.Console.WriteLine("skriv in köpa eller sälja");
            //     buysell = Console.ReadLine();
            // }
            // while(buysell !="sälja")
            // {
            //     System.Console.WriteLine("skriv in köpa eller sälja");
            //     buysell = Console.ReadLine()

            // }

            // System.Console.WriteLine("Bok #" + bnumber);*


        }
    }
}
