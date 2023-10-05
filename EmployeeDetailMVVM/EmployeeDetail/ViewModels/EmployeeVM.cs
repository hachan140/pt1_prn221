using EmployeeDetail01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeDetail01.ViewModels
{
    public class EmployeeVM : BaseVM
    {

        private ObservableCollection<Models.EmployeeDetail> _lstemployeeDetail = new ObservableCollection<Models.EmployeeDetail>();

        public ObservableCollection<Models.EmployeeDetail> LstEmployeeDetail
        {
            get { return _lstemployeeDetail; }
            set
            {
                _lstemployeeDetail = value;
                //OnPropertyChanged(nameof(LstEmployeeDetail));
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public EmployeeVM()
        {
            LstEmployeeDetail = new ObservableCollection<Models.EmployeeDetail>(DataProvider.Ins.DB.EmployeeDetails);
        }
        public void Load()
        {
            LstEmployeeDetail = _lstemployeeDetail;
        }

        public void Delete(object obj)
        {
            var emp = obj as Models.EmployeeDetail;
            if(emp != null)
            {
                using (var context = new MvvmContext())
                {
                    var e = context.EmployeeDetails.Find(emp.Id); // Tìm đối tượng cần cập nhật bằng ID
                    if (e != null)
                        context.EmployeeDetails.Remove(e);
                    context.SaveChanges();
                }
                Load();
            }            
        }
        public void Add(Models.EmployeeDetail obj)
        {
            if (obj != null)
            {
                try
                {
                    DataProvider.Ins.DB.EmployeeDetails.Add(obj);
                    DataProvider.Ins.DB.SaveChanges();
                    Load();
                }catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                
            }
        }
        public void Update(object obj)
        {
            var emp = obj as Models.EmployeeDetail;
            if (emp != null)
            {
                try
                {
                    using (var context = new MvvmContext())
                    {
                        var e = context.EmployeeDetails.Find(emp.Id); // Tìm đối tượng cần cập nhật bằng ID
                        if (e != null)
                        {
                            e.Name = emp.Name;
                            e.Address = emp.Address;
                            e.Age = emp.Age;
                            e.Gender = emp.Gender;
                            context.SaveChanges();
                        }
                    }
                    Load();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }

            }
        }
    }
}
