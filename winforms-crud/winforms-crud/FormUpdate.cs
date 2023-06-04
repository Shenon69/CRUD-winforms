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
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void button_update_uid_Click(object sender, EventArgs e)
        {
            int oldId = int.Parse(textBox_old_uid.Text);
            int newId = int.Parse(textBox_update_uid.Text);

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DVM\Documents\uidDB.mdf;Integrated Security=True;Connect Timeout=30");

            string query = "UPDATE userId SET id = '" + newId + "' WHERE id = '" + oldId + "'";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
               int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                MessageBox.Show($"Successfully updated Id number : {oldId} to {newId}");

                } else
                {
                    MessageBox.Show($"No Id was found as {oldId}");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void button_clear_uid_update_Click(object sender, EventArgs e)
        {
            textBox_old_uid.Text = string.Empty;
            textBox_update_uid.Text= string.Empty;
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

        private void button_nav_read_Click(object sender, EventArgs e)
        {
            FormRead formRead = new FormRead();

            this.Hide();
            formRead.Show();
        }
    }
}
