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


namespace InterShipmentSystem
{
    public partial class OrdersForm : Form
    {

        int orderId = -1;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            
            searchingAtrComboBox.SelectedIndex = 0;
            dateTimePicker1.Value.ToShortDateString();
            if (MainForm.connectionState)
            {
                dataGridView1.DataSource = bindingSource1;
                GetData("select * from Orders");
                      
                dataGridView1.Columns[0].HeaderText = "ID заявки";
                dataGridView1.Columns[1].HeaderText = "наименование груза";
                dataGridView1.Columns[2].HeaderText = "Клиент";
                dataGridView1.Columns[3].HeaderText = "Перевозщик";
                dataGridView1.Columns[4].HeaderText = "Станция отправления";
                dataGridView1.Columns[5].HeaderText = "Станция доставки";
                dataGridView1.Columns[6].HeaderText = "Дата отправки";
                dataGridView1.Columns[7].HeaderText = "Стоимость";
                dataGridView1.Columns[8].HeaderText = "Статус";
                dataGridView1.Columns[9].HeaderText = "Тип груза";
                dataGridView1.Columns[10].HeaderText = "Род вагона";      
                dataGridView1.Columns[11].HeaderText = "Масса груза";
                dataGridView1.Columns[12].HeaderText = "Объем груза";

                dataGridView1.Columns[0].Visible = false;

                dataGridView1.Columns[1].Width = 120;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[7].Width = 100;
                dataGridView1.Columns[11].Width = 75;
                dataGridView1.Columns[12].Width = 55;
            }else
            {
                MessageBox.Show("Подключение к БД не установлено!");
            }
            
            


        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            // Reload the data from the database.
            GetData(dataAdapter.SelectCommand.CommandText);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Update the database with the user's changes.
            // dataAdapter.Update((DataTable)bindingSource1.DataSource);
            SqlCommand cmd;
           if (orderId != -1)
           {

                    using (SqlConnection con = new SqlConnection(MainForm.connectionString))
                    {
                        con.Open();
                        string command = "update Orders set load_name=@load_name, client_name = @client_name,  carrier_name=@carrier_name,  departure_city=@departure_city, destination_city=@destination_city, order_date=@order_date, cost=@cost, order_status=@order_status, load_type=@load_type, carriage_type=@carriage_type, load_weight=@load_weight, load_volume=@load_volume where order_id=@orderId";
                        using (cmd = new SqlCommand(command, con))
                        {
                            cmd.Parameters.AddWithValue("@orderId", orderId);
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

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Успешно!");
                            GetData(dataAdapter.SelectCommand.CommandText);
                        }
                    }
                
            }

        }

        private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                String connectionString = MainForm.connectionString;
                    //"Integrated Security=SSPI;" +
                    //"Initial Catalog= Test ;Data Source=localhost";

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var result  = MessageBox.Show("Вы точно хотите удалить запись?","Удаление",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                string record_id = this.dataGridView1.CurrentRow.Cells["order_id"].Value.ToString();
                string command = "Delete from Orders where order_id= " + record_id;

                SqlDataAdapter dataAdapter2 = new SqlDataAdapter();

                SqlConnection connection = new SqlConnection(MainForm.connectionString);

                try
                {
                    connection.Open();
                    dataAdapter2.DeleteCommand = connection.CreateCommand();
                    dataAdapter2.DeleteCommand.CommandText = command;
                    dataAdapter2.DeleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно удалена!");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                dataAdapter2 = null;
            }

            GetData(dataAdapter.SelectCommand.CommandText);



        }

        private void searchInputBox_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(searchingAtrComboBox.SelectedItem.ToString());
            string searchingAtribute = null;
            switch (searchingAtrComboBox.SelectedItem.ToString())
            {

                case "клиенту":
                    searchingAtribute = "client_name";
                    break;
                case "пункт отправления":
                    searchingAtribute = "departure_city";
                    break;
                case "пункт доставки":
                    searchingAtribute = "destination_city";
                    break;
                case "наименованию груза":
                    searchingAtribute = "load_name";
                    break;
                case "типу груза":
                    searchingAtribute = "load_type";
                    break;
            }
            string command = "select * from Orders where " + searchingAtribute + " Like " + "'%" + searchInputBox.Text + "%'";

            //MessageBox.Show(command);
            if(MainForm.connectionState)
            {
                GetData(command);
            }
            else { MessageBox.Show("Подключение к БД не установлена!"); }
            
        }

        private void searchingAtrComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void showMore()
        {
            ClientBox.Items.Clear();
            CarrierBox.Items.Clear();
            DestinationCityBox.Items.Clear();
            DepartureCityBox.Items.Clear();
            string record_id = this.dataGridView1.CurrentRow.Cells["order_id"].Value.ToString();
            //MessageBox.Show(record_id);

            //Получение списка клиентов
            
            if (record_id != "")
            {
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
                    string company_name = this.dataGridView1.CurrentRow.Cells["client_name"].Value.ToString();
                    ClientBox.SelectedIndex = ClientBox.FindString(company_name);
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
                    string carrier_name = this.dataGridView1.CurrentRow.Cells["carrier_name"].Value.ToString();
                    CarrierBox.SelectedIndex = CarrierBox.FindString(carrier_name);
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
                    string destination_city = this.dataGridView1.CurrentRow.Cells["destination_city"].Value.ToString();
                    DestinationCityBox.SelectedIndex = DestinationCityBox.FindString(destination_city);


                    string departure_city = this.dataGridView1.CurrentRow.Cells["departure_city"].Value.ToString();
                    DepartureCityBox.SelectedIndex = DepartureCityBox.FindString(departure_city);

                    con.Close();
                }

                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string order_status = this.dataGridView1.CurrentRow.Cells["order_status"].Value.ToString();
                statusBox.SelectedIndex = statusBox.FindString(order_status);
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string load_type = this.dataGridView1.CurrentRow.Cells["load_type"].Value.ToString();
                loadTypeBox.SelectedIndex = loadTypeBox.FindString(load_type);
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string carriage_type = this.dataGridView1.CurrentRow.Cells["carriage_type"].Value.ToString();
                carriageTypeBox.SelectedIndex = carriageTypeBox.FindString(carriage_type);
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                loadWeightBox.Text = this.dataGridView1.CurrentRow.Cells["load_weight"].Value.ToString();
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                loadVolumeBox.Text = this.dataGridView1.CurrentRow.Cells["load_volume"].Value.ToString();
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                loadNameBox.Text = this.dataGridView1.CurrentRow.Cells["load_name"].Value.ToString();
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                costBox.Text = this.dataGridView1.CurrentRow.Cells["cost"].Value.ToString();
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                DateTime order_date = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells["order_date"].Value.ToString());
                dateTimePicker1.Value = order_date;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                orderId = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["order_id"].Value.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "MainForm")
                {
                    form.Show();
                    this.Close();
                    break;
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showMore();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            CreateOrderForm createForm = new CreateOrderForm();
            createForm.Show();
            

        }

        private void costBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void costBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void loadVolumeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void OrdersForm_Activated(object sender, EventArgs e)
        {
            if (MainForm.connectionState)
            {
                GetData(dataAdapter.SelectCommand.CommandText);
            }
            
        }
    }
}
