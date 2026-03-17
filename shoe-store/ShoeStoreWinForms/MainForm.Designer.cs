namespace ShoeStoreWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.logo = new System.Windows.Forms.ToolStripButton();
            this.userFioToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.searchToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.searchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.supplierToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.supplierToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.sortToolStrip = new System.Windows.Forms.ToolStrip();
            this.sortIncQuantityButton = new System.Windows.Forms.ToolStripButton();
            this.sortDecQuantityButton = new System.Windows.Forms.ToolStripButton();
            this.bottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.addProductButton = new System.Windows.Forms.ToolStripButton();
            this.deleteProductButton = new System.Windows.Forms.ToolStripButton();
            this.showOrdersButton = new System.Windows.Forms.ToolStripButton();
            this.productCard = new ShoeStoreWinForms.ProductCard();
            this.mainToolStrip.SuspendLayout();
            this.sortToolStrip.SuspendLayout();
            this.bottomToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsListBox
            // 
            this.productsListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.productsListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.ItemHeight = 19;
            this.productsListBox.Location = new System.Drawing.Point(0, 0);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(201, 408);
            this.productsListBox.TabIndex = 0;
            this.productsListBox.SelectedIndexChanged += new System.EventHandler(this.productsListBox_SelectedIndexChanged);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.AutoSize = false;
            this.mainToolStrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logo,
            this.userFioToolStripLabel,
            this.searchToolStripLabel,
            this.searchToolStripTextBox,
            this.toolStripSeparator1,
            this.supplierToolStripLabel,
            this.supplierToolStripComboBox});
            this.mainToolStrip.Location = new System.Drawing.Point(201, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(897, 45);
            this.mainToolStrip.TabIndex = 2;
            // 
            // logo
            // 
            this.logo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logo.AutoSize = false;
            this.logo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(42, 42);
            // 
            // userFioToolStripLabel
            // 
            this.userFioToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.userFioToolStripLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userFioToolStripLabel.Name = "userFioToolStripLabel";
            this.userFioToolStripLabel.Size = new System.Drawing.Size(54, 42);
            this.userFioToolStripLabel.Text = "userFio";
            // 
            // searchToolStripLabel
            // 
            this.searchToolStripLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchToolStripLabel.Name = "searchToolStripLabel";
            this.searchToolStripLabel.Size = new System.Drawing.Size(54, 42);
            this.searchToolStripLabel.Text = "Поиск:";
            // 
            // searchToolStripTextBox
            // 
            this.searchToolStripTextBox.AutoSize = false;
            this.searchToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchToolStripTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchToolStripTextBox.Name = "searchToolStripTextBox";
            this.searchToolStripTextBox.Size = new System.Drawing.Size(150, 26);
            this.searchToolStripTextBox.TextChanged += new System.EventHandler(this.SearchOrFilterProducts);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(20, 30);
            // 
            // supplierToolStripLabel
            // 
            this.supplierToolStripLabel.Name = "supplierToolStripLabel";
            this.supplierToolStripLabel.Size = new System.Drawing.Size(87, 42);
            this.supplierToolStripLabel.Text = "Поставщик:";
            // 
            // supplierToolStripComboBox
            // 
            this.supplierToolStripComboBox.AutoSize = false;
            this.supplierToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.supplierToolStripComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplierToolStripComboBox.Name = "supplierToolStripComboBox";
            this.supplierToolStripComboBox.Size = new System.Drawing.Size(175, 27);
            this.supplierToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchOrFilterProducts);
            // 
            // sortToolStrip
            // 
            this.sortToolStrip.AutoSize = false;
            this.sortToolStrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.sortToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortIncQuantityButton,
            this.sortDecQuantityButton});
            this.sortToolStrip.Location = new System.Drawing.Point(201, 45);
            this.sortToolStrip.Name = "sortToolStrip";
            this.sortToolStrip.Size = new System.Drawing.Size(897, 45);
            this.sortToolStrip.TabIndex = 3;
            // 
            // sortIncQuantityButton
            // 
            this.sortIncQuantityButton.AutoToolTip = false;
            this.sortIncQuantityButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.sortIncQuantityButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sortIncQuantityButton.Image = ((System.Drawing.Image)(resources.GetObject("sortIncQuantityButton.Image")));
            this.sortIncQuantityButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortIncQuantityButton.Name = "sortIncQuantityButton";
            this.sortIncQuantityButton.Size = new System.Drawing.Size(361, 42);
            this.sortIncQuantityButton.Text = "Сортировать по возрастанию количества на складе";
            this.sortIncQuantityButton.Click += new System.EventHandler(this.sortIncQuantityButton_Click);
            // 
            // sortDecQuantityButton
            // 
            this.sortDecQuantityButton.AutoToolTip = false;
            this.sortDecQuantityButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.sortDecQuantityButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sortDecQuantityButton.Image = ((System.Drawing.Image)(resources.GetObject("sortDecQuantityButton.Image")));
            this.sortDecQuantityButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortDecQuantityButton.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.sortDecQuantityButton.Name = "sortDecQuantityButton";
            this.sortDecQuantityButton.Size = new System.Drawing.Size(344, 42);
            this.sortDecQuantityButton.Text = "Сортировать по убыванию количества на складе";
            this.sortDecQuantityButton.Click += new System.EventHandler(this.sortDecQuantityButton_Click);
            // 
            // bottomToolStrip
            // 
            this.bottomToolStrip.AutoSize = false;
            this.bottomToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomToolStrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bottomToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.bottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductButton,
            this.deleteProductButton,
            this.showOrdersButton});
            this.bottomToolStrip.Location = new System.Drawing.Point(201, 367);
            this.bottomToolStrip.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bottomToolStrip.Name = "bottomToolStrip";
            this.bottomToolStrip.Size = new System.Drawing.Size(897, 41);
            this.bottomToolStrip.TabIndex = 4;
            // 
            // addProductButton
            // 
            this.addProductButton.AutoToolTip = false;
            this.addProductButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.addProductButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addProductButton.Image = ((System.Drawing.Image)(resources.GetObject("addProductButton.Image")));
            this.addProductButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addProductButton.Margin = new System.Windows.Forms.Padding(0, 1, 0, 4);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(120, 36);
            this.addProductButton.Text = "Добавить товар";
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.AutoToolTip = false;
            this.deleteProductButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.deleteProductButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteProductButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteProductButton.Image")));
            this.deleteProductButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteProductButton.Margin = new System.Windows.Forms.Padding(4, 1, 0, 4);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(110, 36);
            this.deleteProductButton.Text = "Удалить товар";
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // showOrdersButton
            // 
            this.showOrdersButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.showOrdersButton.AutoToolTip = false;
            this.showOrdersButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.showOrdersButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showOrdersButton.Image = ((System.Drawing.Image)(resources.GetObject("showOrdersButton.Image")));
            this.showOrdersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showOrdersButton.Margin = new System.Windows.Forms.Padding(0, 1, 2, 4);
            this.showOrdersButton.Name = "showOrdersButton";
            this.showOrdersButton.Size = new System.Drawing.Size(126, 36);
            this.showOrdersButton.Text = "Смотреть заказы";
            this.showOrdersButton.Click += new System.EventHandler(this.showOrdersButton_Click);
            // 
            // productCard
            // 
            this.productCard.BackColor = System.Drawing.Color.Chartreuse;
            this.productCard.Location = new System.Drawing.Point(210, 93);
            this.productCard.Name = "productCard";
            this.productCard.Size = new System.Drawing.Size(885, 270);
            this.productCard.TabIndex = 5;
            this.productCard.DoubleClick += new System.EventHandler(this.productCard_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 408);
            this.Controls.Add(this.productCard);
            this.Controls.Add(this.bottomToolStrip);
            this.Controls.Add(this.sortToolStrip);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.productsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Товары - ООО «Обувь»";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.sortToolStrip.ResumeLayout(false);
            this.sortToolStrip.PerformLayout();
            this.bottomToolStrip.ResumeLayout(false);
            this.bottomToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox productsListBox;
        private System.Windows.Forms.ToolStripLabel userFioToolStripLabel;
        private System.Windows.Forms.ToolStripLabel searchToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox searchToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel supplierToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox supplierToolStripComboBox;
        private System.Windows.Forms.ToolStrip sortToolStrip;
        private System.Windows.Forms.ToolStripButton sortDecQuantityButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton sortIncQuantityButton;
        private System.Windows.Forms.ToolStrip bottomToolStrip;
        private System.Windows.Forms.ToolStripButton showOrdersButton;
        private System.Windows.Forms.ToolStripButton addProductButton;
        private System.Windows.Forms.ToolStripButton deleteProductButton;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton logo;
        private ProductCard productCard;
    }
}

