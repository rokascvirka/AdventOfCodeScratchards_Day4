﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeScratchards_Day4.Models
{
    public class ScratchCard
    {
        public int CardId { get; set; }
        public List<int> WinningNumbers { get; set; }
        public List<int> YourNumbers { get; set; }
        public int Repetitions { get; set; }
        public double Score { get; set; }

        public ScratchCard(int cardId, List<int> winningNumbers, List<int> yourNumbers)
        {
            CardId = cardId;
            WinningNumbers = winningNumbers;
            YourNumbers = yourNumbers;
            Repetitions = CountRepetitions(winningNumbers, yourNumbers);
            Score = CountScore(Repetitions);
        }

        private int CountRepetitions(List<int> winningNumbers, List<int> yourNumbers) 
        {
            var count = 0;  
            foreach(var yourNumber in yourNumbers)
            {
                if (winningNumbers.Contains(yourNumber))
                {
                    count++;
                }
            }
            return count;
        }
        private double CountScore(int repetitions)
        {
            if(repetitions == 0) return 0;
            if(repetitions == 1) return 1;
            return Math.Pow(2, repetitions);
        }
    }
}