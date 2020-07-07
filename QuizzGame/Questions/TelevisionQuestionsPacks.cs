using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizzGame
{
    class TelevisionQuestionsPacks
    {
        FileReader lineReader;
        public TelevisionQuestionsPacks()
        {
            lineReader = new FileReader();
        }

        public void ReadTelevisionPack(ThemePackGenerator themePackGenerator)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\raikh\OneDrive\Bureau\Numérique\Développement Informatique\CSHARP Development\QuizzGame\BDD Quizz\BDD TXT\Télévision\Séries américaines.txt");
            lineReader.ReadAllBeginnerQuestions(lines);
        }
    }
}
