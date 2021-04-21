using System;

public class Etudiant
{
	public Etudiant()
	{
		private static int numero_etudaint = 10000;
		public String nom;
		public String prenom;

		public String Nom { get; set; }
		public String Prenom { get; set; }
		public int Code { get; private set; }

		public Etudiant(String nom,String prenom)
		{
			this.Nom = nom;
			this.Prenom = prenom;
			this.Code = ++numero_etudaint;
		}
		
		public void Afficher()
		{ 	
		Console.WriteLine(" Le numero d'étudiant : " +this.Code + '\n' 
				  + "Le nom de l'étudiant: " + this.Nom + '\n'
				  + "Le prenom de l'étudiant : " + this.Prenom )
		}
	}
}
	
	
