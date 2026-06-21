namespace Client.UserControl
{
    partial class PutnikUC
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
            groupBox1 = new GroupBox();
            cmbMesto = new ComboBox();
            btnObrisi = new Button();
            btnIzmeni = new Button();
            txtBrojPasosa = new TextBox();
            txtBrojTelefona = new TextBox();
            txtPrezime = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtIme = new TextBox();
            label6 = new Label();
            dgvSviPutnici = new DataGridView();
            btnKreiraj = new Button();
            groupBox2 = new GroupBox();
            btnOcistiMesto = new Button();
            btnOcistiBrojPasosa = new Button();
            btnOcistiBrojTelefona = new Button();
            btnOcistiPrezime = new Button();
            btnOcistiIme = new Button();
            cmbMestoPretrazi = new ComboBox();
            btnPretrazi = new Button();
            txtBrojPasosaPretrazi = new TextBox();
            txtBrojTelefonaPretrazi = new TextBox();
            txtPrezimePretrazi = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtImePretrazi = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSviPutnici).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbMesto);
            groupBox1.Controls.Add(btnObrisi);
            groupBox1.Controls.Add(btnIzmeni);
            groupBox1.Controls.Add(txtBrojPasosa);
            groupBox1.Controls.Add(txtBrojTelefona);
            groupBox1.Controls.Add(txtPrezime);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtIme);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 565);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Putnik- izmena podataka";
            // 
            // cmbMesto
            // 
            cmbMesto.FormattingEnabled = true;
            cmbMesto.Location = new Point(165, 313);
            cmbMesto.Name = "cmbMesto";
            cmbMesto.Size = new Size(203, 36);
            cmbMesto.TabIndex = 12;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = Color.LavenderBlush;
            btnObrisi.ForeColor = Color.Red;
            btnObrisi.Location = new Point(96, 487);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(162, 42);
            btnObrisi.TabIndex = 11;
            btnObrisi.Text = "Obrisi putnika";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = Color.LavenderBlush;
            btnIzmeni.Location = new Point(96, 407);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(162, 42);
            btnIzmeni.TabIndex = 10;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // txtBrojPasosa
            // 
            txtBrojPasosa.Location = new Point(165, 251);
            txtBrojPasosa.Name = "txtBrojPasosa";
            txtBrojPasosa.Size = new Size(202, 34);
            txtBrojPasosa.TabIndex = 8;
            // 
            // txtBrojTelefona
            // 
            txtBrojTelefona.Location = new Point(166, 196);
            txtBrojTelefona.Name = "txtBrojTelefona";
            txtBrojTelefona.Size = new Size(202, 34);
            txtBrojTelefona.TabIndex = 7;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(166, 135);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(202, 34);
            txtPrezime.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(15, 313);
            label5.Name = "label5";
            label5.Size = new Size(76, 28);
            label5.TabIndex = 5;
            label5.Text = "Mesto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(15, 251);
            label4.Name = "label4";
            label4.Size = new Size(126, 28);
            label4.TabIndex = 4;
            label4.Text = "Broj pasosa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(15, 196);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 3;
            label3.Text = "Broj telefona: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(15, 135);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 2;
            label2.Text = "Prezime: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(15, 77);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 1;
            label1.Text = "Ime: ";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(166, 74);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(202, 34);
            txtIme.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Desktop;
            label6.Location = new Point(768, 32);
            label6.Name = "label6";
            label6.Size = new Size(153, 54);
            label6.TabIndex = 1;
            label6.Text = "Putnici";
            // 
            // dgvSviPutnici
            // 
            dgvSviPutnici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSviPutnici.Location = new Point(424, 89);
            dgvSviPutnici.Name = "dgvSviPutnici";
            dgvSviPutnici.RowHeadersWidth = 62;
            dgvSviPutnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSviPutnici.Size = new Size(874, 395);
            dgvSviPutnici.TabIndex = 2;
            dgvSviPutnici.CellClick += dgvSviPutnici_CellClick;
            // 
            // btnKreiraj
            // 
            btnKreiraj.BackColor = Color.LavenderBlush;
            btnKreiraj.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKreiraj.Location = new Point(729, 490);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Size = new Size(253, 72);
            btnKreiraj.TabIndex = 3;
            btnKreiraj.Text = "Kreiraj novog putnika";
            btnKreiraj.UseVisualStyleBackColor = false;
            btnKreiraj.Click += btnKreiraj_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOcistiMesto);
            groupBox2.Controls.Add(btnOcistiBrojPasosa);
            groupBox2.Controls.Add(btnOcistiBrojTelefona);
            groupBox2.Controls.Add(btnOcistiPrezime);
            groupBox2.Controls.Add(btnOcistiIme);
            groupBox2.Controls.Add(cmbMestoPretrazi);
            groupBox2.Controls.Add(btnPretrazi);
            groupBox2.Controls.Add(txtBrojPasosaPretrazi);
            groupBox2.Controls.Add(txtBrojTelefonaPretrazi);
            groupBox2.Controls.Add(txtPrezimePretrazi);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtImePretrazi);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(1322, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(452, 565);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Putnik- pretraga";
            // 
            // btnOcistiMesto
            // 
            btnOcistiMesto.ForeColor = SystemColors.Desktop;
            btnOcistiMesto.Location = new Point(374, 315);
            btnOcistiMesto.Name = "btnOcistiMesto";
            btnOcistiMesto.Size = new Size(43, 34);
            btnOcistiMesto.TabIndex = 17;
            btnOcistiMesto.Text = "X";
            btnOcistiMesto.UseVisualStyleBackColor = true;
            btnOcistiMesto.Click += btnOcistiMesto_Click;
            // 
            // btnOcistiBrojPasosa
            // 
            btnOcistiBrojPasosa.ForeColor = SystemColors.Desktop;
            btnOcistiBrojPasosa.Location = new Point(374, 251);
            btnOcistiBrojPasosa.Name = "btnOcistiBrojPasosa";
            btnOcistiBrojPasosa.Size = new Size(43, 34);
            btnOcistiBrojPasosa.TabIndex = 16;
            btnOcistiBrojPasosa.Text = "X";
            btnOcistiBrojPasosa.UseVisualStyleBackColor = true;
            btnOcistiBrojPasosa.Click += btnOcistiBrojPasosa_Click;
            // 
            // btnOcistiBrojTelefona
            // 
            btnOcistiBrojTelefona.ForeColor = SystemColors.Desktop;
            btnOcistiBrojTelefona.Location = new Point(374, 196);
            btnOcistiBrojTelefona.Name = "btnOcistiBrojTelefona";
            btnOcistiBrojTelefona.Size = new Size(43, 34);
            btnOcistiBrojTelefona.TabIndex = 15;
            btnOcistiBrojTelefona.Text = "X";
            btnOcistiBrojTelefona.UseVisualStyleBackColor = true;
            btnOcistiBrojTelefona.Click += btnOcistiBrojTelefona_Click;
            // 
            // btnOcistiPrezime
            // 
            btnOcistiPrezime.ForeColor = SystemColors.Desktop;
            btnOcistiPrezime.Location = new Point(374, 135);
            btnOcistiPrezime.Name = "btnOcistiPrezime";
            btnOcistiPrezime.Size = new Size(43, 34);
            btnOcistiPrezime.TabIndex = 14;
            btnOcistiPrezime.Text = "X";
            btnOcistiPrezime.UseVisualStyleBackColor = true;
            btnOcistiPrezime.Click += btnOcistiPrezime_Click;
            // 
            // btnOcistiIme
            // 
            btnOcistiIme.ForeColor = SystemColors.Desktop;
            btnOcistiIme.Location = new Point(374, 74);
            btnOcistiIme.Name = "btnOcistiIme";
            btnOcistiIme.Size = new Size(43, 35);
            btnOcistiIme.TabIndex = 13;
            btnOcistiIme.Text = "X";
            btnOcistiIme.UseVisualStyleBackColor = true;
            btnOcistiIme.Click += btnOcistiIme_Click;
            // 
            // cmbMestoPretrazi
            // 
            cmbMestoPretrazi.FormattingEnabled = true;
            cmbMestoPretrazi.Location = new Point(165, 313);
            cmbMestoPretrazi.Name = "cmbMestoPretrazi";
            cmbMestoPretrazi.Size = new Size(203, 36);
            cmbMestoPretrazi.TabIndex = 12;
            // 
            // btnPretrazi
            // 
            btnPretrazi.BackColor = Color.LavenderBlush;
            btnPretrazi.Location = new Point(127, 394);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(162, 42);
            btnPretrazi.TabIndex = 10;
            btnPretrazi.Text = "Pretrazi";
            btnPretrazi.UseVisualStyleBackColor = false;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // txtBrojPasosaPretrazi
            // 
            txtBrojPasosaPretrazi.Location = new Point(165, 251);
            txtBrojPasosaPretrazi.Name = "txtBrojPasosaPretrazi";
            txtBrojPasosaPretrazi.Size = new Size(202, 34);
            txtBrojPasosaPretrazi.TabIndex = 8;
            // 
            // txtBrojTelefonaPretrazi
            // 
            txtBrojTelefonaPretrazi.Location = new Point(166, 196);
            txtBrojTelefonaPretrazi.Name = "txtBrojTelefonaPretrazi";
            txtBrojTelefonaPretrazi.Size = new Size(202, 34);
            txtBrojTelefonaPretrazi.TabIndex = 7;
            // 
            // txtPrezimePretrazi
            // 
            txtPrezimePretrazi.Location = new Point(166, 135);
            txtPrezimePretrazi.Name = "txtPrezimePretrazi";
            txtPrezimePretrazi.Size = new Size(202, 34);
            txtPrezimePretrazi.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(15, 313);
            label7.Name = "label7";
            label7.Size = new Size(76, 28);
            label7.TabIndex = 5;
            label7.Text = "Mesto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Desktop;
            label8.Location = new Point(15, 251);
            label8.Name = "label8";
            label8.Size = new Size(126, 28);
            label8.TabIndex = 4;
            label8.Text = "Broj pasosa:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Desktop;
            label9.Location = new Point(15, 196);
            label9.Name = "label9";
            label9.Size = new Size(147, 28);
            label9.TabIndex = 3;
            label9.Text = "Broj telefona: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Desktop;
            label10.Location = new Point(15, 135);
            label10.Name = "label10";
            label10.Size = new Size(99, 28);
            label10.TabIndex = 2;
            label10.Text = "Prezime: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.Desktop;
            label11.Location = new Point(15, 77);
            label11.Name = "label11";
            label11.Size = new Size(58, 28);
            label11.TabIndex = 1;
            label11.Text = "Ime: ";
            // 
            // txtImePretrazi
            // 
            txtImePretrazi.Location = new Point(166, 74);
            txtImePretrazi.Name = "txtImePretrazi";
            txtImePretrazi.Size = new Size(202, 34);
            txtImePretrazi.TabIndex = 0;
            // 
            // PutnikUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(btnKreiraj);
            Controls.Add(dgvSviPutnici);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Name = "PutnikUC";
            Size = new Size(1777, 759);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSviPutnici).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnIzmeni;
        private TextBox txtBrojPasosa;
        private TextBox txtBrojTelefona;
        private TextBox txtPrezime;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtIme;
        private Button btnObrisi;
        private Label label6;
        private DataGridView dgvSviPutnici;
        private ComboBox cmbMesto;
        private Button btnKreiraj;
        private GroupBox groupBox2;
        private ComboBox cmbMestoPretrazi;
        private Button btnPretrazi;
        private TextBox txtBrojPasosaPretrazi;
        private TextBox txtBrojTelefonaPretrazi;
        private TextBox txtPrezimePretrazi;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtImePretrazi;
        private Button btnOcistiMesto;
        private Button btnOcistiBrojPasosa;
        private Button btnOcistiBrojTelefona;
        private Button btnOcistiPrezime;
        private Button btnOcistiIme;
    }
}
