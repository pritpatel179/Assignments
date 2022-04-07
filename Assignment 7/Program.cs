using System;

namespace Assignment7
{

    public class Customer
    {
        public string CustomerId { get; set; }
        public string City { get; set; }
        public Customer(string cid, string city)
        {
            this.CustomerId = cid;
            this.City = city;
        }
        public override string ToString()
        {
            return CustomerId + " \t " + City;
        }
    }
    class Program
    {


        static void Main(string[] args)
        {

            List<Customer> customerlist = new List<Customer>();
            customerlist.Add(new Customer("ACSE1", "BHAVNAGAR"));
            customerlist.Add(new Customer("BCSE2", "SURAT"));
            customerlist.Add(new Customer("ACSE3", "BHAVNAGAR"));
            customerlist.Add(new Customer("ZCSE4", "BARODA"));
            customerlist.Add(new Customer("ACSE5", "BHAVNAGAR"));
            customerlist.Add(new Customer("ACSE6", "LUCKNOW"));

            var custQuery1 =
                from customer in customerlist
                where customer.City == "BHAVNAGAR"
                select customer;
            Console.WriteLine("CUSTOMERS ARE IN BHAVNAGAR");

            foreach (Customer cust in custQuery1)
            {
                Console.WriteLine(cust);
            }

            var custQuery2 =
                   (from customer in customerlist
                    select customer).Count();
            Console.Write("\n TOTAL CUSTOMERS : \t");
            Console.Write(custQuery2);

            var custQuery3 =
                     from customer in customerlist
                     where customer.CustomerId.Substring(0, 1) == "A"
                     select customer;
            Console.WriteLine("\nCUSTOMERS WHOSE CIDS STARTS WITH A :\t ");

            foreach (Customer cust in custQuery1)
            {
                Console.WriteLine(cust);
            }
        }
    }
}
