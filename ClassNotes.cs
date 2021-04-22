using System;

public class Notes
{
	//Déclaration des Attributs 
	public double Note { get; set; }
	public int Numero_etudiant { get; set; }
	public int Numero_cours { get; set; }
        //Déclaration des constructeurs 
	public Notes(int numero_etudiant, int numero_cours)
	{
		this.Numero_etudiant = numero_etudiant;
		this.Numero_cours = numero_cours;
	}
        //on utilise la méthode CalculNotes pour calculer la note d'un cours 
	public double CalculNotes(double eA1, double eA2, double eA3)
	{
		double note = eA1 * 0.35 + eA2 * 0.30 + eA3 * 0.35;
		return note;
	}
}
