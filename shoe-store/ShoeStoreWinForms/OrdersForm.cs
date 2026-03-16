using ShoeStoreLib.Services;
using ShoeStoreLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShoeStoreLib.Repositories;
using ShoeStoreLib.Models;

namespace ShoeStoreWinForms
{
    public partial class OrdersForm : Form
    {
        private OrderService orderService_;
        private PickupLocationService pickupLocationService_;
        private UserService userService_;
        private User currentUser_ = null;
        private List<Order> orders_ = new List<Order>();

        public OrdersForm(User user)
        {
            orderService_ = new OrderService(new MySQLOrderRepository());
            userService_ = new UserService(new MySQLUserRepository());
            pickupLocationService_ = new PickupLocationService(new MySQLPickupLocationRepository());
            currentUser_ = user;
            InitializeComponent();

            orders_ = orderService_.GetAllOrders();
            FillOrders(orders_);
            
            if (currentUser_ == null || currentUser_.Role != UserRole.Admin)
            {
                addOrderButton.Enabled = false;
                deleteOrderButton.Enabled = false;
            }
        }

        private void FillOrders(List<Order> orders)
        {
            ordersListBox.DataSource = null;
            ordersListBox.DataSource = orders;
            ordersListBox.DisplayMember = "Id";
        }

        private void ordersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order order = (Order)ordersListBox.SelectedItem;
            if (order == null)
            {
                return;
            }

            orderCard.ShowOrderInfo(order);
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            Order order = (Order)ordersListBox.SelectedItem;
            if (order == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Вы уверены, что хотите удалить заказ {order.Id}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Yes)
            {
                orderService_.DeleteOrder(order);

                orders_.Clear();
                orders_ = orderService_.GetAllOrders();
                FillOrders(orders_);
            }
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            AddOrEditOrderForm addForm = new AddOrEditOrderForm(orderService_, pickupLocationService_, userService_, null, false);
            DialogResult result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                orderService_.AddOrder(addForm.Order);

                orders_.Clear();
                orders_ = orderService_.GetAllOrders();
                FillOrders(orders_);
            }
        }

        private void orderCard_DoubleClick(object sender, EventArgs e)
        {
            if (currentUser_.Role != UserRole.Admin)
            {
                return;
            }

            Order order = (Order)ordersListBox.SelectedItem;
            if (order == null)
            {
                return;
            }

            AddOrEditOrderForm editForm = new AddOrEditOrderForm(orderService_, pickupLocationService_, userService_, order, true);
            DialogResult result = editForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                orderService_.EditOrder(editForm.Order);
                
                orders_.Clear();
                orders_ = orderService_.GetAllOrders();
                FillOrders(orders_);
            }
        }
    }
}
