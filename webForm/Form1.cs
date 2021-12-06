using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webForm
{
    public partial class Form1 : Form
    {
        public string constring = "Data Source=DESKTOP-7JTES9Q\\SQLEXPRESS;Initial Catalog=ITCON;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void binsert_Click(object sender, EventArgs e)
        {
            string id = tid.Text;
            string name = tname.Text;
            string cat = cbcat.SelectedItem.ToString();
            string stock= tstock.Text;
            string query = "insert into mstore values('" + id + "','" + name + "','" + cat + "','" + stock + "')";

            dbcon db = new dbcon(constring);
            if (db.UDI(query))
            {
                lstatus.Text = "Inserted";
            }else
            {
                lstatus.Text = "Error in Inserted";
            }
        }

        private void bupdate_Click(object sender, EventArgs e)
        {
            string id = tid.Text;
            string name = tname.Text;
            string cat = cbcat.SelectedItem.ToString();
            string stock = tstock.Text;
            string query = "update mstore set Name='" + name + "',Category='" + cat + "',Stock'" + stock + "' where id = '" + id + "'";

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
            string query = "delete from mstore where id = '" + id + "'";

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

            string query = "select * from mstore where id = '" + tid.Text + "'";
            dt = dbqry.search(query);
            if (dt.Rows.Count > 0)
            {
                lstatus.Text = "Seach Result";
                tname.Text = dt.Rows[0]["Name"].ToString();
                cbcat.Text = dt.Rows[0]["Category"].ToString();
            }
            else
            {
                lstatus.Text = "Error in Search";
            }
        }

        private void tcatg_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dbcon dbqry = new dbcon(constring);

            string query = "select * from mstore ";
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

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
