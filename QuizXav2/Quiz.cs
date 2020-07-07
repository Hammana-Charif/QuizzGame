using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Quiz
{
    public class Quiz
    {

        public Quiz()
        {
            
        }

        public void Run()
        {
            do
            {
                // Choix du thème
                var theme = ChoiceTheme();

                // Poser les questions
                AskQuestion(theme);

            } while (AskContinue());
        }

        private bool AskContinue()
        {
            Console.WriteLine("Voulez vous recommencer (O/N)?");
            char key;
            do {
                key = Console.ReadKey(true).KeyChar;
            } while (!"ON".Contains(char.ToUpper(key)));
            
            return char.ToUpper(key) == 'O';
        }

        private void AskQuestion(Theme theme)
        {
            foreach (var question in theme.Questions)
            {
                Console.WriteLine(question.Label);

                var responses = question.Responses;

                for (int i = 0; i < responses.Length; i++)
                    Console.WriteLine($"{i+1}: {responses[i].Label}");

                var key = Console.ReadKey(true);
                int choiced = int.Parse(key.KeyChar.ToString()) - 1;

                if (responses[choiced] == question.GoodResponse)
                    Console.WriteLine("Bonne réponse !");
                else
                    Console.WriteLine("Mauvaise réponse !");
            }
        }

        private static Theme ChoiceTheme()
        {
            var themes = Theme.ReadFromDirectory("./Data");

            Console.WriteLine("Veuillez choisir parmis ces thèmes:");
            for (int i = 0; i < themes.Length; ++i)
                Console.WriteLine($"{i + 1}: {themes[i].Label}");

            var key = Console.ReadKey(true);

            int choiced = int.Parse(key.KeyChar.ToString()) - 1;
            var themeChoiced = themes[choiced];
            Console.WriteLine($"Vous avez sélectionné {themeChoiced.Label}");

            return themeChoiced;
        }
    }
}
