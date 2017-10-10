namespace Hockey_Database
{
    partial class OtherManagement
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
            this.lblOtherManagement = new System.Windows.Forms.Label();
            this.cmbOtherManagement = new System.Windows.Forms.ComboBox();
            this.txtNameOtherManagement = new System.Windows.Forms.TextBox();
            this.lblName_om = new System.Windows.Forms.Label();
            this.dgOtherManagement = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblTooltip = new System.Windows.Forms.Label();
            this.toolTipOtherManagement = new System.Windows.Forms.ToolTip(this.components);
            this.panel_pm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOtherManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_pm
            // 
            this.panel_pm.Controls.Add(this.lblOtherManagement);
            this.panel_pm.Controls.Add(this.cmbOtherManagement);
            this.panel_pm.Controls.Add(this.txtNameOtherManagement);
            this.panel_pm.Controls.Add(this.lblName_om);
            this.panel_pm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_pm.Location = new System.Drawing.Point(12, 12);
            this.panel_pm.Name = "panel_pm";
            this.panel_pm.Size = new System.Drawing.Size(203, 172);
            this.panel_pm.TabIndex = 3;
            // 
            // lblOtherManagement
            // 
            this.lblOtherManagement.AutoSize = true;
            this.lblOtherManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherManagement.Location = new System.Drawing.Point(7, 25);
            this.lblOtherManagement.Name = "lblOtherManagement";
            this.lblOtherManagement.Size = new System.Drawing.Size(93, 16);
            this.lblOtherManagement.TabIndex = 7;
            this.lblOtherManagement.Text = "Valitse kohde:";
            // 
            // cmbOtherManagement
            // 
            this.cmbOtherManagement.FormattingEnabled = true;
            this.cmbOtherManagement.Items.AddRange(new object[] {
            "Valmentajat",
            "Liigat",
            "Stadionit"});
            this.cmbOtherManagement.Location = new System.Drawing.Point(10, 44);
            this.cmbOtherManagement.Name = "cmbOtherManagement";
            this.cmbOtherManagement.Size = new System.Drawing.Size(172, 24);
            this.cmbOtherManagement.TabIndex = 6;
            this.cmbOtherManagement.SelectedIndexChanged += new System.EventHandler(this.cmbOtherManagement_SelectedIndexChanged);
            // 
            // txtNameOtherManagement
            // 
            this.txtNameOtherManagement.Location = new System.Drawing.Point(10, 103);
            this.txtNameOtherManagement.Name = "txtNameOtherManagement";
            this.txtNameOtherManagement.Size = new System.Drawing.Size(172, 22);
            this.txtNameOtherManagement.TabIndex = 5;
            // 
            // lblName_om
            // 
            this.lblName_om.AutoSize = true;
            this.lblName_om.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName_om.Location = new System.Drawing.Point(7, 84);
            this.lblName_om.Name = "lblName_om";
            this.lblName_om.Size = new System.Drawing.Size(38, 16);
            this.lblName_om.TabIndex = 0;
            this.lblName_om.Text = "Nimi:";
            // 
            // dgOtherManagement
            // 
            this.dgOtherManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOtherManagement.Location = new System.Drawing.Point(221, 12);
            this.dgOtherManagement.Name = "dgOtherManagement";
            this.dgOtherManagement.Size = new System.Drawing.Size(230, 315);
            this.dgOtherManagement.TabIndex = 4;
            this.dgOtherManagement.SelectionChanged += new System.EventHandler(this.dgOtherManagement_SelectionChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(51, 190);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(153, 38);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Lisää uusi ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(51, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 37);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Tallenna";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(51, 277);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(153, 37);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Poista";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblTooltip
            // 
            this.lblTooltip.AutoSize = true;
            this.lblTooltip.Location = new System.Drawing.Point(9, 320);
            this.lblTooltip.Name = "lblTooltip";
            this.lblTooltip.Size = new System.Drawing.Size(13, 13);
            this.lblTooltip.TabIndex = 10;
            this.lblTooltip.Text = "?";
            this.lblTooltip.MouseHover += new System.EventHandler(this.lblTooltip_MouseHover);
            // 
            // OtherManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 342);
            this.Controls.Add(this.lblTooltip);
            this.Controls.Add(this.dgOtherManagement);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel_pm);
            this.Controls.Add(this.btnClear);
            this.Name = "OtherManagement";
            this.Text = "OtherManagement";
            this.Load += new System.EventHandler(this.OtherManagement_Load);
            this.panel_pm.ResumeLayout(false);
            this.panel_pm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOtherManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgOtherManagement;
        private System.Windows.Forms.Panel panel_pm;
        private System.Windows.Forms.TextBox txtNameOtherManagement;
        private System.Windows.Forms.Label lblName_om;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblOtherManagement;
        private System.Windows.Forms.ComboBox cmbOtherManagement;
        private System.Windows.Forms.Label lblTooltip;
        private System.Windows.Forms.ToolTip toolTipOtherManagement;
    }
}