using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizzGame
{
    class GastronomyQuestionsPacks
    {
        FileReader lineReader;
        public GastronomyQuestionsPacks()
        {
            lineReader = new FileReader();
        }

        public void ReadGastronomyPack(ThemePackGenerator themePackGenerator)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\raikh\OneDrive\Bureau\Numérique\Développement Informatique\CSHARP Development\QuizzGame\BDD Quizz\BDD TXT\Gastronomie\Sucre.txt");
            lineReader.ReadAllBeginnerQuestions(lines);
        }
    }
}
