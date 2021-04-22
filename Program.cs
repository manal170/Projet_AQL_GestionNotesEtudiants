using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Creation d'un nouveau etudiant (A) ou afficher le relever de note d'un etudaint (B) :");
            string reponse = Console.ReadLine();
            while (reponse == "a" || reponse == "b" || reponse == "c") { 
            if (reponse == "a")
            {
                while (reponse == "a")
                {
                    if (reponse != "o")
                    {
                        Console.WriteLine("Entrer votre nom :");
                        string nomEtudiantSaisie = Console.ReadLine();
                        Console.WriteLine("Entrer votre prenom :");
                        string prenomEtudiantSaisie = Console.ReadLine();
                        Console.WriteLine("Saisir un numero d'etudiant :");
                        int numeroEtudiantSaisie = int.Parse(Console.ReadLine());
                        Etudiant e1 = new Etudiant(nomEtudiantSaisie, prenomEtudiantSaisie);


                        string afficaghe1 = "le nom detudiant est :" + nomEtudiantSaisie +
                                            "\n le prenom d'etudiant: " + prenomEtudiantSaisie + 
                                            "\n le numero d'etudiant saisie : " + numeroEtudiantSaisie;
                        string path = @"c:\users\allao\" + numeroEtudiantSaisie + ".txt";

                        if (!File.Exists(path))
                        {
                            // Create a file to write to.
                            using (StreamWriter sw = File.CreateText(path))
                            {
                                sw.WriteLine(afficaghe1);
                            }
                        }
                        Console.Write("voulez vous ajoute un cours (o/n) :");
                        string ajoutCours = Console.ReadLine();

                        while (ajoutCours == "o")
                        {

                            Console.WriteLine("Saisir le titre du cours :");
                            string titreCourSaisie = Console.ReadLine();
                            Console.WriteLine("Saisir le numero du cours :");
                            int numeroCousSaisie = int.Parse(Console.ReadLine());
                            Cours c1 = new Cours(titreCourSaisie, numeroCousSaisie);
                            Console.WriteLine("Saisir la note de la 1 ere evaluation du cours :");
                            double eV1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Saisir la note de la 2 eme evaluation du cours :");
                            double eV2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Saisir la note de la 3 eme evaluation du cours :");
                            double eV3 = double.Parse(Console.ReadLine());
                            Notes n1 = new Notes(numeroEtudiantSaisie, numeroCousSaisie);
                            n1.CalculNotes(eV1, eV2, eV3);
                            string affichage = "le titre du cours est: " + titreCourSaisie + " || " + "le numero du cours est: " + numeroCousSaisie +
                                                " || " + "la note = " + n1.CalculNotes(eV1, eV2, eV3);
                            using (StreamWriter sw = File.AppendText(path))
                            {
                                sw.WriteLine(affichage);
                            }



                            Console.Write("voulez vous ajoute un autre cours (o/n) :");
                            ajoutCours = Console.ReadLine();
                        }
                    }

                    Console.Write("Creation d'un nouveau etudiant (A) ou afficher le relever de note d'un etudaint (B) :");
                    reponse = Console.ReadLine();
                }

            }

            if (reponse == "b")
            {
                while (reponse == "b")
                {

                    Console.WriteLine("Saisir le numero d'etudaint :");
                    int numeroEtudiantSaisie = int.Parse(Console.ReadLine());
                    string path = @"c:\users\allao\" + numeroEtudiantSaisie + ".txt";
                    using (StreamReader sr = File.OpenText(path))
                        {
                            string s = "";
                            while ((s = sr.ReadLine()) != null)
                            {
                            Console.WriteLine(s);
                            }
                        }
                    Console.Write("Creation d'un nouveau etudiant (A) ou afficher le relever de note d'un etudaint (B) :");
                    reponse = Console.ReadLine();

                    }
                }
            }
        }   
    }
}


