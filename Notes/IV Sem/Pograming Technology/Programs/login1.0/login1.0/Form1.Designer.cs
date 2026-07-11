namespace login1._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.text1 = new System.Windows.Forms.TextBox();
            this.forget = new System.Windows.Forms.Label();
            this.u1 = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(176, 35);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(256, 22);
            this.text1.TabIndex = 1;
            // 
            // forget
            // 
            this.forget.AutoSize = true;
            this.forget.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forget.ForeColor = System.Drawing.Color.DarkRed;
            this.forget.Location = new System.Drawing.Point(30, 157);
            this.forget.Name = "forget";
            this.forget.Size = new System.Drawing.Size(154, 23);
            this.forget.TabIndex = 2;
            this.forget.Text = "forget password ?";
            // 
            // u1
            // 
            this.u1.AutoSize = true;
            this.u1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.u1.Location = new System.Drawing.Point(30, 34);
            this.u1.Name = "u1";
            this.u1.Size = new System.Drawing.Size(89, 23);
            this.u1.TabIndex = 3;
            this.u1.Text = "Username";
            this.u1.Click += new System.EventHandler(this.u1_Click);
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p.Location = new System.Drawing.Point(30, 82);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(84, 23);
            this.p.TabIndex = 4;
            this.p.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 22);
            this.textBox1.TabIndex = 5;
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.log.Location = new System.Drawing.Point(272, 128);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(51, 23);
            this.log.TabIndex = 6;
            this.log.Text = "login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.log);
            this.panel1.Controls.Add(this.text1);
            this.panel1.Controls.Add(this.forget);
            this.panel1.Controls.Add(this.p);
            this.panel1.Controls.Add(this.u1);
            this.panel1.Location = new System.Drawing.Point(380, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 237);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1052, 560);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label forget;
        private System.Windows.Forms.Label u1;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Panel panel1;
    }
}

