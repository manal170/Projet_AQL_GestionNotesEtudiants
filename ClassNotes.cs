using System;

public class Notes
{



	

	public double Note { get; set; }
	public int Numero_etudiant { get; set; }
	public int Numero_cours { get; set; }

	public Notes(int numero_etudiant, int numero_cours)
	{
		this.Numero_etudiant = numero_etudiant;
		this.Numero_cours = numero_cours;
	}


	public double CalculNotes(double eA1, double eA2, double eA3)
	{
		double note = eA1 * 0.35 + eA2 * 0.30 + eA3 * 0.35;
		return note;
	}

	
}
