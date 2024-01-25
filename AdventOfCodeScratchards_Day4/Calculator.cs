using AdventOfCodeScratchards_Day4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeScratchards_Day4
{
    public static class Calculator
    {
        public static int CountScrachCards(List<ScratchCard> cards)
        {
            for (var i = 0; i < cards.Count; i++)
            {
                var card = cards[i];
                var amountOfWinningNumbers = card.AmountOfWinningNumbers;

                for(var k =  0; k < card.CardAmount; k++)
                {
                    for (var j = 1; j <= amountOfWinningNumbers; j++)
                    {
                        if ((i + j) < cards.Count)
                        {
                            cards[i + j].CardAmount++;
                        }
                    }
                }
            }

            return cards.Select(c => c.CardAmount).Sum();
        }

        private static int Repeat(List<ScratchCard> cards, int startIndex, int repetitions)
        {
            var count = 0;
            for(var i = startIndex; i <= repetitions; ++i)
            {
                var card = cards[i];
                count += card.AmountOfWinningNumbers;
            }
            return count;
        }
            
    }
}
