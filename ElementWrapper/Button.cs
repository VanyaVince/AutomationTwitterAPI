using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarkov.ElementWrapper
{
    public class Button : BaseElement
    {
        public Button(By locator) :base(locator)
        {
        }
    }
}
