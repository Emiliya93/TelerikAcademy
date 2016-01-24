using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"D:\Users\Emi\GitHub\!TelerikAcademy\QualityAssurancePart1\Exercises\ExamPreparation\Selenium Web Driver\SeleniumWebDriver\packages\WebDriver.ChromeDriver.26.14.313457.1\tools");
            driver.Url = "http://stage.telerikacademy.com/";

            IWebElement loginButton = driver.FindElement(By.Id("EntranceButton"));
            loginButton.Click();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50));

            IWebElement usernameInput = driver.FindElement(By.XPath("//form[@action='/Users/Auth/Login']//input[@id='UsernameOrEmail']"));
            usernameInput.SendKeys("Emiliya93");

            IWebElement passButton = driver.FindElement(By.Id("Password"));
            passButton.SendKeys("chamfer61396");

            IWebElement enterButton = driver.FindElement(By.XPath("//form[@action='/Users/Auth/Login']//input[@value='Вход']"));
            enterButton.Click();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));

            // Navigate to Candidate for academy page
            //IWebElement academyLink = driver.FindElement(By.XPath("//nav//ul[@id='Menu']/li[3]/span/span[@title='Софтуерна академия']"));
            //academyLink.Click();

            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50));

            //IWebElement linkForApplication = driver.FindElement(By.XPath("//nav//ul[@id='Menu']/li[3]//li/a[@href='/SoftwareAcademy/Candidate']"));
            //linkForApplication.Click();

            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50));

            // Fast navigate to candidate
            driver.Url = "http://stage.telerikacademy.com/SoftwareAcademy/Candidate";
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50));


            IWebElement fieldset = driver.FindElement(By.XPath("//fieldset[@id='PersonalData']"));
            IWebElement firstName = driver.FindElement(By.XPath("//fieldset[@id='PersonalData']//table//input[@id='FirstName']"));
            if(firstName.GetAttribute("value") != "Емилия")
            {
                firstName.Clear();
                firstName.SendKeys("Емилия");
            }

            IWebElement secondName = driver.FindElement(By.XPath("//fieldset[@id='PersonalData']//table//input[@id='SecondName']"));
            secondName.SendKeys("Траянова");

            IWebElement lastName = driver.FindElement(By.XPath("//fieldset[@id='PersonalData']//table//input[@id='LastName']"));

            if (lastName.GetAttribute("value") != "Георгиева")
            {
                lastName.Clear();
                lastName.SendKeys("Георгиева");
            }
            
            IWebElement picture = driver.FindElement(By.XPath("//fieldset[@id='PersonalData']//input[@id='Picture']/.."));
            picture.Click();

            driver.SwitchTo()


            picture.SendKeys(Environment.CurrentDirectory + "emi.jpg");
            Console.WriteLine();

            driver.Quit();
        }
    }
}
