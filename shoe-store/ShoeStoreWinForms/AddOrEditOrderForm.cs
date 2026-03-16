using ShoeStoreLib.Services;
using ShoeStoreLib;
using System;
using System.Windows.Forms;

namespace ShoeStoreWinForms
{
    public partial class AddOrEditOrderForm : Form
    {
        private Order order_;
        private OrderService orderService_;
        private PickupLocationService pickupLocationService_;
        private bool isEdit_;

        public AddOrEditOrderForm(OrderService orderService, PickupLocationService pickupLocationService, Order order, bool isEdit)
        {
            orderService_ = orderService;
            pickupLocationService_ = pickupLocationService;
            order_ = order;
            isEdit_ = isEdit;
            InitializeComponent();
        }

        public Order Order => order_;

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void okOrderButton_Click(object sender, EventArgs e)
        {
            if (!isEdit_)
            {
                Order order_ = new Order((int)idTextBox.Value);
            }

            order_.Status = statusComboBox.Text;
            order_.PickupLocation = pickupLocationService_.GetPickupLocation(addressComboBox.Text);
            order_.OrderDate = orderDateTimePicker.Value;
            order_.DeliveryDate = deliveryDateTimePicker.Value;

            DialogResult = DialogResult.OK;
        }

        private void AddOrEditOrderForm_Load(object sender, EventArgs e)
        {
            addressComboBox.DataSource = null;
            addressComboBox.DataSource = pickupLocationService_.GetAllPickupLocations();
            addressComboBox.DisplayMember = "Address";

            if (!isEdit_)
            {
                Text = "Добавление заказа";
                idTextBox.Value = orderService_.GenerateNextId();
                statusComboBox.Text = "Новый";
            }
            else
            {
                Text = "Редактирование заказа";
                idTextBox.Value = order_.Id;
                statusComboBox.Text = order_.Status;
                addressComboBox.Text = order_.PickupLocation.Address;
                orderDateTimePicker.Value = order_.OrderDate;
                deliveryDateTimePicker.Value = order_.DeliveryDate;
            }
        }
    }
}
