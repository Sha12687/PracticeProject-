using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExceptionBusinessLogic
{
   
    [Serializable]
    public class DateException : Exception
    {
        public DateException() { }
        public DateException(string message) : base(message) { }
        public DateException(string message, Exception inner) : base(message, inner) { }
        protected DateException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
