using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    class VideoGamesTheme : ITheme
    {
        public VideoGamesTheme(string themeName)
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
            Nintendo = 0,
        }

        public SubTheme CallASubTheme()
        {
            if (subTheme == SubTheme.Nintendo)
            {
                Console.WriteLine("Nintendo");
                return SubTheme.Nintendo;
            }
            else
            {
                Console.WriteLine("Une erreure est survenue");
                return SubTheme.Nintendo;
            }
        }
    }
}
