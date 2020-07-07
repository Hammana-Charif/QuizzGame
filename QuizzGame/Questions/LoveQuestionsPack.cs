using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizzGame
{
    public class LoveQuestionsPack
    {
        FileReader lineReader;
        public LoveQuestionsPack()
        {
            lineReader = new FileReader();
        }

        public void ReadLovePack(ThemePackGenerator themePackGenerator)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\raikh\OneDrive\Bureau\Numérique\Développement Informatique\CSHARP Development\QuizzGame\BDD Quizz\BDD TXT\Amour\Langues de l'amour.txt");
            lineReader.ReadAllBeginnerQuestions(lines);
        }
    }
}
