namespace Client.UserControl
{
    partial class KreirajRezervacijaUC
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnKreirajPutnika = new Button();
            cmbAgent = new ComboBox();
            cmbPutnik = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            lblJedinicnaCenaStavke = new Label();
            lblUkupnaCenaStavke = new Label();
            label6 = new Label();
            btnDodaj = new Button();
            cmbSmestaj = new ComboBox();
            dateDolazak = new DateTimePicker();
            datePolazak = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            txtOpis = new TextBox();
            numKolicina = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            btnSacuvajRezervaciju = new Button();
            dgvStavkeRezervacije = new DataGridView();
            lblUkupanIznos = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numKolicina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStavkeRezervacije).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(377, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 38);
            label1.TabIndex = 0;
            label1.Text = "Nova rezervacija";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKreirajPutnika);
            groupBox1.Controls.Add(cmbAgent);
            groupBox1.Controls.Add(cmbPutnik);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(184, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(691, 153);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rezervacija";
            // 
            // btnKreirajPutnika
            // 
            btnKreirajPutnika.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKreirajPutnika.Location = new Point(385, 40);
            btnKreirajPutnika.Name = "btnKreirajPutnika";
            btnKreirajPutnika.Size = new Size(51, 36);
            btnKreirajPutnika.TabIndex = 6;
            btnKreirajPutnika.Text = "+";
            btnKreirajPutnika.UseVisualStyleBackColor = true;
            btnKreirajPutnika.Click += btnKreirajPutnika_Click;
            // 
            // cmbAgent
            // 
            cmbAgent.FormattingEnabled = true;
            cmbAgent.Location = new Point(182, 88);
            cmbAgent.Name = "cmbAgent";
            cmbAgent.Size = new Size(191, 36);
            cmbAgent.TabIndex = 5;
            // 
            // cmbPutnik
            // 
            cmbPutnik.FormattingEnabled = true;
            cmbPutnik.Location = new Point(182, 40);
            cmbPutnik.Name = "cmbPutnik";
            cmbPutnik.Size = new Size(191, 36);
            cmbPutnik.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 94);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 3;
            label4.Text = "Agent:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 46);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 2;
            label3.Text = "Putnik:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblJedinicnaCenaStavke);
            groupBox2.Controls.Add(lblUkupnaCenaStavke);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnDodaj);
            groupBox2.Controls.Add(cmbSmestaj);
            groupBox2.Controls.Add(dateDolazak);
            groupBox2.Controls.Add(datePolazak);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtOpis);
            groupBox2.Controls.Add(numKolicina);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(22, 222);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(515, 408);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Stavka rezervacije";
            // 
            // lblJedinicnaCenaStavke
            // 
            lblJedinicnaCenaStavke.AutoSize = true;
            lblJedinicnaCenaStavke.Location = new Point(193, 51);
            lblJedinicnaCenaStavke.Name = "lblJedinicnaCenaStavke";
            lblJedinicnaCenaStavke.Size = new Size(53, 28);
            lblJedinicnaCenaStavke.TabIndex = 15;
            lblJedinicnaCenaStavke.Text = "0.00";
            // 
            // lblUkupnaCenaStavke
            // 
            lblUkupnaCenaStavke.AutoSize = true;
            lblUkupnaCenaStavke.Location = new Point(193, 98);
            lblUkupnaCenaStavke.Name = "lblUkupnaCenaStavke";
            lblUkupnaCenaStavke.Size = new Size(53, 28);
            lblUkupnaCenaStavke.TabIndex = 14;
            lblUkupnaCenaStavke.Text = "0.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(48, 101);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.TabIndex = 13;
            label6.Text = "Ukupna cena:";
            // 
            // btnDodaj
            // 
            btnDodaj.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDodaj.Location = new Point(193, 371);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(285, 33);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj stavku";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // cmbSmestaj
            // 
            cmbSmestaj.FormattingEnabled = true;
            cmbSmestaj.Location = new Point(193, 134);
            cmbSmestaj.Name = "cmbSmestaj";
            cmbSmestaj.Size = new Size(285, 36);
            cmbSmestaj.TabIndex = 7;
            // 
            // dateDolazak
            // 
            dateDolazak.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateDolazak.Location = new Point(193, 321);
            dateDolazak.Name = "dateDolazak";
            dateDolazak.Size = new Size(285, 29);
            dateDolazak.TabIndex = 12;
            // 
            // datePolazak
            // 
            datePolazak.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datePolazak.Location = new Point(193, 279);
            datePolazak.Name = "datePolazak";
            datePolazak.Size = new Size(285, 29);
            datePolazak.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(48, 145);
            label11.Name = "label11";
            label11.Size = new Size(81, 25);
            label11.TabIndex = 8;
            label11.Text = "Smestaj:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(48, 321);
            label10.Name = "label10";
            label10.Size = new Size(139, 25);
            label10.TabIndex = 7;
            label10.Text = "Datum dolaska:";
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(193, 229);
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(285, 34);
            txtOpis.TabIndex = 6;
            // 
            // numKolicina
            // 
            numKolicina.Location = new Point(193, 183);
            numKolicina.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numKolicina.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numKolicina.Name = "numKolicina";
            numKolicina.Size = new Size(285, 34);
            numKolicina.TabIndex = 5;
            numKolicina.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(48, 279);
            label9.Name = "label9";
            label9.Size = new Size(139, 25);
            label9.TabIndex = 4;
            label9.Text = "Datum polaska:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(48, 192);
            label8.Name = "label8";
            label8.Size = new Size(81, 25);
            label8.TabIndex = 3;
            label8.Text = "Kolicina:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(48, 235);
            label7.Name = "label7";
            label7.Size = new Size(111, 25);
            label7.TabIndex = 2;
            label7.Text = "Opis stavke:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(48, 51);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 0;
            label5.Text = "Jedinicna cena:";
            // 
            // btnSacuvajRezervaciju
            // 
            btnSacuvajRezervaciju.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSacuvajRezervaciju.ForeColor = SystemColors.ActiveCaptionText;
            btnSacuvajRezervaciju.Location = new Point(418, 636);
            btnSacuvajRezervaciju.Name = "btnSacuvajRezervaciju";
            btnSacuvajRezervaciju.Size = new Size(285, 47);
            btnSacuvajRezervaciju.TabIndex = 13;
            btnSacuvajRezervaciju.Text = "Sacuvaj rezervaciju";
            btnSacuvajRezervaciju.UseVisualStyleBackColor = true;
            btnSacuvajRezervaciju.Click += btnSacuvajRezervaciju_Click;
            // 
            // dgvStavkeRezervacije
            // 
            dgvStavkeRezervacije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStavkeRezervacije.Location = new Point(569, 232);
            dgvStavkeRezervacije.Name = "dgvStavkeRezervacije";
            dgvStavkeRezervacije.RowHeadersWidth = 62;
            dgvStavkeRezervacije.Size = new Size(472, 302);
            dgvStavkeRezervacije.TabIndex = 14;
            // 
            // lblUkupanIznos
            // 
            lblUkupanIznos.AutoSize = true;
            lblUkupanIznos.Location = new Point(823, 556);
            lblUkupanIznos.Name = "lblUkupanIznos";
            lblUkupanIznos.Size = new Size(36, 25);
            lblUkupanIznos.TabIndex = 15;
            lblUkupanIznos.Text = "0.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(694, 556);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 16;
            label2.Text = "Ukupan iznos:";
            // 
            // KreirajRezervacijaUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(lblUkupanIznos);
            Controls.Add(dgvStavkeRezervacije);
            Controls.Add(btnSacuvajRezervaciju);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "KreirajRezervacijaUC";
            Size = new Size(1062, 711);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numKolicina).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStavkeRezervacije).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cmbAgent;
        private ComboBox cmbPutnik;
        private Label label4;
        private Label label3;
        private Button btnKreirajPutnika;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txtOpis;
        private NumericUpDown numKolicina;
        private Label label9;
        private Label label8;
        private Label label7;
        private DateTimePicker dateDolazak;
        private DateTimePicker datePolazak;
        private Label label11;
        private Label label10;
        private Button btnDodaj;
        private ComboBox cmbSmestaj;
        private Button btnSacuvajRezervaciju;
        private DataGridView dgvStavkeRezervacije;
        private Label lblUkupanIznos;
        private Label label2;
        private Label label6;
        private Label lblUkupnaCenaStavke;
        private Label lblJedinicnaCenaStavke;
    }
}