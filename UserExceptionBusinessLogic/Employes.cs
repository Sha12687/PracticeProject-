using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionHandlingAssignment;
namespace ExceptionBusinessLogic
{
    public class Employes
    {
		private int empno;

		public int Empo
		{
			get { return empno; }
			set {
                if (value == 0)
                {
                    throw new EmployeeNumberException("Employee number cannot be zero ..");

                }

				else
				{
					empno = value;
				}
            }
        }
		private string ename;

		public string Ename
		{
			get { return ename; }
			set {
				if (string.IsNullOrEmpty(value)) {

					throw new EmployeeNameException("Employee Name cannot be null ...");
				}
			
			}
		}
		private double salary;

		public double Salary
		{
			get { return salary; }
			set { salary = value; }
		}
		private int deptno;

		public int DeptNo
		{
			get { return deptno; }
			set {
				if (deptno == 0)
				{
			throw new DepartMentValidationException("Department number cannot be zero ..");

                }
				else
				{
					deptno = value;
				}
			
			}
		}
		public Employes(int empno,string name,int deptno,double salary)
		{
			Empo = empno;
			Ename = name;
			Salary = salary;
			DeptNo = deptno;
		}

	}
}
