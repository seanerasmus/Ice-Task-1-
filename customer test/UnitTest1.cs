namespace customer_test
{
    using NUnit.Framework;

    namespace IndexExample.Tests
    {
        public class CustomerIndexTests
        {
            [Test]
            public void AddAndRetrieveCustomerById()
            {
                var custIndex = new CustomerIndex();
                var cust = new Customer("CUST001", "John Doe", "john.doe@example.com", "555-1234", 1000.0);
                custIndex.Add(cust);

                var retrievedCust = custIndex["customerid"];

                Assert.AreEqual(cust, retrievedCust);
            }

            [Test]
            public void AddAndRetrieveCustomerByIndex()
            {
                var custIndex = new CustomerIndex();
                var cust = new Customer("CUST001", "John Doe", "john.doe@example.com", "555-1234", 1000.0);
                custIndex.Add(cust);

                var retrievedCust = custIndex[0];

                Assert.AreEqual(cust, retrievedCust);
            }

            [Test]
            public void UpdateCustomerById()
            {
                var custIndex = new CustomerIndex();
                var cust = new Customer("CUST001", "John Doe", "john.doe@example.com", "555-1234", 1000.0);
                custIndex.Add(cust);

                var updatedCust = new Customer("CUST001", "Jane Doe", "jane.doe@example.com", "555-5678", 1500.0);
                custIndex["customerid"] = updatedCust;

                Assert.AreEqual("Jane Doe", custIndex["customerid"].Name);
                Assert.AreEqual("jane.doe@example.com", custIndex["customerid"].Email);
            }

            [Test]
            public void CountCustomers()
            {
                var custIndex = new CustomerIndex();
                custIndex.Add(new Customer("CUST001", "John Doe", "john.doe@example.com", "555-1234", 1000.0));
                custIndex.Add(new Customer("CUST002", "Jane Doe", "jane.doe@example.com", "555-5678", 1500.0));

                Assert.AreEqual(2, custIndex.Count);
            }
        }
    }
