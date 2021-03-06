using OpenQA.Selenium;

namespace Twitter
{
    public class BasePage
    {
        protected IWebDriver Driver => DriverFactory.Driver;

        public void SwtichToNewlyOpenedTab()
        {
            var windowsCount = Driver.WindowHandles.Count;
            Driver.SwitchTo().Window(Driver.WindowHandles[windowsCount - 1]);
        }

    }
}
