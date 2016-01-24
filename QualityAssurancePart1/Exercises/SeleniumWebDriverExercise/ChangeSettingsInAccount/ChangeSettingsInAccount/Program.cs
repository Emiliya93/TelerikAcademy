using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeSettingsInAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"D:\Users\Emi\GitHub\!TelerikAcademy\QualityAssurancePart1\SeleniumWebDriverExercise\ChangeSettingsInAccount\packages\WebDriver.ChromeDriver.26.14.313457.1\tools");
            driver.Url = "http://stage.telerikacademy.com/";
            driver.Navigate();
            IWebElement element = driver.FindElement(By.Id("EntranceButton"));
            element.Click();


        }
    }
}
