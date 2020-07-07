using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizzGame
{
    class AnimalsQuestionsPacks
    {
        FileReader lineReader;
        public AnimalsQuestionsPacks()
        {
            lineReader = new FileReader();
        }

        public void ReadAnimalsPack(ThemePackGenerator themePackGenerator)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\raikh\OneDrive\Bureau\Numérique\Développement Informatique\CSHARP Development\QuizzGame\BDD Quizz\BDD TXT\Animaux\Nos amis les chats.txt");
            lineReader.ReadAllBeginnerQuestions(lines);
        }
    }
}
