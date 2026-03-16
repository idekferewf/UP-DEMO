namespace ShoeStoreWinForms
{
    partial class AddOrEditOrderForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressComboBox = new System.Windows.Forms.ComboBox();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.orderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deliveryDateLabel = new System.Windows.Forms.Label();
            this.deliveryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            this.okOrderButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.idTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(21, 19);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 19);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(21, 64);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(58, 19);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Статус:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Новый",
            "Завершен"});
            this.statusComboBox.Location = new System.Drawing.Point(149, 60);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(350, 27);
            this.statusComboBox.TabIndex = 3;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLabel.Location = new System.Drawing.Point(21, 109);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(86, 19);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Адрес ПВЗ:";
            // 
            // addressComboBox
            // 
            this.addressComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressComboBox.FormattingEnabled = true;
            this.addressComboBox.Location = new System.Drawing.Point(149, 105);
            this.addressComboBox.Name = "addressComboBox";
            this.addressComboBox.Size = new System.Drawing.Size(350, 27);
            this.addressComboBox.TabIndex = 5;
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderDateLabel.Location = new System.Drawing.Point(21, 158);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(88, 19);
            this.orderDateLabel.TabIndex = 6;
            this.orderDateLabel.Text = "Дата заказа:";
            // 
            // orderDateTimePicker
            // 
            this.orderDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDateTimePicker.Location = new System.Drawing.Point(149, 155);
            this.orderDateTimePicker.Name = "orderDateTimePicker";
            this.orderDateTimePicker.Size = new System.Drawing.Size(350, 26);
            this.orderDateTimePicker.TabIndex = 7;
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.AutoSize = true;
            this.deliveryDateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deliveryDateLabel.Location = new System.Drawing.Point(21, 202);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(98, 19);
            this.deliveryDateLabel.TabIndex = 8;
            this.deliveryDateLabel.Text = "Дата выдачи:";
            // 
            // deliveryDateTimePicker
            // 
            this.deliveryDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deliveryDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deliveryDateTimePicker.Location = new System.Drawing.Point(149, 199);
            this.deliveryDateTimePicker.Name = "deliveryDateTimePicker";
            this.deliveryDateTimePicker.Size = new System.Drawing.Size(350, 26);
            this.deliveryDateTimePicker.TabIndex = 9;
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.cancelOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelOrderButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelOrderButton.Location = new System.Drawing.Point(313, 256);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(90, 36);
            this.cancelOrderButton.TabIndex = 10;
            this.cancelOrderButton.Text = "Отмена";
            this.cancelOrderButton.UseVisualStyleBackColor = false;
            this.cancelOrderButton.Click += new System.EventHandler(this.cancelOrderButton_Click);
            // 
            // okOrderButton
            // 
            this.okOrderButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.okOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okOrderButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okOrderButton.Location = new System.Drawing.Point(409, 256);
            this.okOrderButton.Name = "okOrderButton";
            this.okOrderButton.Size = new System.Drawing.Size(90, 36);
            this.okOrderButton.TabIndex = 11;
            this.okOrderButton.Text = "ОК";
            this.okOrderButton.UseVisualStyleBackColor = false;
            this.okOrderButton.Click += new System.EventHandler(this.okOrderButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.Location = new System.Drawing.Point(149, 16);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(350, 26);
            this.idTextBox.TabIndex = 12;
            // 
            // AddOrEditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 317);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.okOrderButton);
            this.Controls.Add(this.cancelOrderButton);
            this.Controls.Add(this.deliveryDateTimePicker);
            this.Controls.Add(this.deliveryDateLabel);
            this.Controls.Add(this.orderDateTimePicker);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.addressComboBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "AddOrEditOrderForm";
            this.Load += new System.EventHandler(this.AddOrEditOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.ComboBox addressComboBox;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.DateTimePicker orderDateTimePicker;
        private System.Windows.Forms.Label deliveryDateLabel;
        private System.Windows.Forms.DateTimePicker deliveryDateTimePicker;
        private System.Windows.Forms.Button cancelOrderButton;
        private System.Windows.Forms.Button okOrderButton;
        private System.Windows.Forms.NumericUpDown idTextBox;
    }
}