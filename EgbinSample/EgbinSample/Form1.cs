using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EgbinSample
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Height = this.Height-45;
            panel3.Width = (int)(this.Width - panel1.Width - 40);
            panel3.Height = panel1.Height;
            panel4.Width = panel3.Width;
            label5.Width = panel3.Width;
            panel5.Width = panel3.Width;
            //panel1.Left = (int)(this.Width - panel1.Width) / 2;
        }
    }
}
