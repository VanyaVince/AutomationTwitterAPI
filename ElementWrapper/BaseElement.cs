using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Linq;
using Tarkov.Driver;
using Twitter.Driver;

namespace Tarkov.ElementWrapper
{
    public class BaseElement
    {
        protected By _locator;
        protected IWebDriver Driver => DriverFactory.Driver;
        protected IWebElement Element => Driver.FindElements(_locator).FirstOrDefault();

        public BaseElement(By locator)
        {
            _locator = locator;
        }

        public void Click()
        {
            WaitForElementToBeExisted();
            WaitForElementToBeVisible();
            WaitElementIsClickable();

            Element.Click();
        }

       public void Hover()
        {
            WaitForElementToBeExisted();
            new Actions(Driver).MoveToElement(Element).Perform();
        }

        public IWebElement GetElement()
        {
            WaitForElementToBeExisted();
            return Element;
        }

        public string GetElementAttribute(string value)
        {
            WaitForElementToBeExisted();
            return Element.GetAttribute(value);
        }

        public string GetText()
        {
            WaitForElementToBeExisted();
            return Element.Text;
        }

        public string GetCssAttributeValue(string value)
        {
            WaitForElementToBeExisted();
            return Element.GetCssValue(value);
        }

        public bool IsDisplayed()
        {
            WaitForElementToBeVisible();
            return true;
        }

        protected void WaitElementIsClickable()
        {
            DriverManager.Wait().Until(waiting => 
            { 
                if (Element != null) return Element.Displayed;

                return false; 
            });
        }

        protected void WaitForElementToBeVisible()
        {
            WaitForElementToBeExisted();
            DriverManager.Wait().Until(waiting => 
            { 
                if (Element != null)
                {
                    Console.WriteLine(Element.Text);
                    return Element.Displayed;
                }

                return false; 
            });
        }

        protected void WaitForElementToBeExisted()
        {
            DriverManager.Wait().Until(waiting => { return Driver.FindElements(_locator).Count > 0; });
        }
    }
}
