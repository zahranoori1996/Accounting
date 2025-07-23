using Accounting.DataLayer;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accounting_DBEntities db = new Accounting_DBEntities(); //context injection way
            ICustomerRepository customer = new CustomerRepository(db);
            //Customers AddCustomer = new Customers()
            //{
            //    Fullname = "yeganeh",
            //    Mobile = "09121919",
            //    Email = "yeganeh@gmail.com",
            //    Address = "tehran niyavaran",
            //    CustomerImage = "no photo"
            //};
            //customer.InsertCustomers(AddCustomer);
            //customer.Save();
            var list = customer.GetAllCustomers();
            foreach (var item in list)
            {
                Console.WriteLine(item.Fullname);
            }
        }
    }
}
