using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TARegistrationForm.Pages
{
    public class RegistrationPage
    {
        public RegistrationPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "Username")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "PasswordAgain")]
        public IWebElement PasswordAgain { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "TermsAndConditions")]
        public IWebElement TermsAndConditionsCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//fieldset//input[@value='Регистрация']")]
        public IWebElement RegisterButton { get; set; }

        [FindsBy(How = How.Id, Using = "Username-error")]
        public IWebElement UserNameValidation { get; set; }

        public void Register(
            string userName,
            string pass, 
            string passAgain, 
            string firstName, 
            string lastName, 
            string email, 
            bool isTermsAndConditionsChecked)
        {
            this.UserName.SendKeys(userName);
            this.Password.SendKeys(pass);
            this.PasswordAgain.SendKeys(passAgain);
            this.FirstName.SendKeys(firstName);
            this.LastName.SendKeys(lastName);
            this.Email.SendKeys(email);

            if (isTermsAndConditionsChecked)
            {
                this.TermsAndConditionsCheckBox.Click();
            }

            this.RegisterButton.Click();
        }
    }
}