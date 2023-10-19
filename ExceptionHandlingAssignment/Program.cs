using ExceptionBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserExceptionBusinessLogic;
namespace ExceptionHandlingAssignment
{
    internal class Program
    {
       static void Main(string[] args)
        {
           
            try
            {
              Employes emp1 = new Employes(0, "John Doe", 50000, 10);
              //  Employes emp2 = new Employes(1, "Jane Smith", 60000, 0);
              //  Employes emp3 = new Employes(3, "", 70000, 30);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        }
    }
