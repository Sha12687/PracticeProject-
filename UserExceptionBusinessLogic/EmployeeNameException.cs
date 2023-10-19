using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBusinessLogic
{
   
    [Serializable]
    public class EmployeeNameException: Exception
    {
        public EmployeeNameException() { }
        public EmployeeNameException(string message) : base(message) { }
        public EmployeeNameException(string message, Exception inner) : base(message, inner) { }
        protected EmployeeNameException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
