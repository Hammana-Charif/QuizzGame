using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    class TelevisionTheme : ITheme
    {
        public TelevisionTheme(string themeName)
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
            SeriesAmericaines = 0
        }
        
        SubTheme CallASubTheme()
        {
            if (subTheme == SubTheme.SeriesAmericaines)
            {
                Console.WriteLine("SeriesAmericaines");
                return SubTheme.SeriesAmericaines;
            }
            else
            {
                Console.WriteLine("Une erreure est survenue");
                return SubTheme.SeriesAmericaines;
            }
        }
    }
}
