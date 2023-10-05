using EmployeeDetail01.ViewModels;
using EmployeeDetail02.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EmployeeDetail02.Views
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        OrderVM orderVM;
        
        CustomerVM customerVM;
        public Order(OrderVM o, CustomerVM cVM)
        {
            InitializeComponent();
            orderVM = o;
            customerVM = cVM;
        }


        private void btnOrderDetail_Click(object sender, RoutedEventArgs e)
        {
            string id = txtOrderID.Text;
            OrderDetailVM odVM = new OrderDetailVM();
            OrderDetail od = new OrderDetail(id, odVM);
            od.Show();

        }

        private void btnFindOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string txtID = txtFindOrder.Text.ToString();
                Models.Order o = orderVM.GetOrderByID(txtID);
                if (o == null){
                    MessageBox.Show("Order not found");
                    return;
                }
                Models.Customer customer = customerVM.GetCustomerByID(o.CustomerId);
                txtOrderID.Text = o.OrderId;
                txtDate.Text = o.Date.ToString();
                txtCustomerID.Text = o.CustomerId;
                var discount = customer.DiscountRate;
                txtTotalPayment.Text = (o.TotalPayment * (100-discount)/100).ToString();
               
                txtDiscount.Text = customer.DiscountRate.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
