using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace winforms_crud
{
    public partial class FormRead : Form
    {
        public FormRead()
        {
            InitializeComponent();
        }


        private void button_nav_delete_Click(object sender, EventArgs e)
        {
            FormDelete formDelete = new FormDelete();

            this.Hide();
            formDelete.Show();
        }

        private void button_nav_enter_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Hide();
            form1.Show();
        }

        private void button_nav_update_Click(object sender, EventArgs e)
        {
            FormUpdate formUpdate = new FormUpdate();

            this.Hide();
            formUpdate.Show();
        }

        private void button_show_data_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DVM\Documents\uidDB.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM userId";

            SqlDataAdapter da = new SqlDataAdapter(query, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "userId");
            datagridview_uid.DataSource = ds.Tables["userId"];
        }
    }
}
