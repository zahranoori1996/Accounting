using Accounting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        //Accounting_DBEntities db = new Accounting_DBEntities();
        //constractor injection way
        private Accounting_DBEntities db;
        public CustomerRepository(Accounting_DBEntities context)
        {
            db = context;
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customers GetCustomersById(int customerId)
        {
            return db.Customers.Find(customerId);
        }

        public bool InsertCustomers(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomersById(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool UpdateCustomers(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<Customers> GetCustomersByFilter(string parameter)
        {
            return db.Customers
                .Where(c => c.Fullname.Contains(parameter) || c.Mobile.Contains(parameter) || c.Email.Contains(parameter))
                .ToList();
        }
    }
}
