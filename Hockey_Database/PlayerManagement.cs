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
        dbConnect db = new dbConnect();
        int id, positionID;

        public PlayerManagement()
        {
            InitializeComponent();
        }

        private int GetPositionId()  // PALAUTTAA PELIPAIKAN ID:N
        {
            int positionID = 0;

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

            return positionID;
        }

        private bool CheckIfEmpty()
        {
            bool ret = true;

            if (rbDefender_pm.Checked || rbForward_pm.Checked || rbGoalie_pm.Checked)
            {
                if (txtName_pm.Text.Length == 0 || txtNumber_pm.Text.Length == 0)
                {
                    ret = false;
                }
            }
            else
            {
                ret = false;
            }

            return ret;
        }   // TARKISTUS, ONKO KENTTIÄ TYHJINÄ

        private void SelectPlayerManagement(string hintString)   // HAKEE TIEDOT DATAGRIDVIEWIIN, PÄIVITTÄÄ NÄKYMÄN
        {
            dgPlayerManagement.DataSource = db.Select(db.playerManagementQuery);

            dgPlayerManagement.Columns[0].HeaderText = "ID:";                    
            dgPlayerManagement.Columns[1].HeaderText = "Pelaajan nimi:";
            dgPlayerManagement.Columns[2].HeaderText = "Syntymäaika:";
            dgPlayerManagement.Columns[3].HeaderText = "Pelinumero:";
            dgPlayerManagement.Columns[4].HeaderText = "Joukkue:";
            dgPlayerManagement.Columns[5].HeaderText = "Pelipaikka:";

            dgPlayerManagement.ClearSelection();

            lblPlayerManagementHint.Text = hintString;
        }

        private void PlayerManagement_Load(object sender, EventArgs e)
        {  
            SelectPlayerManagement("Hallinnoi pelaajia: valitsemalla pelaajan listasta, \n" +
                                   "voit muokata hänen tietojaan tai poistaa hänet. \n" +
                                   "Uuden pelaajan voit lisätä kirjoittamalla tiedot kenttiin\n " +
                                   "ja painamalla 'Tallenna'-painiketta.");

            cmbTeams_pm.DataSource = db.Select(db.teamsQuery);
            cmbTeams_pm.DisplayMember = "name";
            cmbTeams_pm.ValueMember = "ID";

            EmptyFields();
        }

        private void dgPlayerManagement_SelectionChanged(object sender, EventArgs e)    // KUN ROW SELECTION VAIHTUU
        {
            btnDel.Enabled = true;      // POISTO-NAPPI ENABLOITUU KUN VALITAAN JOKU PELAAJA
            btnClear.Enabled = true;    // TYHJENNÄ-NAPPI ENABLOITUU KUN VALITAAN JOKU PELAAJA

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

                btnClear.Text = "Tyhjennä kentät uuden pelaajan tietoja varten";

                lblPlayerManagementHint.Text = "Valitsit pelaajan " + txtName_pm.Text + ". \n" +
                                               "Voit muokata pelaajan tietoja kirjoittamalla uudet arvot kenttiin \n" +
                                               "ja painamalla 'Tallenna'-painiketta tai voit poistaa pelaajan \n" +
                                               "painamalla 'Poista'-painiketta.";
            }
        }

        public void EmptyFields()  // TYHJENTÄÄ KENTÄT 
        {
            dgPlayerManagement.ClearSelection();       
            txtName_pm.Text = "";
            cmbTeams_pm.Text = "";      
            txtNumber_pm.Text = "";
            rbForward_pm.Checked = false;
            rbDefender_pm.Checked = false;
            rbGoalie_pm.Checked = false;
            id = 0;
            btnDel.Enabled = false;
            btnClear.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)         
        {
            EmptyFields();
            lblPlayerManagementHint.Text = "Kirjoita uuden pelaajan tiedot kenttiin ja paina 'Tallenna'-painiketta";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM players WHERE ID = " + dgPlayerManagement.SelectedRows[0].Cells[0].Value + string.Empty;
            db.ManageDatabase(query);
            SelectPlayerManagement("Pelaajan " + txtName_pm.Text + " poisto onnistui.");
            EmptyFields();
            
        }

        private void PlayerManagement_panelChanged(object sender, EventArgs e)
        {
            btnClear.Text = "Tyhjennä kentät uuden pelaajan tietoja varten";
            btnClear.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string playerEditQuery = "SELECT * FROM players WHERE ID = " + id + ";";
            DataTable dt = db.Select(playerEditQuery);

            if(CheckIfEmpty())
            {
                if (dt.Rows.Count > 0)  // TIETOJEN PÄIVITYS
                {
                    string date = dpDateOfBirth_pm.Value.ToString("yyyy-MM-dd").Replace('.', '-');
                    string query = "UPDATE players SET name='" + txtName_pm.Text + "', dateOfBirth='" + date + "', number=" + txtNumber_pm.Text + ", team_ID=" + cmbTeams_pm.SelectedValue.ToString() + ", position_ID=" + GetPositionId() + " WHERE ID=" + id;
                    db.ManageDatabase(query);
                    SelectPlayerManagement("Pelaajan " + txtName_pm.Text + " tietojen päivitys onnistui");
                }
                else    // TIETOJEN LISÄYS
                {
                    string date = dpDateOfBirth_pm.Value.ToString("yyyy-MM-dd").Replace('.', '-');
                    string query = "INSERT INTO players (name, dateOfBirth, number, team_ID, position_ID) " +
                                   "VALUES ('" + txtName_pm.Text + "', '" + date + "', "
                                   + txtNumber_pm.Text + ", " + cmbTeams_pm.SelectedValue.ToString() + ", "
                                   + GetPositionId() + ");";

                    db.ManageDatabase(query);
                    SelectPlayerManagement("Pelaajan " + txtName_pm.Text + " lisäys onnistui.");
                }

                EmptyFields();
            }
            else
            {
                lblPlayerManagementHint.Text = "Tietoja puuttuu, täytä kaikki kentät ja paina 'Tallenna'-painiketta.";
            }
        }
    }
}
