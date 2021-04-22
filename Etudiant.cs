using System;

public class Etudiant
{
	        //Déclaration des Attributs 
		public String Nom { get; set; }
		public String Prenom { get; set; }
		public int Code { get; private set; }
                //Déclaration des constructeus 
		public Etudiant(String nom,String prenom)
		{
			this.Nom = nom;
			this.Prenom = prenom;
		}
	}
	
	
