namespace Client.UserControl
{
    partial class LicencaUC
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
            groupBox2 = new GroupBox();
            dpIstek = new DateTimePicker();
            label6 = new Label();
            dpIzdavanje = new DateTimePicker();
            label4 = new Label();
            cmbAgent = new ComboBox();
            label3 = new Label();
            cmbTipLicence = new ComboBox();
            btnSacuvaj = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dpIstek);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dpIzdavanje);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cmbAgent);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbTipLicence);
            groupBox2.Controls.Add(btnSacuvaj);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 9F);
            groupBox2.Location = new Point(246, 93);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(859, 609);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            // 
            // dpIstek
            // 
            dpIstek.Font = new Font("Segoe UI", 9F);
            dpIstek.Location = new Point(409, 392);
            dpIstek.Margin = new Padding(4);
            dpIstek.Name = "dpIstek";
            dpIstek.Size = new Size(396, 31);
            dpIstek.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(129, 393);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 25);
            label6.TabIndex = 26;
            label6.Text = "Datum isteka";
            // 
            // dpIzdavanje
            // 
            dpIzdavanje.Font = new Font("Segoe UI", 9F);
            dpIzdavanje.Location = new Point(409, 288);
            dpIzdavanje.Margin = new Padding(4);
            dpIzdavanje.Name = "dpIzdavanje";
            dpIzdavanje.Size = new Size(396, 31);
            dpIzdavanje.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(129, 289);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 25);
            label4.TabIndex = 24;
            label4.Text = "Datum izdavanja";
            // 
            // cmbAgent
            // 
            cmbAgent.Font = new Font("Segoe UI", 9F);
            cmbAgent.FormattingEnabled = true;
            cmbAgent.Location = new Point(409, 192);
            cmbAgent.Margin = new Padding(4);
            cmbAgent.Name = "cmbAgent";
            cmbAgent.Size = new Size(229, 33);
            cmbAgent.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(129, 193);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 22;
            label3.Text = "Agent";
            // 
            // cmbTipLicence
            // 
            cmbTipLicence.Font = new Font("Segoe UI", 9F);
            cmbTipLicence.FormattingEnabled = true;
            cmbTipLicence.Location = new Point(409, 89);
            cmbTipLicence.Margin = new Padding(4);
            cmbTipLicence.Name = "cmbTipLicence";
            cmbTipLicence.Size = new Size(229, 33);
            cmbTipLicence.TabIndex = 21;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.BackColor = SystemColors.ControlLight;
            btnSacuvaj.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSacuvaj.Location = new Point(352, 491);
            btnSacuvaj.Margin = new Padding(4);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(184, 40);
            btnSacuvaj.TabIndex = 20;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(129, 90);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 16;
            label2.Text = "Tip licence";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(539, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 48);
            label1.TabIndex = 20;
            label1.Text = "Nova licenca";
            // 
            // LicencaUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 726);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "LicencaUC";
            Text = "LicencaUC";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private DateTimePicker dpIstek;
        private Label label6;
        private DateTimePicker dpIzdavanje;
        private Label label4;
        private ComboBox cmbAgent;
        private Label label3;
        private ComboBox cmbTipLicence;
        private Button btnSacuvaj;
        private Label label2;
        private Label label1;
    }
}