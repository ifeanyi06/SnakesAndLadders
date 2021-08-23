using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class Player
    {
        private List<BoardGame> _boardGames;
        public string Name { get; set; }

        public string GamesWon { get; set; }

        public void AddGame(BoardGame boardGame)
        {
            _boardGames.Add(boardGame);
        }

        public IEnumerable<BoardGame> BoardGames
        {
            get
            {
                return _boardGames.ToList();
            }
        }

    }
}
