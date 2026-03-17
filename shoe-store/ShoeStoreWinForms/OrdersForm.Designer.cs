namespace ShoeStoreWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.ordersListBox = new System.Windows.Forms.ListBox();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.addOrderButton = new System.Windows.Forms.ToolStripButton();
            this.deleteOrderButton = new System.Windows.Forms.ToolStripButton();
            this.orderCard = new ShoeStoreWinForms.OrderCard();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersListBox
            // 
            this.ordersListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ordersListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersListBox.FormattingEnabled = true;
            this.ordersListBox.ItemHeight = 19;
            this.ordersListBox.Location = new System.Drawing.Point(0, 0);
            this.ordersListBox.Name = "ordersListBox";
            this.ordersListBox.Size = new System.Drawing.Size(121, 195);
            this.ordersListBox.TabIndex = 0;
            this.ordersListBox.SelectedIndexChanged += new System.EventHandler(this.ordersListBox_SelectedIndexChanged);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.AutoSize = false;
            this.mainToolStrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrderButton,
            this.deleteOrderButton});
            this.mainToolStrip.Location = new System.Drawing.Point(121, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(503, 50);
            this.mainToolStrip.TabIndex = 4;
            // 
            // addOrderButton
            // 
            this.addOrderButton.AutoSize = false;
            this.addOrderButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.addOrderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addOrderButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("addOrderButton.Image")));
            this.addOrderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addOrderButton.Margin = new System.Windows.Forms.Padding(0);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(140, 35);
            this.addOrderButton.Text = "Добавить заказ";
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.AutoSize = false;
            this.deleteOrderButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.deleteOrderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteOrderButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteOrderButton.Image")));
            this.deleteOrderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteOrderButton.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(140, 35);
            this.deleteOrderButton.Text = "Удалить заказ";
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // orderCard
            // 
            this.orderCard.BackColor = System.Drawing.Color.Chartreuse;
            this.orderCard.Location = new System.Drawing.Point(130, 48);
            this.orderCard.Name = "orderCard";
            this.orderCard.Size = new System.Drawing.Size(488, 141);
            this.orderCard.TabIndex = 5;
            this.orderCard.DoubleClick += new System.EventHandler(this.orderCard_DoubleClick);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 195);
            this.Controls.Add(this.orderCard);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.ordersListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrdersForm";
            this.Text = "Заказы - ООО «Обувь»";
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ordersListBox;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton addOrderButton;
        private System.Windows.Forms.ToolStripButton deleteOrderButton;
        private OrderCard orderCard;
    }
}