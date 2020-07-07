using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Quiz
{
    public class Question
    {
        public string Name { get; set; }//On s'en fout?

        public string Anecdote { get; set; }//On s'en fout?

        public Response[] Responses { get; private set; }//On s'en fout?

        public Question(string fileName)
        {
            //var goodResponse = Responses.FirstOrDefault(c => c.GoodResponse);
            //Console.WriteLine(goodResponse);
        }

        /// <summary>
        /// Récupération des questions dans l'ensemble des fichiers du répertoire.
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <returns></returns>
        public static string[] ReadQuestionsFromDirectory(string directoryPath)
        {
            /// <summary>
            /// Récupérations des fichiers dans le répertoire.
            /// </summary>
            var files = Directory.EnumerateFiles(directoryPath, "*.txt");

            /// <summary>
            /// Détermine la taille du tableau, en fonction du nombre lignes contenues dans les fichiers.
            /// </summary>
            var questionsCount = 0;//Compteur de lignes.
            foreach (var file in files)
            {  
                var path = Path.GetFullPath(file);//Récupération du chemin des fichiers
                questionsCount = (from line in File.ReadAllLines(path) select line).Count();//Comptage et stockage du nombre de lignes totales sur l'ensemble des fichiers.
            }
            
            int primaryIndex = questionsCount;//Utilisation du nombre de lignes comme dimension du tableau.
 
            string[] questions = new string[primaryIndex];//Instanciation du tableau.
 
            /// <summary>
            /// Récupération des questions et stockage dans le tableau.
            /// </summary>
            int cycleIndex = 0;//Index qui va servir dans la boucle, avec une incrémentation à chaque question traité.
            foreach (var file in files)
            {
                //Obtention des chemins des fichiers et lecture des lignes.
                var path = Path.GetFullPath(file);
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    if (line.Contains("question"))//Extraire les lignes correspondant à la balise "question".
                    {
                        int found = line.IndexOf(": ");//Extraire la chaine de caractères à l'indice Indexof et stocker l'item dans le tableau.
                        string question = line.Substring(found + 2);
                        questions[cycleIndex++] = question;
                        //Console.WriteLine(question);//A utiliser pour vérifier visuellement que tout marche.
                    }
                }
            }
            return questions;
        }

        //public static IEnumerable<Question> ReadQuestionsFromDirectory2(string directoryPath)
        //{
        //    List<Question> questions = new List<Question>();

        //    var files = Directory.EnumerateFiles(directoryPath, "*.txt");

        //    foreach (var file in files)
        //    {
        //        var path = Path.GetFullPath(file);
        //        var lines = File.ReadAllLines(path);
        //        foreach (var line in lines)
        //        {
        //            if (line.Contains("question"))
        //            {
        //                int found = line.IndexOf(": ");
        //                Question question = new Question(line.Substring(found + 2));
        //                questions.Add(question);
        //                Console.WriteLine(line.Substring(found + 2));
        //            }
        //        }
        //    }
        //    return questions;
        //}
    }
}
