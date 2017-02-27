using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterShipmentSystem
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            String infoText = "Данное программное обеспечение является дипломным проектым студента группы ЗСИС-212 КарГУ им. академика Е.Букетова Молдабаева Д.М." 
                + "\n \nТема дипломного проекта - \"ИС для отдела междугородних перевозок\"  "
                + "\n \nПрограмма написана на языке C# в среде разработки Visual studio 2015" 
                + "\n \nИспользуемый СУБД в - MSSQL Server 2016";
            infoLabel.Text = infoText;
        }
    }
}
