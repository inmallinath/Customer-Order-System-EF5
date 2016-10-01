using SalesDomain.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDomainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCustomers();
        }

        private static void GetCustomers()
        {
            using (var context = new SalesModelContext())
            {
                var customers = context.Customers.ToList();
                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.FirstName);
                }
            }
        }
    }
}
