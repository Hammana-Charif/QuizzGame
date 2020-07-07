using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    class GastronomyTheme : ITheme
    {
        public GastronomyTheme(string themeName)
        {
            ThemeName = Name;
            Name = themeName;

            Dice = new Dice(1);
            subTheme = (SubTheme)Dice.Launch();

            CallASubTheme();
        }

        public string ThemeName { get; set; }

        string Name;

        public Dice Dice { get; set; }

        public SubTheme subTheme { get; set; }

        public enum SubTheme
        {
            Sucre = 0,
        }

        public SubTheme CallASubTheme()
        {
            if (subTheme == SubTheme.Sucre)
            {
                Console.WriteLine("Sucre");
                return SubTheme.Sucre;
            }
            else 
            {
                Console.WriteLine("Une erreure est survenue");
                return SubTheme.Sucre;
            }
        }
    }
}
