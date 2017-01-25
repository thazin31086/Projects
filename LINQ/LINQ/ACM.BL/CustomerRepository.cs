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
            List<Customer> custList = new List<Customer>
            {
                new Customer() { CustomerId =1, FirstName="Frado", LastName="Baggins", EmailAddress="fb@hob,me", CustomerTypeId=1},
                new Customer() { CustomerId =2, FirstName="Bilbo", LastName="Baggins", EmailAddress="bb@hob,me", CustomerTypeId=2},
                new Customer() { CustomerId =3, FirstName="John", LastName="Baggins", EmailAddress="jb@hob,me", CustomerTypeId=1},
                new Customer() { CustomerId =4, FirstName="Stecy", LastName="Baggins", EmailAddress="sb@hob,me", CustomerTypeId=2},
                new Customer() { CustomerId =5, FirstName="Mary", LastName="Baggins", EmailAddress="mb@hob,me", CustomerTypeId=1}
            };

            return custList;
        }
    }
}
