using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    public class ThemeList
    {
        public List<string> GenerateAThemeList()
        {
            List<string> themeList = new List<string>();

            themeList.Add("Animaux");
            themeList.Add("Cinéma");
            themeList.Add("Gastronomie");
            themeList.Add("Culture Générale");
            themeList.Add("Géographie");
            themeList.Add("Histoire");
            themeList.Add("Littérature");
            themeList.Add("Amour");
            themeList.Add("Musique");
            themeList.Add("Nature");
            themeList.Add("Science");
            themeList.Add("Sport");
            themeList.Add("Télévision");
            themeList.Add("Jeux Vidéo");

            return themeList;
        }

        public string[] GenerateAThemeArray()
        {
            string[] themeTab = new string[]
            {
                "Animaux",
                "Cinéma",
                "Gastronomie",
                "Culture Générale",
                "Géographie",
                "Histoire",
                "Littérature",
                "Amour",
                "Musique",
                "Nature",
                "Science",
                "Sport",
                "Télévision",
                "Jeux Vidéo"
            };
            return themeTab;
        }

        //public ITheme[] GenerateAThemePackArray()
        //{
        //    ITheme[] themeTab = new ITheme[]
        //    {
        //        new AnimalsTheme("Animaux"),
        //        new CinemaTheme("Cinéma"),
        //        new GastronomyTheme("Gastronomie"),
        //        new GeneralCultureTheme("Culture Générale"),
        //        new GeographyTheme("Géographie"),
        //        new HistoryTheme("histoire"),
        //        new LiteratureTheme("Littérature"),
        //        new LoveTheme("Amour"),
        //        new MusicTheme("Musique"),
        //        new NatureTheme("Nature"),
        //        new ScienceTheme("Science"),
        //        new SportTheme("Sport"),
        //        new TelevisionTheme("Télévision"),
        //        new VideoGamesTheme("Jeux Vidéo")
        //    };
        //    return themeTab;
        //}
    }
}
