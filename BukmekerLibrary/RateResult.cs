using System;

namespace BukmekerLibrary
{
    public class RateResult
    {
        public string[] GetResultInfo(Game game, Rate rate)
        {
            return new string[] { GetGameResult(game), GetRateResult(game, rate) };
        }

        private string GetGameResult(Game game)
        {
            if (game.ScoreTeamA == game.ScoreTeamB)
            {
                return "Игра закончилась в ничью";
            }
            else
            {
                if (game.ScoreTeamA > game.ScoreTeamB)
                    return "Победила команда: " + game.NameTeamA;
                if (game.ScoreTeamA < game.ScoreTeamB)
                    return "Победила команда: " + game.NameTeamB;
            }

            throw new Exception("Ошибка вывода результата игры");
        }

        private string GetRateResult(Game game, Rate rate)
        {
            if (rate.RateTypeIndex == 0)
            {
                if (game.ScoreTeamA == game.ScoreTeamB)
                {
                    return "Вы выиграли x3: " + (rate.Params.Size * 3).ToString();
                }
                else
                    return "Увы, в этот раз вы проиграли, приходите к нам еще";
            }

            if (rate.RateTypeIndex == 1)
            {
                if (game.ScoreTeamA == game.ScoreTeamB)
                    return "Увы, в этот раз вы проиграли, приходите к нам еще";
                else
                {
                    if ((rate.Params.TeamIndex == 0 && game.ScoreTeamA > game.ScoreTeamB) ||
                        (rate.Params.TeamIndex == 1 && game.ScoreTeamA < game.ScoreTeamB))
                    {
                        return "Вы выиграли x2: " + (rate.Params.Size * 2).ToString();
                    }
                    else
                        return "Увы, в этот раз вы проиграли, приходите к нам еще";
                }
            }

            if (rate.RateTypeIndex == 2)
            {
                if (game.ScoreTeamA == game.ScoreTeamB)
                {
                    return "Увы, в этот раз вы проиграли, приходите к нам еще";
                }
                else
                {
                    if (rate.Params.GoalsA == game.ScoreTeamA && rate.Params.GoalsB == game.ScoreTeamA)
                    {
                        return "Вы выиграли x4: " + (rate.Params.Size * 2).ToString();
                    }
                    else
                        return "Увы, в этот раз вы проиграли, приходите к нам еще";
                }
            }

            throw new Exception("Ошибка вывода результата ставки");
        }
    }
}
