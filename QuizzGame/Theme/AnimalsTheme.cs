using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    public class AnimalsTheme : ITheme
    {
        public AnimalsTheme(string themeName)
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
            NosAmisLesChats = 0
        }

        public SubTheme CallASubTheme()
        {
            if (subTheme == SubTheme.NosAmisLesChats)
            {
                Console.WriteLine("NosAmisLesChats");
                return SubTheme.NosAmisLesChats;
            }
            else
            {
                Console.WriteLine("Une erreure est survenue");
                return SubTheme.NosAmisLesChats;
            }
        }
    }
}
