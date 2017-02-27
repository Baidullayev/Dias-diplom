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
    public partial class CreateOrderForm : Form
    {
        public CreateOrderForm()
        {
            InitializeComponent();
        }

        private void createOrderButton_Click(object sender, EventArgs e)
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
                    
                    string command = "insert into Orders values (@load_name, @client_name, @carrier_name, @departure_city, @destination_city, @order_date, @cost, @order_status, @load_type, @carriage_type, @load_weight, @load_volume)";
                    using (cmd = new SqlCommand(command, con))
                    {                        
                        cmd.Parameters.AddWithValue("@load_name", loadNameBox.Text);
                        cmd.Parameters.AddWithValue("@client_name", ClientBox.Text);
                        cmd.Parameters.AddWithValue("@carrier_name", CarrierBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@departure_city", DepartureCityBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@destination_city", DestinationCityBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@order_date", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@cost", costBox.Text);
                        cmd.Parameters.AddWithValue("@order_status", statusBox.Text);
                        cmd.Parameters.AddWithValue("@load_type", loadTypeBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@carriage_type", carriageTypeBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@load_weight", loadWeightBox.Text);
                        cmd.Parameters.AddWithValue("@load_volume", loadVolumeBox.Text);
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

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            //Получени списка клиентов
            using (SqlConnection con = new SqlConnection(MainForm.connectionString))
            {
                try
                {
                    con.Open();

                    string command = "select company_name from Clients";
                    SqlCommand cmd = new SqlCommand(command, con);

                    SqlDataReader reader = cmd.ExecuteReader();

                    string[] arr = new string[5];
                    while (reader.Read())
                    {
                        ClientBox.Items.Add(reader["company_name"].ToString());
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }


            //Получени списка перевозщиков
            using (SqlConnection con = new SqlConnection(MainForm.connectionString))
            {
                con.Open();

                string command = "select carrier_name from Carriers";
                SqlCommand cmd = new SqlCommand(command, con);

                SqlDataReader reader = cmd.ExecuteReader();

                string[] arr = new string[5];
                while (reader.Read())
                {
                    CarrierBox.Items.Add(reader["carrier_name"].ToString());
                }

                con.Close();
            }


            //Получение списка городов 
            using (SqlConnection con = new SqlConnection(MainForm.connectionString))
            {
                con.Open();

                string command = "select city_name from Cities";
                SqlCommand cmd = new SqlCommand(command, con);

                SqlDataReader reader = cmd.ExecuteReader();

                string[] arr = new string[5];
                while (reader.Read())
                {
                    DepartureCityBox.Items.Add(reader["city_name"].ToString());
                    DestinationCityBox.Items.Add(reader["city_name"].ToString());
                }

                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearBoxes();
        }

        public void clearBoxes()
        {
            loadNameBox.Text = "";
            ClientBox.Text = "";
            CarrierBox.SelectedIndex = -1;
            DepartureCityBox.SelectedIndex = -1;
            DestinationCityBox.SelectedIndex = -1;
            costBox.Text = "";
            loadTypeBox.SelectedIndex = -1;
            carriageTypeBox.SelectedIndex = -1;
            loadWeightBox.Text = "";
            loadVolumeBox.Clear();
        }

        private void loadVolumeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void loadWeightBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void costBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void addCarrierButton_Click(object sender, EventArgs e)
        {
            NewCarrierForm newCarrierForm = new NewCarrierForm();
            newCarrierForm.Show();
        }

        private void addCleintButton_Click(object sender, EventArgs e)
        {
            NewClientForm newClient = new NewClientForm();
            newClient.Show();
        }

        private void CreateOrderForm_Activated(object sender, EventArgs e)
        {
            ClientBox.Items.Clear();
            CarrierBox.Items.Clear();
            using (SqlConnection con = new SqlConnection(MainForm.connectionString))
            {
                con.Open();

                string command = "select company_name from Clients";
                SqlCommand cmd = new SqlCommand(command, con);

                SqlDataReader reader = cmd.ExecuteReader();

                string[] arr = new string[5];
                while (reader.Read())
                {
                    ClientBox.Items.Add(reader["company_name"].ToString());
                }

                con.Close();
            }


            //Получени списка перевозщиков
            using (SqlConnection con = new SqlConnection(MainForm.connectionString))
            {
                con.Open();

                string command = "select carrier_name from Carriers";
                SqlCommand cmd = new SqlCommand(command, con);

                SqlDataReader reader = cmd.ExecuteReader();

                string[] arr = new string[5];
                while (reader.Read())
                {
                    CarrierBox.Items.Add(reader["carrier_name"].ToString());
                }

                con.Close();
            }
        }
    }
}
