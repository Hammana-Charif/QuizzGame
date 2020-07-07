using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizzGame
{
    class MusicQuestionsPacks
    {
        FileReader lineReader;
        public MusicQuestionsPacks()
        {
            lineReader = new FileReader();
        }

        public void ReadMusicPack(ThemePackGenerator themePackGenerator)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\raikh\OneDrive\Bureau\Numérique\Développement Informatique\CSHARP Development\QuizzGame\BDD Quizz\BDD TXT\Musique\Chanteurs internationaux.txt");
            lineReader.ReadAllBeginnerQuestions(lines);
        }
    }
}
