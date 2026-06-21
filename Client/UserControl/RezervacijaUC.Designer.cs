namespace Client.UserControl
{
    partial class RezervacijaUC
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
            btnKreirajRezervaciju = new Button();
            dgvRezervacije = new DataGridView();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            cmbSmestajPretrazi = new ComboBox();
            btnPretrazi = new Button();
            label2 = new Label();
            cmbPutnikPretrazi = new ComboBox();
            label3 = new Label();
            cmbAgentPretrazi = new ComboBox();
            label4 = new Label();
            dgvStavkaRez = new DataGridView();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblUkupanIznos = new Label();
            label5 = new Label();
            btnObrisiStavku = new Button();
            btnIzmeniStavku = new Button();
            btnDodajStavku = new Button();
            cmbPutnik = new ComboBox();
            label6 = new Label();
            cmbAgent = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRezervacije).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStavkaRez).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnKreirajRezervaciju
            // 
            btnKreirajRezervaciju.BackColor = SystemColors.ControlLight;
            btnKreirajRezervaciju.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKreirajRezervaciju.Location = new Point(765, 538);
            btnKreirajRezervaciju.Margin = new Padding(4);
            btnKreirajRezervaciju.Name = "btnKreirajRezervaciju";
            btnKreirajRezervaciju.Size = new Size(212, 63);
            btnKreirajRezervaciju.TabIndex = 29;
            btnKreirajRezervaciju.Text = "Kreiraj rezervaciju";
            btnKreirajRezervaciju.UseVisualStyleBackColor = false;
            btnKreirajRezervaciju.Click += btnKreirajRezervaciju_Click;
            // 
            // dgvRezervacije
            // 
            dgvRezervacije.AllowUserToAddRows = false;
            dgvRezervacije.AllowUserToDeleteRows = false;
            dgvRezervacije.BackgroundColor = SystemColors.ControlLight;
            dgvRezervacije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRezervacije.GridColor = SystemColors.ControlDark;
            dgvRezervacije.Location = new Point(578, 87);
            dgvRezervacije.Margin = new Padding(2);
            dgvRezervacije.Name = "dgvRezervacije";
            dgvRezervacije.ReadOnly = true;
            dgvRezervacije.RowHeadersWidth = 62;
            dgvRezervacije.Size = new Size(585, 427);
            dgvRezervacije.TabIndex = 28;
            dgvRezervacije.CellClick += dgvRezervacije_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cmbSmestajPretrazi);
            groupBox1.Controls.Add(btnPretrazi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbPutnikPretrazi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbAgentPretrazi);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1196, 76);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(531, 375);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rezervacija- pretraga";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.Location = new Point(455, 216);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(44, 44);
            button2.TabIndex = 20;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.Location = new Point(455, 128);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(44, 44);
            button3.TabIndex = 19;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(455, 44);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(44, 44);
            button1.TabIndex = 11;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbSmestajPretrazi
            // 
            cmbSmestajPretrazi.Font = new Font("Segoe UI", 9F);
            cmbSmestajPretrazi.FormattingEnabled = true;
            cmbSmestajPretrazi.Location = new Point(124, 224);
            cmbSmestajPretrazi.Margin = new Padding(4);
            cmbSmestajPretrazi.Name = "cmbSmestajPretrazi";
            cmbSmestajPretrazi.Size = new Size(323, 33);
            cmbSmestajPretrazi.TabIndex = 9;
            // 
            // btnPretrazi
            // 
            btnPretrazi.BackColor = SystemColors.ControlLight;
            btnPretrazi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPretrazi.Location = new Point(170, 292);
            btnPretrazi.Margin = new Padding(4);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(222, 45);
            btnPretrazi.TabIndex = 8;
            btnPretrazi.Text = "Pretrazi";
            btnPretrazi.UseVisualStyleBackColor = false;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(9, 230);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 28);
            label2.TabIndex = 4;
            label2.Text = "Smestaj:";
            // 
            // cmbPutnikPretrazi
            // 
            cmbPutnikPretrazi.Font = new Font("Segoe UI", 9F);
            cmbPutnikPretrazi.FormattingEnabled = true;
            cmbPutnikPretrazi.Location = new Point(124, 52);
            cmbPutnikPretrazi.Margin = new Padding(4);
            cmbPutnikPretrazi.Name = "cmbPutnikPretrazi";
            cmbPutnikPretrazi.Size = new Size(323, 33);
            cmbPutnikPretrazi.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(9, 142);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 28);
            label3.TabIndex = 2;
            label3.Text = "Agent:";
            // 
            // cmbAgentPretrazi
            // 
            cmbAgentPretrazi.Font = new Font("Segoe UI", 9F);
            cmbAgentPretrazi.FormattingEnabled = true;
            cmbAgentPretrazi.Location = new Point(124, 136);
            cmbAgentPretrazi.Margin = new Padding(4);
            cmbAgentPretrazi.Name = "cmbAgentPretrazi";
            cmbAgentPretrazi.Size = new Size(323, 33);
            cmbAgentPretrazi.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(9, 59);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 0;
            label4.Text = "Putnik:";
            // 
            // dgvStavkaRez
            // 
            dgvStavkaRez.BackgroundColor = SystemColors.ControlLight;
            dgvStavkaRez.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStavkaRez.Location = new Point(21, 209);
            dgvStavkaRez.Margin = new Padding(4);
            dgvStavkaRez.Name = "dgvStavkaRez";
            dgvStavkaRez.RowHeadersWidth = 51;
            dgvStavkaRez.Size = new Size(471, 214);
            dgvStavkaRez.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(742, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(235, 54);
            label1.TabIndex = 25;
            label1.Text = "Rezervacije";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblUkupanIznos);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dgvStavkaRez);
            groupBox2.Controls.Add(btnObrisiStavku);
            groupBox2.Controls.Add(btnIzmeniStavku);
            groupBox2.Controls.Add(btnDodajStavku);
            groupBox2.Controls.Add(cmbPutnik);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cmbAgent);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(13, 76);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(540, 674);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Stavke izabrane rezervacije";
            // 
            // lblUkupanIznos
            // 
            lblUkupanIznos.AutoSize = true;
            lblUkupanIznos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUkupanIznos.Location = new Point(147, 427);
            lblUkupanIznos.Name = "lblUkupanIznos";
            lblUkupanIznos.Size = new Size(46, 25);
            lblUkupanIznos.TabIndex = 31;
            lblUkupanIznos.Text = "0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 427);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 30;
            label5.Text = "Ukupan iznos: ";
            // 
            // btnObrisiStavku
            // 
            btnObrisiStavku.BackColor = SystemColors.ControlLight;
            btnObrisiStavku.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnObrisiStavku.ForeColor = Color.Red;
            btnObrisiStavku.Location = new Point(314, 462);
            btnObrisiStavku.Margin = new Padding(4);
            btnObrisiStavku.Name = "btnObrisiStavku";
            btnObrisiStavku.Size = new Size(178, 45);
            btnObrisiStavku.TabIndex = 33;
            btnObrisiStavku.Text = "Obrisi stavku";
            btnObrisiStavku.UseVisualStyleBackColor = false;
            btnObrisiStavku.Click += btnObrisiStavku_Click;
            // 
            // btnIzmeniStavku
            // 
            btnIzmeniStavku.BackColor = SystemColors.ControlLight;
            btnIzmeniStavku.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIzmeniStavku.Location = new Point(21, 471);
            btnIzmeniStavku.Margin = new Padding(4);
            btnIzmeniStavku.Name = "btnIzmeniStavku";
            btnIzmeniStavku.Size = new Size(178, 45);
            btnIzmeniStavku.TabIndex = 32;
            btnIzmeniStavku.Text = "Izmeni stavku";
            btnIzmeniStavku.UseVisualStyleBackColor = false;
            btnIzmeniStavku.Click += btnIzmeniStavku_Click;
            // 
            // btnDodajStavku
            // 
            btnDodajStavku.BackColor = SystemColors.ControlLight;
            btnDodajStavku.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDodajStavku.Location = new Point(147, 584);
            btnDodajStavku.Margin = new Padding(4);
            btnDodajStavku.Name = "btnDodajStavku";
            btnDodajStavku.Size = new Size(222, 45);
            btnDodajStavku.TabIndex = 8;
            btnDodajStavku.Text = "Dodaj novu stavku";
            btnDodajStavku.UseVisualStyleBackColor = false;
            btnDodajStavku.Click += btnDodajStavku_Click;
            // 
            // cmbPutnik
            // 
            cmbPutnik.Font = new Font("Segoe UI", 9F);
            cmbPutnik.FormattingEnabled = true;
            cmbPutnik.Location = new Point(124, 52);
            cmbPutnik.Margin = new Padding(4);
            cmbPutnik.Name = "cmbPutnik";
            cmbPutnik.Size = new Size(323, 33);
            cmbPutnik.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(10, 136);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(74, 28);
            label6.TabIndex = 2;
            label6.Text = "Agent:";
            // 
            // cmbAgent
            // 
            cmbAgent.Font = new Font("Segoe UI", 9F);
            cmbAgent.FormattingEnabled = true;
            cmbAgent.Location = new Point(124, 136);
            cmbAgent.Margin = new Padding(4);
            cmbAgent.Name = "cmbAgent";
            cmbAgent.Size = new Size(323, 33);
            cmbAgent.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(10, 60);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 28);
            label7.TabIndex = 0;
            label7.Text = "Putnik:";
            // 
            // RezervacijaUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(btnKreirajRezervaciju);
            Controls.Add(dgvRezervacije);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "RezervacijaUC";
            Size = new Size(1746, 833);
            ((System.ComponentModel.ISupportInitialize)dgvRezervacije).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStavkaRez).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKreirajRezervaciju;
        private DataGridView dgvRezervacije;
        private GroupBox groupBox1;
        private Button button2;
        private Button button3;
        private Button button1;
        private ComboBox cmbSmestajPretrazi;
        private Button btnPretrazi;
        private Label label2;
        private ComboBox cmbPutnikPretrazi;
        private Label label3;
        private ComboBox cmbAgentPretrazi;
        private Label label4;
        private DataGridView dgvStavkaRez;
        private Label label1;
        private GroupBox groupBox2;
            private Button btnDodajStavku;
        private Button btnObrisiStavku;
        private Button btnIzmeniStavku;
        private ComboBox cmbPutnik;
        private Label label6;
        private ComboBox cmbAgent;
        private Label label7;
        private Label lblUkupanIznos;
        private Label label5;
    }
}
