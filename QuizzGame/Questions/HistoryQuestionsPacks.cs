using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizzGame
{
    class HistoryQuestionsPacks
    {
        FileReader lineReader;
        public HistoryQuestionsPacks()
        {
            lineReader = new FileReader();
        }

        public void ReadHistoryPack(ThemePackGenerator themePackGenerator)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\raikh\OneDrive\Bureau\Numérique\Développement Informatique\CSHARP Development\QuizzGame\BDD Quizz\BDD TXT\Histoire\Ca c'est passé en 2019.txt");
            lineReader.ReadAllBeginnerQuestions(lines);
        }
    }
}
