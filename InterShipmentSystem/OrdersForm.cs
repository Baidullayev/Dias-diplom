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
//using Excel = Microsoft.Office.Interop.Excel;

namespace InterShipmentSystem
{
    public partial class OrdersForm : Form
    {

        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            searchingAtrComboBox.SelectedIndex = 0;
            if (MainForm.connectionState)
            {
                dataGridView1.DataSource = bindingSource1;
                GetData("select * from Orders");
               // dataGridView1.Columns[0].HeaderText = "First Column";

                //string sqlCommand = "SELECT * FROM Clients";
                //SqlConnection connection = new SqlConnection(MainForm.connectionString);
                //SqlDataAdapter dataadapter = new SqlDataAdapter(sqlCommand, connection);
                //DataSet ds = new DataSet();
                //connection.Open();
                //dataadapter.Fill(ds, "Clients_table");
                //connection.Close();
                //dataGridView1.DataSource = ds;
                //dataGridView1.DataMember = "Clients_table";
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
            dataAdapter.Update((DataTable)bindingSource1.DataSource);
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
                string record_id = this.dataGridView1.CurrentRow.Cells["client_id"].Value.ToString();
                string command = "Delete from Clients where client_id = " + record_id;

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
            MessageBox.Show(command);
            GetData(command);
        }

        private void searchingAtrComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
