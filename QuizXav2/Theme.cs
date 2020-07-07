using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Quiz
{
    public class Theme
    {
        /// <summary>
        /// Nom du thème (Jeux vidéo, Manga, etc.)
        /// </summary>
        public string Label { get; private set; }

        /// <summary>
        /// Chemin du fichier du thème.
        /// </summary>
        public string FilePath { get; private set; }

        private Question[] questions;

        /// <summary>
        /// Questions du thème.
        /// </summary>
        public Question[] Questions { get
            {
                if (questions == null)
                    questions = Question.ReadQuestionsFromDirectory(FilePath);

                return questions;
            }
        }

        public static Theme[] ReadFromDirectory(string directoryPath)
        {
            var themeFiles = Directory.EnumerateFiles(directoryPath, "*.txt");

            return themeFiles.Select(fileName => new Theme()
            {
                Label = Path.GetFileNameWithoutExtension(fileName),
                FilePath = fileName
            }).ToArray();
        }

        public override string ToString() => Label;
    }
}

