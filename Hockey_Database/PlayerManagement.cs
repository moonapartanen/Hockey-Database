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
        // LUODAAN DB-OLIO
        dbConnect db = new dbConnect();
        int id, positionID;

        public PlayerManagement()
        {
            InitializeComponent();
        }

        private int GetPositionId()
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
        }

        private void SelectPlayerManagement()   // HAKEE TIEDOT DATAGRIDVIEWIIN
        {
            dgPlayerManagement.DataSource = db.Select(db.playerManagementQuery);

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
            cmbTeams_pm.DataSource = db.Select(db.teamsQuery);
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

        private void btnClear_Click(object sender, EventArgs e)     // TYHJENNETÄÄN KENTÄT      TODO: TÄHÄN VARMASTI PAREMPI TAPA OLEMASSA
        {
            dgPlayerManagement.ClearSelection();       
            txtName_pm.Text = "";
            cmbTeams_pm.Text = "";      
            txtNumber_pm.Text = "";
            dpDateOfBirth_pm.Text = "";
            rbForward_pm.Checked = false;
            rbDefender_pm.Checked = false;
            rbGoalie_pm.Checked = false;
            id = 0;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgPlayerManagement.SelectedRows.Count > 0)
            {
                string query = "DELETE FROM players WHERE ID = " + dgPlayerManagement.SelectedRows[0].Cells[0].Value + string.Empty;
                db.ManageDatabase(query);
                //MessageBox.Show("Poisto onnistui!");
                SelectPlayerManagement();
            }
            else
            {
                MessageBox.Show("Et ole valinnut poistettavaa riviä!");
            }
        }

        private void lblTooltip_MouseHover(object sender, EventArgs e)
        {
            toolTipPlayerManagement.Show("Valitse alasvetovalikosta tietokannan taulu, jota haluat muokata. \n" +
                            "Jos haluat lisätä tauluun tietoa, kirjoita tiedot kenttiin ja paina \n" +
                            "'Tallenna'-painiketta. Jos haluat muokata jo olemassa olevaa tieta, \n" +
                            "valitse haluamasi rivi ja muokkaa tietoja kentistä. Paina muokkauksen \n" +
                            "jäkeen 'Tallenna'-painiketta. Poistaminen onnistuu valitsemalla ensin rivi \n" +
                            "ja sen jälkeen painamalla 'Poista'-painiketta. ", lblTooltip);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string playerEditQuery = "SELECT * FROM players WHERE ID = " + id + ";";
            DataTable dt = db.Select(playerEditQuery);

            if(CheckIfEmpty())
            {
                if (dt.Rows.Count > 0)
                {

                    string date = dpDateOfBirth_pm.Value.ToString("yyyy-MM-dd").Replace('.', '-');
                    string query = "UPDATE players SET name='" + txtName_pm.Text + "', dateOfBirth='" + date + "', number=" + txtNumber_pm.Text + ", team_ID=" + cmbTeams_pm.SelectedValue.ToString() + ", position_ID=" + GetPositionId() + " WHERE ID=" + id;
                    db.ManageDatabase(query);
                    //MessageBox.Show("Tietojen päivitys onnistui!");
                    SelectPlayerManagement();

                }
                else
                {
                    string date = dpDateOfBirth_pm.Value.ToString("yyyy-MM-dd").Replace('.', '-');
                    string query = "INSERT INTO players (name, dateOfBirth, number, team_ID, position_ID) " +
                                   "VALUES ('" + txtName_pm.Text + "', '" + date + "', "
                                   + txtNumber_pm.Text + ", " + cmbTeams_pm.SelectedValue.ToString() + ", "
                                   + GetPositionId() + ");";

                    db.ManageDatabase(query);
                    // MessageBox.Show("Tietojen lisäys onnistui!");
                    SelectPlayerManagement();
                }
            }
            else
            {
                MessageBox.Show("Taytä kentät!");
            }
        }
    }
}
