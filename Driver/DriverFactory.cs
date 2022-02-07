using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Twitter
{
    public class DriverFactory
    {
        private static IWebDriver _driver;
        public static IWebDriver Driver => _driver ?? (_driver = InitDriver());

        private static IWebDriver InitDriver()
        {
            return new ChromeDriver();
        }
    }
}
