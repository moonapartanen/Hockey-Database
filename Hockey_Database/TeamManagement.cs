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
    public partial class TeamManagement : Form
    {
        string teamManagementQuery = "SELECT teams.ID, teams.name, stadiums.name, leagues.name, coaches.name " +
                                     "FROM teams " +
                                     "INNER JOIN stadiums ON teams.stadium_ID = stadiums.ID " +
                                     "INNER JOIN leagues ON teams.league_ID = leagues.ID " +
                                     "INNER JOIN coaches ON teams.coach_ID = coaches.ID ";

        string stadiumsQuery = "SELECT DISTINCT ID, name " +
                                    "FROM stadiums";

        string leaguesQuery = "SELECT DISTINCT ID, name " +
                              "FROM leagues";

        string coachesQuery = "SELECT DISTINCT ID, name " +
                              "FROM coaches";

        dbConnect db = new dbConnect();

        int id;

        public TeamManagement()
        {
            InitializeComponent();
        }

        private bool CheckIfEmpty()
        {
            bool ret = true;

            if (txtName_tm.Text.Length == 0 || cmbCoaches_tm.SelectedIndex == -1 || cmbLeagues_tm.SelectedIndex == -1 || cmbStadiums_tm.Text.Length == -1)
            {
                ret = false;
            }

            return ret;
        }

        private void SelectTeamManagement()
        {
            dgTeamManagement.DataSource = db.Select(teamManagementQuery);

            dgTeamManagement.Columns[0].HeaderText = "ID:";
            dgTeamManagement.Columns[1].HeaderText = "Joukkueen nimi:";
            dgTeamManagement.Columns[2].HeaderText = "Kotistadion:";
            dgTeamManagement.Columns[3].HeaderText = "Liiga:";
            dgTeamManagement.Columns[4].HeaderText = "Päävalmentaja:";

            dgTeamManagement.ClearSelection();  // POISTETAAN SAMALLA DATAGRIDVIEWIN VALINTA
        }

        private void FillComboboxes()
        {
            // HAETAAN COMBOBOXEIHIN TIEDOT

            cmbStadiums_tm.DataSource = db.Select(stadiumsQuery);
            cmbStadiums_tm.DisplayMember = "name";
            cmbStadiums_tm.ValueMember = "ID";
            cmbStadiums_tm.SelectedIndex = -1; 

            cmbLeagues_tm.DataSource = db.Select(leaguesQuery);
            cmbLeagues_tm.DisplayMember = "name";
            cmbLeagues_tm.ValueMember = "ID";
            cmbLeagues_tm.SelectedIndex = -1;

            cmbCoaches_tm.DataSource = db.Select(coachesQuery);
            cmbCoaches_tm.DisplayMember = "name";
            cmbCoaches_tm.ValueMember = "ID";
            cmbCoaches_tm.SelectedIndex = -1;
        }

        private void TeamManagement_Load(object sender, EventArgs e)
        {
            SelectTeamManagement();
            FillComboboxes();
        }

        private void dgTeamManagement_SelectionChanged(object sender, EventArgs e)
        {
            if (dgTeamManagement.SelectedRows.Count > 0)
            {
                txtName_tm.Text = dgTeamManagement.SelectedRows[0].Cells[1].Value + string.Empty;
                cmbStadiums_tm.Text = dgTeamManagement.SelectedRows[0].Cells[2].Value + string.Empty;
                cmbLeagues_tm.Text = dgTeamManagement.SelectedRows[0].Cells[3].Value + string.Empty;
                cmbCoaches_tm.Text = dgTeamManagement.SelectedRows[0].Cells[4].Value + string.Empty;

                id = Convert.ToInt32(dgTeamManagement.SelectedRows[0].Cells[0].Value);    // ID TALTEEN POISTOA TAI MUOKKAUSTA VARTEN
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgTeamManagement.ClearSelection();
            txtName_tm.Text = "";
            cmbStadiums_tm.Text = "";
            cmbLeagues_tm.Text = "";
            cmbCoaches_tm.Text = "";

            id = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string teamEditQuery = "SELECT * FROM teams WHERE ID = " + id + ";";
            DataTable dt = db.Select(teamEditQuery);

            if (CheckIfEmpty())
            {
                if (dt.Rows.Count > 0)
                {
                    string query = "UPDATE teams SET name='" + txtName_tm.Text + "', stadium_ID=" + cmbStadiums_tm.SelectedValue.ToString() + ", league_ID=" + cmbLeagues_tm.SelectedValue.ToString() + ", coach_ID=" + cmbCoaches_tm.SelectedValue.ToString() + " WHERE ID=" + id;
                    db.Update(query);
                    MessageBox.Show("Tietojen päivitys onnistui!");
                    SelectTeamManagement();

                }
                else
                {
                    string query = "INSERT INTO teams (name, stadium_ID, league_ID, coach_ID) " +
                                    "VALUES ('" + txtName_tm.Text + "', " + cmbStadiums_tm.SelectedValue.ToString() + ", " + cmbLeagues_tm.SelectedValue.ToString() + ", " + cmbCoaches_tm.SelectedValue.ToString() + ");";

                    db.Insert(query);
                    MessageBox.Show("Tietojen lisäys onnistui!");
                    SelectTeamManagement();
                }
            }
            else
            {
                MessageBox.Show("Täytä kentät!");
            }
         
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgTeamManagement.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Jos valitsemassasi joukkueessa on pelaajia, pelaajat poistetaan joukkueen mukana. Haluatko silti poistaa joukkueen?", "Varoitus", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "DELETE FROM teams WHERE ID = " + id;
                    db.Delete(query);
                    MessageBox.Show("Poisto onnistui!");
                    SelectTeamManagement();
                }
            }
            else
            {
                MessageBox.Show("Et ole valinnut poistettavaa riviä!");
            }
        }
    }
}
