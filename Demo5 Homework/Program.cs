using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //create prisoner
            Prisoner prisoner = new Prisoner { Man = "Johnny gangsta", Age = "He is 32 years old" };
            Jail jail = new Jail { Novice = "Just another pickpocketeer", Danger = "We get more murderer squirels everyday" };
            jail.AddPrisoner(prisoner);
            jail.AddPrisoner(prisoner);
            jail.AddPrisoner(prisoner);
            jail.AddPrisoner(prisoner);

            Console.WriteLine(jail.ToString());


            Console.WriteLine("Should have make this thing better");
            Console.ReadLine();





        }
    }
}
