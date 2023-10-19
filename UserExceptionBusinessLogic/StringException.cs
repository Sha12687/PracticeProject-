using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExceptionBusinessLogic
{
 
    [Serializable]
    public class StringException : Exception
    {
        public StringException() { }
        public StringException(string message) : base(message) { }
        public StringException(string message, Exception inner) : base(message, inner) { }
        protected StringException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
