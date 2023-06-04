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
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
        }

        private void button_submit_uid_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_delete_uid.Text);

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DVM\Documents\uidDB.mdf;Integrated Security=True;Connect Timeout=30");

            string query = "DELETE FROM userId WHERE id = '" + id + "'";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Recored successfully deleted");
                } else
                {
                    MessageBox.Show("No id found");
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button_clear_uid_delete_Click(object sender, EventArgs e)
        {
            textBox_delete_uid.Text = string.Empty;
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

        private void button_nav_read_Click(object sender, EventArgs e)
        {
            FormRead formRead = new FormRead();
            this.Hide();
            formRead.Show();
        }
    }
}
