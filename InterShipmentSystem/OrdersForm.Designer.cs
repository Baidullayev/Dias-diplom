namespace InterShipmentSystem
{
    partial class OrdersForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reloadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchingAtrComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(6, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(957, 181);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(208, 565);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(75, 23);
            this.reloadButton.TabIndex = 1;
            this.reloadButton.Text = "Обновить";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(317, 565);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(417, 565);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(154, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchInputBox
            // 
            this.searchInputBox.Location = new System.Drawing.Point(60, 19);
            this.searchInputBox.Name = "searchInputBox";
            this.searchInputBox.Size = new System.Drawing.Size(197, 22);
            this.searchInputBox.TabIndex = 4;
            this.searchInputBox.TextChanged += new System.EventHandler(this.searchInputBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(277, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "по";
            // 
            // searchingAtrComboBox
            // 
            this.searchingAtrComboBox.FormattingEnabled = true;
            this.searchingAtrComboBox.Items.AddRange(new object[] {
            "клиенту",
            "пункт отправления",
            "пункт доставки",
            "наименованию груза",
            "типу груза"});
            this.searchingAtrComboBox.Location = new System.Drawing.Point(302, 17);
            this.searchingAtrComboBox.Name = "searchingAtrComboBox";
            this.searchingAtrComboBox.Size = new System.Drawing.Size(145, 24);
            this.searchingAtrComboBox.TabIndex = 7;
            this.searchingAtrComboBox.SelectedIndexChanged += new System.EventHandler(this.searchingAtrComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.searchingAtrComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.searchInputBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 249);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список";
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(12, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(963, 257);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Станция доставки";
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Активный",
            "Доставлен",
            "Отменен"});
            this.statusBox.Location = new System.Drawing.Point(700, 22);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(208, 21);
            this.statusBox.TabIndex = 27;
            // 
            // loadVolumeBox
            // 
            this.loadVolumeBox.Location = new System.Drawing.Point(700, 155);
            this.loadVolumeBox.Name = "loadVolumeBox";
            this.loadVolumeBox.Size = new System.Drawing.Size(208, 20);
            this.loadVolumeBox.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(623, 159);
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
            this.DestinationCityBox.TabIndex = 24;
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
            this.DepartureCityBox.TabIndex = 22;
            // 
            // CarrierBox
            // 
            this.CarrierBox.FormattingEnabled = true;
            this.CarrierBox.Location = new System.Drawing.Point(164, 79);
            this.CarrierBox.Name = "CarrierBox";
            this.CarrierBox.Size = new System.Drawing.Size(244, 21);
            this.CarrierBox.TabIndex = 21;
            // 
            // ClientBox
            // 
            this.ClientBox.FormattingEnabled = true;
            this.ClientBox.Location = new System.Drawing.Point(164, 49);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(244, 21);
            this.ClientBox.TabIndex = 20;
            // 
            // loadWeightBox
            // 
            this.loadWeightBox.Location = new System.Drawing.Point(700, 121);
            this.loadWeightBox.Name = "loadWeightBox";
            this.loadWeightBox.Size = new System.Drawing.Size(208, 20);
            this.loadWeightBox.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(623, 121);
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
            this.carriageTypeBox.Location = new System.Drawing.Point(700, 83);
            this.carriageTypeBox.Name = "carriageTypeBox";
            this.carriageTypeBox.Size = new System.Drawing.Size(208, 21);
            this.carriageTypeBox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(630, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Род вагона";
            // 
            // loadTypeBox
            // 
            this.loadTypeBox.FormattingEnabled = true;
            this.loadTypeBox.Items.AddRange(new object[] {
            "универсальный;",
            "навалочный",
            "наливный",
            "специальный",
            "другой"});
            this.loadTypeBox.Location = new System.Drawing.Point(700, 53);
            this.loadTypeBox.Name = "loadTypeBox";
            this.loadTypeBox.Size = new System.Drawing.Size(208, 21);
            this.loadTypeBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(637, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Тип груза";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(647, 25);
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
            this.costBox.Size = new System.Drawing.Size(244, 20);
            this.costBox.TabIndex = 10;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.reloadButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrdersForm";
            this.Text = "Окно управления заявками";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox searchInputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchingAtrComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}