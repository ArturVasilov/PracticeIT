using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEndedQueue
{
    class EmptyQueueException : ArgumentOutOfRangeException
    {
        private const string DEFAULT_MESSAGE = "Double-ended queue is empty!";

        public EmptyQueueException() : base(DEFAULT_MESSAGE)
        {
        }

        public EmptyQueueException(string message)
            : base(message)
        {
        }

    }
}
