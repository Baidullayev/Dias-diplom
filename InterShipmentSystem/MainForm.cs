using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }
    }
}
