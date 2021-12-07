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
    public partial class Form2 : Form
    {
        string constring = "Data Source=DESKTOP-7JTES9Q\\SQLEXPRESS;Initial Catalog=ITCON;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }
        /* public void Function()
        {
            string id = tid.Text;
            string name = tname.Text;
            string cat = cbcat.SelectedItem.ToString();
            string stock = tstock.Text;
        }
       */
        private void binsert_Click(object sender, EventArgs e)
        {
            //Function f=new Function();
            string id = tid.Text;
            string name = tname.Text;
            string cat = cbcat.SelectedItem.ToString();
            string rate = trate.Text;
            string stock = tstock.Text;
            string query = "insert into mstore1 values('" + id + "','" + name + "','" + cat + "','" + rate + "','" + stock + "')";

            dbcon db = new dbcon(constring);
            if (db.UDI(query))
            {
                lstatus.Text = "Inserted";
            }
            else
            {
                lstatus.Text = "Error in Inserted";
            }
        }

        private void bupdate_Click(object sender, EventArgs e)
        {
            string id = tid.Text;
            string name = tname.Text;
            string cat = cbcat.SelectedItem.ToString();
            string stock = trate.Text;
            string query = "update mstore1 set Name='" + name + "',Category='" + cat + "',Rate'" + trate + "',Stock'" + stock + "' where id = '" + id + "'";

            dbcon db = new dbcon(constring);
            if (db.UDI(query))
            {
                lstatus.Text = "Updated";
            }
            else
            {
                lstatus.Text = "Error in Updated";
            }
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            string id = tid.Text;
            string query = "delete from mstore1 where id = '" + id + "'";

            dbcon db = new dbcon(constring);
            if (db.UDI(query))
            {
                lstatus.Text = "Deleted";
            }
            else
            {
                lstatus.Text = "Error in Deleted";
            }
        }

        private void bsearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dbcon dbqry = new dbcon(constring);

            string query = "select * from mstore1 where id = '" + tid.Text + "'";
            dt = dbqry.search(query);
            if (dt.Rows.Count > 0)
            {
                lstatus.Text = "Seach Result";
                tname.Text = dt.Rows[0]["Name"].ToString();
                cbcat.Text = dt.Rows[0]["Category"].ToString();
                trate.Text = dt.Rows[0]["Rate"].ToString();
                tstock.Text = dt.Rows[0]["Stock"].ToString();
            }
            else
            {
                lstatus.Text = "Error in Search";
            }
        }

        private void bdisplay_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dbcon dbqry = new dbcon(constring);

            string query = "select * from mstore1 ";
            dt = dbqry.search(query);
            if (dt.Rows.Count > 0)
            {
                lstatus.Text = "Result Displaid";
                dgv1.DataSource = dt;
            }
            else
            {
                lstatus.Text = "Error in Search";
            }
        }

        private void bhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fhome = new Form1();
            fhome.ShowDialog();
        }
    }
}
