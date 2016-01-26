using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5_Homework
{
    class Jail : Prisoner

    {
        public string Novice { get; set; }
        public string Danger { get; set; }

        public List<Prisoner> Prisoners { get; }
        public Jail()
        {
            Prisoners = new List<Prisoner>();
        }

        public void AddPrisoner(Prisoner prisoner)
        {
            Prisoners.Add(prisoner);
        }

        public override string ToString()
        {
            string sJail = "Novice criminal " + Novice + "Dangerous criminal " + Danger + "Prisoners \n";
            foreach (Prisoner prisoner in Prisoners)
            {
                sJail += Prisoners.ToString() + "\n";
            }
                return sJail;
            }
        }
    }

