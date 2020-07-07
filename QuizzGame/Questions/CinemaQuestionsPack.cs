using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizzGame
{
    class CinemaQuestionsPack
    {
        FileReader lineReader;
        public CinemaQuestionsPack()
        {
            lineReader = new FileReader();
        }

        public void ReadCinemaPack(ThemePackGenerator themePackGenerator)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\raikh\OneDrive\Bureau\Numérique\Développement Informatique\CSHARP Development\QuizzGame\BDD Quizz\BDD TXT\Cinéma\Heros Marvel.txt");
            lineReader.ReadAllBeginnerQuestions(lines);
        }
    }
}
