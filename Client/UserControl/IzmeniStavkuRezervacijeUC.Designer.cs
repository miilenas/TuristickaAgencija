namespace Client.UserControl
{
    partial class IzmeniStavkuRezervacijeUC
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnNazad = new Button();
            btnSacuvaj = new Button();
            dtpDatumDo = new DateTimePicker();
            label4 = new Label();
            dtpDatumOd = new DateTimePicker();
            label5 = new Label();
            txtOpisStavke = new TextBox();
            label7 = new Label();
            numericKolicina = new NumericUpDown();
            label6 = new Label();
            lblUkupnaCena = new Label();
            label8 = new Label();
            lblJedinicnaCena = new Label();
            label3 = new Label();
            cmbSmestaj = new ComboBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericKolicina).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(498, 43);
            label1.Name = "label1";
            label1.Size = new Size(441, 48);
            label1.TabIndex = 0;
            label1.Text = "Izmeni stavku rezervacije";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNazad);
            groupBox1.Controls.Add(btnSacuvaj);
            groupBox1.Controls.Add(dtpDatumDo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpDatumOd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtOpisStavke);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numericKolicina);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblUkupnaCena);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lblJedinicnaCena);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbSmestaj);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(398, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(579, 540);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o stavci";
            // 
            // btnNazad
            // 
            btnNazad.BackColor = Color.LavenderBlush;
            btnNazad.Location = new Point(311, 463);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(176, 43);
            btnNazad.TabIndex = 15;
            btnNazad.Text = "Nazad";
            btnNazad.UseVisualStyleBackColor = false;
            btnNazad.Click += btnNazad_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.BackColor = Color.LavenderBlush;
            btnSacuvaj.Location = new Point(94, 463);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(176, 43);
            btnSacuvaj.TabIndex = 14;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // dtpDatumDo
            // 
            dtpDatumDo.Font = new Font("Segoe UI", 9F);
            dtpDatumDo.Location = new Point(207, 367);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.Size = new Size(280, 31);
            dtpDatumDo.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(63, 373);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 12;
            label4.Text = "Datum dolaska";
            // 
            // dtpDatumOd
            // 
            dtpDatumOd.Font = new Font("Segoe UI", 9F);
            dtpDatumOd.Location = new Point(207, 316);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.Size = new Size(280, 31);
            dtpDatumOd.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(63, 322);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 10;
            label5.Text = "Datum polaska";
            // 
            // txtOpisStavke
            // 
            txtOpisStavke.Font = new Font("Segoe UI", 9F);
            txtOpisStavke.Location = new Point(207, 253);
            txtOpisStavke.Name = "txtOpisStavke";
            txtOpisStavke.Size = new Size(280, 31);
            txtOpisStavke.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(63, 259);
            label7.Name = "label7";
            label7.Size = new Size(104, 25);
            label7.TabIndex = 8;
            label7.Text = "Opis stavke";
            // 
            // numericKolicina
            // 
            numericKolicina.Font = new Font("Segoe UI", 9F);
            numericKolicina.Location = new Point(207, 131);
            numericKolicina.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericKolicina.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericKolicina.Name = "numericKolicina";
            numericKolicina.Size = new Size(280, 31);
            numericKolicina.TabIndex = 7;
            numericKolicina.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = SystemColors.Desktop;
            label6.Location = new Point(63, 137);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 6;
            label6.Text = "Kolicina";
            // 
            // lblUkupnaCena
            // 
            lblUkupnaCena.AutoSize = true;
            lblUkupnaCena.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUkupnaCena.Location = new Point(207, 202);
            lblUkupnaCena.Name = "lblUkupnaCena";
            lblUkupnaCena.Size = new Size(47, 25);
            lblUkupnaCena.TabIndex = 5;
            lblUkupnaCena.Text = "0.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.ForeColor = SystemColors.Desktop;
            label8.Location = new Point(63, 202);
            label8.Name = "label8";
            label8.Size = new Size(114, 25);
            label8.TabIndex = 4;
            label8.Text = "Ukupna cena";
            // 
            // lblJedinicnaCena
            // 
            lblJedinicnaCena.AutoSize = true;
            lblJedinicnaCena.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblJedinicnaCena.Location = new Point(207, 92);
            lblJedinicnaCena.Name = "lblJedinicnaCena";
            lblJedinicnaCena.Size = new Size(47, 25);
            lblJedinicnaCena.TabIndex = 3;
            lblJedinicnaCena.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(63, 92);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 2;
            label3.Text = "Jedinicna cena";
            // 
            // cmbSmestaj
            // 
            cmbSmestaj.Font = new Font("Segoe UI", 9F);
            cmbSmestaj.FormattingEnabled = true;
            cmbSmestaj.Location = new Point(207, 43);
            cmbSmestaj.Name = "cmbSmestaj";
            cmbSmestaj.Size = new Size(280, 33);
            cmbSmestaj.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(63, 51);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 0;
            label2.Text = "Smestaj";
            // 
            // IzmeniStavkuRezervacijeUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "IzmeniStavkuRezervacijeUC";
            Size = new Size(1401, 754);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericKolicina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private GroupBox groupBox1;
        private Button btnNazad;
        private Button btnSacuvaj;
        private DateTimePicker dtpDatumDo;
        private Label label4;
        private DateTimePicker dtpDatumOd;
        private Label label5;
        private TextBox txtOpisStavke;
        private Label label7;
        private NumericUpDown numericKolicina;
        private Label label6;
        private Label lblUkupnaCena;
        private Label label8;
        private Label lblJedinicnaCena;
        private Label label3;
        private ComboBox cmbSmestaj;
        private Label label2;
    }
}
