using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Driver
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
