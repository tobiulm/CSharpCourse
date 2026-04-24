using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewElements.DemoLibrary
{
    /// <summary>
    /// Stellt einen Customer Datensatz aus der Norhwind DB Tabelle Customers dar
    /// </summary>
    public class Customer
    {
        public string CustomerId { get; set; }
        public string CompanyName {get; set;}
        public string City { get; set; }
        public string Country { get; set; }

        public Customer()
        {
        }

        public Customer(string customerId)
        {
            CustomerId = customerId;
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers WHERE CustomerID = @customerId", connection);
            cmd.Parameters.Add(new SqlParameter("@customerId", CustomerId));

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CompanyName = reader["CompanyName"].ToString();
                        City = reader["City"].ToString();
                        Country = reader["Country"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
                if (connection != null && connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                    connection.Dispose();
                }

            }
        }

        public static List<Customer> LoadAllCustomers()
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", connection);
           
            SqlDataReader reader = null;

            List<Customer> customers = new List<Customer>();

            try
            {
                connection.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Customer customer = new Customer();
                        customer.CustomerId = reader["CustomerID"].ToString();
                        customer.CompanyName = reader["CompanyName"].ToString();
                        customer.City = reader["City"].ToString();
                        customer.Country = reader["Country"].ToString();
                        customers.Add(customer);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
                if (connection != null && connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            return customers;
        }

    }
}
