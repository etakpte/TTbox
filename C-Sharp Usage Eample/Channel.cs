using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Poderosa.Terminal;

namespace TTbox
{
    public partial class Channel : Form
    {
        public Channel()
        {
            InitializeComponent();
        }
        public int channelnumber = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            this.terminalControl1.UserName = this.usertextBox3.Text;
            this.terminalControl1.Password = this.passtextBox2.Text;
            this.terminalControl1.Host = this.servertextBox1.Text;
            this.terminalControl1.Method = WalburySoftware.ConnectionMethod.SSH2;

            this.terminalControl1.Connect();

            this.terminalControl1.SetPaneColors(Color.Blue, Color.Black);
            this.terminalControl1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.terminalControl1.TerminalPane.ConnectionTag == null) // it will be null if you're not connected to anything
                return;


            Poderosa.Forms.EditRenderProfile dlg = new Poderosa.Forms.EditRenderProfile(this.terminalControl1.TerminalPane.ConnectionTag.RenderProfile);
            
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            this.terminalControl1.TerminalPane.ConnectionTag.RenderProfile = dlg.Result;
            this.terminalControl1.TerminalPane.ApplyRenderProfile(dlg.Result);
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
               case (char)13:
                    this.terminalControl1.SendText(textBox1.Lines[textBox1.GetLineFromCharIndex(textBox1.SelectionStart)] + Environment.NewLine);
                    textBox1.AppendText(Environment.NewLine);
                    e.Handled = true;
                    break;
            }
        }
        
    }

}