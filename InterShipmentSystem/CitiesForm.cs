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
    public partial class CitiesForm : Form
    {
        int city_id = -1;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public CitiesForm()
        {
            InitializeComponent();
        }

        private void searchInputBox_TextChanged(object sender, EventArgs e)
        {
            string command = "select * from Cities where city_name Like " + "'%" + searchInputBox.Text + "%'";
            GetData(command);
        }

        private void CitiesForm_Load(object sender, EventArgs e)
        {
            if (MainForm.connectionState)
            {
                dataGridView1.DataSource = bindingSource1;
                GetData("select * from Cities");
                dataGridView1.Columns[0].HeaderText = "ID города";
                dataGridView1.Columns[1].HeaderText = "Наименование станции";                
                dataGridView1.Columns[2].HeaderText = "Почтовый индекс";

                //dataGridView1.Columns[0].Width = 30;
                //dataGridView1.Columns[1].Width = 100;
                //dataGridView1.Columns[2].Width = 30;
            }
            else
            {
                MessageBox.Show("Подключние к БД не было установлено");

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
                DataGridViewAutoSizeColumnsMode.ColumnHeader);


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void showMore()
        {
            cityNameBox.Text = this.dataGridView1.CurrentRow.Cells["city_name"].Value.ToString();
            postIndexBox.Text = this.dataGridView1.CurrentRow.Cells["post_index"].Value.ToString();
            city_id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["city_id"].Value.ToString());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showMore();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            if (city_id != -1)
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

                    string command = "update Cities set city_name=@city_name, post_index=@post_index where city_id=@city_id";
                    using (cmd = new SqlCommand(command, con))
                    {
                        cmd.Parameters.AddWithValue("@city_id", city_id);
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
                        GetData(dataAdapter.SelectCommand.CommandText);

                    }
                }

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes && city_id != -1)
            {
                string record_id = this.dataGridView1.CurrentRow.Cells["city_id"].Value.ToString();
                string command = "Delete from Cities where city_id= " + record_id;

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

        private void CitiesForm_Activated(object sender, EventArgs e)
        {
            if(MainForm.connectionState)
            {
                GetData(dataAdapter.SelectCommand.CommandText);
            }

            
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            NewCityForm newCityForm = new NewCityForm();
            newCityForm.Show();
        }
    }
}
