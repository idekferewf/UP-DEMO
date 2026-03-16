using ShoeStoreLib.Services;
using ShoeStoreLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoeStoreLib.Interfaces;
using ShoeStoreLib.Repositories;

namespace ShoeStoreWinForms
{
    public partial class OrdersForm : Form
    {
        private OrderService orderService_;
        private PickupLocationService pickupLocationService_;
        private List<Order> orders_ = new List<Order>();
        private User currentUser_ = null;

        public OrdersForm(User user)
        {
            InitializeComponent();
            currentUser_ = user;

            orderService_ = new OrderService();
            pickupLocationService_ = new PickupLocationService();

            try
            {
                orders_ = orderService_.GetAllOrders();
                FillOrders(orders_);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Ошибка загрузки товаров",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            if (currentUser_.Role != UserRole.Admin)
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

            string address = pickupLocationService_.GetPickupLocationAddressById(order.Id);
            orderCard.ShowOrderInfo(order, address);
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

                if (ordersListBox.Items.Count > 0)
                {
                    ordersListBox.SelectedIndex = 0;
                }
            }
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            AddOrEditOrderForm addForm = new AddOrEditOrderForm(orderService_, pickupLocationService_, null, false);
            DialogResult result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                orderService_.AddOrder(addForm.Order);

                orders_.Clear();
                orders_ = orderService_.GetAllOrders();
                FillOrders(orders_);

                if (ordersListBox.Items.Count > 0)
                {
                    ordersListBox.SelectedIndex = 0;
                }
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

            AddOrEditOrderForm editForm = new AddOrEditOrderForm(orderService_, pickupLocationService_, order, true);
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
