using NUnit.Framework;
using OpenQA.Selenium;

namespace Twitter
{
    public class BaseTest
    {
        protected IWebDriver Driver => DriverFactory.Driver;

        protected LoginPageSteps LoginPageSteps = new LoginPageSteps();
        protected HomePageSteps HomePageSteps = new HomePageSteps();
        protected ProfilePageSteps ProfilePageSteps = new ProfilePageSteps();

        [SetUp]
        public virtual void Setup()
        {
            OpenUrl();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
            Driver.Dispose();
        }

        protected void OpenUrl()
        {
            Driver.Navigate().GoToUrl("https://twitter.com");
            Driver.Manage().Window.Maximize();
        }
    }
}