using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Quiz
{
    public class Question
    {
        public string Label { get; set; }

        public Response[] Responses { get; private set; }

        public Response GoodResponse => Responses.First();

        /// <summary>
        /// Récupération des questions dans l'ensemble des fichiers du répertoire.
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <returns></returns>
        public static Question[] ReadQuestionsFromDirectory(string fileName)
        {
            List<Question> questions = new List<Question>();

            using (var file = File.OpenText(fileName))
            while (!file.EndOfStream)
            {
                var questionLine = file.ReadLine();
                var responsesLine = file.ReadLine();

                questions.Add(new Question()
                {
                    Label = questionLine,
                    Responses = responsesLine.Split('|').Select(r => new Response() { Label = r }).ToArray(),
                });
            }

            return questions.ToArray();
        }

        public override string ToString() => Label;
    }
}
