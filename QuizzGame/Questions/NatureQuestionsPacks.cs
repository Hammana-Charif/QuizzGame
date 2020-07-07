using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizzGame
{
    class NatureQuestionsPacks
    {
        FileReader lineReader;
        public NatureQuestionsPacks()
        {
            lineReader = new FileReader();
        }

        public void ReadNaturePack(ThemePackGenerator themePackGenerator)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\raikh\OneDrive\Bureau\Numérique\Développement Informatique\CSHARP Development\QuizzGame\BDD Quizz\BDD TXT\Nature\Faune et flore des champs.txt");
            lineReader.ReadAllBeginnerQuestions(lines);
        }
    }
}
