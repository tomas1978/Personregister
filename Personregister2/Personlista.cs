using System;
using System.Collections.Generic;
using System.Text;

namespace Personregister2
{
    class Personlista
    {
        private List<Person> personlista = new List<Person>();

        public void nyPerson()
        {
            string nyttNamn;
            string nyAdress;
            int nyÅlder;
            Console.Write("Ange namn: ");
            nyttNamn = Console.ReadLine();
            Console.Write("Ange ålder: ");
            nyÅlder = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ange adress: ");
            nyAdress = Console.ReadLine();
            Person nyPerson = new Person(nyttNamn, nyÅlder, nyAdress);
            personlista.Add(nyPerson);

        }

        public void skrivUt()
        {
            foreach (Person element in personlista)
            {
                Console.WriteLine(element.Namn);
                Console.WriteLine(element.Ålder);
                Console.WriteLine(element.Adress);
            }
        }
    }
}
