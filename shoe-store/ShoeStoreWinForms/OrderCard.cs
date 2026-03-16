using System;
using System.Windows.Forms;
using ShoeStoreLib;

namespace ShoeStoreWinForms
{
    public partial class OrderCard : UserControl
    {
        public OrderCard()
        {
            InitializeComponent();

            addressLabel.DoubleClick += ChildControl_DoubleClick;
            deliveryDateLabel.DoubleClick += ChildControl_DoubleClick;
            idLabel.DoubleClick += ChildControl_DoubleClick;
            orderDateLabel.DoubleClick += ChildControl_DoubleClick;
            statusLabel.DoubleClick += ChildControl_DoubleClick;
        }

        public void ShowOrderInfo(Order order)
        {
            addressLabel.Text = order.PickupLocation.Address;
            deliveryDateLabel.Text = order.DeliveryDate.Date.ToString("dd.MM.yyyy");
            idLabel.Text = order.Id.ToString();
            orderDateLabel.Text = order.OrderDate.ToShortDateString();
            statusLabel.Text = order.Status;
        }

        private void ChildControl_DoubleClick(object sender, EventArgs e)
        {
            OnDoubleClick(e);
        }
    }
}
