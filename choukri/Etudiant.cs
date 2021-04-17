using System;

public class Etudiant
{
	public int numero_etudaint = 0;
	public String nom;
    public String prenom;

	public int Numro_etudiant { get; set; }
	public String Nom { get; set; }
	public String Prenom { get; set; }

	public Etudiant(nom,prenom)
	{
		this.Nom = nom;
		this.Prenom = prenom;
		this.Numro_etudiant++;
	}
}
