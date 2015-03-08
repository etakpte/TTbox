using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TTbox
{
    public partial class Main : Form
    {
       public Channel[] newchannel = new Channel[15];
       public Int16 channels = 0;
        public void sendtext(string text)
        {
            this.newchannel[channels].terminalControl1.SendText(text);
        }
        public Main()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //newchannel = new Channel();
            channels++;
            newchannel[channels] = new Channel();
            newchannel[channels].Owner = this;
            newchannel[channels].MdiParent = this;
            newchannel[channels].Text = "Channel" + channels;
            newchannel[channels].channelnumber = channels;
            newchannel[channels].Show();
            
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            File newfile = new File(this);
            newfile.Owner = this;
            newfile.MdiParent = this;
            newfile.Show();
        }
    }
}
