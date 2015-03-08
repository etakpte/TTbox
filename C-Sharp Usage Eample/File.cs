using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TTbox
{
    public partial class File : Form
    {
        private Main parent;
        private Channel activechannel;
        public File(Main parent)
        {
            InitializeComponent();
            this.parent = parent;
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F4:
                    if (activechannel != null)
                    {
                        activechannel.terminalControl1.SendText(textBox1.Lines[textBox1.GetLineFromCharIndex(textBox1.SelectionStart)] + Environment.NewLine);
                        //this.MdiParent.terminalControl1.SendText(textBox1.Lines[textBox1.GetLineFromCharIndex(textBox1.SelectionStart)] + Environment.NewLine);
                        //textBox1.AppendText(Environment.NewLine);
                        e.Handled = true;
                    }
                        break;
                    
            }

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
         
                
            }
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            this.toolStripMenuItem4.DropDownItems.Clear();
            ToolStripMenuItem[] items = new ToolStripMenuItem[parent.channels]; 
            if (parent.channels > 0)
            {
                for (int i = 0; i < parent.channels; i++)
                {

             
                        items[i] = new ToolStripMenuItem();
                        items[i].Name = "dynamicItem" + i.ToString();
                        items[i].Tag = "specialDataHere";
                        items[i].Text = parent.newchannel[i+1].Text;
                        items[i].Click += new EventHandler(MenuItemClickHandler);
                 
      
                 
               //     this.toolStripMenuItem6.Size = new System.Drawing.Size(152, 22);
                 
                   
                    if (activechannel == parent.newchannel[i+1])
                    { items[i].Checked = true; }
                }
                this.toolStripMenuItem4.DropDownItems.AddRange(items);
            }
        }

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            for (int i = 0; i < parent.channels; i++)
                {
                    if (parent.newchannel[i + 1].Text == clickedItem.Text)
                    {
                    activechannel = parent.newchannel[i+1];
                }
                }
        }

    
    }
}
