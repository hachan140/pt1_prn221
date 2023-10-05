using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetail02.Models
{
    public class OrderManagement
    {
        private static OrderManagement instance;
        private static readonly object instanceLock = new object();
        private OrderManagement() { }
        public static OrderManagement Instance
        {
            get 
            { 
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance= new OrderManagement();
                    }
                }
                return instance; 
            }
        }
        public IEnumerable<Order> GetOrderList()
        {
            List<Order> emp;
            try
            {
                var myDB = new MvvmContext();
                emp = myDB.Orders.ToList();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return emp;
        }
        public Order GetOrderByID(string id)
        {
            Order order= new Order();
            try
            {
                var db = new MvvmContext(); 
                order = db.Orders.SingleOrDefault(c => c.OrderId == id);
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }
    }
}
