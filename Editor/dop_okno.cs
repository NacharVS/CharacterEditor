using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Editor
{
    public partial class dop_okno : Form
    {
        public dop_okno()
        {
            InitializeComponent();
        }

        private void dop_okno_SizeChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dop_okno_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }
    }
}
