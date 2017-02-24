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
    public partial class ClientsForm : Form
    {
        int client_id = -1;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public ClientsForm()
        {
            InitializeComponent();
        }
        private void ClientsForm_Load(object sender, EventArgs e)
        {
            searchingAtrComboBox.SelectedIndex = 0;

            if (MainForm.connectionState)
            {
                dataGridView1.DataSource = bindingSource1;
                GetData("select * from Clients");
                dataGridView1.Columns[0].HeaderText = "ID клиента";
                dataGridView1.Columns[1].HeaderText = "Наименование организации";
                dataGridView1.Columns[2].HeaderText = "Ф.И.О. контактного лица";
                dataGridView1.Columns[3].HeaderText = "Телефон номер";
                dataGridView1.Columns[4].HeaderText = "Электронная почта";
                dataGridView1.Columns[5].HeaderText = "Адрес";
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void searchInputBox_TextChanged(object sender, EventArgs e)
        {
            string searchingAtribute = null;
            switch (searchingAtrComboBox.SelectedItem.ToString())
            {

                case "наименованию компаний":
                    searchingAtribute = "company_name";
                    break;
                case "Ф.И.О контактного лица":
                    searchingAtribute = "contact_person";
                    break;
            }
            string command = "select * from Clients where " + searchingAtribute + " Like " + "'%" + searchInputBox.Text + "%'";

            //MessageBox.Show(command);
            GetData(command);
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

        private void showMore()
        {
            companyNameBox.Text = this.dataGridView1.CurrentRow.Cells["company_name"].Value.ToString();
            contactPersonBox.Text = this.dataGridView1.CurrentRow.Cells["contact_person"].Value.ToString();
            phoneNumberBox.Text = this.dataGridView1.CurrentRow.Cells["phone_number"].Value.ToString();
            mailBox.Text = this.dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            addressBox.Text = this.dataGridView1.CurrentRow.Cells["company_address"].Value.ToString();
            client_id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["client_id"].Value.ToString());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showMore();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes && client_id!=-1)
            {
                string record_id = this.dataGridView1.CurrentRow.Cells["client_id"].Value.ToString();
                string command = "Delete from Clients where client_id= " + record_id;

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

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            if (client_id != -1)
            {

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
                   
                    string command = "update Clients set company_name=@company_name, contact_person=@contact_person, phone_number=@phone_number, email=@email, company_address=@company_address where client_id=@client_id";
                    using (cmd = new SqlCommand(command, con))
                    {
                        cmd.Parameters.AddWithValue("@client_id", client_id);
                        cmd.Parameters.AddWithValue("@company_name", companyNameBox.Text);
                        cmd.Parameters.AddWithValue("@contact_person", contactPersonBox.Text);
                        cmd.Parameters.AddWithValue("@phone_number", phoneNumberBox.Text);
                        cmd.Parameters.AddWithValue("@email", mailBox.Text);
                        cmd.Parameters.AddWithValue("@company_address", addressBox.Text);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                     
                        
                        MessageBox.Show("Успешно!");
                        GetData(dataAdapter.SelectCommand.CommandText);
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Form form in Application.OpenForms)
            {
                if(form.Name == "MainForm")
                {
                    form.Show();
                    this.Close();
                    break;
                }
            }

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            NewClientForm newClientForm = new NewClientForm();       
            newClientForm.Show();
        }

        private void ClientsForm_Activated(object sender, EventArgs e)
        {
            GetData(dataAdapter.SelectCommand.CommandText);
        }
    }
}
