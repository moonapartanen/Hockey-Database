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

            if (txtName_tm.Text.Length == 0 || cmbCoaches_tm.SelectedIndex == -1 || cmbLeagues_tm.SelectedIndex == -1 || cmbStadiums_tm.Text.Length == -1)
            {
                ret = false;
            }

            return ret;
        }

        private void SelectTeamManagement()
        {
            dgTeamManagement.DataSource = db.Select(db.teamManagementQuery);

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
                    db.ManageDatabase(query);
                    // MessageBox.Show("Tietojen päivitys onnistui!");
                    SelectTeamManagement();

                }
                else
                {
                    string query = "INSERT INTO teams (name, stadium_ID, league_ID, coach_ID) " +
                                    "VALUES ('" + txtName_tm.Text + "', " + cmbStadiums_tm.SelectedValue.ToString() + ", " + cmbLeagues_tm.SelectedValue.ToString() + ", " + cmbCoaches_tm.SelectedValue.ToString() + ");";

                    db.ManageDatabase(query);
                    // MessageBox.Show("Tietojen lisäys onnistui!");
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
                    db.ManageDatabase(query);
                    // MessageBox.Show("Poisto onnistui!");
                    SelectTeamManagement();
                }
            }
            else
            {
                MessageBox.Show("Et ole valinnut poistettavaa riviä!");
            }
        }

        private void lblTooltip_MouseHover_1(object sender, EventArgs e)
        {
            toolTipTeamManagement.Show("Valitse alasvetovalikosta tietokannan taulu, jota haluat muokata. \n" +
                            "Jos haluat lisätä tauluun tietoa, kirjoita tiedot kenttiin ja paina \n" +
                            "'Tallenna'-painiketta. Jos haluat muokata jo olemassa olevaa tieta, \n" +
                            "valitse haluamasi rivi ja muokkaa tietoja kentistä. Paina muokkauksen \n" +
                            "jäkeen 'Tallenna'-painiketta. Poistaminen onnistuu valitsemalla ensin rivi \n" +
                            "ja sen jälkeen painamalla 'Poista'-painiketta. ", lblTooltip);
        }
    }
}
