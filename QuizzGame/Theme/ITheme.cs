using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{    
    interface ITheme
    {
        string ThemeName { get; set; }

        Dice Dice { get; set; }
    }
}
