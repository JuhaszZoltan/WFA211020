
namespace WFA211020
{
    partial class FrmMain
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
            this.mainMS = new System.Windows.Forms.MenuStrip();
            this.tenyesztoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.parkeresoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.bejelentesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.mainDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMS
            // 
            this.mainMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tenyesztoTSMI,
            this.parkeresoTSMI,
            this.bejelentesTSMI});
            this.mainMS.Location = new System.Drawing.Point(0, 0);
            this.mainMS.Name = "mainMS";
            this.mainMS.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMS.Size = new System.Drawing.Size(752, 73);
            this.mainMS.TabIndex = 0;
            this.mainMS.Text = "menuStrip1";
            // 
            // tenyesztoTSMI
            // 
            this.tenyesztoTSMI.Image = global::WFA211020.Properties.Resources.wizard;
            this.tenyesztoTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tenyesztoTSMI.Name = "tenyesztoTSMI";
            this.tenyesztoTSMI.Size = new System.Drawing.Size(76, 69);
            this.tenyesztoTSMI.Text = "Tenyésztők";
            this.tenyesztoTSMI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // parkeresoTSMI
            // 
            this.parkeresoTSMI.Image = global::WFA211020.Properties.Resources.love;
            this.parkeresoTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.parkeresoTSMI.Name = "parkeresoTSMI";
            this.parkeresoTSMI.Size = new System.Drawing.Size(70, 69);
            this.parkeresoTSMI.Text = "Párkereső";
            this.parkeresoTSMI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bejelentesTSMI
            // 
            this.bejelentesTSMI.Image = global::WFA211020.Properties.Resources.unicorn;
            this.bejelentesTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bejelentesTSMI.Name = "bejelentesTSMI";
            this.bejelentesTSMI.Size = new System.Drawing.Size(72, 69);
            this.bejelentesTSMI.Text = "Bejelentés";
            this.bejelentesTSMI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bejelentesTSMI.Click += new System.EventHandler(this.BejelentesTSMI_Click);
            // 
            // mainDGV
            // 
            this.mainDGV.AllowUserToAddRows = false;
            this.mainDGV.AllowUserToDeleteRows = false;
            this.mainDGV.AllowUserToResizeColumns = false;
            this.mainDGV.AllowUserToResizeRows = false;
            this.mainDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.mainDGV.Location = new System.Drawing.Point(11, 85);
            this.mainDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainDGV.Name = "mainDGV";
            this.mainDGV.RowHeadersVisible = false;
            this.mainDGV.RowHeadersWidth = 51;
            this.mainDGV.RowTemplate.Height = 24;
            this.mainDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDGV.Size = new System.Drawing.Size(734, 378);
            this.mainDGV.TabIndex = 1;
            this.mainDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDGV_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fajta";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tulajdonos";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Város";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "Súly";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.FillWeight = 50F;
            this.Column6.HeaderText = "Nem";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(752, 476);
            this.Controls.Add(this.mainDGV);
            this.Controls.Add(this.mainMS);
            this.MainMenuStrip = this.mainMS;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMain";
            this.Text = "Unikornis Menes Manager 2021";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mainMS.ResumeLayout(false);
            this.mainMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMS;
        private System.Windows.Forms.DataGridView mainDGV;
        private System.Windows.Forms.ToolStripMenuItem tenyesztoTSMI;
        private System.Windows.Forms.ToolStripMenuItem parkeresoTSMI;
        private System.Windows.Forms.ToolStripMenuItem bejelentesTSMI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

