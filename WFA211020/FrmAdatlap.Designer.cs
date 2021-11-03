
namespace WFA211020
{
    partial class FrmAdatlap
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.cbTulajok = new System.Windows.Forms.ComboBox();
            this.nudSuly = new System.Windows.Forms.NumericUpDown();
            this.rbKanca = new System.Windows.Forms.RadioButton();
            this.pbKep = new System.Windows.Forms.PictureBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFajtak = new System.Windows.Forms.ComboBox();
            this.rbCsodor = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Thistle;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfo.Location = new System.Drawing.Point(77, 101);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(43, 17);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Fajta:";
            // 
            // cbTulajok
            // 
            this.cbTulajok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTulajok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbTulajok.FormattingEnabled = true;
            this.cbTulajok.Location = new System.Drawing.Point(165, 145);
            this.cbTulajok.Name = "cbTulajok";
            this.cbTulajok.Size = new System.Drawing.Size(141, 24);
            this.cbTulajok.TabIndex = 1;
            // 
            // nudSuly
            // 
            this.nudSuly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudSuly.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSuly.Location = new System.Drawing.Point(200, 193);
            this.nudSuly.Maximum = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.nudSuly.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudSuly.Name = "nudSuly";
            this.nudSuly.Size = new System.Drawing.Size(72, 23);
            this.nudSuly.TabIndex = 2;
            this.nudSuly.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // rbKanca
            // 
            this.rbKanca.AutoSize = true;
            this.rbKanca.BackColor = System.Drawing.Color.Thistle;
            this.rbKanca.Checked = true;
            this.rbKanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbKanca.Location = new System.Drawing.Point(165, 240);
            this.rbKanca.Name = "rbKanca";
            this.rbKanca.Size = new System.Drawing.Size(64, 21);
            this.rbKanca.TabIndex = 3;
            this.rbKanca.TabStop = true;
            this.rbKanca.Text = "kanca";
            this.rbKanca.UseVisualStyleBackColor = false;
            // 
            // pbKep
            // 
            this.pbKep.BackColor = System.Drawing.Color.White;
            this.pbKep.Location = new System.Drawing.Point(369, 53);
            this.pbKep.Name = "pbKep";
            this.pbKep.Size = new System.Drawing.Size(200, 250);
            this.pbKep.TabIndex = 4;
            this.pbKep.TabStop = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInsert.Location = new System.Drawing.Point(41, 323);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(528, 49);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Új egyed rögzítése az adatbázisba!";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(38, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tulajdonos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(81, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Súly:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(79, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nem:";
            // 
            // cbFajtak
            // 
            this.cbFajtak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFajtak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFajtak.FormattingEnabled = true;
            this.cbFajtak.Location = new System.Drawing.Point(165, 98);
            this.cbFajtak.Name = "cbFajtak";
            this.cbFajtak.Size = new System.Drawing.Size(141, 24);
            this.cbFajtak.TabIndex = 1;
            this.cbFajtak.SelectedIndexChanged += new System.EventHandler(this.CbFajtak_SelectedIndexChanged);
            // 
            // rbCsodor
            // 
            this.rbCsodor.AutoSize = true;
            this.rbCsodor.BackColor = System.Drawing.Color.Thistle;
            this.rbCsodor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbCsodor.Location = new System.Drawing.Point(237, 240);
            this.rbCsodor.Name = "rbCsodor";
            this.rbCsodor.Size = new System.Drawing.Size(69, 21);
            this.rbCsodor.TabIndex = 3;
            this.rbCsodor.TabStop = true;
            this.rbCsodor.Text = "csődör";
            this.rbCsodor.UseVisualStyleBackColor = false;
            // 
            // FrmAdatlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(635, 423);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.pbKep);
            this.Controls.Add(this.rbCsodor);
            this.Controls.Add(this.rbKanca);
            this.Controls.Add(this.nudSuly);
            this.Controls.Add(this.cbFajtak);
            this.Controls.Add(this.cbTulajok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAdatlap";
            this.Text = "Új Egyed Bejelentése";
            this.Load += new System.EventHandler(this.FrmAdatlap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSuly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cbTulajok;
        private System.Windows.Forms.NumericUpDown nudSuly;
        private System.Windows.Forms.RadioButton rbKanca;
        private System.Windows.Forms.PictureBox pbKep;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFajtak;
        private System.Windows.Forms.RadioButton rbCsodor;
    }
}