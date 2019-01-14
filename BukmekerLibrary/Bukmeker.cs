using System;

namespace BukmekerLibrary
{
    public partial class Bukmeker
    {
        public void SetNewRate()
        {
            {
                //Create new game
                Game game = new Game("Спартак", "Динамо");

                //Show info about game to users
                Console.WriteLine("Начинается игра между командами №0: {0} и №1: {1}", game.NameTeamA, game.NameTeamB);

                //Read rate type and get new rate
                Rate rate = RateTypeCreator.CreateRate(game);

                //Read rate params
                rate.Params = RateParamsCreatorBase.ReaderInstance(rate.RateTypeIndex).GetRateParams();

                //Get rate results
                foreach(string line in new RateResult().GetResultInfo(game, rate))
                {
                    Console.WriteLine(line);
                }

                Console.ReadKey();
            }
        }
    }
}
