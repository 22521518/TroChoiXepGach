using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace GameComponent.Player
{
    public class ReaderSQL : IReaderSQL
    {
        readonly string _datapath = "Database.db";
        private DataSet _scoreboard;
        private DataSet _playerboard;
        private DataSet _modeclassicboard;
        private DataSet _modehumanboard;
        
        public DataSet Scoreboard { get => _scoreboard; }
        public DataSet Playerboard { get => _playerboard; }
        public DataSet ModeClassicboard { get => _modeclassicboard; }
        public DataSet ModeHumanboard { get => _modehumanboard; }
        public ReaderSQL()
        {
            if (!File.Exists(_datapath))
               CreateDatabaseFile();
            UpdateData();
        }
        private void CreateDatabaseFile()
        {
            SQLiteConnection.CreateFile(_datapath);
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={_datapath}; Version=3"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "CREATE TABLE IF NOT EXISTS PLAYER (" +
                                            "PLAYER_ID TINYINT PRIMARY KEY," +
                                            "PLAYER_NAME VARCHAR(20)" +
                                            ")";
                    command.ExecuteNonQuery();
                    command.CommandText = "CREATE TABLE IF NOT EXISTS MODE (" +
                                            "MODE_ID TINYINT PRIMARY KEY," +
                                            "MODE_NAME VARCHAR(10)" +
                                            ")";
                    command.ExecuteNonQuery();
                    command.CommandText = "CREATE TABLE IF NOT EXISTS SCOREBOARD (" +
                                            "PLAYER_ID TINYINT, SCORE MEDIUMINT, MODE_ID TINYINT, " +
                                            "FOREIGN KEY (PLAYER_ID) REFERENCES PLAYER(PLAYER_ID), " +
                                            "FOREIGN KEY (MODE_ID) REFERENCES MODE(MODE_ID), " +
                                            "PRIMARY KEY (PLAYER_ID, SCORE, MODE_ID));";
                    command.ExecuteNonQuery();

                    command.CommandText = $"INSERT INTO MODE (MODE_ID, MODE_NAME) VALUES ({(int)GameMode.Classic}, 'Classic')";
                    command.ExecuteNonQuery();
                    command.CommandText = $"INSERT INTO MODE (MODE_ID, MODE_NAME) VALUES ({(int)GameMode.Human}, 'Human')";
                    command.ExecuteNonQuery();
                    command.CommandText = $"INSERT INTO MODE (MODE_ID, MODE_NAME) VALUES ({(int)GameMode.PvP}, 'PvP')";
                    command.ExecuteNonQuery();


                    command.CommandText = $"INSERT INTO PLAYER (PLAYER_ID, PLAYER_NAME) VALUES (0, '{"anonymous"}')";
                    command.ExecuteNonQuery();
                }
            }
        }
        public DataSet GetData(string Query)
        {
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={_datapath}; Version=3"))
            {
                connection.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Query, connection);
                DataSet data = new DataSet();   
                adapter.Fill(data, "DATA");
                return data;
            }

        }
        public DataSet GetPlayerData(string name)
        {
            string query = $"SELECT PLAYER_NAME AS NAME, SCORE, MODE_NAME AS MODE FROM PLAYER INNER JOIN SCOREBOARD ON PLAYER.PLAYER_ID = SCOREBOARD.PLAYER_ID INNER JOIN MODE ON SCOREBOARD.MODE_ID = MODE.MODE_ID WHERE PLAYER_NAME LIKE '%{name}%'";
            return GetData(query);
        }   
        public void UpdateData()
        {
            _playerboard = new DataSet();
            _scoreboard = new DataSet();
            _modeclassicboard = new DataSet();
            _modehumanboard = new DataSet();

            _playerboard = GetData("SELECT PLAYER_ID AS ID, PLAYER_NAME AS NAME FROM PLAYER");
            _scoreboard = GetData("SELECT PLAYER_NAME AS NAME, SCORE, MODE_NAME AS MODE FROM PLAYER INNER JOIN SCOREBOARD ON PLAYER.PLAYER_ID = SCOREBOARD.PLAYER_ID INNER JOIN MODE ON SCOREBOARD.MODE_ID = MODE.MODE_ID ORDER BY SCORE DESC");
            _modeclassicboard = GetData($"SELECT PLAYER_NAME AS NAME, SCORE, MODE_NAME AS MODE FROM PLAYER INNER JOIN SCOREBOARD ON PLAYER.PLAYER_ID = SCOREBOARD.PLAYER_ID INNER JOIN MODE ON SCOREBOARD.MODE_ID = MODE.MODE_ID WHERE MODE.MODE_ID = {(int)GameMode.Classic} ORDER BY SCORE DESC");
            _modehumanboard = GetData($"SELECT PLAYER_NAME AS NAME, SCORE, MODE_NAME AS MODE FROM PLAYER INNER JOIN SCOREBOARD ON PLAYER.PLAYER_ID = SCOREBOARD.PLAYER_ID INNER JOIN MODE ON SCOREBOARD.MODE_ID = MODE.MODE_ID WHERE MODE.MODE_ID = {(int)GameMode.Human} ORDER BY SCORE DESC");
        }
    }
}
