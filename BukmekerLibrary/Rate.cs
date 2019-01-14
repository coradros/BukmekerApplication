namespace BukmekerLibrary
{
    public class Rate
    {
        public int RateTypeIndex { get; }

        public Game CurrentGame { get; }

        public RateParams Params { get; set; }

        public Rate(int rateTypeIndex, Game game)
        {
            RateTypeIndex = rateTypeIndex;

            CurrentGame = game;
        }
    }
}
