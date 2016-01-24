using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TARegistrationForm.Pages
{
    public class MainNavigationView
    {
        public MainNavigationView(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href='/Users/Auth/Registration']")]
        public IWebElement Registration { get; set; }
    }
}
