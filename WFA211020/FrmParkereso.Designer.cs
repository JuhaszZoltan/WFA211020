namespace WFA211020
{
    partial class FrmParkereso
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvParok = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVaros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFajta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSuly = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParok)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSuly);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbFajta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbVaros);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott unikornis tulajdonságai:";
            // 
            // dgvParok
            // 
            this.dgvParok.AllowUserToAddRows = false;
            this.dgvParok.AllowUserToDeleteRows = false;
            this.dgvParok.AllowUserToResizeColumns = false;
            this.dgvParok.AllowUserToResizeRows = false;
            this.dgvParok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParok.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvParok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dgvParok.Location = new System.Drawing.Point(12, 138);
            this.dgvParok.Margin = new System.Windows.Forms.Padding(2);
            this.dgvParok.Name = "dgvParok";
            this.dgvParok.RowHeadersVisible = false;
            this.dgvParok.RowHeadersWidth = 51;
            this.dgvParok.RowTemplate.Height = 24;
            this.dgvParok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParok.Size = new System.Drawing.Size(507, 237);
            this.dgvParok.TabIndex = 2;
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
            // Column5
            // 
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "Súly";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Város:";
            // 
            // tbVaros
            // 
            this.tbVaros.Enabled = false;
            this.tbVaros.Location = new System.Drawing.Point(67, 36);
            this.tbVaros.Name = "tbVaros";
            this.tbVaros.Size = new System.Drawing.Size(100, 26);
            this.tbVaros.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fajta:";
            // 
            // tbFajta
            // 
            this.tbFajta.Enabled = false;
            this.tbFajta.Location = new System.Drawing.Point(228, 36);
            this.tbFajta.Name = "tbFajta";
            this.tbFajta.Size = new System.Drawing.Size(100, 26);
            this.tbFajta.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Súly:";
            // 
            // tbSuly
            // 
            this.tbSuly.Enabled = false;
            this.tbSuly.Location = new System.Drawing.Point(383, 36);
            this.tbSuly.Name = "tbSuly";
            this.tbSuly.Size = new System.Drawing.Size(100, 26);
            this.tbSuly.TabIndex = 1;
            // 
            // FrmParkereso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 386);
            this.Controls.Add(this.dgvParok);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmParkereso";
            this.Text = "Unikornis párkereső";
            this.Load += new System.EventHandler(this.FrmParkereso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSuly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFajta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVaros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvParok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}