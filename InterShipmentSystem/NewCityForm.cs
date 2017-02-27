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
    public partial class NewCityForm : Form
    {
        public NewCityForm()
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

                string command = "insert into Cities values (@city_name, @post_index)";
                using (cmd = new SqlCommand(command, con))
                {
                    cmd.Parameters.AddWithValue("@city_name", cityNameBox.Text);
                    cmd.Parameters.AddWithValue("@post_index", postIndexBox.Text);
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            clearBoxes();
        }
        private void clearBoxes()
        {
            cityNameBox.Clear();
            postIndexBox.Clear(); 
        }
    }
}
