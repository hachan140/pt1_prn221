using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetail02.Models
{
    public class CustomerManagement
    {
        private static CustomerManagement instance;
        private static readonly object instancLock = new object();
        public static CustomerManagement Instance
        {
            get
            {
                lock(instancLock)
                {
                    if(instance == null)
                    {
                        instance = new CustomerManagement();
                    }
                }
                return instance; 
            }
        }
        public Customer GetCustomerByID(string id)
        {
            Customer c = new Customer();
            try
            {
                var myDB = new MvvmContext();
                c = myDB.Customers.SingleOrDefault(c => c.CustomerId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return c;
        }
    }
}
