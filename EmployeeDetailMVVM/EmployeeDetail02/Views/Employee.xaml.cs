using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
using EmployeeDetail02.Models;
using EmployeeDetail02.ViewModels;

namespace EmployeeDetail02.Views
{
    /// <summary>
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class Employee : Window
    {
        EmployeeVM employeeVM;
        public Employee(EmployeeVM emp)
        {
            InitializeComponent();
            employeeVM = emp;
        }
        private EmployeeDetail GetInfo()
        {
            EmployeeDetail emp = null;
            try
            {
                emp = new EmployeeDetail()
                {
                    Id = txtID.Text,
                    Name = txtName.Text,
                    Age = txtAge.Text,
                    Gender = txtGender.Text,
                    Address = txtAddress.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Employee");
            }

            return emp;
        }
        public void LoadEmpList()
        {
            lstView.ItemsSource = employeeVM.GetEmps();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            LoadEmpList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EmployeeDetail emp = GetInfo();
                employeeVM.AddEmployee(emp);
                LoadEmpList();
                MessageBox.Show($"{emp.Id} inserted successfully", "Insert Employee");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Employee");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EmployeeDetail emp = GetInfo();
                employeeVM.UpdateEmployee(emp);
                LoadEmpList();
                MessageBox.Show($"{emp.Id} Update successfully", "Update Employee");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Employee");
            }
        }

        private void btnDele_click(object sender, RoutedEventArgs e)
        {
            try
            {
                EmployeeDetail emp = GetInfo();
                var result = MessageBox.Show("Are you sure to delete Employee with ID " + emp.Id, "Delete",
                    MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {
                    employeeVM.Delete(emp);
                    LoadEmpList();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Employee");
            }
        }
    }
}
