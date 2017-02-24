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
    public partial class CarriersForm : Form
    {
        int carrier_id = -1;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public CarriersForm()
        {
            InitializeComponent();
        }

        private void CarriersForm_Load(object sender, EventArgs e)
        {
            if (MainForm.connectionState)
            {
                dataGridView1.DataSource = bindingSource1;
                GetData("select * from Carriers");
                dataGridView1.Columns[0].HeaderText = "ID организации";
                dataGridView1.Columns[1].HeaderText = "Наименование организации";
                dataGridView1.Columns[2].HeaderText = "Телефон номер";
                dataGridView1.Columns[3].HeaderText = "Электронная почта";
            }
        }

        private void GetData(string selectCommand)
        {
            try
            {
                String connectionString = MainForm.connectionString;
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchInputBox_TextChanged(object sender, EventArgs e)
        {
            string command = "select * from Carriers where carrier_name Like " + "'%" + searchInputBox.Text + "%'";
            GetData(command);
        }
        private void showMore()
        {
            companyNameBox.Text = this.dataGridView1.CurrentRow.Cells["carrier_name"].Value.ToString();
            mailBox.Text = this.dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            phoneNumberBox.Text = this.dataGridView1.CurrentRow.Cells["phone_number"].Value.ToString();
            carrier_id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["carrier_id"].Value.ToString());

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showMore();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            if (carrier_id != -1)
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

                    string command = "update Carriers set carrier_name=@carrier_name, phone_number=@phone_number, email=@email where carrier_id=@carrier_id";
                    using (cmd = new SqlCommand(command, con))
                    {
                        cmd.Parameters.AddWithValue("@carrier_id", carrier_id);
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
                        GetData(dataAdapter.SelectCommand.CommandText);

                    }
                }

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes && carrier_id!=-1)
            {
                string record_id = this.dataGridView1.CurrentRow.Cells["carrier_id"].Value.ToString();
                string command = "Delete from Carriers where carrier_id= " + record_id;

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

        private void createButton_Click(object sender, EventArgs e)
        {
            NewCarrierForm newCarrierForm = new NewCarrierForm();
            newCarrierForm.Show();
        }

        private void CarriersForm_Activated(object sender, EventArgs e)
        {
            GetData(dataAdapter.SelectCommand.CommandText);
        }
    }
}
