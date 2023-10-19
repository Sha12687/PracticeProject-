using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBusinessLogic
{
   
    [Serializable]
    public class EmployeeNumberException : Exception
    {
        public EmployeeNumberException() { }
        public EmployeeNumberException(string message) : base(message) { }
        public EmployeeNumberException(string message, Exception inner) : base(message, inner) { }
        protected EmployeeNumberException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
