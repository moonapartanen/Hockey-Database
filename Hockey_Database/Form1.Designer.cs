namespace Hockey_Database
{
    partial class HockeyDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgPlayers = new System.Windows.Forms.DataGridView();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTeam = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.cmbLeague = new System.Windows.Forms.ComboBox();
            this.lblLeague = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.cmbYears = new System.Windows.Forms.ComboBox();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlayers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCities = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbLeagueTeams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoach = new System.Windows.Forms.TextBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblCoach = new System.Windows.Forms.Label();
            this.dgTeams = new System.Windows.Forms.DataGridView();
            this.liigatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stadionitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayers)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPlayers
            // 
            this.dgPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlayers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgPlayers.Location = new System.Drawing.Point(23, 148);
            this.dgPlayers.Name = "dgPlayers";
            this.dgPlayers.Size = new System.Drawing.Size(628, 332);
            this.dgPlayers.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(17, 17);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(43, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Nimi:";
            this.lbName.UseWaitCursor = true;
            // 
            // lbTeam
            // 
            this.lbTeam.AutoSize = true;
            this.lbTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeam.Location = new System.Drawing.Point(17, 50);
            this.lbTeam.Name = "lbTeam";
            this.lbTeam.Size = new System.Drawing.Size(73, 20);
            this.lbTeam.TabIndex = 2;
            this.lbTeam.Text = "Joukkue:";
            this.lbTeam.UseWaitCursor = true;
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirth.Location = new System.Drawing.Point(17, 82);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(110, 20);
            this.lbDateOfBirth.TabIndex = 3;
            this.lbDateOfBirth.Text = "Syntymävuosi:";
            this.lbDateOfBirth.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbPosition);
            this.panel1.Controls.Add(this.cmbLeague);
            this.panel1.Controls.Add(this.lblLeague);
            this.panel1.Controls.Add(this.lblPosition);
            this.panel1.Controls.Add(this.cmbYears);
            this.panel1.Controls.Add(this.txtTeam);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbDateOfBirth);
            this.panel1.Controls.Add(this.lbTeam);
            this.panel1.Location = new System.Drawing.Point(23, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 123);
            this.panel1.TabIndex = 4;
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(417, 48);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(150, 22);
            this.cmbPosition.TabIndex = 10;
            this.cmbPosition.TextChanged += new System.EventHandler(this.PlayersSearchParameters_Changed);
            // 
            // cmbLeague
            // 
            this.cmbLeague.FormattingEnabled = true;
            this.cmbLeague.Location = new System.Drawing.Point(417, 16);
            this.cmbLeague.Name = "cmbLeague";
            this.cmbLeague.Size = new System.Drawing.Size(150, 22);
            this.cmbLeague.TabIndex = 9;
            this.cmbLeague.TextChanged += new System.EventHandler(this.PlayersSearchParameters_Changed);
            // 
            // lblLeague
            // 
            this.lblLeague.AutoSize = true;
            this.lblLeague.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeague.Location = new System.Drawing.Point(322, 17);
            this.lblLeague.Name = "lblLeague";
            this.lblLeague.Size = new System.Drawing.Size(46, 20);
            this.lblLeague.TabIndex = 8;
            this.lblLeague.Text = "Liiga:";
            this.lblLeague.UseWaitCursor = true;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(322, 50);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(84, 20);
            this.lblPosition.TabIndex = 7;
            this.lblPosition.Text = "Pelipaikka:";
            this.lblPosition.UseWaitCursor = true;
            // 
            // cmbYears
            // 
            this.cmbYears.FormattingEnabled = true;
            this.cmbYears.Location = new System.Drawing.Point(132, 80);
            this.cmbYears.Name = "cmbYears";
            this.cmbYears.Size = new System.Drawing.Size(150, 22);
            this.cmbYears.TabIndex = 6;
            this.cmbYears.TextChanged += new System.EventHandler(this.PlayersSearchParameters_Changed);
            // 
            // txtTeam
            // 
            this.txtTeam.Location = new System.Drawing.Point(132, 50);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(150, 21);
            this.txtTeam.TabIndex = 5;
            this.txtTeam.TextChanged += new System.EventHandler(this.PlayersSearchParameters_Changed);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 21);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.PlayersSearchParameters_Changed);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hallintaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hallintaToolStripMenuItem
            // 
            this.hallintaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPlayers,
            this.mnuTeams,
            this.mnuCities,
            this.liigatToolStripMenuItem,
            this.stadionitToolStripMenuItem});
            this.hallintaToolStripMenuItem.Name = "hallintaToolStripMenuItem";
            this.hallintaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.hallintaToolStripMenuItem.Text = "Hallinta";
            // 
            // mnuPlayers
            // 
            this.mnuPlayers.Name = "mnuPlayers";
            this.mnuPlayers.Size = new System.Drawing.Size(152, 22);
            this.mnuPlayers.Text = "Pelaajat";
            this.mnuPlayers.Click += new System.EventHandler(this.mnuPlayers_Click);
            // 
            // mnuTeams
            // 
            this.mnuTeams.Name = "mnuTeams";
            this.mnuTeams.Size = new System.Drawing.Size(152, 22);
            this.mnuTeams.Text = "Joukkueet";
            // 
            // mnuCities
            // 
            this.mnuCities.Name = "mnuCities";
            this.mnuCities.Size = new System.Drawing.Size(152, 22);
            this.mnuCities.Text = "Valmentajat";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(0, 27);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(685, 534);
            this.tabMain.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgPlayers);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(677, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pelaajat";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dgTeams);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(677, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Joukkueet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbLeagueTeams);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtCoach);
            this.panel2.Controls.Add(this.txtTeamName);
            this.panel2.Controls.Add(this.lblTeamName);
            this.panel2.Controls.Add(this.lblCoach);
            this.panel2.Location = new System.Drawing.Point(22, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 123);
            this.panel2.TabIndex = 5;
            // 
            // cmbLeagueTeams
            // 
            this.cmbLeagueTeams.FormattingEnabled = true;
            this.cmbLeagueTeams.Location = new System.Drawing.Point(132, 82);
            this.cmbLeagueTeams.Name = "cmbLeagueTeams";
            this.cmbLeagueTeams.Size = new System.Drawing.Size(150, 22);
            this.cmbLeagueTeams.TabIndex = 9;
            this.cmbLeagueTeams.TextChanged += new System.EventHandler(this.TeamsSearchParameters_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Liiga:";
            this.label1.UseWaitCursor = true;
            // 
            // txtCoach
            // 
            this.txtCoach.Location = new System.Drawing.Point(132, 50);
            this.txtCoach.Name = "txtCoach";
            this.txtCoach.Size = new System.Drawing.Size(150, 21);
            this.txtCoach.TabIndex = 5;
            this.txtCoach.TextChanged += new System.EventHandler(this.TeamsSearchParameters_Changed);
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(132, 17);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(150, 21);
            this.txtTeamName.TabIndex = 4;
            this.txtTeamName.TextChanged += new System.EventHandler(this.TeamsSearchParameters_Changed);
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(17, 17);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(43, 20);
            this.lblTeamName.TabIndex = 1;
            this.lblTeamName.Text = "Nimi:";
            this.lblTeamName.UseWaitCursor = true;
            // 
            // lblCoach
            // 
            this.lblCoach.AutoSize = true;
            this.lblCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoach.Location = new System.Drawing.Point(17, 50);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(93, 20);
            this.lblCoach.TabIndex = 2;
            this.lblCoach.Text = "Valmentaja:";
            this.lblCoach.UseWaitCursor = true;
            // 
            // dgTeams
            // 
            this.dgTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTeams.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgTeams.Location = new System.Drawing.Point(22, 147);
            this.dgTeams.Name = "dgTeams";
            this.dgTeams.Size = new System.Drawing.Size(628, 332);
            this.dgTeams.TabIndex = 1;
            // 
            // liigatToolStripMenuItem
            // 
            this.liigatToolStripMenuItem.Name = "liigatToolStripMenuItem";
            this.liigatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.liigatToolStripMenuItem.Text = "Liigat";
            // 
            // stadionitToolStripMenuItem
            // 
            this.stadionitToolStripMenuItem.Name = "stadionitToolStripMenuItem";
            this.stadionitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stadionitToolStripMenuItem.Text = "Stadionit";
            // 
            // HockeyDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 556);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HockeyDatabase";
            this.Text = "Hockey Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPlayers;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTeam;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hallintaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPlayers;
        private System.Windows.Forms.ToolStripMenuItem mnuTeams;
        private System.Windows.Forms.ToolStripMenuItem mnuCities;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cmbYears;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.ComboBox cmbLeague;
        private System.Windows.Forms.Label lblLeague;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbLeagueTeams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCoach;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblCoach;
        private System.Windows.Forms.DataGridView dgTeams;
        private System.Windows.Forms.ToolStripMenuItem liigatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stadionitToolStripMenuItem;
    }
}

