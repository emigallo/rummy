using System;
using System.Collections.Generic;

namespace rummy_v2.Models
{
    public class Turn
    {
        private List<Player> players;

        public Turn(List<Player> players)
        {
            this.players = players;
        }

        internal Player Next()
        {
            throw new NotImplementedException();
        }
    }
}