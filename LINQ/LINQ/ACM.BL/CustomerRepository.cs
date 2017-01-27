using System;
using System.Collections.Generic;
using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Find(List<Customer> customerList, int customerId)
        {
            Customer foundCustomer = null;
            //foreach (var c in customerList)
            //{
            //    if (c.CustomerId == customerId) {
            //        foundCustomer = c;
            //        break;
            //    }
            //}

            //LINQ Query Syntax
            var query = from c in customerList
                        where c.CustomerId == customerId
                        select c;
            foundCustomer = query.FirstOrDefault();

            return foundCustomer;
        }
        public List<Customer> Retrieve()
        {
            InvoiceRepository invoicerepo = new InvoiceRepository();
            List<Customer> custList = new List<Customer>
            {
                new Customer() { CustomerId =1, FirstName="Frado", LastName="Baggins", EmailAddress="fb@hob,me", CustomerTypeId=1, InvoiceList = invoicerepo.Retrieve(1)},
                new Customer() { CustomerId =2, FirstName="Bilbo", LastName="Baggins", EmailAddress="bb@hob,me", CustomerTypeId=2, InvoiceList = invoicerepo.Retrieve(2)},
                new Customer() { CustomerId =3, FirstName="John", LastName="Baggins", EmailAddress="jb@hob,me", CustomerTypeId=1, InvoiceList = invoicerepo.Retrieve(3)},
                new Customer() { CustomerId =4, FirstName="Stecy", LastName="Baggins", EmailAddress="sb@hob,me", CustomerTypeId=2, InvoiceList = invoicerepo.Retrieve(4)},
                new Customer() { CustomerId =5, FirstName="Mary", LastName="Baggins", EmailAddress="mb@hob,me", CustomerTypeId=1, InvoiceList = invoicerepo.Retrieve(5)}
            };

            return custList;
        }

        public IEnumerable<string> GetNames(List<Customer> customerList)
        {
            var query = customerList.Select(c => c.LastName + ", " + c.FirstName);
            return query;
        }


        /// <summary>
        /// Dynamic Type by pass compile time checking bypass anonymous type
        /// </summary>
        /// <param name="customerList"></param>
        /// <returns></returns>
        public dynamic GetNameAndEmail(List<Customer> customerList)
        {
            var query = customerList.Select(c => new { Name = c.LastName + " ," + c.FirstName, c.EmailAddress });

            foreach (var item in query)
            {
                Console.WriteLine(item.Name + ":" + item.EmailAddress); 
            }
            return query; 
        }


        public dynamic GetNamesAndType(List<Customer> customerList, List<CustomerType> customerTypeList)
        {
            var query = customerList.Join(customerTypeList,
                c => c.CustomerTypeId,
                ct => ct.CustomerTypeId,
                (c, ct) => new { Name = c.LastName + ", " + c.FirstName, CustomerTypeName = ct.TypeName });

            foreach (var item in query)
            {
                Console.WriteLine(item.Name + ": " + item.CustomerTypeName);
            }

            return query;
        }

        public IEnumerable<Customer> RetrieveEmptyList()
        {
            return Enumerable.Repeat(new Customer(), 5);
        }
        public IEnumerable<Customer> SortByName(List<Customer> customerList)
        {
            return customerList.OrderBy(c => c.LastName).ThenBy(c=> c.FirstName);
        }

        public IEnumerable<Customer> SortByNameInReverse(List<Customer> customerList)
        {
            return customerList.OrderByDescending(c => c.LastName).ThenByDescending(c => c.FirstName);
        }
    }
}
