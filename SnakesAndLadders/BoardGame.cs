using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class BoardGame
    {
        private List<Player> _players;
        private List<BoardSquare> _boardSquares;
        private readonly int numberOfSquares;
        private readonly Dictionary<int, int> snakeAndLadderLinks;

        public BoardGame(List<Player> players, int numberOfSquares,Dictionary<int,int> snakeAndLadderLinks)
        {
            _players = players;
            this.numberOfSquares = numberOfSquares;
            this.snakeAndLadderLinks = snakeAndLadderLinks;
        }

        public void SetUp()
        {
            AddSquares();
            AddSnakeAndLadderLinks();
        }

        private void AddSnakeAndLadderLinks()
        {
            snakeAndLadderLinks.ToList().ForEach(x =>
                _boardSquares.Find(y => y.SquareNumber == x.Key).Next = x.Value
            ); 
        }

        private void AddSquares()
        {
            for (int i = 1; i < (numberOfSquares + 1); i++)
            {
                _boardSquares.Add(new BoardSquare(i));
            }
        }
    }
}
