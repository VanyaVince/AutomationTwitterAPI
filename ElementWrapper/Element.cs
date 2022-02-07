using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarkov.ElementWrapper
{
    public class Element : BaseElement
    {
        public Element(By locator) : base(locator)
        {
        }
    }
}
