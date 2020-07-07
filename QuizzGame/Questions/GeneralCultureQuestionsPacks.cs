using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizzGame
{
    class GeneralCultureQuestionsPacks
    {
        FileReader lineReader;
        public GeneralCultureQuestionsPacks()
        {
            lineReader = new FileReader();
        }

        public void ReadGeneralCulturePack(ThemePackGenerator themePackGenerator)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\raikh\OneDrive\Bureau\Numérique\Développement Informatique\CSHARP Development\QuizzGame\BDD Quizz\BDD TXT\Culture Générale\Culture Générale en vrac.txt");
            lineReader.ReadAllBeginnerQuestions(lines);
        }
    }
}
