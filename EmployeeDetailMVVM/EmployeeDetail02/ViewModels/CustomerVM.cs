using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDetail02.Models;

namespace EmployeeDetail02.ViewModels
{
    public class CustomerVM
    {
        public Customer GetCustomerByID(string id) => CustomerManagement.Instance.GetCustomerByID(id);

    }
}
