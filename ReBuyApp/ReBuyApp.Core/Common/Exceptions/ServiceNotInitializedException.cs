using System;
namespace ReBuyApp.Core.Common.Exceptions
{
    public class ServiceNotInitializedException : Exception
    {
        public ServiceNotInitializedException(string message = "At first you have to initialize the service") : base(message)
        {
        }
    }
}
