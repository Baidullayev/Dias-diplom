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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            serversBox.Items.Add(MainForm.serverName);

            DataTable table = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow server in table.Rows)
            {
                serversBox.Items.Add(server[table.Columns["ServerName"]].ToString());
            }
            instanceBox.Text = MainForm.instanceName;
            dbNameBox.Text = MainForm.dbName;
            loginBox.Text = MainForm.loginSql;
            passwordBox.Text = MainForm.passwordSql;
            serversBox.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MainForm.serverName = serversBox.Text;
            MainForm.instanceName = instanceBox.Text;
            MainForm.dbName = dbNameBox.Text;
            MainForm.loginSql = loginBox.Text;
            MainForm.passwordSql = passwordBox.Text;

            try
            {
                MainForm.myIni.Write("serverName", MainForm.serverName, "SqlServer connection parameters");
                MainForm.myIni.Write("instanceName", MainForm.instanceName, "SqlServer connection parameters");
                MainForm.myIni.Write("dbName", MainForm.dbName, "SqlServer connection parameters");
                MainForm.myIni.Write("login", MainForm.loginSql, "SqlServer connection parameters");
                MainForm.myIni.Write("password", MainForm.passwordSql, "SqlServer connection parameters");
                MainForm.connectionString = "server=" + MainForm.serverName + "\\" + MainForm.instanceName + ";database=" + MainForm.dbName + ";UID=" + MainForm.loginSql + ";password=" + MainForm.passwordSql;
                MessageBox.Show("Параметры успешно сохранены!");
                bool test = testConnection(needFeedback: false);
                if (test)
                {
                    MainForm.connectionState = true;
                }
                else MainForm.connectionState = false;
                this.Close();

            }
            catch (Exception es)
            {
                MessageBox.Show("Ошибка при сохранении параметров! " + es.Message);
            }
        }
        public bool testConnection(bool needFeedback = true)// фукнция проверки подключения к серверу БД
        {
            try
            {
                String str = "server=" + serversBox.Text + "\\" + instanceBox.Text + ";database=" + dbNameBox.Text + ";UID=" + loginBox.Text + ";password=" + passwordBox.Text;
                SqlConnection con = new SqlConnection(str);
                con.Open();
                if (needFeedback)
                { MessageBox.Show("Успешно!"); }
                con.Close();
                return true;
            }
            catch (Exception es)
            {
                if (needFeedback)
                { MessageBox.Show(es.Message); }
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool test = testConnection();
        }
    }
}
