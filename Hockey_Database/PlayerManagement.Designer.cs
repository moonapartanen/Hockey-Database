namespace Hockey_Database
{
    partial class PlayerManagement
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
            this.dgPlayerManagement = new System.Windows.Forms.DataGridView();
            this.panel_pm = new System.Windows.Forms.Panel();
            this.lblName_pm = new System.Windows.Forms.Label();
            this.lbDateOfBirth_pm = new System.Windows.Forms.Label();
            this.lblNumber_pm = new System.Windows.Forms.Label();
            this.lblTeam_pm = new System.Windows.Forms.Label();
            this.txtName_pm = new System.Windows.Forms.TextBox();
            this.dpDateOfBirth_pm = new System.Windows.Forms.DateTimePicker();
            this.txtNumber_pm = new System.Windows.Forms.TextBox();
            this.rbgPostion_pm = new System.Windows.Forms.GroupBox();
            this.rbForward_pm = new System.Windows.Forms.RadioButton();
            this.rbDefender_pm = new System.Windows.Forms.RadioButton();
            this.rbGoalie_pm = new System.Windows.Forms.RadioButton();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbTeams_pm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayerManagement)).BeginInit();
            this.panel_pm.SuspendLayout();
            this.rbgPostion_pm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPlayerManagement
            // 
            this.dgPlayerManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlayerManagement.Location = new System.Drawing.Point(266, 12);
            this.dgPlayerManagement.Name = "dgPlayerManagement";
            this.dgPlayerManagement.Size = new System.Drawing.Size(642, 341);
            this.dgPlayerManagement.TabIndex = 0;
            this.dgPlayerManagement.SelectionChanged += new System.EventHandler(this.dgPlayerManagement_SelectionChanged);
            // 
            // panel_pm
            // 
            this.panel_pm.Controls.Add(this.cmbTeams_pm);
            this.panel_pm.Controls.Add(this.rbgPostion_pm);
            this.panel_pm.Controls.Add(this.txtNumber_pm);
            this.panel_pm.Controls.Add(this.dpDateOfBirth_pm);
            this.panel_pm.Controls.Add(this.txtName_pm);
            this.panel_pm.Controls.Add(this.lblTeam_pm);
            this.panel_pm.Controls.Add(this.lblNumber_pm);
            this.panel_pm.Controls.Add(this.lbDateOfBirth_pm);
            this.panel_pm.Controls.Add(this.lblName_pm);
            this.panel_pm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_pm.Location = new System.Drawing.Point(12, 12);
            this.panel_pm.Name = "panel_pm";
            this.panel_pm.Size = new System.Drawing.Size(248, 341);
            this.panel_pm.TabIndex = 1;
            // 
            // lblName_pm
            // 
            this.lblName_pm.AutoSize = true;
            this.lblName_pm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName_pm.Location = new System.Drawing.Point(7, 17);
            this.lblName_pm.Name = "lblName_pm";
            this.lblName_pm.Size = new System.Drawing.Size(38, 16);
            this.lblName_pm.TabIndex = 0;
            this.lblName_pm.Text = "Nimi:";
            // 
            // lbDateOfBirth_pm
            // 
            this.lbDateOfBirth_pm.AutoSize = true;
            this.lbDateOfBirth_pm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirth_pm.Location = new System.Drawing.Point(7, 68);
            this.lbDateOfBirth_pm.Name = "lbDateOfBirth_pm";
            this.lbDateOfBirth_pm.Size = new System.Drawing.Size(89, 16);
            this.lbDateOfBirth_pm.TabIndex = 1;
            this.lbDateOfBirth_pm.Text = "Syntymäaika:";
            // 
            // lblNumber_pm
            // 
            this.lblNumber_pm.AutoSize = true;
            this.lblNumber_pm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber_pm.Location = new System.Drawing.Point(7, 122);
            this.lblNumber_pm.Name = "lblNumber_pm";
            this.lblNumber_pm.Size = new System.Drawing.Size(79, 16);
            this.lblNumber_pm.TabIndex = 2;
            this.lblNumber_pm.Text = "Pelinumero:";
            // 
            // lblTeam_pm
            // 
            this.lblTeam_pm.AutoSize = true;
            this.lblTeam_pm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam_pm.Location = new System.Drawing.Point(7, 172);
            this.lblTeam_pm.Name = "lblTeam_pm";
            this.lblTeam_pm.Size = new System.Drawing.Size(62, 16);
            this.lblTeam_pm.TabIndex = 3;
            this.lblTeam_pm.Text = "Joukkue:";
            // 
            // txtName_pm
            // 
            this.txtName_pm.Location = new System.Drawing.Point(10, 37);
            this.txtName_pm.Name = "txtName_pm";
            this.txtName_pm.Size = new System.Drawing.Size(223, 22);
            this.txtName_pm.TabIndex = 5;
            // 
            // dpDateOfBirth_pm
            // 
            this.dpDateOfBirth_pm.Location = new System.Drawing.Point(10, 88);
            this.dpDateOfBirth_pm.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dpDateOfBirth_pm.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dpDateOfBirth_pm.Name = "dpDateOfBirth_pm";
            this.dpDateOfBirth_pm.Size = new System.Drawing.Size(223, 22);
            this.dpDateOfBirth_pm.TabIndex = 6;
            // 
            // txtNumber_pm
            // 
            this.txtNumber_pm.Location = new System.Drawing.Point(10, 142);
            this.txtNumber_pm.Name = "txtNumber_pm";
            this.txtNumber_pm.Size = new System.Drawing.Size(86, 22);
            this.txtNumber_pm.TabIndex = 7;
            // 
            // rbgPostion_pm
            // 
            this.rbgPostion_pm.Controls.Add(this.rbGoalie_pm);
            this.rbgPostion_pm.Controls.Add(this.rbDefender_pm);
            this.rbgPostion_pm.Controls.Add(this.rbForward_pm);
            this.rbgPostion_pm.Location = new System.Drawing.Point(10, 224);
            this.rbgPostion_pm.Name = "rbgPostion_pm";
            this.rbgPostion_pm.Size = new System.Drawing.Size(223, 104);
            this.rbgPostion_pm.TabIndex = 9;
            this.rbgPostion_pm.TabStop = false;
            this.rbgPostion_pm.Text = "Pelipaikka:";
            // 
            // rbForward_pm
            // 
            this.rbForward_pm.AutoSize = true;
            this.rbForward_pm.Location = new System.Drawing.Point(7, 22);
            this.rbForward_pm.Name = "rbForward_pm";
            this.rbForward_pm.Size = new System.Drawing.Size(92, 20);
            this.rbForward_pm.TabIndex = 0;
            this.rbForward_pm.TabStop = true;
            this.rbForward_pm.Text = "Hyökkääjä";
            this.rbForward_pm.UseVisualStyleBackColor = true;
            // 
            // rbDefender_pm
            // 
            this.rbDefender_pm.AutoSize = true;
            this.rbDefender_pm.Location = new System.Drawing.Point(7, 49);
            this.rbDefender_pm.Name = "rbDefender_pm";
            this.rbDefender_pm.Size = new System.Drawing.Size(89, 20);
            this.rbDefender_pm.TabIndex = 1;
            this.rbDefender_pm.TabStop = true;
            this.rbDefender_pm.Text = "Puolustaja";
            this.rbDefender_pm.UseVisualStyleBackColor = true;
            // 
            // rbGoalie_pm
            // 
            this.rbGoalie_pm.AutoSize = true;
            this.rbGoalie_pm.Location = new System.Drawing.Point(7, 76);
            this.rbGoalie_pm.Name = "rbGoalie_pm";
            this.rbGoalie_pm.Size = new System.Drawing.Size(87, 20);
            this.rbGoalie_pm.TabIndex = 2;
            this.rbGoalie_pm.TabStop = true;
            this.rbGoalie_pm.Text = "Maalivahti";
            this.rbGoalie_pm.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(288, 371);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(132, 37);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Poista";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(150, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Tallenna";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 371);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 37);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Lisää uusi pelaaja";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbTeams_pm
            // 
            this.cmbTeams_pm.FormattingEnabled = true;
            this.cmbTeams_pm.Location = new System.Drawing.Point(10, 192);
            this.cmbTeams_pm.Name = "cmbTeams_pm";
            this.cmbTeams_pm.Size = new System.Drawing.Size(223, 24);
            this.cmbTeams_pm.TabIndex = 10;
            // 
            // PlayerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 421);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.panel_pm);
            this.Controls.Add(this.dgPlayerManagement);
            this.Name = "PlayerManagement";
            this.Text = "PlayerManagement";
            this.Load += new System.EventHandler(this.PlayerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayerManagement)).EndInit();
            this.panel_pm.ResumeLayout(false);
            this.panel_pm.PerformLayout();
            this.rbgPostion_pm.ResumeLayout(false);
            this.rbgPostion_pm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPlayerManagement;
        private System.Windows.Forms.Panel panel_pm;
        private System.Windows.Forms.Label lblTeam_pm;
        private System.Windows.Forms.Label lblNumber_pm;
        private System.Windows.Forms.Label lbDateOfBirth_pm;
        private System.Windows.Forms.Label lblName_pm;
        private System.Windows.Forms.GroupBox rbgPostion_pm;
        private System.Windows.Forms.RadioButton rbGoalie_pm;
        private System.Windows.Forms.RadioButton rbDefender_pm;
        private System.Windows.Forms.RadioButton rbForward_pm;
        private System.Windows.Forms.TextBox txtNumber_pm;
        private System.Windows.Forms.DateTimePicker dpDateOfBirth_pm;
        private System.Windows.Forms.TextBox txtName_pm;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbTeams_pm;
    }
}