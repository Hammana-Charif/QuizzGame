using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    class ScienceTheme : ITheme
    {
        public ScienceTheme(string themeName)
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
            Inventions = 0
        }
        
        SubTheme CallASubTheme()
        {
            if (subTheme == SubTheme.Inventions)
            {
                Console.WriteLine("Inventions");
                return SubTheme.Inventions;
            }
            else
            {
                Console.WriteLine("Une erreure est survenue");
                return SubTheme.Inventions;
            }
        }
    }
}
