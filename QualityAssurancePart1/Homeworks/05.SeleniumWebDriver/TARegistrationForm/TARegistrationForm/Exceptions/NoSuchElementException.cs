using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARegistrationForm.Exceptions
{
    public class NoSuchElementException : ApplicationException
    {
        public NoSuchElementException(By by, BaseTestClass test, Exception ex)
        {
            string message = this.BuildMessage(by, test);

            throw new ApplicationException(message);
        }

        private string BuildMessage(By by, BaseTestClass test)
        {
            StringBuilder message = new StringBuilder();

            string locationMessage = string.Format("***Element with location strategy: {0}***\n ***Not Found!***", by.ToString());
            message.Append(locationMessage);

            string currentUrlMessage = string.Format("The URL when test failed was: {0}", test.Browser.Url);
            message.Append(currentUrlMessage);

            return message.ToString();
        }
    }
}
