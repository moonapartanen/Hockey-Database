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
    public partial class OtherManagement : Form
    {
        dbConnect db = new dbConnect();

        int id;

        public OtherManagement()
        {
            InitializeComponent();
        }

        private void SelectCoachManagement()
        {
            dgOtherManagement.DataSource = db.Select(db.coachQuery);

            dgOtherManagement.Columns[0].HeaderText = "ID:";
            dgOtherManagement.Columns[1].HeaderText = "Valmentajan nimi:";

            dgOtherManagement.ClearSelection();  // POISTETAAN SAMALLA DATAGRIDVIEWIN VALINTA

            id = 0;     // NOLLATAAN ID
        }

       private void SelectLeagueManagement()
        {
            dgOtherManagement.DataSource = db.Select(db.leagueQuery);

            dgOtherManagement.Columns[0].HeaderText = "ID:";
            dgOtherManagement.Columns[1].HeaderText = "Liigan nimi:";

            dgOtherManagement.ClearSelection();  // POISTETAAN SAMALLA DATAGRIDVIEWIN VALINTA

            id = 0;     // NOLLATAAN ID
        }

        private void SelectStadiumManagement()
        {
            dgOtherManagement.DataSource = db.Select(db.stadiumQuery);

            dgOtherManagement.Columns[0].HeaderText = "ID:";
            dgOtherManagement.Columns[1].HeaderText = "Stadionin nimi:";

            dgOtherManagement.ClearSelection();  // POISTETAAN SAMALLA DATAGRIDVIEWIN VALINTA

            id = 0;     // NOLLATAAN ID
        }

        private void UpdateDataGridView()
        {
            int index = cmbOtherManagement.SelectedIndex;

            switch (index)
            {
                case 0:
                    SelectCoachManagement();
                    break;
                case 1:
                    SelectLeagueManagement();
                    break;
                case 2:
                    SelectStadiumManagement();
                    break;
            }
        }

        private void OtherManagement_Load(object sender, EventArgs e)
        {
            cmbOtherManagement.SelectedIndex = 0;
            SelectCoachManagement();
        }

        private void cmbOtherManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNameOtherManagement.Text = "";   // TYHJENNETÄÄN TEKSTIKENTTÄ, ETTEI JÄÄ MUIDEN TAULUJEN TIETOJA
            UpdateDataGridView();
        }

        private void dgOtherManagement_SelectionChanged(object sender, EventArgs e)
        {
            if (dgOtherManagement.SelectedRows.Count > 0)
            {
                txtNameOtherManagement.Text = dgOtherManagement.SelectedRows[0].Cells[1].Value + string.Empty;
                id = Convert.ToInt32(dgOtherManagement.SelectedRows[0].Cells[0].Value);    // ID TALTEEN POISTOA TAI MUOKKAUSTA VARTEN
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNameOtherManagement.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            string editQuery = "";
            string table = "";

            if (cmbOtherManagement.SelectedIndex == 0)
            {
                editQuery = "SELECT * FROM coaches WHERE ID = " + id + ";";
                dt = db.Select(editQuery);
                table = "coaches";
            }
            else if (cmbOtherManagement.SelectedIndex == 1)
            {
                editQuery = "SELECT * FROM leagues WHERE ID = " + id + ";";
                dt = db.Select(editQuery);
                table = "leagues";
            }
            else if (cmbOtherManagement.SelectedIndex == 2)
            {
                editQuery = "SELECT * FROM stadiums WHERE ID = " + id + ";";
                dt = db.Select(editQuery);
                table = "stadiums";
            }

            if (txtNameOtherManagement.Text.Length > 0)
            {
                if (dt.Rows.Count > 0)
                {
                    string query = "UPDATE " + table + " SET name='" + txtNameOtherManagement.Text + "' WHERE ID=" + id;
                    db.ManageDatabase(query);
                    //MessageBox.Show("Tietojen päivitys onnitui!");
                    UpdateDataGridView();

                }
                else
                {
                    string query = "INSERT INTO " + table + " (name) VALUES ('" + txtNameOtherManagement.Text + "');";
                    db.ManageDatabase(query);
                    //MessageBox.Show("Tietojen lisäys onnitui!");
                    UpdateDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Täytä kentät!");
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string table = "", warning = "";

            if (cmbOtherManagement.SelectedIndex == 0)
            {
                warning = "Jos poistat valmentajat, samalla hänen joukkueensa poistetaan. Haluatko jatkaa?";
                table = "coaches";
            }
            else if (cmbOtherManagement.SelectedIndex == 1)
            {
                warning = "Jos poistat liigan, samalla kaikki liigan joukkueet poistetaan. Haluatko jatkaa?";
                table = "leagues";
            }
            else if (cmbOtherManagement.SelectedIndex == 2)
            {
                warning = "Jos poistat stadionin, samalla kaikki ne joukkueet, joiden kotistadion on kyseinen poistetaan. Haluatko jatkaa?";
                table = "stadiums";
            }

            if (dgOtherManagement.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(warning, "Varoitus", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "DELETE FROM " + table + " WHERE ID = " + id;
                    db.ManageDatabase(query);
                    //MessageBox.Show("Poisto onnistui!");
                    UpdateDataGridView();
                    txtNameOtherManagement.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Et ole valinnut poistettavaa riviä!");
            }
        }

        private void lblTooltip_MouseHover(object sender, EventArgs e)
        {
            toolTipOtherManagement.Show("Valitse alasvetovalikosta tietokannan taulu, jota haluat muokata. \n" +
                                        "Jos haluat lisätä tauluun tietoa, kirjoita tiedot kenttiin ja paina \n" +
                                        "'Tallenna'-painiketta. Jos haluat muokata jo olemassa olevaa tieta, \n" +
                                        "valitse haluamasi rivi ja muokkaa tietoja kentistä. Paina muokkauksen \n" +
                                        "jäkeen 'Tallenna'-painiketta. Poistaminen onnistuu valitsemalla ensin rivi \n" +
                                        "ja sen jälkeen painamalla 'Poista'-painiketta. ", lblTooltip);
        }
    }
}
