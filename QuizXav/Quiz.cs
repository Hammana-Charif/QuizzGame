using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Quiz
{
    public class Quiz
    {
        /// <summary>
        /// Délégué pour simplifier l'affichage des "string".
        /// </summary>
        public Action<string> show = s => Console.WriteLine(s);

        Theme theme = new Theme();
        public Quiz()
        {
            
        }

        public void Run()
        {
            PlayAPhase(1);
        }

        /// <summary>
        /// Exécute x parties.
        /// </summary>
        /// <param name="phaseNum">Nombre de parties à exécuter</param>
        /// <returns></returns>
        private void PlayAPhase(int phaseNum)
        {
            for (int phase = 0; phase < phaseNum; phase++)
            {
                Start();
            }
        }

        /// <summary>
        /// Lancement d'une partie. Renseigne le chemin du répertoire. Appel des events.
        /// </summary>
        private void Start()
        {
            SubscribeToStartQuestionsPack();
            theme.ThemeChoice(@"./Data");
        }

        /// <summary>
        /// Mise en place des abonnements aux events.
        /// </summary>
        private void SubscribeToStartQuestionsPack()
        {
            //theme.ThemeChoiced += CallThemeQuestions;
            theme.VideoGames += CallVideoGamesQuestions;
            theme.Manga += CallMangaQuestions;
        }

        /// <summary>
        /// Saisie utilisateur, choix de la réponse.
        /// </summary>
        /// <param name="questions"></param>
        /// <param name="responses"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        private void CallQuestionStystem(string[] questions, string[] responses, int i, int j)
        {
            show(questions[i]);
            show($"1: {responses[j]}");
            show($"2: {responses[j + 1]}");
            show($"3: {responses[j + 2]}");

            Console.Write("Selectionnez la réponse de votre choix :");
            string input = Console.ReadLine();
            int.TryParse(input, out int choice);

            switch (choice)
            {
                case 1:
                    show($"{responses[j]} est la bonne réponse!");
                    //show(readALine[i + 5]);
                    break;
                case 2:
                    show($"{responses[j + 1]} est une mauvaise réponse.");
                    break;
                case 3:
                    show($"{responses[j + 2]} est une mauvaise réponse.");
                    break;
                default:
                    break;
            }
            show("Appuyez sur une touche pour passer à la prochaine question");
            Console.ReadLine();
        }

        /// <summary>
        /// Méthode standardisée pour appeler question et réponses. Thème: "Jeux Vidéo".
        /// </summary>
        /// <param name="theme"></param>
        /// <param name="questions"></param>
        /// <param name="responses"></param>
        public void CallVideoGamesQuestions(Theme theme, string[] questions, string[] responses)
        {
            CallQuestionStystem(questions, responses, 0, 0);
            CallQuestionStystem(questions, responses, 1, 3);
            CallQuestionStystem(questions, responses, 2, 6);
        }

        /// <summary>
        /// Méthode standardisée pour appeler question et réponses. Thème: "Manga".
        /// </summary>
        /// <param name="theme"></param>
        /// <param name="questions"></param>
        /// <param name="responses"></param>
        public void CallMangaQuestions(Theme theme, string[] questions, string[] responses)
        {
            CallQuestionStystem(questions, responses, 3, 9);
            CallQuestionStystem(questions, responses, 4, 12);
            CallQuestionStystem(questions, responses, 5, 15);
        }
    }
}
