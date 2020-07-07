using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    public class ThemeTitleGenerator
    {
        ThemeList themeList;
        public ThemeTitleGenerator()
        {
            themeList = new ThemeList();
        }

        public string GenerateAThemeTitle()
        {
            string[] tab = themeList.GenerateAThemeArray();

            Dice dice = new Dice(14);
            int diceDraw = dice.Launch();

            string tabTheme = tab[diceDraw];

            return tabTheme;
        }
    }
}
