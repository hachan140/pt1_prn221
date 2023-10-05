using EmployeeDetail02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetail02.ViewModels
{
    public class OrderDetailVM
    {
        public IEnumerable<OrderDetail> GetOrderDetailByID(string id)
        {
            return OrderDetailManagement.Instance.GetOrderDetailByID(id);
        }
    }
}
