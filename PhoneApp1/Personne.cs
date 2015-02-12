using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp1
{
    public class Personne
    {
        protected String Nom {get; set;}
        protected String Prenom { get; set; }
        public int Age { get; set; }
        protected bool Masculin { get; set; }
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
