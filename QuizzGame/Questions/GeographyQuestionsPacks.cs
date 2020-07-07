using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizzGame
{
    class GeographyQuestionsPacks
    {        
        FileReader lineReader;
        public GeographyQuestionsPacks()
        {
            lineReader = new FileReader();
        }

        public void ReadGeographyPack(ThemePackGenerator themePackGenerator)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\raikh\OneDrive\Bureau\Numérique\Développement Informatique\CSHARP Development\QuizzGame\BDD Quizz\BDD TXT\Géographie\Monuments du monde.txt");
            lineReader.ReadAllBeginnerQuestions(lines);
        }
    }
}
