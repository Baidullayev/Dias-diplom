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

namespace InterShipmentSystem
{
    public partial class NewClientForm : Form
    {
        public NewClientForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            using (SqlConnection con = new SqlConnection(MainForm.connectionString))
            {
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                string command = "insert into Clients values (@company_name, @contact_person, @phone_number, @email, @company_address)";
                using (cmd = new SqlCommand(command, con))
                {
                    cmd.Parameters.AddWithValue("@company_name", companyNameBox.Text);
                    cmd.Parameters.AddWithValue("@contact_person", contactPersonBox.Text);
                    cmd.Parameters.AddWithValue("@phone_number", phoneNumberBox.Text);
                    cmd.Parameters.AddWithValue("@email", mailBox.Text);
                    cmd.Parameters.AddWithValue("@company_address", addressBox.Text);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Успешно!");
                    clearBoxes();
                }
            }

        }

        private void clearBoxes()
        {
            companyNameBox.Clear();
            contactPersonBox.Clear();
            phoneNumberBox.Clear();
            mailBox.Clear();
            addressBox.Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            clearBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
