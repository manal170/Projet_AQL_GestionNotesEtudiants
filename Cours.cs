using System;

public class Cours
{
	public int numeroDeCours = 100;
	public string titre;
	public int code;

	public int NumeroDeCours { get;set }
	public string Titre { get; set }
	public int Code { get; set }

	public Cours(string titre, int numeroDeCours)
    {
		this.titre = tire;
		numeroDeCours++;
    }

	public Cours(string titre, int numeroDeCours, int code): this(tire,numeroDeCours)
	{
		code++;
	}
}
