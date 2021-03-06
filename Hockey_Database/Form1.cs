﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Collections;
using System.Globalization;

namespace Hockey_Database
{
    public partial class HockeyDatabase : Form
    {
        // LUODAAN DB-OLIO
        dbConnect db = new dbConnect();   

        public HockeyDatabase()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)     
        {       
            db.OpenConnection(); // AVATAAN TIETOKANTAYHTEYS DB-OLIOLLA
            SelectAllPlayers();
            SelectAllTeams();
            FillComboBoxes();
            db.Exit();  // SULJETAAN TIETOKANTA-YHTEYS LOPUKSI
        }

        private void FillComboBoxes()
        {
            cmbLeagueTeams.DataSource = db.Select(db.leagueQuery);              // HAETAAN LIIGA-COMBOBOXIIN LIIGAT
            cmbLeagueTeams.DisplayMember = "name";
            cmbLeagueTeams.SelectedIndex = -1;

            cmbYears.DataSource = db.Select(db.yearOfBirthQuery);              // HAETAAN SYNTYMÄVUOSI-COMBOBOXIIN VUODET
            cmbYears.DisplayMember = "SUBSTRING(dateOfBirth, 1, 4)";
            cmbYears.SelectedIndex = -1;

            cmbLeague.DataSource = db.Select(db.leaguesMainQuery);                  // HAETAAN LIIGA-COMBOBOXIIN LIIGAT
            cmbLeague.DisplayMember = "name";
            cmbLeague.SelectedIndex = -1;

            cmbPosition.DataSource = db.Select(db.positionQuery);              // HAETAAN PELIPAIKKA-COMBOBOXIIN PELIPAIKAT
            cmbPosition.DisplayMember = "position";
            cmbPosition.SelectedIndex = -1;
        }

        private void SelectAllTeams()
        {
            dgTeams.DataSource = db.Select(db.teamQuery);                   // HAETAAN KAIKKI JOUKKUEIDEN TIEDOT TIETOKANNASTA

            dgTeams.Columns[0].HeaderText = "Joukkue:";                  // VAIHDETAAN SUOMENKIELISIKSI HEADER-ROW:T
            dgTeams.Columns[1].HeaderText = "Päävalmentaja:";
            dgTeams.Columns[2].HeaderText = "Kotiareena:";
            dgTeams.Columns[3].HeaderText = "Liiga:";

        }

        private void SelectAllPlayers()
        {
            dgPlayers.DataSource = db.Select(db.playersQuery);                // HAETAAN KAIKKI PELAAJIEN TIEDOT TIETOKANNASTA

            dgPlayers.Columns[0].HeaderText = "Pelaaja:";                  // VAIHDETAAN SUOMENKIELISIKSI HEADER-ROW:T
            dgPlayers.Columns[1].HeaderText = "Syntymäaika:";
            dgPlayers.Columns[2].HeaderText = "Joukkue:";
            dgPlayers.Columns[3].HeaderText = "Liiga:";
            dgPlayers.Columns[4].HeaderText = "Pelinumero:";
            dgPlayers.Columns[5].HeaderText = "Pelipaikka:";

        }

        private void PlayersSearchParameters_Changed(object sender, EventArgs e)   // FILTTERÖIDÄÄN PELAAJA-DATAGRIDVIEWIÄ TIETOJEN PERUSTEELLA
        {
            (dgPlayers.DataSource as DataTable).DefaultView.RowFilter = string.Format(
                "Name LIKE '%{0}%'" +
                "AND Name1 LIKE '%{1}%'" +
                "AND CONVERT(DateOfBirth, System.String) LIKE '%{2}%'" +
                "AND Name2 LIKE '%{3}%'" +
                "AND Position LIKE '%{4}%'",
                txtName.Text, txtTeam.Text, this.cmbYears.GetItemText(this.cmbYears.SelectedItem), this.cmbLeague.GetItemText(this.cmbLeague.SelectedItem), this.cmbPosition.GetItemText(this.cmbPosition.SelectedItem));
        }

        private void TeamsSearchParameters_Changed(object sender, EventArgs e)   // FILTTERÖIDÄÄN JOUKKUE-DATAGRIDVIEWIÄ TIETOJEN PERUSTEELLA
        {
            (dgTeams.DataSource as DataTable).DefaultView.RowFilter = string.Format(
                "Name LIKE '%{0}%'" +
                "AND Name1 LIKE '%{1}%'" +
                "AND Name3 LIKE '%{2}%'",
                txtTeamName.Text, txtCoach.Text, this.cmbLeagueTeams.GetItemText(this.cmbLeagueTeams.SelectedItem));
        }

        private void mnuPlayers_Click(object sender, EventArgs e)
        {
            PlayerManagement pm = new PlayerManagement();
            pm.ShowDialog();
            SelectAllPlayers();
            SelectAllTeams();
        }

        private void mnuTeams_Click(object sender, EventArgs e)
        {
            TeamManagement tm = new TeamManagement();
            tm.ShowDialog();
            SelectAllPlayers();
            SelectAllTeams();
        }

        private void mnuOther_Click(object sender, EventArgs e)
        {
            OtherManagement om = new OtherManagement();
            om.ShowDialog();
            SelectAllPlayers();
            SelectAllTeams();
        }

    }
}
