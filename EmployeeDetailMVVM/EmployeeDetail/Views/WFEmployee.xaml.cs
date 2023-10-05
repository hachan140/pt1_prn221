using EmployeeDetail01.Models;
using EmployeeDetail01.ViewModels;
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

namespace EmployeeDetail01.Views
{
    /// <summary>
    /// Interaction logic for WFEmployee.xaml
    /// </summary>
    public partial class WFEmployee : Window
    {
        EmployeeVM vm= new EmployeeVM();
        public WFEmployee()
        {
            InitializeComponent();
            DataContext = new EmployeeVM();
        }
        public EmployeeDetail GetInfo()
        {
            Models.EmployeeDetail m = new Models.EmployeeDetail();
            try
            {
                m.Name = txtName.Text;
                m.Address = txtAddress.Text;
                m.Gender = txtGender.Text;
                m.Age = txtAge.Text;
                m.Id = txtID.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Info");
            }
            return m;
        }
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {

        }

        public void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                vm.Add(GetInfo());
                DataContext = new EmployeeVM();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                vm.Update(GetInfo());
                DataContext = new EmployeeVM();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnDele_click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure to delete Employee with ID " + txtID.Text, "Delete",
                    MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {
                    vm.Delete(GetInfo());
                    DataContext = new EmployeeVM();
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
