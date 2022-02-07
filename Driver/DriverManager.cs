using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using Twitter.Driver;

namespace Tarkov.Driver
{
    public class DriverManager
    {
        //TO DO helper for reading properties from the file 
        private static readonly TimeSpan _timeout = TimeSpan.FromSeconds(10);
        private static readonly TimeSpan _pollingInterval = TimeSpan.FromMilliseconds(700);
        private static IWebDriver Driver => DriverFactory.Driver;

        public static WebDriverWait Wait(TimeSpan timeout = default, TimeSpan pollingInterval = default)
        {
            timeout = timeout.Ticks == 0 ? _timeout : timeout;
            pollingInterval = pollingInterval.Ticks == 0 ? _pollingInterval : pollingInterval;

            return new WebDriverWait(Driver, timeout)
            {
                PollingInterval = pollingInterval,
            };
        }
    }
}
