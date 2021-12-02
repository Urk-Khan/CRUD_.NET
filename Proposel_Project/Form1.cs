using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purposel_Project
{
    public partial class Form1 : Form
    {
        public string constring = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void binsert_Click(object sender, EventArgs e)
        {
            string id = tid.Text;
            string name = tname.Text;
            string type = ttype.Text;

            string qry = "insert into medicine values('"+id+ "','"+name+ "','"+type+"')";

            dbcon db = new dbcon(constring);

            if (db.UDI(qry))
            {
                lstatus.Text = "Inserted";
            }
            else
            {
                lstatus.Text = "Errot in Insertion";
            }
        }
    }
}
