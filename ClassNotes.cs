using System;

public class Notes
{


	public int numero_etudiant;
	public int numero_cours;
	public double UA1, UA2, UA3;

	

	public double Note { get; set; }
	public int NumeroEtudiant { get; set; }
	public int NumeroCours { get; set; }

	public Notes(int numero_etudiant, int numero_cours)
	{
		this.NumeroEtudiant = numero_etudiant;
		this.NumeroCours = numero_cours;
	}


	public double calculNotes()
	{

		return double note = UA1 * 0.35 + UA2 * 0.30 + UA3 * 0.35;
	}

	public void afficher()
	{
		Console.WriteLine(" Le numero d'étudiant est : " + this.NumeroEtudiant  + '\n'
							+ "Numero du cours est : " + this.NumeroCours + '\n'
							+ "Note de l'étudiant est : " + this.calculNotes());
	}
}
