namespace InterShipmentSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InfoBox = new System.Windows.Forms.PictureBox();
            this.ConfigBox = new System.Windows.Forms.PictureBox();
            this.CityBox = new System.Windows.Forms.PictureBox();
            this.DeliverBox = new System.Windows.Forms.PictureBox();
            this.ClientBox = new System.Windows.Forms.PictureBox();
            this.OrderBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliverBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(173, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Заявки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(355, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Клиенты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(529, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Перевозщики";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(546, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Инфо";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(355, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Настройки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(173, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Города";
            // 
            // InfoBox
            // 
            this.InfoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoBox.Image = global::InterShipmentSystem.Properties.Resources.штащ;
            this.InfoBox.Location = new System.Drawing.Point(485, 269);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(180, 125);
            this.InfoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoBox.TabIndex = 5;
            this.InfoBox.TabStop = false;
            this.InfoBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoBox_MouseMove);
            // 
            // ConfigBox
            // 
            this.ConfigBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfigBox.Image = global::InterShipmentSystem.Properties.Resources.pcicon_2_edited;
            this.ConfigBox.Location = new System.Drawing.Point(299, 269);
            this.ConfigBox.Name = "ConfigBox";
            this.ConfigBox.Size = new System.Drawing.Size(180, 125);
            this.ConfigBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ConfigBox.TabIndex = 4;
            this.ConfigBox.TabStop = false;
            this.ConfigBox.Click += new System.EventHandler(this.ConfigBox_Click);
            this.ConfigBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConfigBox_MouseMove);
            // 
            // CityBox
            // 
            this.CityBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CityBox.Image = global::InterShipmentSystem.Properties.Resources.smart_city;
            this.CityBox.Location = new System.Drawing.Point(113, 269);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(180, 125);
            this.CityBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CityBox.TabIndex = 3;
            this.CityBox.TabStop = false;
            this.CityBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CityBox_MouseMove);
            // 
            // DeliverBox
            // 
            this.DeliverBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeliverBox.Image = global::InterShipmentSystem.Properties.Resources.images__1_1;
            this.DeliverBox.Location = new System.Drawing.Point(485, 105);
            this.DeliverBox.Name = "DeliverBox";
            this.DeliverBox.Size = new System.Drawing.Size(180, 125);
            this.DeliverBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeliverBox.TabIndex = 2;
            this.DeliverBox.TabStop = false;
            this.DeliverBox.Click += new System.EventHandler(this.DeliverBox_Click);
            this.DeliverBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeliverBox_MouseMove);
            // 
            // ClientBox
            // 
            this.ClientBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientBox.Image = global::InterShipmentSystem.Properties.Resources.client;
            this.ClientBox.Location = new System.Drawing.Point(299, 105);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(180, 125);
            this.ClientBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClientBox.TabIndex = 1;
            this.ClientBox.TabStop = false;
            this.ClientBox.Click += new System.EventHandler(this.ClientBox_Click);
            this.ClientBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientBox_MouseMove);
            // 
            // OrderBox
            // 
            this.OrderBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderBox.Image = global::InterShipmentSystem.Properties.Resources.order_form_online_offer_512;
            this.OrderBox.Location = new System.Drawing.Point(113, 105);
            this.OrderBox.Name = "OrderBox";
            this.OrderBox.Size = new System.Drawing.Size(180, 125);
            this.OrderBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OrderBox.TabIndex = 0;
            this.OrderBox.TabStop = false;
            this.OrderBox.Click += new System.EventHandler(this.OrderBox_Click);
            this.OrderBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OrderBox_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 514);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.ConfigBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.DeliverBox);
            this.Controls.Add(this.ClientBox);
            this.Controls.Add(this.OrderBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автоматизированная система отдела междугородних перевозок";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.InfoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliverBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OrderBox;
        private System.Windows.Forms.PictureBox ClientBox;
        private System.Windows.Forms.PictureBox DeliverBox;
        private System.Windows.Forms.PictureBox InfoBox;
        private System.Windows.Forms.PictureBox ConfigBox;
        private System.Windows.Forms.PictureBox CityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

