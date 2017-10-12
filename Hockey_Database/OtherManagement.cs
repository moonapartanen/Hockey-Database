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
        string hintUpdate = "";

        public OtherManagement()
        {
            InitializeComponent();
        }

        private void SelectCoachManagement(string hintString)
        {
            dgOtherManagement.DataSource = db.Select(db.coachQuery);

            dgOtherManagement.Columns[0].HeaderText = "ID:";
            dgOtherManagement.Columns[1].HeaderText = "Valmentajan nimi:";

            dgOtherManagement.ClearSelection();  
            id = 0;
            lblOtherManagementHint.Text = hintString;
            btnClear.Enabled = false;
            btnDel.Enabled = false;
        }

       private void SelectLeagueManagement(string hintString)
        {
            dgOtherManagement.DataSource = db.Select(db.leagueQuery);

            dgOtherManagement.Columns[0].HeaderText = "ID:";
            dgOtherManagement.Columns[1].HeaderText = "Liigan nimi:";

            dgOtherManagement.ClearSelection(); 
            id = 0;
            lblOtherManagementHint.Text = hintString;
            btnClear.Enabled = false;
            btnDel.Enabled = false;
        }

        private void SelectStadiumManagement(string hintString)
        {
            dgOtherManagement.DataSource = db.Select(db.stadiumQuery);

            dgOtherManagement.Columns[0].HeaderText = "ID:";
            dgOtherManagement.Columns[1].HeaderText = "Stadionin nimi:";

            dgOtherManagement.ClearSelection(); 
            id = 0;
            lblOtherManagementHint.Text = hintString;
            btnClear.Enabled = false;
            btnDel.Enabled = false;
        }

        private void UpdateDataGridView(string hintUpdate)
        {
            int index = cmbOtherManagement.SelectedIndex;

            switch (index)
            {
                case 0:
                    SelectCoachManagement(hintUpdate);
                    break;
                case 1:
                    SelectLeagueManagement(hintUpdate);
                    break;
                case 2:
                    SelectStadiumManagement(hintUpdate);
                    break;
            }
        }

        private void OtherManagement_Load(object sender, EventArgs e)
        {
            cmbOtherManagement.SelectedIndex = 0;
            SelectCoachManagement("Hallinnoi tietoja: valitsemalla valmentajan listasta, \n" +
                                 "voit muokata hänen tietojaan tai poistaa hänet. \n" +
                                 "Uuden valmentajan voit lisätä kirjoittamalla tiedot \n" +
                                 "kenttiin ja painamalla 'Tallenna'-painiketta.");

            btnDel.Enabled = false;
            btnClear.Enabled = false;
        }

        private void cmbOtherManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNameOtherManagement.Text = "";   // TYHJENNETÄÄN TEKSTIKENTTÄ, ETTEI JÄÄ MUIDEN TAULUJEN TIETOJA

            if (cmbOtherManagement.SelectedIndex == 0)
            {
                hintUpdate = "Hallinnoi tietoja: valitsemalla valmentajan listasta, \n" +
                             "voit muokata hänen tietojaan tai poistaa hänet. \n" +
                             "Uuden valmentajan voit lisätä kirjoittamalla tiedot \n" +
                             "kenttiin ja painamalla 'Tallenna'-painiketta.";

                btnClear.Text = "Tyhjennä kenttä uutta valmentajaa varten";
            }
            else if (cmbOtherManagement.SelectedIndex == 1)
            {
                hintUpdate = "Hallinnoi tietoja: valitsemalla liigan listasta, \n" +
                             "voit muokata sen tietoja tai poistaa sen. \n" +
                             "Uuden liigan voit lisätä kirjoittamalla tiedot \n" +
                             "kenttiin ja painamalla 'Tallenna'-painiketta.";

                btnClear.Text = "Tyhjennä kenttä uutta liigaa varten";
            }
            else if (cmbOtherManagement.SelectedIndex == 2)
            {
                hintUpdate = "Hallinnoi tietoja: valitsemalla stadionin listasta, \n" +
                             "voit muokata sen tietoja tai poistaa sen. \n" +
                             "Uuden stadionin voit lisätä kirjoittamalla tiedot \n" +
                             "kenttiin ja painamalla 'Tallenna'-painiketta.";

                btnClear.Text = "Tyhjennä kenttä uutta stadionia varten";
            }

            UpdateDataGridView(hintUpdate);
        }

        private void dgOtherManagement_SelectionChanged(object sender, EventArgs e)
        {
            if (dgOtherManagement.SelectedRows.Count > 0)
            {
                txtNameOtherManagement.Text = dgOtherManagement.SelectedRows[0].Cells[1].Value + string.Empty;
                id = Convert.ToInt32(dgOtherManagement.SelectedRows[0].Cells[0].Value);    // ID TALTEEN POISTOA TAI MUOKKAUSTA VARTEN

                if (cmbOtherManagement.SelectedIndex == 0)
                {
                    lblOtherManagementHint.Text = "Valitsit valmentajan " + txtNameOtherManagement.Text + ". \n" +
                                                  "Voit muokata tietoja kirjoittamalla uudet arvot kenttiin \n" +
                                                  "ja painamalla 'Tallenna'-painiketta tai voit poistaa valmentajan \n" +
                                                  "painamalla 'Poista'-painiketta.";
                }
                else if (cmbOtherManagement.SelectedIndex == 1)
                {
                    lblOtherManagementHint.Text = "Valitsit liigan " + txtNameOtherManagement.Text + ". \n" +
                                                  "Voit muokata tietoja kirjoittamalla uudet arvot kenttiin \n" +
                                                  "ja painamalla 'Tallenna'-painiketta tai voit poistaa liigan \n" +
                                                  "painamalla 'Poista'-painiketta.";
                }
                else if (cmbOtherManagement.SelectedIndex == 2)
                {
                    lblOtherManagementHint.Text = "Valitsit stadionin " + txtNameOtherManagement.Text + ". \n" +
                                                  "Voit muokata tietoja kirjoittamalla uudet arvot kenttiin \n" +
                                                  "ja painamalla 'Tallenna'-painiketta tai voit poistaa stadionin \n" +
                                                  "painamalla 'Poista'-painiketta.";
                }
            }

            btnDel.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNameOtherManagement.Text = "";
            btnDel.Enabled = false;
            btnClear.Enabled = false;
            lblOtherManagementHint.Text = "Kirjoita tiedot kenttiin ja paina 'Tallenna'-painiketta";
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
                    hintUpdate = "Tietojen päivitys onnistui";
                    UpdateDataGridView(hintUpdate);

                }
                else
                {
                    string query = "INSERT INTO " + table + " (name) VALUES ('" + txtNameOtherManagement.Text + "');";
                    db.ManageDatabase(query);
                    hintUpdate = "Tietojen lisäys onnistui";
                    UpdateDataGridView(hintUpdate);
                }
            }
            else
            {
                lblOtherManagementHint.Text = "Nimi puuttuu. Täytä kenttä ja paina 'Tallenna'-painiketta";
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

            if (MessageBox.Show(warning, "Varoitus", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM " + table + " WHERE ID = " + id;
                db.ManageDatabase(query);
                hintUpdate = "Tietojen poisto onnistui.";
                UpdateDataGridView(hintUpdate);
                txtNameOtherManagement.Text = "";
            }

        }

        private void txtNameOtherManagement_TextChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
        }
    }
}
