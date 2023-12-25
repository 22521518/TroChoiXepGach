using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponent.Player
{
    public class Player
    {
        private int _id;
        private string _name;
        private GameMode _modeid;
        private int _score;

        public int ID { get => _id; set => _id = value; }
        public string Name {  get => _name; set => _name = value; }
        public GameMode ModeID { get => _modeid; set => _modeid = value; }
        public int Score { get => _score; set => _score = value; }
        public Player(string name = "anonymous", int score = 0, GameMode idmode = GameMode.Classic)
        {
            AddPlayerIntoDatabase(name);
            _name = name;
            _modeid = idmode;
            _score = score;

        }
        private void AddPlayerIntoDatabase(string name)
        {
            WriterSQL writerSQL = new WriterSQL();
            _id = writerSQL.InsertPlayer(name);
        }
        public override string ToString()
        {
            string[] Modes = { "Classic", "Human", "PvP" }; 
            return $"{Name.PadRight(15)} : {ID.ToString().PadRight(5)} : " +
                    ModeID.ToString(); ;
        }
    }
}
