using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetail02.Models
{
    public class OrderDetailManagement
    {
        private static OrderDetailManagement instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailManagement() { }
        public static OrderDetailManagement Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailManagement();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<OrderDetail> GetOrderDetailByID(string id)
        {
            List<OrderDetail> o;
            try
            {
                var myDB = new MvvmContext();
                o = myDB.OrderDetails.Where(o => o.OrderId == id).ToList();
            } 
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return o;
        }
    }
}
