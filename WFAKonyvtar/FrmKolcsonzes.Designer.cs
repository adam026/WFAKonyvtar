namespace WFAKonyvtar
{
    partial class FrmKolcsonzes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbkISBN = new System.Windows.Forms.TextBox();
            this.tbkSzerzo = new System.Windows.Forms.TextBox();
            this.tbkCim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKolcsonzo = new System.Windows.Forms.TextBox();
            this.nudHonap = new System.Windows.Forms.NumericUpDown();
            this.btnFelvitel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHonap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Szerző:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cím:";
            // 
            // tbkISBN
            // 
            this.tbkISBN.Enabled = false;
            this.tbkISBN.Location = new System.Drawing.Point(125, 16);
            this.tbkISBN.Name = "tbkISBN";
            this.tbkISBN.Size = new System.Drawing.Size(240, 22);
            this.tbkISBN.TabIndex = 1;
            // 
            // tbkSzerzo
            // 
            this.tbkSzerzo.Enabled = false;
            this.tbkSzerzo.Location = new System.Drawing.Point(125, 49);
            this.tbkSzerzo.Name = "tbkSzerzo";
            this.tbkSzerzo.Size = new System.Drawing.Size(240, 22);
            this.tbkSzerzo.TabIndex = 1;
            // 
            // tbkCim
            // 
            this.tbkCim.Enabled = false;
            this.tbkCim.Location = new System.Drawing.Point(125, 84);
            this.tbkCim.Name = "tbkCim";
            this.tbkCim.Size = new System.Drawing.Size(240, 22);
            this.tbkCim.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kölcsönzés időtartama (hónap):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kölcsönző neve:";
            // 
            // tbKolcsonzo
            // 
            this.tbKolcsonzo.Location = new System.Drawing.Point(534, 19);
            this.tbKolcsonzo.Name = "tbKolcsonzo";
            this.tbKolcsonzo.Size = new System.Drawing.Size(240, 22);
            this.tbKolcsonzo.TabIndex = 1;
            // 
            // nudHonap
            // 
            this.nudHonap.Location = new System.Drawing.Point(646, 50);
            this.nudHonap.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudHonap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHonap.Name = "nudHonap";
            this.nudHonap.Size = new System.Drawing.Size(128, 22);
            this.nudHonap.TabIndex = 3;
            this.nudHonap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Location = new System.Drawing.Point(16, 127);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(758, 48);
            this.btnFelvitel.TabIndex = 4;
            this.btnFelvitel.Text = "Felvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // FrmKolcsonzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 198);
            this.Controls.Add(this.btnFelvitel);
            this.Controls.Add(this.nudHonap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbkCim);
            this.Controls.Add(this.tbkSzerzo);
            this.Controls.Add(this.tbKolcsonzo);
            this.Controls.Add(this.tbkISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmKolcsonzes";
            this.Text = "FrmKolcsonzes";
            this.Load += new System.EventHandler(this.FrmKolcsonzes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHonap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbkISBN;
        private System.Windows.Forms.TextBox tbkSzerzo;
        private System.Windows.Forms.TextBox tbkCim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKolcsonzo;
        private System.Windows.Forms.NumericUpDown nudHonap;
        private System.Windows.Forms.Button btnFelvitel;
    }
}