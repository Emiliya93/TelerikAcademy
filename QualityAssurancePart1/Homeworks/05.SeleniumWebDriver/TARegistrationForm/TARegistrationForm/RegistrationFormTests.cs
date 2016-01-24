using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using TARegistrationForm.Pages;
using TARegistrationForm.Helpers;

namespace TARegistrationForm
{
    [TestClass]
    public class RegistrationFormTests : BaseTestClass
    {
        private const int TimeOutSeconds = 10;

        [TestInitialize]
        public void TestInit()
        {
            this.Browser = new FirefoxDriver();
            this.BaseUrl = @"http://stage.telerikacademy.com";
            this.Wait = new WebDriverWait(this.Browser, TimeSpan.FromSeconds(TimeOutSeconds));
            this.TimeOut = TimeOutSeconds;
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.Browser.Quit();
        }

        //[TestMethod]
        //public void EmptyUserNameShouldnotCreateUser()
        //{
            //this.Browser.Navigate().GoToUrl("http://stage.telerikacademy.com/Users/Auth/Registration");
            //this.CurrentElement = this.GetElement(By.Id("Password"));
            //this.CurrentElement.SendKeys("123456");

            //this.CurrentElement = this.GetElement(By.Id("PasswordAgain"));
            //this.CurrentElement.SendKeys("123456");
        //}

        [TestMethod]
        public void EmptyUserNameShouldnotCreateUser_PageObjectModel()
        {
            this.Browser.Navigate().GoToUrl(this.BaseUrl);

            var mainNavigationView = new MainNavigationView(this.Browser);
            mainNavigationView.Registration.Click();

            var registrationPage = new RegistrationPage(this.Browser);
            registrationPage.Register(string.Empty, "123456", "123456", "Ася", "Георгиева", "qa@track.com", true);

            Assert.AreEqual(registrationPage.UserNameValidation.Text, "Потребителското име е задължително");
            Assert.IsTrue(registrationPage.RegisterButton.Displayed);
        }

        [TestMethod]
        public void CreatUserWithValidInput()
        {
            RandomGenerator random = RandomGenerator.Instance;

            this.Browser.Navigate().GoToUrl(this.BaseUrl);

            var mainNavigationView = new MainNavigationView(this.Browser);
            mainNavigationView.Registration.Click();

            var registrationPage = new RegistrationPage(this.Browser);

            string randomName = random.GetRandomStringLatinLetters(7);
            string firstName = random.GetRandomStringCyrillicLetters(3);
            string lastName = random.GetRandomStringCyrillicLetters(4);
            string email = randomName + "@" + randomName + ".com";

            registrationPage.Register(randomName, "123456", "123456", firstName, lastName, email, true);

            Assert.IsFalse(this.IsElementPresent(this.Browser, By.Id("Username-error")));
        }
    }
}
