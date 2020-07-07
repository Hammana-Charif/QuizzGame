using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    class HistoryTheme : ITheme
    {
        public HistoryTheme(string themeName)
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
            CaCestPasséEn2019 = 0
        }
        
        public SubTheme CallASubTheme()
        {
            if (subTheme == SubTheme.CaCestPasséEn2019)
            {
                Console.WriteLine("CaCestPasséEn2019");
                return SubTheme.CaCestPasséEn2019;
            }
            else
            {
                Console.WriteLine("Une erreure est survenue");
                return SubTheme.CaCestPasséEn2019;
            }
        }
    }
}
