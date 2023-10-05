using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDetail02.Models
{
    class EmployeeManagement
    {
        private static EmployeeManagement instance = null;
        private static readonly object instanceLock = new object();
        private EmployeeManagement() { }
        public static EmployeeManagement Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new EmployeeManagement();
                    }
                    return instance;
                }
            }
        }
        //------------------------------------------
        public IEnumerable<EmployeeDetail> GetEmployeeList()
        {
            List<EmployeeDetail> emp;
            try
            {
                var myDB = new MvvmContext();
                emp = myDB.EmployeeDetails.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return emp;
        }

        //-------------------------------------------
        public EmployeeDetail GetEmpByID(string ID)
        {
            EmployeeDetail emp = new EmployeeDetail();
            try
            {
                var myDB = new MvvmContext();
                emp = myDB.EmployeeDetails.SingleOrDefault(c => c.Id==ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return emp;
        }

        //---------------------------------------------
        public void AddNew(EmployeeDetail emp)
        {
            try
            {
                EmployeeDetail _emp = GetEmpByID(emp.Id);
                if (_emp == null)
                {
                    var myDB = new MvvmContext();
                    myDB.EmployeeDetails.Add(emp);
                    myDB.SaveChanges();
                }
                else
                {
                    throw new Exception("The Employee is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //------------------------------------------------
        public void Update(EmployeeDetail emp)
        {
            try
            {
                EmployeeDetail c = GetEmpByID(emp.Id);
                if (c != null)
                {
                    var myDB = new MvvmContext();
                    myDB.Entry<EmployeeDetail>(emp).State = EntityState.Modified;
                    myDB.SaveChanges();
                }
                else
                {
                    throw new Exception("The Employee does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //-----------------------------------------------------
        public void Remove(EmployeeDetail emp)
        {
            try
            {
                EmployeeDetail c = GetEmpByID(emp.Id);
                if (c != null)
                {
                    var myDB = new MvvmContext();
                    myDB.EmployeeDetails.Remove(c);
                    myDB.SaveChanges();
                }
                else
                {
                    throw new Exception("The car does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //-------------------------------------------------------------

    }
}
