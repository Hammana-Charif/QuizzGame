using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    class SportTheme : ITheme
    {
        public SportTheme(string themeName)
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

        SubTheme subTheme { get; set; }

        enum SubTheme
        {
            SportsPourTous = 0
        }
        
        SubTheme CallASubTheme()
        {
            if (subTheme == SubTheme.SportsPourTous)
            {
                Console.WriteLine("SportsPourTous");
                return SubTheme.SportsPourTous;
            }
            else
            {
                Console.WriteLine("Une erreure est survenue");
                return SubTheme.SportsPourTous;
            }
        }
    }
}
