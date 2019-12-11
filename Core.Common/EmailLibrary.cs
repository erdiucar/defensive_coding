using System;

namespace Core.Common
{
    public class EmailLibrary
    {
        public void SendEmail(string emailAddress, string message)
        {
            // If a valid email address is provided,
            try
            {
                // Send an email.
            }
            catch (InvalidOperationException ex)
            {
                // log
                throw;
            }
        }
    }
}
