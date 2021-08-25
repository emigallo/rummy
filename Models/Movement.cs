using System;

namespace rummy_v2.Models
{
    public class Movement
    {   
        public enum ActionPlayer {ADD_FROM_RACK, MOVE_IN_TABLE,
            FINISH_TURN
        }
        public ActionPlayer Action { get; internal set; }
        public String SelectedTiles { get; internal set; }
        public int Destination { get; set; }
        public int Origin { get; internal set; }
    }
}