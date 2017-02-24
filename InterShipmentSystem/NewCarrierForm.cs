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
    public partial class NewCarrierForm : Form
    {
        public NewCarrierForm()
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

                string command = "insert into Carriers values (@carrier_name, @phone_number, @email)";
                using (cmd = new SqlCommand(command, con))
                {
                    cmd.Parameters.AddWithValue("@carrier_name", companyNameBox.Text);     
                    cmd.Parameters.AddWithValue("@phone_number", phoneNumberBox.Text);
                    cmd.Parameters.AddWithValue("@email", mailBox.Text);
     
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
            phoneNumberBox.Clear();
            mailBox.Clear();        
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            clearBoxes();
        }
    }
}
