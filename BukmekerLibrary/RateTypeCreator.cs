using System;

namespace BukmekerLibrary
{
    public static class RateTypeCreator
    {
        public static Rate CreateRate(Game game)
        {
            string data = GetInputData();

            int type = 0;

            if (Int32.TryParse(data, out type))
            {
                return new Rate(type, game);
            }
            else
            {
                throw new Exception("Ошибка создания ставки. Некорректные данные создания ставки.");
            }
        }

        private static string GetInputData()
        {
            Console.WriteLine("Введите тип ставки:");
            Console.WriteLine("0 - ставка на ничью.");
            Console.WriteLine("1 - ставка на победу одной из команд.");
            Console.WriteLine("2 - ставка на конкретный счет.");
            return Console.ReadLine();
        }
    }
}
