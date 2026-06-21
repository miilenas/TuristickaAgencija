namespace Client.UserControl
{
    partial class KreirajPutnikUC
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
            cmbMesto = new ComboBox();
            btnSacuvaj = new Button();
            txtBrojPasosa = new TextBox();
            txtBrojTelefona = new TextBox();
            txtPrezime = new TextBox();
            txtIme = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(726, 169);
            label1.Name = "label1";
            label1.Size = new Size(142, 30);
            label1.TabIndex = 0;
            label1.Text = "Novi putnik";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbMesto);
            groupBox1.Controls.Add(btnSacuvaj);
            groupBox1.Controls.Add(txtBrojPasosa);
            groupBox1.Controls.Add(txtBrojTelefona);
            groupBox1.Controls.Add(txtPrezime);
            groupBox1.Controls.Add(txtIme);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(506, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(660, 461);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // cmbMesto
            // 
            cmbMesto.FormattingEnabled = true;
            cmbMesto.Location = new Point(242, 316);
            cmbMesto.Name = "cmbMesto";
            cmbMesto.Size = new Size(243, 33);
            cmbMesto.TabIndex = 11;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(242, 388);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(243, 40);
            btnSacuvaj.TabIndex = 10;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // txtBrojPasosa
            // 
            txtBrojPasosa.Location = new Point(242, 253);
            txtBrojPasosa.Name = "txtBrojPasosa";
            txtBrojPasosa.Size = new Size(243, 31);
            txtBrojPasosa.TabIndex = 8;
            // 
            // txtBrojTelefona
            // 
            txtBrojTelefona.Location = new Point(242, 190);
            txtBrojTelefona.Name = "txtBrojTelefona";
            txtBrojTelefona.Size = new Size(243, 31);
            txtBrojTelefona.TabIndex = 7;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(242, 125);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(243, 31);
            txtPrezime.TabIndex = 6;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(242, 64);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(243, 31);
            txtIme.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(51, 321);
            label6.Name = "label6";
            label6.Size = new Size(76, 28);
            label6.TabIndex = 4;
            label6.Text = "Mesto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(51, 253);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 3;
            label5.Text = "Broj pasosa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(51, 190);
            label4.Name = "label4";
            label4.Size = new Size(141, 28);
            label4.TabIndex = 2;
            label4.Text = "Broj telefona:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 125);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 1;
            label3.Text = "Prezime: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 63);
            label2.Name = "label2";
            label2.Size = new Size(64, 30);
            label2.TabIndex = 0;
            label2.Text = "Ime: ";
            // 
            // KreirajPutnikUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "KreirajPutnikUC";
            Size = new Size(1570, 806);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSacuvaj;
        private TextBox txtBrojPasosa;
        private TextBox txtBrojTelefona;
        private TextBox txtPrezime;
        private TextBox txtIme;
        private ComboBox cmbMesto;
    }
}