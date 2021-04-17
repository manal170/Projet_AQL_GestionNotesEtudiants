using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3_AQL
{
    class Etudiant
    {
        string nom;
        string prenom;
        int numeroEtudiant;

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public Etudiant(string nom ,string prenom)
        {
            this.Nom = nom ;
            this.Prenom = prenom;
        }
    }
}
