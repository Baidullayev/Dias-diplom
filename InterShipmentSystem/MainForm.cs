using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterShipmentSystem
{
    public partial class MainForm : Form
    {
        public static IniFile myIni = new IniFile(Directory.GetCurrentDirectory() + "\\config.ini");
        //объявляем статичные переменные подключения к бд
        public static string serverName;
        public static string instanceName;
        public static string dbName;
        public static string loginSql;
        public static string passwordSql;

        public static string connectionString = null;
        public static bool connectionState = false;

        public MainForm()
        {
            InitializeComponent();
        }
        

        private void OrderBox_MouseMove(object sender, MouseEventArgs e)
        {
            OrderBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ClientBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            DeliverBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            CityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ConfigBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void ClientBox_MouseMove(object sender, MouseEventArgs e)
        {
            ClientBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            OrderBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            DeliverBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            CityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ConfigBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void DeliverBox_MouseMove(object sender, MouseEventArgs e)
        {
            DeliverBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            OrderBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ClientBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            CityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ConfigBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void CityBox_MouseMove(object sender, MouseEventArgs e)
        {
            CityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            OrderBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ClientBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            DeliverBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ConfigBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void ConfigBox_MouseMove(object sender, MouseEventArgs e)
        {
            ConfigBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            OrderBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ClientBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            DeliverBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            CityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void InfoBox_MouseMove(object sender, MouseEventArgs e)
        {
            InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            OrderBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ClientBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            DeliverBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            CityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ConfigBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            OrderBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ClientBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            DeliverBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            CityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ConfigBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            serverName = myIni.Read("serverName", "SqlServer connection parameters");
            instanceName = myIni.Read("instanceName", "SqlServer connection parameters");
            dbName = myIni.Read("dbName", "SqlServer connection parameters");
            loginSql = myIni.Read("login", "SqlServer connection parameters");
            passwordSql = myIni.Read("password", "SqlServer connection parameters");


            // проверка подключения
            if (serverName != "null" || instanceName != "null" || dbName != "null" || loginSql != "null" || passwordSql != "null")
            {
                try
                {
                    String str = "server=" + serverName + "\\" + instanceName + ";database=" + dbName + ";UID=" + loginSql + ";password=" + passwordSql;
                    SqlConnection con = new SqlConnection(str);
                    con.Open();
                    connectionState = true;
                    con.Close();
                    connectionString = str;

                }
                catch (Exception es)
                {
                    connectionState = false;                    
                    //ConnectionStripLabel.Text = "Соединение с БД не установлено";
                    MessageBox.Show(es.Message);

                }
            }

        }

        private void ConfigBox_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void OrderBox_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
        }
    }
}
