using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ACM.BL.Tests
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [TestClass]
    public class CustomerRepositoryTests
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get; set;
        }

        [TestMethod]
        public void FindTestExistingCustomer()
        {
            //Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            //Act 
            var result = repository.Find(customerList, 2);

            //Assert 
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.CustomerId);
            Assert.AreEqual("Baggins", result.LastName);
            Assert.AreEqual("Bilbo", result.FirstName);
        }

        [TestMethod]
        public void SortByNameTest()
        {

            //Arrange
            CustomerRepository respository = new CustomerRepository();
            var customerList = respository.Retrieve();

            //Act 
            var result = respository.SortByName(customerList);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.First().CustomerId);
            Assert.AreEqual("Baggins", result.First().LastName);
            Assert.AreEqual("Bilbo", result.First().FirstName);
        }

        [TestMethod]
        public void SortByNameInReverseTest()
        {

            //Arrange
            CustomerRepository respository = new CustomerRepository();
            var customerList = respository.Retrieve();

            //Act 
            var result = respository.SortByNameInReverse(customerList);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.First().CustomerId);
            Assert.AreEqual("Baggins", result.First().LastName);
            Assert.AreEqual("Stecy", result.First().FirstName);
        }



        [TestMethod()]
        public void GetNamesTest()
        {
            //Arrange 
            CustomerRepository repo = new CustomerRepository();
            var customerList = repo.Retrieve();

            //Act 
            var query = repo.GetNames(customerList);


            //Analyze
            foreach (var item in query)
            {
                TestContext.WriteLine(item);
            }

            //Assert 
            Assert.IsNotNull(query);
        }

        [TestMethod()]
        public void GetNameAndEmailTest()
        {
            //Arrange 
            CustomerRepository repo = new CustomerRepository();
            var customerlist = repo.Retrieve();

            //Act 
            var result = repo.GetNameAndEmail(customerlist);


            //NOT
        }

        [TestMethod()]
        public void GetNamesAndTypeTest()
        {
            //Assign 
            CustomerRepository repo = new CustomerRepository();
            var customerList = repo.Retrieve();

            CustomerTypeRepository lrepo = new CustomerTypeRepository();
            var customerTypeList = lrepo.Retrieve();

            //Act 
            var result = repo.GetNamesAndType(customerList, customerTypeList); 
            
        }
    }
}
