﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 servicesForm = new Form6();
            servicesForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 timeForm = new Form7();
            timeForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 timeForm = new Form8();
            timeForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 timeForm = new Form9();
            timeForm.ShowDialog();
        }
    }
}
