using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    class LiteratureTheme : ITheme
    {
        public LiteratureTheme(string themeName)
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
            AuteursClassiques = 0,
        }
        
        public SubTheme CallASubTheme()
        {
            if (subTheme == SubTheme.AuteursClassiques)
            {
                Console.WriteLine("AuteursClassiques");
                return SubTheme.AuteursClassiques;
            }
            else
            {
                Console.WriteLine("Une erreure est survenue");
                return SubTheme.AuteursClassiques;
            }
        }
    }
}
