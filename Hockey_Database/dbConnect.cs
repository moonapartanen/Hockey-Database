using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hockey_Database
{
    class dbConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        // KAIKKI SQL-QUERYT TÄÄLLÄ, JOTTA HELPOMPI YLLÄPITÄÄ

        // TEAM-MANAGEMENT QUERYT
        public string teamManagementQuery = "SELECT teams.ID, teams.name, stadiums.name, leagues.name, coaches.name " +
                                     "FROM teams " +
                                     "INNER JOIN stadiums ON teams.stadium_ID = stadiums.ID " +
                                     "INNER JOIN leagues ON teams.league_ID = leagues.ID " +
                                     "INNER JOIN coaches ON teams.coach_ID = coaches.ID ";

        public string stadiumsQuery = "SELECT DISTINCT ID, name " +
                                    "FROM stadiums";

        public string leaguesQuery = "SELECT DISTINCT ID, name " +
                                     "FROM leagues";

        public string coachesQuery = "SELECT DISTINCT ID, name " +
                                     "FROM coaches";

        // PLAYER-MANAGEMENTIN QUERYT
        public string playerManagementQuery = "SELECT players.ID, players.name, players.dateOfBirth, players.number, teams.name, positions.position " +
                                              "FROM players " +
                                              "INNER JOIN teams ON players.team_ID = teams.ID " +
                                              "INNER JOIN positions ON players.position_ID = positions.ID; ";

        public string teamsQuery = "SELECT DISTINCT ID, name " +
                                    "FROM teams";

        // OTHER-MANAGEMENTIN QUERYT
        public string coachQuery = "SELECT * FROM coaches";

        public string leagueQuery = "SELECT * FROM leagues";

        public string stadiumQuery = "SELECT * FROM stadiums";

        // PÄÄFORMIN QUERYT
        public string playersQuery = "SELECT players.name, players.dateOfBirth, teams.name, leagues.name, players.number, positions.position " +
                                     "FROM players " +
                                     "INNER JOIN teams ON players.team_ID = teams.ID " +
                                     "INNER JOIN leagues ON teams.league_ID = leagues.ID " +
                                     "INNER JOIN positions ON players.position_ID = positions.ID; ";

        public string yearOfBirthQuery = "SELECT DISTINCT SUBSTRING(dateOfBirth, 1, 4) " +
                                         "FROM players " +
                                         "ORDER BY SUBSTRING(dateOfBirth, 1, 4) ASC;";

        public string leaguesMainQuery = "SELECT DISTINCT name " +
                                         "FROM leagues";

        public string positionQuery = "SELECT DISTINCT position " +
                                      "FROM positions";

        public string teamQuery = "SELECT teams.name, coaches.name, stadiums.name, leagues.name " +
                                   "FROM teams " +
                                   "INNER JOIN coaches ON teams.coach_ID = coaches.ID " +
                                   "INNER JOIN leagues ON teams.league_ID = leagues.ID " +
                                   "INNER JOIN stadiums ON teams.stadium_ID = stadiums.ID; ";

        public dbConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "hockey_database";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
    
        public bool OpenConnection()
        {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Ei yhteyttä tietokantaan.");
                            break;

                        case 1045:
                            MessageBox.Show("Väärät käyttäjätunnukset tietokantaan, yritä uudelleen!");
                            break;
                    }
                    return false;
}
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public System.Data.DataTable Select(string query)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            return dt;
        }

        public void ManageDatabase(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void Exit()
        {
            this.CloseConnection(); // TÄMÄ PITÄÄ TEHDÄ OHJELMAN SULKEUDUTTUA
        }
        
    }
}
