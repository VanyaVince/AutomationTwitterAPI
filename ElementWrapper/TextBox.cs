using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarkov.ElementWrapper
{
    public class TextBox : BaseElement
    {
        public TextBox(By locator) : base(locator)
        {
        }

        public void SetText(string value) 
        {
            WaitForElementToBeExisted();
            WaitForElementToBeVisible();

            Element.SendKeys(value);
        }
    }
}
