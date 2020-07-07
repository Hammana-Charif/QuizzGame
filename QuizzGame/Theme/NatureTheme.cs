using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    class NatureTheme : ITheme
    {
        public NatureTheme(string themeName)
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
            FauneEtFloreDesChamps = 0
        }
        
        SubTheme CallASubTheme()
        {
            if (subTheme == SubTheme.FauneEtFloreDesChamps)
            {
                Console.WriteLine("FauneEtFloreDesChamps");
                return SubTheme.FauneEtFloreDesChamps;
            }
            else
            {
                Console.WriteLine("Une erreure est survenue");
                return SubTheme.FauneEtFloreDesChamps;
            }
        }
    }
}
