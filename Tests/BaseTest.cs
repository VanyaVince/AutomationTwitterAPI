using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using Twitter.Driver;
using Twitter.Steps;

namespace Twitter
{
    public class BaseTest
    {
        protected IWebDriver Driver => DriverFactory.Driver;

        protected LoginPageSteps LoginPageSteps = new LoginPageSteps();

        [SetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl("https://twitter.com");
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
            Driver.Dispose();
        }
    }
}