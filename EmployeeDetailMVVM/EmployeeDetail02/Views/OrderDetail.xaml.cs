﻿using System;
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
using EmployeeDetail02.ViewModels;

namespace EmployeeDetail02.Views
{
    /// <summary>
    /// Interaction logic for OrderDetail.xaml
    /// </summary>
    public partial class OrderDetail : Window
    {
        string id;
        OrderDetailVM odVM;
        public OrderDetail(string id, OrderDetailVM odVM)
        {
            InitializeComponent();
            this.id = id;
            this.odVM = odVM;
            LoadOrderDetailList();
        }
        public void LoadOrderDetailList()
        {
            lvOrderDetail.ItemsSource = odVM.GetOrderDetailByID(id);
        }
    }
}
