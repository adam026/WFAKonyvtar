namespace WFAKonyvtar
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szerzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megjelenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbSzerzo = new System.Windows.Forms.TextBox();
            this.tbCim = new System.Windows.Forms.TextBox();
            this.tbMegjelenes = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSelectedKolcsonozheto = new System.Windows.Forms.TextBox();
            this.tbSelectedCim = new System.Windows.Forms.TextBox();
            this.tbSelectedSzerzo = new System.Windows.Forms.TextBox();
            this.tbSelectedISBN = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnKolcsonzes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.szerzo,
            this.cim,
            this.megjelenes});
            this.dgvMain.Location = new System.Drawing.Point(16, 15);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(924, 290);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // ISBN
            // 
            this.ISBN.FillWeight = 70F;
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // szerzo
            // 
            this.szerzo.FillWeight = 130F;
            this.szerzo.HeaderText = "Szerző";
            this.szerzo.Name = "szerzo";
            // 
            // cim
            // 
            this.cim.HeaderText = "Cím";
            this.cim.Name = "cim";
            // 
            // megjelenes
            // 
            this.megjelenes.HeaderText = "Megjelenés";
            this.megjelenes.Name = "megjelenes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szerző:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cím:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 435);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Megjelenés:";
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(145, 313);
            this.tbISBN.Margin = new System.Windows.Forms.Padding(4);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(271, 22);
            this.tbISBN.TabIndex = 2;
            // 
            // tbSzerzo
            // 
            this.tbSzerzo.Location = new System.Drawing.Point(145, 352);
            this.tbSzerzo.Margin = new System.Windows.Forms.Padding(4);
            this.tbSzerzo.Name = "tbSzerzo";
            this.tbSzerzo.Size = new System.Drawing.Size(271, 22);
            this.tbSzerzo.TabIndex = 2;
            // 
            // tbCim
            // 
            this.tbCim.Location = new System.Drawing.Point(145, 390);
            this.tbCim.Margin = new System.Windows.Forms.Padding(4);
            this.tbCim.Name = "tbCim";
            this.tbCim.Size = new System.Drawing.Size(271, 22);
            this.tbCim.TabIndex = 2;
            // 
            // tbMegjelenes
            // 
            this.tbMegjelenes.Location = new System.Drawing.Point(145, 429);
            this.tbMegjelenes.Margin = new System.Windows.Forms.Padding(4);
            this.tbMegjelenes.Name = "tbMegjelenes";
            this.tbMegjelenes.Size = new System.Drawing.Size(271, 22);
            this.tbMegjelenes.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbSelectedKolcsonozheto);
            this.groupBox1.Controls.Add(this.tbSelectedCim);
            this.groupBox1.Controls.Add(this.tbSelectedSzerzo);
            this.groupBox1.Controls.Add(this.tbSelectedISBN);
            this.groupBox1.Location = new System.Drawing.Point(533, 313);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(407, 158);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A kiválasztott könyv adatai:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Kölcsönözhető:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cím:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Szerző:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "ISBN:";
            // 
            // tbSelectedKolcsonozheto
            // 
            this.tbSelectedKolcsonozheto.Enabled = false;
            this.tbSelectedKolcsonozheto.Location = new System.Drawing.Point(112, 110);
            this.tbSelectedKolcsonozheto.Margin = new System.Windows.Forms.Padding(4);
            this.tbSelectedKolcsonozheto.Name = "tbSelectedKolcsonozheto";
            this.tbSelectedKolcsonozheto.Size = new System.Drawing.Size(277, 22);
            this.tbSelectedKolcsonozheto.TabIndex = 2;
            // 
            // tbSelectedCim
            // 
            this.tbSelectedCim.Enabled = false;
            this.tbSelectedCim.Location = new System.Drawing.Point(112, 81);
            this.tbSelectedCim.Margin = new System.Windows.Forms.Padding(4);
            this.tbSelectedCim.Name = "tbSelectedCim";
            this.tbSelectedCim.Size = new System.Drawing.Size(277, 22);
            this.tbSelectedCim.TabIndex = 2;
            // 
            // tbSelectedSzerzo
            // 
            this.tbSelectedSzerzo.Enabled = false;
            this.tbSelectedSzerzo.Location = new System.Drawing.Point(112, 52);
            this.tbSelectedSzerzo.Margin = new System.Windows.Forms.Padding(4);
            this.tbSelectedSzerzo.Name = "tbSelectedSzerzo";
            this.tbSelectedSzerzo.Size = new System.Drawing.Size(277, 22);
            this.tbSelectedSzerzo.TabIndex = 2;
            // 
            // tbSelectedISBN
            // 
            this.tbSelectedISBN.Enabled = false;
            this.tbSelectedISBN.Location = new System.Drawing.Point(112, 24);
            this.tbSelectedISBN.Margin = new System.Windows.Forms.Padding(4);
            this.tbSelectedISBN.Name = "tbSelectedISBN";
            this.tbSelectedISBN.Size = new System.Drawing.Size(277, 22);
            this.tbSelectedISBN.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(16, 472);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(400, 52);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Új könyv hozzáadása";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnKolcsonzes
            // 
            this.btnKolcsonzes.Location = new System.Drawing.Point(533, 479);
            this.btnKolcsonzes.Margin = new System.Windows.Forms.Padding(4);
            this.btnKolcsonzes.Name = "btnKolcsonzes";
            this.btnKolcsonzes.Size = new System.Drawing.Size(407, 45);
            this.btnKolcsonzes.TabIndex = 4;
            this.btnKolcsonzes.Text = "Kiválasztott könyv kölcsönzése";
            this.btnKolcsonzes.UseVisualStyleBackColor = true;
            this.btnKolcsonzes.Click += new System.EventHandler(this.btnKolcsonzes_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 555);
            this.Controls.Add(this.btnKolcsonzes);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbMegjelenes);
            this.Controls.Add(this.tbCim);
            this.Controls.Add(this.tbSzerzo);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Könyvtár program minimál";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn szerzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cim;
        private System.Windows.Forms.DataGridViewTextBoxColumn megjelenes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.TextBox tbSzerzo;
        private System.Windows.Forms.TextBox tbCim;
        private System.Windows.Forms.TextBox tbMegjelenes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSelectedKolcsonozheto;
        private System.Windows.Forms.TextBox tbSelectedCim;
        private System.Windows.Forms.TextBox tbSelectedSzerzo;
        private System.Windows.Forms.TextBox tbSelectedISBN;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnKolcsonzes;
    }
}

