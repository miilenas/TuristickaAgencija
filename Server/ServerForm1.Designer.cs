namespace Server
{
    partial class ServerForm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            buttonStop = new Button();
            buttonStart = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Desktop;
            textBox1.Location = new Point(214, 182);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 42);
            textBox1.TabIndex = 5;
            textBox1.Text = "Server nije pokrenut";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = Color.LavenderBlush;
            buttonStop.Location = new Point(214, 324);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(250, 44);
            buttonStop.TabIndex = 4;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = false;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.LavenderBlush;
            buttonStart.Location = new Point(214, 265);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(250, 44);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(280, 103);
            label1.Name = "label1";
            label1.Size = new Size(116, 45);
            label1.TabIndex = 6;
            label1.Text = "Server";
            // 
            // ServerForm1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 493);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Name = "ServerForm1";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonStop;
        private Button buttonStart;
        private Label label1;
    }
}
