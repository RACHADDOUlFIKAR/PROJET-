﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;
            if (panel1.Width>=610)
                {
                timer1.Stop();
                Form1 f = new Form1();
                f.Show();
                this.Hide();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
