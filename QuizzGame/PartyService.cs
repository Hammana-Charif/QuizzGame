using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzGame
{
    public class PartyService
    {

        ThemePackGenerator themePackGenerator;
        
        AnimalsQuestionsPacks animalsQuestionsPacks = new AnimalsQuestionsPacks();
        CinemaQuestionsPack cinemaQuestionsPack = new CinemaQuestionsPack();
        GastronomyQuestionsPacks gastronomyQuestionsPacks = new GastronomyQuestionsPacks();
        GeneralCultureQuestionsPacks generalCultureQuestionsPacks = new GeneralCultureQuestionsPacks();
        GeographyQuestionsPacks geographyQuestionsPacks = new GeographyQuestionsPacks();
        HistoryQuestionsPacks historyQuestionsPacks = new HistoryQuestionsPacks();
        LiteratureQuestionsPacks literatureQuestionsPacks = new LiteratureQuestionsPacks();
        LoveQuestionsPack loveQuestionsPack = new LoveQuestionsPack();
        MusicQuestionsPacks musicQuestionsPacks = new MusicQuestionsPacks();
        NatureQuestionsPacks natureQuestionsPacks = new NatureQuestionsPacks();
        ScienceQuestionsPacks scienceQuestionsPacks = new ScienceQuestionsPacks();
        SportQuestionsPacks sportQuestionsPacks = new SportQuestionsPacks();
        TelevisionQuestionsPacks televisionQuestionsPacks = new TelevisionQuestionsPacks();
        VideoGamesQuestionsPacks videoGamesQuestionsPacks = new VideoGamesQuestionsPacks();

        public PartyService()
        {
            themePackGenerator = new ThemePackGenerator();

            SubscribeToStartQuestionsPack();

            PlayACycle();
        }

        public void PlayACycle()
        {
            PlayAPhase(1, 3);
            for (int phase = 0; phase <= 3 ; phase++)
            {
                themePackGenerator.GenerateAThemePack();
            }
        }

        private void SubscribeToStartQuestionsPack()
        {
            themePackGenerator.AnimalsPackCalled += animalsQuestionsPacks.ReadAnimalsPack;
            themePackGenerator.CinemaPackCalled += cinemaQuestionsPack.ReadCinemaPack;
            themePackGenerator.GastronomyPackCalled += gastronomyQuestionsPacks.ReadGastronomyPack;
            themePackGenerator.GeneralCulturePackCalled += generalCultureQuestionsPacks.ReadGeneralCulturePack;
            themePackGenerator.GeographyPackCalled += geographyQuestionsPacks.ReadGeographyPack;
            themePackGenerator.HistoryPackCalled += historyQuestionsPacks.ReadHistoryPack;
            themePackGenerator.LiteraturePackCalled += literatureQuestionsPacks.ReadLiteraturePack;
            themePackGenerator.LovePackCalled += loveQuestionsPack.ReadLovePack;
            themePackGenerator.MusicPackCalled += musicQuestionsPacks.ReadMusicPack;
            themePackGenerator.NaturePackCalled += natureQuestionsPacks.ReadNaturePack;
            themePackGenerator.SciencePackCalled += scienceQuestionsPacks.ReadSciencePack;
            themePackGenerator.SportPackCalled += sportQuestionsPacks.ReadSportPack;
            themePackGenerator.TelevisionPackCalled += televisionQuestionsPacks.ReadTelevisionPack;
            themePackGenerator.VideoGamesPackCalled += videoGamesQuestionsPacks.ReadVideoGamesPack;
        }

        public int PlayAPhase(int min, int max) => max;
    }
}
