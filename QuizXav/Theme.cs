using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Quiz
{
    public class Theme
    {
        /// <summary>
        /// Délégué des events thématiques.
        /// </summary>
        /// <param name="theme"></param>
        /// <param name="questions"></param>
        /// <param name="responses"></param>
        public delegate void delgueQuestionsPackHandler(Theme theme, string[] questions, string[] responses);

        /// <summary>
        /// Events utilisés en balises(points d'encrage) dans la méthode ThemeChoice.
        /// </summary>
        public event delgueQuestionsPackHandler VideoGames;
        public event delgueQuestionsPackHandler Manga;

        public string Name { get; private set; }//On s'en fout?

        public IEnumerable<Question> Questions { get; set; }//On s'en fout?

        public Theme()
        {

        }

        /// <summary>
        /// Saisie de l'utilisateur pour choisir un thème. Le choix du thème appel les packs de questions/réponses, via des events.
        /// </summary>
        /// <param name="directoryPath"></param>
        public void ThemeChoice(string directoryPath)
        {
            Console.WriteLine("Selectionnez le thème de votre choix :");

            /// <summary>
            /// Appel du tableau de thèmes, crée dans la méthode ReadFromDirectory.
            /// </summary>
            string[] theme = ReadFromDirectory(directoryPath);

            /// <summary>
            /// Appel des tableaux questions et réponses pour les events.
            /// </summary>
            var questions = Question.ReadQuestionsFromDirectory(directoryPath);
            var responses = Response.ReadResponsesFromDirectory(directoryPath);

            /// <summary>
            /// Saisie utilisateur.
            /// </summary>
            string input = Console.ReadLine();
            int.TryParse(input, out int choice);

            /// <summary>
            /// Condition switch, de choix de thème, déterminé par la saisie utilisateur. Les events appels les méthodes questions/réponses.
            /// </summary>Les choix en fonction de la saisie.
            switch (choice)
            {
                case 1:    
                    Console.WriteLine($"{_ = theme[0]}");
                    VideoGames?.Invoke(this, questions, responses);//Event : appel la méthode Jeux Vidéo.
                    break;
                case 2:
                    Console.WriteLine($"{_ = theme[1]}");
                    Manga?.Invoke(this, questions, responses);//Event : appel la méthode Manga.
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Tableau des thèmes, contenues dans les fichiers du répertoire.
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <returns></returns>
        public static string[] ReadFromDirectory(string directoryPath)
        {
            /// <summary>
            /// Comptage des fichiers dans le dossier, pour préparer l'index du tableau
            /// </summary>
            var filesCount = (from file in Directory.EnumerateFiles(directoryPath, "*.txt", SearchOption.AllDirectories) select file).Count();

            /// <summary>
            /// Variable qui servira de nombre de "cases" que contiendra le tableau. La taille du tableau. Elle est égale au nombre de fichiers.
            /// </summary>
            int primaryIndex = filesCount;

            /// <summary>
            /// Le tableau de type "string" : stockage des thèmes sous forme de chaîne de caractère.
            /// </summary>
            string[] themes = new string[primaryIndex];

            /// <summary>
            /// Récupérations des fichiers dans le dossier.
            /// </summary>
            var files = Directory.EnumerateFiles(directoryPath, "*.txt");

            /// <summary>
            /// Création des thèmes et stockage dans le tableau "theme".
            /// </summary>
            int numbering = 0;//Variable qui permettera de numéroter les thèmes du quizz par ordre croissant.
            int cycleIndex = 0;//VAriable qui permettera de dimensionner le tableau en fonction du nombre de lignes extraites.
            foreach (var file in files)
            {
                var lines = File.ReadAllLines(file);//Pour chaque fichier, lecture des lignes contenues dans le fichier.
                foreach (var line in lines)
                {
                    if (line.Contains("thème"))//Pour chaque ligne, séléctionne celles contenant le mot "thème".
                    {
                        int found = line.IndexOf(": ");//Pour chaque ligne contenant le mot "thème", on extrait le nom du thème à cet indice.
                        numbering++;
                        string theme = line.Substring(found + 2);//Instanciation de la classe lié au theme.
                        themes[cycleIndex++] = theme;//Pour chaque thème extrait, on le stock dans une case du tableau. 
                        Console.WriteLine($"{numbering}: {theme}");
                    }
                }
            }
            return themes;
        }

        //public static Theme[] ReadFromDirectory2(string directoryPath)
        //{
        //    var filesCount = (from file in Directory.EnumerateFiles(directoryPath, "*.txt", SearchOption.AllDirectories) select file).Count();
        //    int primaryIndex = filesCount;

        //    Theme[] themes = new Theme[primaryIndex];

        //    var files = Directory.EnumerateFiles(directoryPath, "*.txt");

        //    int numbering = 0;
        //    int cycleIndex = 0;
        //    foreach (var file in files)
        //    {
        //        var lines = File.ReadAllLines(file);

        //        foreach (var line in lines)
        //        {
        //            if (line.Contains("thème"))
        //            {
        //                int found = line.IndexOf(": ");
        //                Theme theme = new Theme(numbering++, line.Substring(found + 2));
        //                themes[cycleIndex++] = theme;
        //                Console.WriteLine($"{numbering}: {line.Substring(found + 2)}");
        //            }
        //        }
        //    }
        //    return themes;
        //}
    }
}

