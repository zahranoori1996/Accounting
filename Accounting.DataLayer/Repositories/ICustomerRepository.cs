using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        //notice: this is a repository interface for managing customer data

        //read data by filter
        IEnumerable<Customers> GetCustomersByFilter(string parameter);


        //read
        List<Customers> GetAllCustomers();
        //read
        Customers GetCustomersById(int customerId);
        //create
        bool InsertCustomers(Customers customer);
        //update
        bool UpdateCustomers(Customers customer);
        //delete
        bool DeleteCustomer(Customers customerId);
        //delete
        bool DeleteCustomer(int customerId);
        //save
        //save is not needed in repository interface, it is handled by UnitOfWork
    }
}
