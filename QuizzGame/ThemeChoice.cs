using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    class ThemeChoice
    {
        static Action<string> show = s => Console.WriteLine(s);
        static Action<string> show2 = s => Console.Write(s);

        ThemeTitleGenerator themeTitleGenerator;
        public ThemeChoice()
        {
            themeTitleGenerator = new ThemeTitleGenerator();
        }

        private int themeChoice;
        public string ChooseATheme()
        {
            string theme1 = themeTitleGenerator.GenerateAThemeTitle();
            show($"1: {theme1}");

            string theme2 = themeTitleGenerator.GenerateAThemeTitle();
            show($"2: {theme2}");

            string theme3 = themeTitleGenerator.GenerateAThemeTitle();
            show($"3: {theme3}");

            show2("Selectionnez le thème de votre choix :");
            string input = Console.ReadLine();
            bool correctNum = int.TryParse(input, out themeChoice);

            switch (themeChoice)
            {
                case 1:
                    show($"*{theme1}*");
                    return $"{theme1}";
                case 2:
                    show($"*{theme2}*");
                    return $"{theme2}";
                case 3:
                    show($"*{theme3}*");
                    return $"{theme3}";
                default:
                    return "La saisie ne correspond pas à un choix valide";
            }
        }
    }
}
