using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QuizzGame
{
    public class ThemePackGenerator
    {
        public delegate void delgueQuestionsPacksHandler(ThemePackGenerator themePackGenerator);

        public event delgueQuestionsPacksHandler AnimalsPackCalled;
        public event delgueQuestionsPacksHandler CinemaPackCalled;
        public event delgueQuestionsPacksHandler GastronomyPackCalled;
        public event delgueQuestionsPacksHandler GeneralCulturePackCalled;
        public event delgueQuestionsPacksHandler GeographyPackCalled;
        public event delgueQuestionsPacksHandler HistoryPackCalled;
        public event delgueQuestionsPacksHandler LiteraturePackCalled;
        public event delgueQuestionsPacksHandler LovePackCalled;
        public event delgueQuestionsPacksHandler MusicPackCalled;
        public event delgueQuestionsPacksHandler NaturePackCalled;
        public event delgueQuestionsPacksHandler SciencePackCalled;
        public event delgueQuestionsPacksHandler SportPackCalled;
        public event delgueQuestionsPacksHandler TelevisionPackCalled;
        public event delgueQuestionsPacksHandler VideoGamesPackCalled;
        

        ThemeChoice themeChoice;
        public ThemePackGenerator()
        {
            themeChoice = new ThemeChoice();
        }

        public string GenerateAThemePack()
        {
            string theme = themeChoice.ChooseATheme();
            switch (theme)
            {
                case "Animaux":
                    AnimalsPackCalled?.Invoke(this);
                    new AnimalsTheme("Animaux");
                    break;
                case "Cinéma":
                    CinemaPackCalled?.Invoke(this);
                    new CinemaTheme("Cinema"); 
                    break;
                case "Gastronomie":
                    GastronomyPackCalled?.Invoke(this);
                    new GastronomyTheme("Gastronomie"); 
                    break;
                case "Culture Générale":
                    GeneralCulturePackCalled?.Invoke(this);
                    new GeneralCultureTheme("Culture Générale"); 
                    break;
                case "Géographie":
                    GeographyPackCalled?.Invoke(this);
                    new GeographyTheme("Géographie"); 
                    break;
                case "Histoire":
                    HistoryPackCalled?.Invoke(this);
                    new HistoryTheme("histoire"); 
                    break;
                case "Littérature":
                    LiteraturePackCalled?.Invoke(this);
                    new LiteratureTheme("Littérature"); 
                    break;
                case "Amour":
                    LovePackCalled?.Invoke(this);
                    new LoveTheme("Amour");
                    break;
                case "Musique":
                    MusicPackCalled?.Invoke(this);
                    new MusicTheme("Musique");
                    break;
                case "Nature":
                    NaturePackCalled?.Invoke(this);
                    new NatureTheme("Nature");
                    break;
                case "Science":
                    SciencePackCalled?.Invoke(this);
                    new ScienceTheme("Science");
                    break;
                case "Sport":
                    SportPackCalled?.Invoke(this);
                    new SportTheme("Sport");
                    break;
                case "Télévision":
                    TelevisionPackCalled?.Invoke(this);
                    new TelevisionTheme("Télévision");
                    break;
                case "Jeux Vidéo":
                    VideoGamesPackCalled?.Invoke(this);
                    new VideoGamesTheme("Jeux Vidéo");
                    break;
                default:
                    break;
            }
            return theme;
        }
    }
}
