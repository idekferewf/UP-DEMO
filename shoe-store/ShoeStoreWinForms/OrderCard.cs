using ShoeStoreLib;
using System.Windows.Forms;

namespace ShoeStoreWinForms
{
    public partial class OrderCard : UserControl
    {
        private Order order_;
        private string address_;

        public OrderCard()
        {
            InitializeComponent();
        }

        public void ShowOrderInfo(Order order, string address)
        {
            order_ = order;
            address_ = address;

            addressLabel.Text = address;
            deliveryDateLabel.Text = order.DeliveryDate.Date.ToString("dd.MM.yyyy");
            idLabel.Text = order.Id.ToString();
            orderDateLabel.Text = order.OrderDate.ToShortDateString();
            statusLabel.Text = order.Status;
        }
    }
}
