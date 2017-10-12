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
        dbConnect db = new dbConnect();
        int id;

        public TeamManagement()
        {
            InitializeComponent();
        }

        private bool CheckIfEmpty()
        {
            bool ret = true;

            if (txtName_tm.Text.Length == 0 || cmbCoaches_tm.SelectedIndex < 0 || cmbLeagues_tm.SelectedIndex < 0 || cmbStadiums_tm.Text.Length < 0)
            {
                ret = false;
            }

            return ret;
        }   // TARKISTUS; ONKO TYHJIÄ KENTTIÄ

        private void SelectTeamManagement(string hintString)
        {
            dgTeamManagement.DataSource = db.Select(db.teamManagementQuery);

            dgTeamManagement.Columns[0].HeaderText = "ID:";
            dgTeamManagement.Columns[1].HeaderText = "Joukkueen nimi:";
            dgTeamManagement.Columns[2].HeaderText = "Kotistadion:";
            dgTeamManagement.Columns[3].HeaderText = "Liiga:";
            dgTeamManagement.Columns[4].HeaderText = "Päävalmentaja:";

            dgTeamManagement.ClearSelection();  

            lblTeamManagementHint.Text = hintString;
        }

        private void FillComboboxes()
        {
            // HAETAAN COMBOBOXEIHIN TIEDOT

            cmbStadiums_tm.DataSource = db.Select(db.stadiumsQuery);
            cmbStadiums_tm.DisplayMember = "name";
            cmbStadiums_tm.ValueMember = "ID";
            cmbStadiums_tm.SelectedIndex = -1; 

            cmbLeagues_tm.DataSource = db.Select(db.leaguesQuery);
            cmbLeagues_tm.DisplayMember = "name";
            cmbLeagues_tm.ValueMember = "ID";
            cmbLeagues_tm.SelectedIndex = -1;

            cmbCoaches_tm.DataSource = db.Select(db.coachesQuery);
            cmbCoaches_tm.DisplayMember = "name";
            cmbCoaches_tm.ValueMember = "ID";
            cmbCoaches_tm.SelectedIndex = -1;
        }

        private void TeamManagement_Load(object sender, EventArgs e)
        {
            SelectTeamManagement("Hallinnoi joukkueita: valitsemalla joukkueen listasta, \n" +
                                 "voit muokata sen tietoja tai poistaa sen. \n" +
                                 "Uuden joukkueen voit lisätä kirjoittamalla tiedot \n" +
                                 "kenttiin ja painamalla 'Tallenna'-painiketta.");
            FillComboboxes();
            EmptyFields();
        }

        private void dgTeamManagement_SelectionChanged(object sender, EventArgs e)
        {
            btnDel.Enabled = true;      // POISTO-NAPPI ENABLOITUU KUN VALITAAN JOKU JOUKKUE
            btnClear.Enabled = true;    // TYHJENNÄ-NAPPI ENABLOITUU KUN VALITAAN JOKU JOUKKUE

            if (dgTeamManagement.SelectedRows.Count > 0)
            {
                txtName_tm.Text = dgTeamManagement.SelectedRows[0].Cells[1].Value + string.Empty;
                cmbStadiums_tm.Text = dgTeamManagement.SelectedRows[0].Cells[2].Value + string.Empty;
                cmbLeagues_tm.Text = dgTeamManagement.SelectedRows[0].Cells[3].Value + string.Empty;
                cmbCoaches_tm.Text = dgTeamManagement.SelectedRows[0].Cells[4].Value + string.Empty;

                id = Convert.ToInt32(dgTeamManagement.SelectedRows[0].Cells[0].Value);    // ID TALTEEN POISTOA TAI MUOKKAUSTA VARTEN
            }

            btnClear.Text = "Tyhjennä kentät uuden joukkueen tietoja varten";

            lblTeamManagementHint.Text = "Valitsit joukkueen " + txtName_tm.Text + ". \n" +
                               "Voit muokata joukkueen tietoja kirjoittamalla uudet arvot kenttiin \n" +
                               "ja painamalla 'Tallenna'-painiketta tai voit poistaa joukkueen \n" +
                               "painamalla 'Poista'-painiketta.";
        }

        private void EmptyFields()
        {
            dgTeamManagement.ClearSelection();
            txtName_tm.Text = "";
            cmbStadiums_tm.Text = "";
            cmbStadiums_tm.SelectedIndex = -1;
            cmbLeagues_tm.Text = "";
            cmbLeagues_tm.SelectedIndex = -1;
            cmbCoaches_tm.Text = "";
            cmbCoaches_tm.SelectedIndex = -1;

            id = 0;

            btnDel.Enabled = false;
            btnClear.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            EmptyFields();
            lblTeamManagementHint.Text = "Kirjoita uuden joukkueen tiedot kenttiin ja \n" +
                                         "paina 'Tallenna'-painiketta";
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
                    db.ManageDatabase(query);
                    SelectTeamManagement("Joukkueen " + txtName_tm.Text + " tietojen päivitys onnistui");

                }
                else
                {
                    string query = "INSERT INTO teams (name, stadium_ID, league_ID, coach_ID) " +
                                    "VALUES ('" + txtName_tm.Text + "', " + cmbStadiums_tm.SelectedValue.ToString() + ", " + cmbLeagues_tm.SelectedValue.ToString() + ", " + cmbCoaches_tm.SelectedValue.ToString() + ");";

                    db.ManageDatabase(query);
                    SelectTeamManagement("Joukkueen " + txtName_tm.Text + " lisäys onnistui.");
                }

                EmptyFields();
            }
            else
            {
               lblTeamManagementHint.Text = "Tietoja puuttuu, täytä kaikki kentät ja \n" +
                                            "paina 'Tallenna'-painiketta.";
            }
         
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jos valitsemassasi joukkueessa on pelaajia, pelaajat poistetaan joukkueen mukana. Haluatko silti poistaa joukkueen?", "Varoitus", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM teams WHERE ID = " + id;
                db.ManageDatabase(query);
                SelectTeamManagement("Joukkueen " + txtName_tm.Text + " poisto onnistui.");
            }  
        }

        private void TeamManagement_panelChanged(object sender, EventArgs e)
        {
            btnClear.Text = "Tyhjennä kentät uuden joukkueen tietoja varten";
            btnClear.Enabled = true;
            btnSave.Enabled = true;
        }
    }
}
