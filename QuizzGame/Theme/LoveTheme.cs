using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    public class LoveTheme : ITheme
    {
        public LoveTheme(string themeName)
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
            LanguesDeLamour = 0,
        }
        
        public SubTheme CallASubTheme()
        {
            if (subTheme == SubTheme.LanguesDeLamour)
            {
                Console.WriteLine("LanguesDeLamour");
                return SubTheme.LanguesDeLamour;
            }
            else
            {
                Console.WriteLine("Une erreure est survenue");
                return SubTheme.LanguesDeLamour;
            }
        }
    }
}
