using System;

namespace BukmekerLibrary
{
    public class Game
    {
        public string NameTeamA { get; }
        public string NameTeamB { get; }

        public int ScoreTeamA { get; }
        public int ScoreTeamB { get; }

        public Game(string nameTeamA, string nameTeamB)
        {
            NameTeamA = nameTeamA;
            NameTeamB = nameTeamB;

            ScoreTeamA = new Random().Next(0, 200);
            ScoreTeamB = new Random().Next(0, 100);
        }

        public Game(string nameTeamA, string nameTeamB, int scoreTeamA, int scoreTeamB)
        {
            NameTeamA = nameTeamA;
            NameTeamB = nameTeamB;
            ScoreTeamA = scoreTeamA;
            ScoreTeamB = scoreTeamB;
        }
    }
}
