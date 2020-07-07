using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace QuizzGame
{
    public class FileReader
    {
        static Action<string> show = s => Console.WriteLine(s);

        static UserInput userInput = new UserInput();

        public string ReadAFile(string[] readALine, int i)
        {
            string reader = readALine[i];
            Console.WriteLine(reader);

            return reader;
        }

        public void ReadAFileByQuestion(string[] readALine, int i)
        {
            show(readALine[i]);
            show(readALine[i + 1]);
            show(readALine[i + 2]);
            show(readALine[i + 3]);
            show(readALine[i + 4]);

            char choice = userInput.RequestInput();

            switch (choice)
            {
                case 'a':
                    show($"{readALine[i + 1]} est la bonne réponse!");
                    show(readALine[i + 5]);
                    break;
                case 'b':
                    show($"{readALine[i + 2]} est une mauvaise réponse.");
                    break;
                case 'c':
                    show($"{readALine[i + 3]} est une mauvaise réponse.");
                    break;
                case 'd':
                    show($"{readALine[i + 4]} est une mauvaise réponse.");
                    break;
                default:
                    break;
            }
            show("Appuyez sur une touche pour passer à la prochaine question");
            Console.ReadLine();
        }

        public void ReadAllBeginnerQuestions(string[] lines)
        {
            ReadAFileByQuestion(lines, 12);
            ReadAFileByQuestion(lines, 20);
            ReadAFileByQuestion(lines, 28);
            ReadAFileByQuestion(lines, 36);
            ReadAFileByQuestion(lines, 44);
            ReadAFileByQuestion(lines, 52);
            ReadAFileByQuestion(lines, 60);
            ReadAFileByQuestion(lines, 68);
            ReadAFileByQuestion(lines, 76);
            ReadAFileByQuestion(lines, 84);
        }
    }
}
