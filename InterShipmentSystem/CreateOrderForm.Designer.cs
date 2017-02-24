namespace InterShipmentSystem
{
    partial class CreateOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrderForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.loadVolumeBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DestinationCityBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DepartureCityBox = new System.Windows.Forms.ComboBox();
            this.CarrierBox = new System.Windows.Forms.ComboBox();
            this.ClientBox = new System.Windows.Forms.ComboBox();
            this.loadWeightBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.carriageTypeBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.loadTypeBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.costBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loadNameBox = new System.Windows.Forms.TextBox();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addCleintButton = new System.Windows.Forms.Button();
            this.addCarrierButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.statusBox);
            this.groupBox2.Controls.Add(this.loadVolumeBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.DestinationCityBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.DepartureCityBox);
            this.groupBox2.Controls.Add(this.CarrierBox);
            this.groupBox2.Controls.Add(this.ClientBox);
            this.groupBox2.Controls.Add(this.loadWeightBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.carriageTypeBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.loadTypeBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.costBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.loadNameBox);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 413);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Форма заполнения заявки";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(387, 218);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "тг";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(383, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "м3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(386, 343);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "кг";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Активный",
            "Доставлен",
            "Отменен"});
            this.statusBox.Location = new System.Drawing.Point(164, 241);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(217, 21);
            this.statusBox.TabIndex = 7;
            // 
            // loadVolumeBox
            // 
            this.loadVolumeBox.Location = new System.Drawing.Point(164, 374);
            this.loadVolumeBox.Name = "loadVolumeBox";
            this.loadVolumeBox.Size = new System.Drawing.Size(217, 20);
            this.loadVolumeBox.TabIndex = 11;
            this.loadVolumeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loadVolumeBox_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(87, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Объем груза";
            // 
            // DestinationCityBox
            // 
            this.DestinationCityBox.FormattingEnabled = true;
            this.DestinationCityBox.Location = new System.Drawing.Point(164, 147);
            this.DestinationCityBox.Name = "DestinationCityBox";
            this.DestinationCityBox.Size = new System.Drawing.Size(244, 21);
            this.DestinationCityBox.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(55, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Станция доставки";
            // 
            // DepartureCityBox
            // 
            this.DepartureCityBox.FormattingEnabled = true;
            this.DepartureCityBox.Location = new System.Drawing.Point(164, 111);
            this.DepartureCityBox.Name = "DepartureCityBox";
            this.DepartureCityBox.Size = new System.Drawing.Size(244, 21);
            this.DepartureCityBox.TabIndex = 3;
            // 
            // CarrierBox
            // 
            this.CarrierBox.FormattingEnabled = true;
            this.CarrierBox.Location = new System.Drawing.Point(164, 79);
            this.CarrierBox.Name = "CarrierBox";
            this.CarrierBox.Size = new System.Drawing.Size(244, 21);
            this.CarrierBox.TabIndex = 2;
            // 
            // ClientBox
            // 
            this.ClientBox.FormattingEnabled = true;
            this.ClientBox.Location = new System.Drawing.Point(164, 49);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(244, 21);
            this.ClientBox.TabIndex = 1;
            // 
            // loadWeightBox
            // 
            this.loadWeightBox.Location = new System.Drawing.Point(164, 340);
            this.loadWeightBox.Name = "loadWeightBox";
            this.loadWeightBox.Size = new System.Drawing.Size(217, 20);
            this.loadWeightBox.TabIndex = 10;
            this.loadWeightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loadWeightBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(87, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Масса груза";
            // 
            // carriageTypeBox
            // 
            this.carriageTypeBox.FormattingEnabled = true;
            this.carriageTypeBox.Items.AddRange(new object[] {
            "Крытый",
            "Полувагон",
            "Хоппер",
            "Платформа",
            "Вагон-цистерна",
            "бункерный вагон",
            "Думпкар",
            "Вагон Рефрижиратор"});
            this.carriageTypeBox.Location = new System.Drawing.Point(164, 302);
            this.carriageTypeBox.Name = "carriageTypeBox";
            this.carriageTypeBox.Size = new System.Drawing.Size(217, 21);
            this.carriageTypeBox.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(94, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Род вагона";
            // 
            // loadTypeBox
            // 
            this.loadTypeBox.FormattingEnabled = true;
            this.loadTypeBox.Items.AddRange(new object[] {
            "универсальный",
            "навалочный",
            "наливный",
            "специальный",
            "другой"});
            this.loadTypeBox.Location = new System.Drawing.Point(164, 272);
            this.loadTypeBox.Name = "loadTypeBox";
            this.loadTypeBox.Size = new System.Drawing.Size(217, 21);
            this.loadTypeBox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(101, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Тип груза";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(111, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Статус";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(92, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Стоимость";
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(164, 215);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(217, 20);
            this.costBox.TabIndex = 6;
            this.costBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(71, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Дата отправки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Станция отправления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(82, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Перевозщик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(111, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Клиент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Наименование груза";
            // 
            // loadNameBox
            // 
            this.loadNameBox.Location = new System.Drawing.Point(164, 19);
            this.loadNameBox.Name = "loadNameBox";
            this.loadNameBox.Size = new System.Drawing.Size(244, 20);
            this.loadNameBox.TabIndex = 0;
            // 
            // createOrderButton
            // 
            this.createOrderButton.Location = new System.Drawing.Point(12, 485);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(446, 36);
            this.createOrderButton.TabIndex = 12;
            this.createOrderButton.Text = "Сохранить новую запись";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(327, 456);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(131, 23);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addCleintButton
            // 
            this.addCleintButton.Location = new System.Drawing.Point(12, 456);
            this.addCleintButton.Name = "addCleintButton";
            this.addCleintButton.Size = new System.Drawing.Size(149, 23);
            this.addCleintButton.TabIndex = 13;
            this.addCleintButton.Text = "Добавить клиента";
            this.addCleintButton.UseVisualStyleBackColor = true;
            this.addCleintButton.Click += new System.EventHandler(this.addCleintButton_Click);
            // 
            // addCarrierButton
            // 
            this.addCarrierButton.Location = new System.Drawing.Point(167, 456);
            this.addCarrierButton.Name = "addCarrierButton";
            this.addCarrierButton.Size = new System.Drawing.Size(154, 23);
            this.addCarrierButton.TabIndex = 14;
            this.addCarrierButton.Text = "Добавить перевозщика";
            this.addCarrierButton.UseVisualStyleBackColor = true;
            this.addCarrierButton.Click += new System.EventHandler(this.addCarrierButton_Click);
            // 
            // CreateOrderForm
            // 
            this.AcceptButton = this.createOrderButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 533);
            this.Controls.Add(this.addCarrierButton);
            this.Controls.Add(this.addCleintButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.CreateOrderForm_Activated);
            this.Load += new System.EventHandler(this.CreateOrderForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.TextBox loadVolumeBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox DestinationCityBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox DepartureCityBox;
        private System.Windows.Forms.ComboBox CarrierBox;
        private System.Windows.Forms.ComboBox ClientBox;
        private System.Windows.Forms.TextBox loadWeightBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox carriageTypeBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox loadTypeBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loadNameBox;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addCleintButton;
        private System.Windows.Forms.Button addCarrierButton;
    }
}