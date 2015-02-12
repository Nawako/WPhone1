using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp1
{
    public class Personne
    {
        public String Nom {get; set;}
        public String Prenom { get; set; }
        public int Age { get; set; }
        public bool Masculin { get; set; }
        public String Mail { get; set; }
        public String Photo { get; set; }


        public Personne()
        {
            this.Masculin = true;
        }

        public Personne (String nom, String prenom, int age, bool masculin)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
            this.Masculin = masculin;
        }


    }
}
