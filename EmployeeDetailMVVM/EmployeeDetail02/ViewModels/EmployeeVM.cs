using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using EmployeeDetail02.Models;

namespace EmployeeDetail02.ViewModels
{
    public class EmployeeVM
    {
        public void Delete(EmployeeDetail emp)
        {
            EmployeeManagement.Instance.Remove(emp);
        }

        public EmployeeDetail GetEmpByID(string Id)
        {
            return EmployeeManagement.Instance.GetEmpByID(Id);
        }

        public IEnumerable<EmployeeDetail> GetEmps()
        {
            return EmployeeManagement.Instance.GetEmployeeList();
        }

        public void AddEmployee(EmployeeDetail emp)
        {
            EmployeeManagement.Instance.AddNew(emp);
        }

        public void UpdateEmployee(EmployeeDetail emp)
        {
            EmployeeManagement.Instance.Update(emp);
        }
    }
}
