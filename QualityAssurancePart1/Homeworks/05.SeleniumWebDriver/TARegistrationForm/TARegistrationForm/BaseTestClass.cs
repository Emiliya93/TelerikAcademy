using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARegistrationForm
{
    public class BaseTestClass
    {
        public void TestInit(IWebDriver driver, string baseUrl, int timeOut)
        {
            this.Browser = driver;
            this.BaseUrl = baseUrl;
            this.Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            this.TimeOut = timeOut;
        }

        public IWebDriver Browser { get; set; }

        public string BaseUrl { get; set; }

        public WebDriverWait Wait { get; set; }

        public IWebElement CurrentElement { get; set; }

        public int TimeOut { get; set; }

        public IWebElement GetElement(By by)
        {
            IWebElement result = null;

            try
            {
                result = this.Wait.Until(x => x.FindElement(by));
            }
            catch(TimeoutException ex)
            {
                throw new TARegistrationForm.Exceptions.NoSuchElementException(by, this, ex);
            }
            catch(NoSuchElementException ex)
            {
                throw new TARegistrationForm.Exceptions.NoSuchElementException(by, this, ex);
            }

            return result;
        }

        public void WaitForElementPresent(By by)
        {
            this.GetElement(by);
        }

        public bool IsElementPresent(IWebDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);

                return true;
            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
        }
    }
}
