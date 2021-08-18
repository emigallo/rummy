using System;
using System.Collections.Generic;
using rummy_v2.Models;

namespace rummy_v2
{
    class Rummy
    {
        const int NUM_PLAYERS = 4;
        const int NUM_INIT_TILES = 14;
        List<Player> _players;
        Turn _turn;
        Table _table;
        Pounch _pounch;
        public Rummy()
        {
            this._players = InitPlayers();
            this._turn = new Turn(_players);
            this._table = new Table();
            this._pounch = new Pounch();
        }

        private List<Player> InitPlayers()
        {
            var result = new List<Player>(NUM_PLAYERS);
            for (int i = 0; i < NUM_PLAYERS; i++)
            {
                var p = new Player(this._table);
                for(int j=0; i<NUM_INIT_TILES; j++){
                    p.ExtractTile(_pounch.TakeTile());
                }
                this._players.Add(p);
            }
            return result;
        }

        private void Play()
        {
            Player player = null;
            do{
                player = this._turn.Next();
                player.PlayTurn();
                if(!player.TileAddedToGroup()){
                    player.ExtractTile(_pounch.TakeTile());
                }
            }while(!player.IsWinner());            
        }
        static void Main(string[] args)
        {
            new Rummy().Play();
        }
    }
}
