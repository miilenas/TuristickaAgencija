namespace Client.UserControl
{
    partial class StavkaRezervacijeUC
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtOpisStavke = new TextBox();
            label7 = new Label();
            numericKolicina = new NumericUpDown();
            label6 = new Label();
            lblUkupnaCena = new Label();
            labela = new Label();
            dtpDatumOd = new DateTimePicker();
            label5 = new Label();
            lblJedinicnaCena = new Label();
            btnSacuvaj = new Button();
            btnObrisi = new Button();
            btnDodajStavku = new Button();
            dgvStavkaRezervacije = new DataGridView();
            dtpDatumDo = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbSmestaj = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericKolicina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStavkaRezervacije).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(513, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(319, 48);
            label1.TabIndex = 22;
            label1.Text = "Stavka rezervacije";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtOpisStavke);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numericKolicina);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblUkupnaCena);
            groupBox1.Controls.Add(labela);
            groupBox1.Controls.Add(dtpDatumOd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblJedinicnaCena);
            groupBox1.Controls.Add(btnSacuvaj);
            groupBox1.Controls.Add(btnObrisi);
            groupBox1.Controls.Add(btnDodajStavku);
            groupBox1.Controls.Add(dgvStavkaRezervacije);
            groupBox1.Controls.Add(dtpDatumDo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbSmestaj);
            groupBox1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(304, 83);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(774, 685);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // txtOpisStavke
            // 
            txtOpisStavke.Location = new Point(278, 218);
            txtOpisStavke.Name = "txtOpisStavke";
            txtOpisStavke.Size = new Size(396, 35);
            txtOpisStavke.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(104, 228);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(104, 25);
            label7.TabIndex = 31;
            label7.Text = "Opis stavke";
            // 
            // numericKolicina
            // 
            numericKolicina.Location = new Point(278, 135);
            numericKolicina.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericKolicina.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericKolicina.Name = "numericKolicina";
            numericKolicina.Size = new Size(396, 35);
            numericKolicina.TabIndex = 30;
            numericKolicina.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(103, 140);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 29;
            label6.Text = "Kolicina";
            // 
            // lblUkupnaCena
            // 
            lblUkupnaCena.AutoSize = true;
            lblUkupnaCena.Location = new Point(278, 177);
            lblUkupnaCena.Name = "lblUkupnaCena";
            lblUkupnaCena.Size = new Size(72, 29);
            lblUkupnaCena.TabIndex = 28;
            lblUkupnaCena.Text = "0.00";
            // 
            // labela
            // 
            labela.AutoSize = true;
            labela.Font = new Font("Segoe UI", 9F);
            labela.Location = new Point(104, 181);
            labela.Margin = new Padding(4, 0, 4, 0);
            labela.Name = "labela";
            labela.Size = new Size(114, 25);
            labela.TabIndex = 27;
            labela.Text = "Ukupna cena";
            // 
            // dtpDatumOd
            // 
            dtpDatumOd.Font = new Font("Georgia", 10.8F);
            dtpDatumOd.Location = new Point(278, 270);
            dtpDatumOd.Margin = new Padding(4);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.Size = new Size(396, 32);
            dtpDatumOd.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(104, 277);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 25;
            label5.Text = "Datum polaska";
            // 
            // lblJedinicnaCena
            // 
            lblJedinicnaCena.AutoSize = true;
            lblJedinicnaCena.Location = new Point(278, 96);
            lblJedinicnaCena.Name = "lblJedinicnaCena";
            lblJedinicnaCena.Size = new Size(72, 29);
            lblJedinicnaCena.TabIndex = 24;
            lblJedinicnaCena.Text = "0.00";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.BackColor = SystemColors.ControlLight;
            btnSacuvaj.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSacuvaj.Location = new Point(475, 609);
            btnSacuvaj.Margin = new Padding(4);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(184, 40);
            btnSacuvaj.TabIndex = 23;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = SystemColors.ControlLight;
            btnObrisi.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisi.Location = new Point(142, 609);
            btnObrisi.Margin = new Padding(4);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(184, 40);
            btnObrisi.TabIndex = 21;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnDodajStavku
            // 
            btnDodajStavku.BackColor = SystemColors.ControlLight;
            btnDodajStavku.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajStavku.Location = new Point(344, 370);
            btnDodajStavku.Margin = new Padding(4);
            btnDodajStavku.Name = "btnDodajStavku";
            btnDodajStavku.Size = new Size(184, 40);
            btnDodajStavku.TabIndex = 19;
            btnDodajStavku.Text = "Dodaj";
            btnDodajStavku.UseVisualStyleBackColor = false;
            btnDodajStavku.Click += btnDodajStavku_Click;
            // 
            // dgvStavkaRezervacije
            // 
            dgvStavkaRezervacije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvStavkaRezervacije.DefaultCellStyle = dataGridViewCellStyle1;
            dgvStavkaRezervacije.Location = new Point(8, 418);
            dgvStavkaRezervacije.Margin = new Padding(4);
            dgvStavkaRezervacije.Name = "dgvStavkaRezervacije";
            dgvStavkaRezervacije.RowHeadersWidth = 51;
            dgvStavkaRezervacije.Size = new Size(758, 174);
            dgvStavkaRezervacije.TabIndex = 20;
            dgvStavkaRezervacije.CellContentClick += dgvStavkaRezervacije_CellContentClick;
            // 
            // dtpDatumDo
            // 
            dtpDatumDo.Font = new Font("Georgia", 10.8F);
            dtpDatumDo.Location = new Point(278, 321);
            dtpDatumDo.Margin = new Padding(4);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.Size = new Size(396, 32);
            dtpDatumDo.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(104, 321);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 18;
            label4.Text = "Datum dolaska";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(103, 99);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 17;
            label3.Text = "Jedinicna cena";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(104, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 15;
            label2.Text = "Smestaj";
            // 
            // cmbSmestaj
            // 
            cmbSmestaj.Font = new Font("Georgia", 10.8F);
            cmbSmestaj.FormattingEnabled = true;
            cmbSmestaj.Location = new Point(278, 50);
            cmbSmestaj.Margin = new Padding(4);
            cmbSmestaj.Name = "cmbSmestaj";
            cmbSmestaj.Size = new Size(396, 35);
            cmbSmestaj.TabIndex = 14;
            // 
            // StavkaRezervacijeUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "StavkaRezervacijeUC";
            Size = new Size(1401, 754);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericKolicina).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStavkaRezervacije).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnSacuvaj;
        private Button btnObrisi;
        private Button btnDodajStavku;
        private DataGridView dgvStavkaRezervacije;
        private DateTimePicker dtpDatumDo;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbSmestaj;
        private Label label5;
        private Label lblJedinicnaCena;
        private Label lblUkupnaCena;
        private Label labela;
        private DateTimePicker dtpDatumOd;
        private TextBox txtOpisStavke;
        private Label label7;
        private NumericUpDown numericKolicina;
        private Label label6;
    }
}