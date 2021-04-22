using System;

public class Notes
{
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
}
