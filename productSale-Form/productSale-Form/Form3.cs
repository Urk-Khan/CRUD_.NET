﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace productSale_Form
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fhome = new Form1();
            fhome.ShowDialog();
        }
    }
}
