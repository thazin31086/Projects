using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ACM.BL.Test
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [TestClass]
    public class CustomerRepositoryTest
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
        
    }
}
