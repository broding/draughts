using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Draughts
{
    class GameMaster
    {
        public List<Stone> stones;

        public GameMaster()
        {
            stones = new List<Stone>();
        }

        public bool IsMovePossible(Stone target, Vector2 position)
        {
            if (!IsOccupied(position))
            {

            }

            return false;
        }

        public bool IsOccupied(Vector2 position)
        {
            foreach (Stone stone in stones)
                if (stone.position == position)
                    return true;

            return false;
        }
    }
}
