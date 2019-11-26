using System;
using System.Collections.Generic;
using System.Text;

namespace Personregister2
{
    class Person
    {
        private string namn;
        private int ålder;
        private string adress;

        public Person(string n, int å, string a)
        {
            namn = n;
            ålder = å;
            adress = a;
        }

        public Person() { }

        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }

        public int Ålder
        {
            get { return ålder; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Fel! Åldern måste vara positiv");
                else
                    ålder = value;
            }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
    }
}
