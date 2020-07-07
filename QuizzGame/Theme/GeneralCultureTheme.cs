using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    public class GeneralCultureTheme : ITheme
    {
        public GeneralCultureTheme(string themeName)
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
            CultureGénéraleEnVrac = 0
        }

        SubTheme CallASubTheme()
        {
            if (subTheme == SubTheme.CultureGénéraleEnVrac)
            {
                Console.WriteLine("CultureGénéraleEnVrac");
                return SubTheme.CultureGénéraleEnVrac;
            }
            else
            {
                Console.WriteLine("Une erreure est survenue");
                return SubTheme.CultureGénéraleEnVrac;
            }
        }
    }
}
