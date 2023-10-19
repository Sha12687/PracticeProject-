using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UserExceptionBusinessLogic;
namespace ExceptionHandlingAssignment
{
    public class TheaterMain
    {
       public static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie(1, "Inception", "English"));
            movies.Add(new Movie(2, "Parasite", "Korean"));
            movies.Add(new Movie(3, "The Shawshank Redemption", "English"));
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(101, DateTime.Parse("2023-10-01"), 1));
            customers.Add(new Customer(102, DateTime.Parse("2023-10-10"), 2));
            customers.Add(new Customer(103, DateTime.Parse("2023-10-17"), 3));


            List<Customer> overdueCustomers = new List<Customer>();
            foreach (Customer customer in customers)
            {
                if (customer.IsOverdue(customer))
                {
                    Console.WriteLine(customer.CustID+" "+customer.MovieID);
                    overdueCustomers.Add(customer);
                }
            }
        }
    }
}
