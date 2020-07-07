using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace Quiz
{
    public class Response
    {
        public bool GoodResponse;//On s'en fout??

        public Response(int counter, string path)
        {

        }

        /// <summary>
        /// Tableau des réponses, contenues dans les fichiers du répertoire.
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <returns></returns>
        public static string[] ReadResponsesFromDirectory(string directoryPath)
        {
            /// <summary>
            /// Récupérations des fichiers dans le répertoire.
            /// </summary>
            var files = Directory.EnumerateFiles(directoryPath, "*.txt");

            /// <summary>
            /// Détermine la taille du tableau, en fonction du nombre lignes contenues dans les fichiers.
            /// </summary>
            var reponsesCount = 0;//Compteur de lignes.
            foreach (var file in files)
            {
                var path = Path.GetFullPath(file);//Récupération du chemin des fichiers
                reponsesCount = (from line in File.ReadAllLines(path) select line).Count();//Comptage et stockage du nombre de lignes totales sur l'ensemble des fichiers.
            }

            int primaryIndex = reponsesCount;//Utilisation du nombre de lignes comme dimension du tableau.
            
            string[] responses = new string[primaryIndex];//Instanciation du tableau.

            /// <summary>
            /// Récupération des réponses et stockage dans le tableau.
            /// </summary>
            int numbering = 0;//Variable qui permettera de numéroter les thèmes du quizz par ordre croissant.
            int cycleIndex = 0;//Index qui va servir dans la boucle, avec une incrémentation à chaque réponse traité.
            foreach (var file in files)
            { 
                var lines = File.ReadAllLines(file);//Obtention des chemins des fichiers et lecture des lignes.
                foreach (var line in lines)
                {
                    string pattern = @"\[([^\[\]]+)\]";//Paterne d'extraction des items.
                    foreach (Match m in Regex.Matches(line, pattern))
                    {
                        numbering++;
                        string response = m.Groups[1].Value;
                        responses[cycleIndex++] = response;
                        //Console.WriteLine($"{numbering}: {response}");//A utiliser pour vérifier visuellement que tout marche.
                    }
                }
            }
            return responses;
        }
    }
}
