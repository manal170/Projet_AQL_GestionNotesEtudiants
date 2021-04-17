using System;

public class Etudiant
{
	public Etudiant()
	{
		public int numero_etudaint = 10000;
		public String nom;
		public String prenom;

		public String Nom { get; set; }
		public String Prenom { get; set; }

		public Etudiant(nom, prenom)
		{
			this.Nom = nom;
			this.Prenom = prenom;
			this.Numro_etudiant++;
		}
		
		public void Afficher()
		{ 	
		Console.WriteLine(" Le numero d'étudiant : " + this.Numero_etudiant + '\n' 
				  + "Le nom de l'étudiant: " + this.Nom + '\n'
				  + "Le prenom de l'étudiant : " + this.Prenom )
		}
	}
}
	
	
