using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExceptionBusinessLogic
{
    public class Customer
    {
        private int custID;
        public int CustID
        {
            get { return custID; }
            set {

                if (value == 0)
                {
                    throw new IDException("Id must be greater then zero ... ");
                }
                else
                    custID = value; }
        }

        private DateTime borrowDate;
        public DateTime BorrowDate
        {
            get { return borrowDate; }
            set {

                if (value == null)
                {
                    throw new DateException("Borrow date cannot be null ...");
                }
                borrowDate = value; }
        }

        private int movieID;
        public int MovieID
        {
            get { return movieID; }
            set { movieID = value; }
        }

        private DateTime returnDate;
        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        public Customer() { }
        public Customer(int custID, DateTime borrowDate, int movieID)
        {
            CustID = custID;
            BorrowDate = borrowDate;
            MovieID = movieID;
           
        }
        public void Borrow(Movie movie, DateTime borrowDate)
        {
            MovieID = movie.MovieID;
            BorrowDate = borrowDate;
           // ReturnDate = borrowDate.AddDays(10);

            Console.WriteLine($"Movie CD '{movie.MovieName}' has been borrowed by Customer {CustID}.");
        }
        public bool IsOverdue(Customer customer)
        {
            ReturnDate= customer.borrowDate.AddDays(10);
            return DateTime.Now > ReturnDate;
        }
    }
}
