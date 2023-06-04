using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_submit_uid_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_uid.Text);

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DVM\Documents\uidDB.mdf;Integrated Security=True;Connect Timeout=30");

            string query = "INSERT INTO userId VALUES('" + id + "')";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_clear_uid_Click(object sender, EventArgs e)
        {
            textBox_uid.Text = string.Empty;
        }

        private void button_nav_delete_Click(object sender, EventArgs e)
        {
           FormDelete formDel = new FormDelete();

            this.Hide();
            formDel.Show();
        }

        private void button_nav_update_Click(object sender, EventArgs e)
        {
            FormUpdate formUpdate = new FormUpdate();
            this.Hide();
            formUpdate.Show();
        }

        private void button_nav_read_Click(object sender, EventArgs e)
        {
            FormRead formRead = new FormRead();

            this.Hide();
            formRead.Show();

          
        }
    }
}
