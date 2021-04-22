using System;

public class Cours
{
	public int numeroDeCours = 100;
	public string titre;
	public int code = 0;

	public int NumeroDeCours { get; set; }
	public string Titre { get; set; }
	public int Code { get; set; }

	public Cours(string titre, int numeroDeCours)
    {
		this.titre = titre;
		numeroDeCours++;
    }
	public void Afficher()
	{
		Console.WriteLine("Le titre du cours: " + this.Titre + '\n' +
				  "Le numero du cours: " + this.NumeroDeCours);
	}
}
