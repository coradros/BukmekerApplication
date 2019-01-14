using System;

namespace BukmekerLibrary
{
    public abstract class RateParamsCreatorBase
    {
        public static RateParamsCreatorBase ReaderInstance(int typeIndex)
        {
            switch (typeIndex)
            {
                case 0:
                    return new RateParamsCreatorDraw();

                case 1:
                    return new RateParamsCreatorVictory();

                case 2:
                    return new RateParamsCreatorScore();
            }

            throw new Exception("Ошибка привязчика ставки. Некорректные данные для параметров ставки.");
        }

        public RateParams GetRateParams()
        {
            return CreateParams(GetInputData());
        }

        protected virtual string[] GetInputData()
        {
            Console.WriteLine("Введите размер ставки:");
            string size = Console.ReadLine();
            return new string[] { size };
        }

        protected virtual RateParams CreateParams(string[] data)
        {
            if (data.Length > 0)
            {
                int size = 0;

                if (Int32.TryParse(data[0], out size))
                {
                    if (size < 0)
                        throw new Exception("Ошибка привязчика ставки. Некорректные данные для размера ставки.");
                    else
                        return new RateParams(size);
                }
                else
                {
                    throw new Exception("Ошибка привязчика ставки. Некорректные данные для размера ставки.");
                }
            }
            else
            {
                throw new Exception("Ошибка привязчика ставки. Недостаточно данных для ставки.");
            }
        }
    }

    public class RateParamsCreatorDraw : RateParamsCreatorBase { }

    public class RateParamsCreatorVictory : RateParamsCreatorBase
    {
        protected override string[] GetInputData()
        {
            string result = base.GetInputData()[0];

            Console.WriteLine("Введите номер команды, которая победит (0 или 1):");
            string number = Console.ReadLine();

            return new string[] { result, number };
        }

        protected override RateParams CreateParams(string[] rateData)
        {
            RateParams returnRate = base.CreateParams(rateData);

            if (rateData.Length > 1)
            {
                int teamIndex = 0;

                if (Int32.TryParse(rateData[1], out teamIndex))
                {
                    if (teamIndex < 0 || teamIndex > 1)
                        throw new Exception("Ошибка привязчика ставки. Некорректные данные для выбора команды.");
                    else
                        returnRate.TeamIndex = teamIndex;
                }
                else
                {
                    throw new Exception("Ошибка привязчика ставки. Некорректные данные для выбора команды.");
                }
            }
            else
            {
                throw new Exception("Ошибка привязчика ставки. Недостаточно данных для ставки.");
            }

            return returnRate;
        }
    }

    public class RateParamsCreatorScore : RateParamsCreatorBase
    {
        protected override string[] GetInputData()
        {
            string result = base.GetInputData()[0];

            Console.WriteLine("Введите количество голов первой команды:");
            string goalsA = Console.ReadLine();

            Console.WriteLine("Введите количество голов второй команды:");
            string goalsB = Console.ReadLine();

            return new string[] { result, goalsA, goalsB };
        }

        protected override RateParams CreateParams(string[] rateData)
        {
            RateParams returnRate = base.CreateParams(rateData);

            if (rateData.Length > 2)
            {
                int goalsA = 0;

                if (Int32.TryParse(rateData[1], out goalsA))
                {
                    if (goalsA < 0)
                        throw new Exception("Ошибка привязчика ставки. Некорректные данные для выбор количества голов первой команды.");
                    else
                        returnRate.GoalsA = goalsA;
                }
                else
                {
                    throw new Exception("Ошибка привязчика ставки. Некорректные данные для выбор количества голов первой команды.");
                }

                int goalsB = 0;

                if (Int32.TryParse(rateData[2], out goalsB))
                {
                    if (goalsB < 0)
                        throw new Exception("Ошибка привязчика ставки. Некорректные данные для выбор количества голов первой команды.");
                    else
                        returnRate.GoalsB = goalsB;
                }
                else
                {
                    throw new Exception("Ошибка привязчика ставки. Некорректные данные для выбор количества голов первой команды.");
                }
            }
            else
            {
                throw new Exception("Ошибка привязчика ставки. Недостаточно данных для ставки.");
            }

            return returnRate;
        }

    }
}
