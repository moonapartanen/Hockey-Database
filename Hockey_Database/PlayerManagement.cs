using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hockey_Database
{
    public partial class PlayerManagement : Form
    {
        string playerManagementQuery = "SELECT players.ID, players.name, players.dateOfBirth, players.number, teams.name, positions.position " +
                                       "FROM players " +
                                       "INNER JOIN teams ON players.team_ID = teams.ID " +
                                       "INNER JOIN positions ON players.position_ID = positions.ID; ";

        public string teamsQuery = "SELECT DISTINCT ID, name " +
                                    "FROM teams";

        // LUODAAN DB-OLIO
        dbConnect db = new dbConnect();
        int id, positionID;

        public PlayerManagement()
        {
            InitializeComponent();
        }

        private void SelectPlayerManagement()
        {
            dgPlayerManagement.DataSource = db.Select(playerManagementQuery);

            dgPlayerManagement.Columns[0].HeaderText = "ID:";                    
            dgPlayerManagement.Columns[1].HeaderText = "Pelaajan nimi:";
            dgPlayerManagement.Columns[2].HeaderText = "Syntymäaika:";
            dgPlayerManagement.Columns[3].HeaderText = "Pelinumero:";
            dgPlayerManagement.Columns[4].HeaderText = "Joukkue:";
            dgPlayerManagement.Columns[5].HeaderText = "Pelipaikka:";
        }

        private void PlayerManagement_Load(object sender, EventArgs e)
        {
            //db.OpenConnection();   
            SelectPlayerManagement();

            cmbTeams_pm.SelectedIndex = -1;
            cmbTeams_pm.DataSource = db.Select(teamsQuery);
            cmbTeams_pm.DisplayMember = "name";
            cmbTeams_pm.ValueMember = "ID";
        }

        private void dgPlayerManagement_SelectionChanged(object sender, EventArgs e)    // KUN ROW SELECTION VAIHTUU
        {
            if (dgPlayerManagement.SelectedRows.Count > 0) 
            {
                txtName_pm.Text = dgPlayerManagement.SelectedRows[0].Cells[1].Value + string.Empty;
                dpDateOfBirth_pm.Value = Convert.ToDateTime(dgPlayerManagement.SelectedRows[0].Cells[2].Value);
                cmbTeams_pm.Text = dgPlayerManagement.SelectedRows[0].Cells[4].Value + string.Empty;
                txtNumber_pm.Text = dgPlayerManagement.SelectedRows[0].Cells[3].Value + string.Empty;

                switch (dgPlayerManagement.SelectedRows[0].Cells[5].Value + string.Empty)
                {
                    case "Hyökkääjä":
                        rbForward_pm.Checked = true;
                        positionID = 1;
                        break;
                    case "Puolustaja":
                        rbDefender_pm.Checked = true;
                        positionID = 2;
                        break;
                    case "Maalivahti":
                        rbGoalie_pm.Checked = true;
                        positionID = 3;
                        break;
                }

                id = Convert.ToInt32(dgPlayerManagement.SelectedRows[0].Cells[0].Value);    // ID TALTEEN POISTOA TAI MUOKKAUSTA VARTEN
            }
        }

        private void btnClear_Click(object sender, EventArgs e)     // TYHJENNETÄÄN KENTÄT
        {
            dgPlayerManagement.ClearSelection();        // TODO: TÄHÄN VARMASTI PAREMPI TAPA OLEMASSA
            txtName_pm.Text = "";
            cmbTeams_pm.SelectedIndex = -1;             // TODO: KORJAA TÄMÄ
            txtNumber_pm.Text = "";
            dpDateOfBirth_pm.Value = DateTime.Now;
            rbForward_pm.Checked = false;
            rbDefender_pm.Checked = false;
            rbGoalie_pm.Checked = false;
            id = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string playerEditQuery = "SELECT * FROM players WHERE ID = " + id + ";";

            DataTable dt = db.Select(playerEditQuery);

            if (dt.Rows.Count > 0)
            {

                // TÄHÄN UPDATE
               
            }
            else
            {
                if (rbForward_pm.Checked)
                {
                    positionID = 1;
                }
                else if (rbDefender_pm.Checked)
                {
                    positionID = 2;
                }
                else if (rbGoalie_pm.Checked)   
                {
                    positionID = 3;
                }


                string date = dpDateOfBirth_pm.Value.ToString("yyyy-MM-dd").Replace('.', '-');
                string query = "INSERT INTO players (name, dateOfBirth, number, team_ID, position_ID) " +
                               "VALUES ('" + txtName_pm.Text + "', '" + date + "', "
                               + txtNumber_pm.Text + ", " + cmbTeams_pm.SelectedValue.ToString() + ", "
                               + positionID + ");";

                db.Insert(query);
                SelectPlayerManagement();
            }
        }
    }
}
