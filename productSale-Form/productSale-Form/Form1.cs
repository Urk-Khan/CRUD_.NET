using System;
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
    public partial class Form1 : Form
    {
        string constring = "Data Source=DESKTOP-7JTES9Q\\SQLEXPRESS;Initial Catalog=ITCON;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
       
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void bstock_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fstock = new Form2();
            fstock.ShowDialog();
            fstock = null;
            this.Show();
        }
        private void bsale_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fsale = new Form3();
            fsale.ShowDialog();
            fsale = null;
            this.Show();
        }
    }
}
