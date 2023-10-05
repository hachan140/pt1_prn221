using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using EmployeeDetail02.ViewModels;
using EmployeeDetail02.Models;
using EmployeeDetail02.Views;
using EmployeeDetail01.ViewModels;

namespace EmployeeDetail02
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        public App()
        {
            //Config for Dependencyinjection(DI)
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton(typeof(EmployeeVM), typeof(EmployeeVM));
            services.AddSingleton<Employee>();
            services.AddSingleton(typeof(OrderVM), typeof(OrderVM));
            services.AddSingleton<Views.Order>();
            services.AddSingleton(typeof(OrderDetailVM), typeof(OrderDetailVM));
            services.AddSingleton<Views.OrderDetail>();
            services.AddSingleton(typeof(CustomerVM), typeof(CustomerVM));
          //  services.AddSingleton<Views.Customer>();
        }

        public void OnStartup(object sender, StartupEventArgs e)
        {
            /*var employee = serviceProvider.GetService<Employee>();
            employee.Show();*/
            var order = serviceProvider.GetService<Views.Order>();
            order.Show();
        }
    }
}
