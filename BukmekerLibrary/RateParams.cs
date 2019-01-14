namespace BukmekerLibrary
{
    public class RateParams
    {
        public int Size { get; set; }

        public int TeamIndex { get; set; }

        public int GoalsA { get; set; }

        public int GoalsB { get; set; }

        public RateParams(int size)
        {
            Size = size;
        }
    }
}
