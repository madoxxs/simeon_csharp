using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Zadacha2
{
    class SentenceNotCompletedException:Exception
    {
        public SentenceNotCompletedException()
            : base()
        {

        }
        public SentenceNotCompletedException(string message)
            : base(message)
        {

        }
        public SentenceNotCompletedException(String message, Exception innerException)
            : base(message, innerException)
        {

        }
        protected SentenceNotCompletedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
