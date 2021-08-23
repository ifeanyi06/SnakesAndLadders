using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class BoardSquare
    {
        private int squareNumber;
        private int _next;

        public BoardSquare(int squareNumber)
        {
            this.squareNumber = squareNumber;
        }

        public int SquareNumber
        {
            set => squareNumber = value;
            get => squareNumber;
        }

        public int Next
        {
            set => _next = value;
            get => _next;
        }
    }
}
