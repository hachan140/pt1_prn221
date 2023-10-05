using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDetail02.Models;

namespace EmployeeDetail01.ViewModels
{
    public class OrderVM
    {
        public Order GetOrderByID(string id)
        {
            return OrderManagement.Instance.GetOrderByID(id);
        }
    }
}
