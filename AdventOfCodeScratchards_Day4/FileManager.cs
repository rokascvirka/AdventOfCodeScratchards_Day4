using AdventOfCodeScratchards_Day4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeScratchards_Day4
{
    public static class FileManager
    {
        public static List<ScratchCard> ReadFile(string path)
        {
            List<ScratchCard> cards = new List<ScratchCard>();

            using(StreamReader sr = new StreamReader(path))
            {
                var text = sr.ReadToEnd().Split(Environment.NewLine);

                foreach(var line in text)
                {
                    List<int> winNum = new List<int>();
                    List<int> yourNum = new List<int>();
                    if(line != string.Empty)
                    {
                        var data = line.Trim().Split("|");
                        var firstPart = data[0].Trim().Split(":");
                        var cardId = int.Parse(firstPart[0].Trim().Replace("Card", "").Replace(" ", ""));
                        var winningNumbers = firstPart[1].Split(" ");
                        var yourNumbers = data[1].Trim().Split(" ");
                        foreach (var winningNumber in winningNumbers)
                        {
                            if (winningNumber != string.Empty)
                            {
                                winNum.Add(int.Parse(winningNumber));
                            }
                        }
                        foreach (var yourNumber in yourNumbers)
                        {
                            if (yourNumber != string.Empty)
                            {
                                yourNum.Add(int.Parse(yourNumber));
                            }
                        }

                        cards.Add(new ScratchCard(cardId, winNum, yourNum));
                    }

                    
                }
            }

            return cards;
        }
    }
}
