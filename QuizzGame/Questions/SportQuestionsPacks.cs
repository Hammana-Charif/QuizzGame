using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizzGame
{
    class SportQuestionsPacks
    {
        FileReader lineReader;
        public SportQuestionsPacks()
        {
            lineReader = new FileReader();
        }

        public void ReadSportPack(ThemePackGenerator themePackGenerator)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\raikh\OneDrive\Bureau\Numérique\Développement Informatique\CSHARP Development\QuizzGame\BDD Quizz\BDD TXT\Sport\Sports pour tous.txt");
            lineReader.ReadAllBeginnerQuestions(lines);
        }
    }
}
