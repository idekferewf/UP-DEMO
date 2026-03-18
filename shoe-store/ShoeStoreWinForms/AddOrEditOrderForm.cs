using ShoeStoreLib.Services;
using ShoeStoreLib;
using System;
using System.Windows.Forms;
using ShoeStoreLib.Models;

namespace ShoeStoreWinForms
{
    public partial class AddOrEditOrderForm : Form
    {
        private OrderService orderService_;
        private PickupLocationService pickupLocationService_;
        private UserService userService_;
        private Order order_;
        private bool isEdit_;

        public AddOrEditOrderForm(
            OrderService orderService,
            PickupLocationService pickupLocationService,
            UserService userService,
            Order order,
            bool isEdit
        )
        {
            orderService_ = orderService;
            pickupLocationService_ = pickupLocationService;
            userService_ = userService;
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
                order_ = new Order((int)idTextBox.Value);
            }

            order_.Status = statusComboBox.Text;
            order_.PickupLocation = (PickupLocation)pickupLocationComboBox.SelectedItem;
            order_.User = (User)userComboBox.SelectedItem;
            order_.OrderDate = orderDateTimePicker.Value;
            order_.DeliveryDate = deliveryDateTimePicker.Value;

            DialogResult = DialogResult.OK;
        }

        private void AddOrEditOrderForm_Load(object sender, EventArgs e)
        {
            pickupLocationComboBox.DataSource = null;
            pickupLocationComboBox.DataSource = pickupLocationService_.GetAllPickupLocations();
            pickupLocationComboBox.DisplayMember = "Address";

            userComboBox.DataSource = null;
            userComboBox.DataSource = userService_.GetAllUsers();
            userComboBox.DisplayMember = "Fio";

            if (!isEdit_)
            {
                Text = "Добавление заказа - ООО «Обувь»";
                idTextBox.Value = orderService_.GenerateNextId();
                statusComboBox.Text = "Новый";
                return;
            }

            Text = "Редактирование заказа - ООО «Обувь»";
            idTextBox.Value = order_.Id;
            statusComboBox.Text = order_.Status;
            pickupLocationComboBox.SelectedItem = order_.PickupLocation;
            userComboBox.SelectedItem = order_.User;
            orderDateTimePicker.Value = order_.OrderDate;
            deliveryDateTimePicker.Value = order_.DeliveryDate;
        }
    }
}
