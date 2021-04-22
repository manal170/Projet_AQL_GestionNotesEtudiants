using System;
using System.Collections.Generic;
using System.IO;
// pour enregistrement et creation des fichier texte il faut changer le chemin de l'enregistrement dans le dossier souhaiter 
// dans les lignes 36 et 92  il faut changer   string path = @"c:\users\allao\" + numeroEtudiantSaisie + ".txt"  par   string path = @" (le chemin souhaiter)" + numeroEtudiantSaisie + ".txt"

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Creation d'un nouveau etudiant (A) ou afficher le relever de note d'un etudaint (B) :");
            string reponse = Console.ReadLine();
            // on a creer la boucle while  pour permettre de choisir l'une des 2 option suivante
            while (reponse == "a" || reponse == "b") { 
            if (reponse == "a")
            {
                while (reponse == "a")
                {
                    if (reponse != "o")
                    {
                        Console.Write("Entrer votre nom :");
                        string nomEtudiantSaisie = Console.ReadLine();
                        Console.Write("Entrer votre prenom :");
                        string prenomEtudiantSaisie = Console.ReadLine();
                        Console.Write("Saisir un numero d'etudiant :");
                        int numeroEtudiantSaisie = int.Parse(Console.ReadLine());
                        Etudiant e1 = new Etudiant(nomEtudiantSaisie, prenomEtudiantSaisie);
                       
                        // on a creer affichage1 pour afficher les informations de l'etudiant dans un fichier texte  
                        string affichage1 = "le nom detudiant est :" + nomEtudiantSaisie +
                                            "\n le prenom d'etudiant: " + prenomEtudiantSaisie + 
                                            "\n le numero d'etudiant saisie : " + numeroEtudiantSaisie;
                        string path = @"c:\users\allao\" + numeroEtudiantSaisie + ".txt";
                        
                        // creation d'un fishier texte dont le nom de fichier est le numero d'etudiant
                        if (!File.Exists(path))
                        {
                            // Create a file to write to.
                            using (StreamWriter sw = File.CreateText(path))
                            {
                                sw.WriteLine(affichage1);
                            }
                        }
                        Console.Write("voulez vous ajoute un cours (o/n) :");
                        string ajoutCours = Console.ReadLine();

                        while (ajoutCours == "o")
                        {

                            Console.Write("Saisir le titre du cours :");
                            string titreCourSaisie = Console.ReadLine();
                            Console.Write("Saisir le numero du cours :");
                            int numeroCousSaisie = int.Parse(Console.ReadLine());
                            Cours c1 = new Cours(titreCourSaisie, numeroCousSaisie);
                            Console.Write("Saisir la note de la 1 ere evaluation du cours :");
                            double eV1 = double.Parse(Console.ReadLine());
                            Console.Write("Saisir la note de la 2 eme evaluation du cours :");
                            double eV2 = double.Parse(Console.ReadLine());
                            Console.Write("Saisir la note de la 3 eme evaluation du cours :");
                            double eV3 = double.Parse(Console.ReadLine());
                            Notes n1 = new Notes(numeroEtudiantSaisie, numeroCousSaisie);
                            n1.CalculNotes(eV1, eV2, eV3);
                            
                            // on a creer affichage pour permettre a ajouter le cours dans le fichier texte 
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

                    Console.Write("Saisir le numero d'etudaint :");
                    int numeroEtudiantSaisie = int.Parse(Console.ReadLine());
                    string path = @"c:\users\allao\" + numeroEtudiantSaisie + ".txt";
                    
                    //pour afficher le relever d'un etudiant 
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


