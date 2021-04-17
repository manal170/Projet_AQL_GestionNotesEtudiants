using System;

public class Cours
{
	public int numeroDeCours = 100;
	public string titre;
	public int code = 0;

	public string Titre { get; set }

	public Cours(string titre, int numeroDeCours)
    {
		this.titre = tire;
		numeroDeCours++;
    }

	public Cours(string titre, int numeroDeCours, int code): this(tire,numeroDeCours)
	{
		code++;
	}
	
	public void Afficher()

	{ 
		Console.WriteLine(" Le nom du cours est : " + this.titre + '\n' + "Numero du cours est : " + numeroDeCours + '\n'+ "Code du cours est : " + code )
	}
