using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizzGame
{
    class ScienceQuestionsPacks
    {
        FileReader lineReader;
        public ScienceQuestionsPacks()
        {
            lineReader = new FileReader();
        }

        public void ReadSciencePack(ThemePackGenerator themePackGenerator)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\raikh\OneDrive\Bureau\Numérique\Développement Informatique\CSHARP Development\QuizzGame\BDD Quizz\BDD TXT\Science\Inventions.txt");
            lineReader.ReadAllBeginnerQuestions(lines);
        }
    }
}
