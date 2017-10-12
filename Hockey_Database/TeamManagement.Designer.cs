namespace Hockey_Database
{
    partial class TeamManagement
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
            this.panel_pm = new System.Windows.Forms.Panel();
            this.cmbLeagues_tm = new System.Windows.Forms.ComboBox();
            this.cmbStadiums_tm = new System.Windows.Forms.ComboBox();
            this.cmbCoaches_tm = new System.Windows.Forms.ComboBox();
            this.txtName_tm = new System.Windows.Forms.TextBox();
            this.lblCoach_tm = new System.Windows.Forms.Label();
            this.lblLeague_tm = new System.Windows.Forms.Label();
            this.lbStadium_tm = new System.Windows.Forms.Label();
            this.lblName_tm = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dgTeamManagement = new System.Windows.Forms.DataGridView();
            this.toolTipTeamManagement = new System.Windows.Forms.ToolTip(this.components);
            this.lblTeamManagementHint = new System.Windows.Forms.Label();
            this.panel_pm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeamManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_pm
            // 
            this.panel_pm.Controls.Add(this.cmbLeagues_tm);
            this.panel_pm.Controls.Add(this.cmbStadiums_tm);
            this.panel_pm.Controls.Add(this.cmbCoaches_tm);
            this.panel_pm.Controls.Add(this.txtName_tm);
            this.panel_pm.Controls.Add(this.lblCoach_tm);
            this.panel_pm.Controls.Add(this.lblLeague_tm);
            this.panel_pm.Controls.Add(this.lbStadium_tm);
            this.panel_pm.Controls.Add(this.lblName_tm);
            this.panel_pm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_pm.Location = new System.Drawing.Point(12, 12);
            this.panel_pm.Name = "panel_pm";
            this.panel_pm.Size = new System.Drawing.Size(248, 256);
            this.panel_pm.TabIndex = 2;
            // 
            // cmbLeagues_tm
            // 
            this.cmbLeagues_tm.FormattingEnabled = true;
            this.cmbLeagues_tm.Location = new System.Drawing.Point(10, 142);
            this.cmbLeagues_tm.Name = "cmbLeagues_tm";
            this.cmbLeagues_tm.Size = new System.Drawing.Size(223, 24);
            this.cmbLeagues_tm.TabIndex = 12;
            this.cmbLeagues_tm.SelectedIndexChanged += new System.EventHandler(this.TeamManagement_panelChanged);
            // 
            // cmbStadiums_tm
            // 
            this.cmbStadiums_tm.FormattingEnabled = true;
            this.cmbStadiums_tm.Location = new System.Drawing.Point(10, 88);
            this.cmbStadiums_tm.Name = "cmbStadiums_tm";
            this.cmbStadiums_tm.Size = new System.Drawing.Size(223, 24);
            this.cmbStadiums_tm.TabIndex = 11;
            this.cmbStadiums_tm.SelectedIndexChanged += new System.EventHandler(this.TeamManagement_panelChanged);
            // 
            // cmbCoaches_tm
            // 
            this.cmbCoaches_tm.FormattingEnabled = true;
            this.cmbCoaches_tm.Location = new System.Drawing.Point(10, 192);
            this.cmbCoaches_tm.Name = "cmbCoaches_tm";
            this.cmbCoaches_tm.Size = new System.Drawing.Size(223, 24);
            this.cmbCoaches_tm.TabIndex = 10;
            this.cmbCoaches_tm.SelectedIndexChanged += new System.EventHandler(this.TeamManagement_panelChanged);
            // 
            // txtName_tm
            // 
            this.txtName_tm.Location = new System.Drawing.Point(10, 37);
            this.txtName_tm.Name = "txtName_tm";
            this.txtName_tm.Size = new System.Drawing.Size(223, 22);
            this.txtName_tm.TabIndex = 5;
            this.txtName_tm.TextChanged += new System.EventHandler(this.TeamManagement_panelChanged);
            // 
            // lblCoach_tm
            // 
            this.lblCoach_tm.AutoSize = true;
            this.lblCoach_tm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoach_tm.Location = new System.Drawing.Point(7, 172);
            this.lblCoach_tm.Name = "lblCoach_tm";
            this.lblCoach_tm.Size = new System.Drawing.Size(102, 16);
            this.lblCoach_tm.TabIndex = 3;
            this.lblCoach_tm.Text = "Päävalmentaja:";
            // 
            // lblLeague_tm
            // 
            this.lblLeague_tm.AutoSize = true;
            this.lblLeague_tm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeague_tm.Location = new System.Drawing.Point(7, 122);
            this.lblLeague_tm.Name = "lblLeague_tm";
            this.lblLeague_tm.Size = new System.Drawing.Size(40, 16);
            this.lblLeague_tm.TabIndex = 2;
            this.lblLeague_tm.Text = "Liiga:";
            // 
            // lbStadium_tm
            // 
            this.lbStadium_tm.AutoSize = true;
            this.lbStadium_tm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStadium_tm.Location = new System.Drawing.Point(7, 68);
            this.lbStadium_tm.Name = "lbStadium_tm";
            this.lbStadium_tm.Size = new System.Drawing.Size(77, 16);
            this.lbStadium_tm.TabIndex = 1;
            this.lbStadium_tm.Text = "Kotistadion:";
            // 
            // lblName_tm
            // 
            this.lblName_tm.AutoSize = true;
            this.lblName_tm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName_tm.Location = new System.Drawing.Point(7, 17);
            this.lblName_tm.Name = "lblName_tm";
            this.lblName_tm.Size = new System.Drawing.Size(38, 16);
            this.lblName_tm.TabIndex = 0;
            this.lblName_tm.Text = "Nimi:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 285);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 61);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Lisää uusi joukkue";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(150, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 61);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Tallenna";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(288, 285);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(132, 61);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Poista";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dgTeamManagement
            // 
            this.dgTeamManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTeamManagement.Location = new System.Drawing.Point(266, 12);
            this.dgTeamManagement.Name = "dgTeamManagement";
            this.dgTeamManagement.Size = new System.Drawing.Size(537, 256);
            this.dgTeamManagement.TabIndex = 8;
            this.dgTeamManagement.SelectionChanged += new System.EventHandler(this.dgTeamManagement_SelectionChanged);
            // 
            // lblTeamManagementHint
            // 
            this.lblTeamManagementHint.AutoSize = true;
            this.lblTeamManagementHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamManagementHint.Location = new System.Drawing.Point(435, 285);
            this.lblTeamManagementHint.Name = "lblTeamManagementHint";
            this.lblTeamManagementHint.Size = new System.Drawing.Size(29, 16);
            this.lblTeamManagementHint.TabIndex = 9;
            this.lblTeamManagementHint.Text = "test";
            // 
            // TeamManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 376);
            this.Controls.Add(this.lblTeamManagementHint);
            this.Controls.Add(this.dgTeamManagement);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel_pm);
            this.Name = "TeamManagement";
            this.Text = "TeamManagement";
            this.Load += new System.EventHandler(this.TeamManagement_Load);
            this.panel_pm.ResumeLayout(false);
            this.panel_pm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeamManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_pm;
        private System.Windows.Forms.ComboBox cmbCoaches_tm;
        private System.Windows.Forms.TextBox txtName_tm;
        private System.Windows.Forms.Label lblCoach_tm;
        private System.Windows.Forms.Label lblLeague_tm;
        private System.Windows.Forms.Label lbStadium_tm;
        private System.Windows.Forms.Label lblName_tm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgTeamManagement;
        private System.Windows.Forms.ComboBox cmbStadiums_tm;
        private System.Windows.Forms.ComboBox cmbLeagues_tm;
        private System.Windows.Forms.ToolTip toolTipTeamManagement;
        private System.Windows.Forms.Label lblTeamManagementHint;
    }
}