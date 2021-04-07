using DataModelsEmployee.EmployeeClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEmployees
{
    public interface IEmployeeRepo
    {
        bool Create(Organisation model);
        bool Edit(Organisation model);
        IEnumerable<Organisation> GetALL();
        object GetBYID(int id);
        bool Delete(int id);


    }
    public class Employee : IEmployeeRepo
    {
        ReviewYEntities1 db = new ReviewYEntities1();
        public bool Create(Organisation model)
        {
            Organisation obj = new Organisation();
            obj.Name = model.Name;
            obj.PhoneNumber = model.PhoneNumber;
            obj.Country = model.Country;
            obj.Description = model.Description;
            db.Organisations.Add(obj);
            db.SaveChanges(); 
            return true;
        }

        public bool Delete(int id)
        {
            var obj=db.Organisations.Find(id);
            db.Organisations.Remove(obj);
            db.SaveChanges();
            return true;
        }

        public bool Edit(Organisation model)
        {
            var obj=db.Organisations.Find(model.Id);
            obj.Name = model.Name;
            obj.PhoneNumber = model.PhoneNumber;
            obj.Country = model.Country;
            obj.Description = model.Description;
            db.SaveChanges();
            return true;
        }

        public IEnumerable<Organisation> GetALL()
        {
            var list = db.Organisations.ToList();
            return list;
        }

        public object GetBYID(int id)
        {
            var obj = db.Organisations.Find(id);
            return obj;
        }
    }
}
