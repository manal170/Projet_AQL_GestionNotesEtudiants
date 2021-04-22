using System;

public class Cours
{
	
	//Déclaration des attributs
	public int NumeroDeCours { get; set; }
	public string Titre { get; set; }
	public int Code { get; set; }
        //Déclaration des constructeurs 
	public Cours(string titre, int numeroDeCours)
    {
		this.Titre = titre;
		
    }
	
}
