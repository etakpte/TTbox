namespace TTbox
{
    partial class Channel
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
            this.button1 = new System.Windows.Forms.Button();
            this.servertextBox1 = new System.Windows.Forms.TextBox();
            this.passtextBox2 = new System.Windows.Forms.TextBox();
            this.usertextBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.terminalControl1 = new WalburySoftware.TerminalControl();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // servertextBox1
            // 
            this.servertextBox1.Location = new System.Drawing.Point(12, 35);
            this.servertextBox1.Name = "servertextBox1";
            this.servertextBox1.Size = new System.Drawing.Size(100, 20);
            this.servertextBox1.TabIndex = 0;
            this.servertextBox1.Text = "192.168.1.13";
            // 
            // passtextBox2
            // 
            this.passtextBox2.Location = new System.Drawing.Point(246, 35);
            this.passtextBox2.Name = "passtextBox2";
            this.passtextBox2.PasswordChar = '*';
            this.passtextBox2.Size = new System.Drawing.Size(100, 20);
            this.passtextBox2.TabIndex = 2;
            this.passtextBox2.Text = "P@5sword!";
            // 
            // usertextBox3
            // 
            this.usertextBox3.Location = new System.Drawing.Point(130, 35);
            this.usertextBox3.Name = "usertextBox3";
            this.usertextBox3.Size = new System.Drawing.Size(100, 20);
            this.usertextBox3.TabIndex = 1;
            this.usertextBox3.Text = "remoteserver";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SSH Server";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "edit display";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 92);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.terminalControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(646, 442);
            this.splitContainer1.SplitterDistance = 371;
            this.splitContainer1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(646, 67);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // terminalControl1
            // 
            this.terminalControl1.AuthType = Poderosa.ConnectionParam.AuthType.Password;
            this.terminalControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.terminalControl1.Host = "";
            this.terminalControl1.IdentifyFile = "";
            this.terminalControl1.Location = new System.Drawing.Point(0, 0);
            this.terminalControl1.Method = WalburySoftware.ConnectionMethod.Telnet;
            this.terminalControl1.Name = "terminalControl1";
            this.terminalControl1.Password = "";
            this.terminalControl1.Size = new System.Drawing.Size(646, 371);
            this.terminalControl1.TabIndex = 1;
            this.terminalControl1.Text = "terminalControl1";
            this.terminalControl1.UserName = "";
            // 
            // Channel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usertextBox3);
            this.Controls.Add(this.passtextBox2);
            this.Controls.Add(this.servertextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Channel";
            this.Text = "Channel";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox servertextBox1;
        private System.Windows.Forms.TextBox passtextBox2;
        private System.Windows.Forms.TextBox usertextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public WalburySoftware.TerminalControl terminalControl1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

