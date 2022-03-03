using System;

namespace Sales.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException (string message) : base(message)
        {
        }
    }
}
