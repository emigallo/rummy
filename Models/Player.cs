using System;
using System.Collections.Generic;

namespace rummy_v2.Models
{
    public class Player
    {

        Table _table;
        Rack _rack;

        public Player(Table table)
        {
            this._table = table;
            this._rack = new Rack();
        }

        public void PlayTurn()
        {
            Movement movement = null;
            this.TileAddedToGroup = false;
            do
            {
                movement = this.ReadMovement();
                switch (movement.Action)
                {
                    case Movement.ActionPlayer.ADD_FROM_RACK: AddTileToGroup(movement); break;
                    case Movement.ActionPlayer.MOVE_IN_TABLE: this._table.MoveTilesInTable(movement); break;
                    case Movement.ActionPlayer.FINISH_TURN : this._table.IsValid(); break;
                }

            } while (this.IsWinner() || movement.Action != Movement.ActionPlayer.FINISH_TURN);
        }

        private void AddTileToGroup(Movement movement)
        {
            List<TileBase> tiles = null;
            if (this._rack.ValidateMovemnt(movement.SelectedTiles))
            {
                tiles = this._rack.GetTiles(movement.SelectedTiles);
                this._table.AddTiles(tiles, movement.Destination);
                this._rack.ExtractTile(tiles);
                this.TileAddedToGroup = true;
            }
            else
            {
                this.MostrarError("");
            }
        }

        private void MostrarError(string v)
        {
            Console.WriteLine(v);
        }

        private void Show()
        {
            Console.WriteLine("----");
            this._rack.Show();
        }

        public bool TileAddedToGroup { get; private set; }

        public void ExtractTile(TileBase p)
        {
            this._rack.Add(p);
        }

        public bool IsWinner()
        {
            return this._rack.Empty();
        }

        private Movement ReadMovement()
        {
            throw new NotImplementedException();
        }
    }
}