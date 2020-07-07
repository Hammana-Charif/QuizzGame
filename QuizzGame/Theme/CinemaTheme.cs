using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    class CinemaTheme : ITheme
    {
        public CinemaTheme(string themeName)
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
            Marvel = 0,
        }

        public SubTheme CallASubTheme()
        {
            if (subTheme == SubTheme.Marvel)
            {
                Console.WriteLine("Marvel");
                return SubTheme.Marvel;
            }
            else
            {
                Console.WriteLine("Une erreure est survenue");
                return SubTheme.Marvel;
            }
        }
    }
}
