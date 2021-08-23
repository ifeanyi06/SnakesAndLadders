using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class Dice
    {
        private readonly int numberOfDie;

        public Dice(int numberOfDie)
        {
            this.numberOfDie = numberOfDie;
        }
        public int RollDice
        {
            get
            {
                Random ran = new Random();
                return ran.Next(1, numberOfDie);
            }
        }
    }
}
