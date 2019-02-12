using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEval
{
    public class candidature
    {
        private string nom_prenom;


        public candidature( string unNom_prenom)
        {
            this.nom_prenom = unNom_prenom;
        }

        public string Nom_prenom { get => nom_prenom; set => nom_prenom = value; }

        
    }
}
