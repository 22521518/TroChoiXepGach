using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameComponent.Player
{
    public class WriterSQL : IWriterSQL
    {
        readonly string _datapath = "Database.db";
        int _numberofplayers;
        public WriterSQL()
        {
            using (SQLiteConnection connect = new SQLiteConnection($"Data Source={_datapath}; Version=3"))
            {
                connect.Open();
                using (SQLiteCommand command = new SQLiteCommand(connect))
                {
                    command.CommandText = $"SELECT COUNT(*) FROM PLAYER;";
                    _numberofplayers = Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }
        public int InsertPlayer(string name)
        {
            using (SQLiteConnection connect = new SQLiteConnection($"Data Source={_datapath}; Version=3"))
            {
                connect.Open();
                int id;
                using (SQLiteCommand command = new SQLiteCommand(connect))
                {
                    command.CommandText = $"SELECT PLAYER_ID FROM PLAYER WHERE PLAYER_NAME = '{name}'";
                    id = Convert.ToInt32(command.ExecuteScalar());
                    if (id != 0)
                    {
                        return id;
                    }

                    command.CommandText = $"INSERT INTO PLAYER (PLAYER_ID, PLAYER_NAME) SELECT {_numberofplayers + 1}, '{name}' WHERE NOT EXISTS ( SELECT *  FROM PLAYER WHERE PLAYER_NAME = '{name}')";
                    command.ExecuteNonQuery();
                    _numberofplayers++;
                    return _numberofplayers;
                }
            }
        }
        public void InsertNewScore(Player User) 
        {
            try
            {
                using (SQLiteConnection connect = new SQLiteConnection($"Data Source={_datapath}; Version=3"))
                {
                    connect.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(connect))
                    {
                        cmd.CommandText = $"INSERT INTO SCOREBOARD (PLAYERID, SCORE, MODEID) VALUES ({User.ID}, {User.Score}, {User.ModeID})";
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        
    }
}
