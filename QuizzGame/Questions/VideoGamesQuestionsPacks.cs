using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizzGame
{
    class VideoGamesQuestionsPacks
    {
        FileReader lineReader;
        public VideoGamesQuestionsPacks()
        {
            lineReader = new FileReader();
        }

        public void ReadVideoGamesPack(ThemePackGenerator themePackGenerator)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\raikh\OneDrive\Bureau\Numérique\Développement Informatique\CSHARP Development\QuizzGame\BDD Quizz\BDD TXT\JeuxVidéo\Nintendo.txt");
            lineReader.ReadAllBeginnerQuestions(lines);
        }
    }
}
