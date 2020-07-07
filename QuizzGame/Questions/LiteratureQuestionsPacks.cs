using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizzGame
{
    class LiteratureQuestionsPacks
    {
        FileReader lineReader;
        public LiteratureQuestionsPacks()
        {
            lineReader = new FileReader();
        }

        public void ReadLiteraturePack(ThemePackGenerator themePackGenerator)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\raikh\OneDrive\Bureau\Numérique\Développement Informatique\CSHARP Development\QuizzGame\BDD Quizz\BDD TXT\Littérature\Auteurs Classiques.txt");
            lineReader.ReadAllBeginnerQuestions(lines);
        }
    }
}
