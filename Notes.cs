using System;

public class Notes
{


	int numero_etudiant;
	int numero_cours;
	double UA1, UA2, UA3;

	int a;

	public double Note { get; set; }
	public int Numero_etudiant { get; set; }
	public int Numero_cours { get; set; }

	public Notes(int numero_etudiant, int numero_cours)
	{
		this.Numero_etudiant = numero_etudiant;
		this.Numero_cours = numero_cours;
	}


	public double CalculNotes()
	{

		return double note = UA1 * 0.35 + UA2 * 0.30 + UA3 * 0.35;
	}

	public void Afficher()
	{
		Console.WriteLine(" Le numero d'étudiant est : " + this.num + '\n'
							+ "Numero du cours est : " + numeroDeCours + '\n'
							+ "Note de l'étudiant est : " + CalculNotes());
	}
}