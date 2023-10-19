using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    [Serializable]
    public class DepartMentValidationException : Exception
    {
        public DepartMentValidationException() { }
        public DepartMentValidationException(string message) : base(message) { }
        public DepartMentValidationException(string message, Exception inner) : base(message, inner) { }
        protected DepartMentValidationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
