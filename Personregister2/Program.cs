using System;

namespace Personregister2
{
    class Program
    {
        static void Main(string[] args)
        {
            int menyval = 1;
            Personlista pl = new Personlista();
            while (menyval != 0)
            {
                Console.WriteLine("Personregister");
                Console.WriteLine("==============");
                Console.WriteLine("1. Registrera ny person");
                Console.WriteLine("2. Skriv ut alla personer i listan");
                Console.WriteLine("0. Avsluta");
                Console.Write("Ange ditt val: ");
                menyval = Convert.ToInt32(Console.ReadLine());
                if (menyval == 1)
                    pl.nyPerson();
                else if (menyval == 2)
                    pl.skrivUt();
            }
        }
    }
}
